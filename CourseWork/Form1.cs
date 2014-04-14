using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using SortLib;
using ApproximationLib;



namespace CourseWork
{
    /// <summary>
    /// Структура для хранения значения точки(X и Y координат).
    /// </summary>
    public struct Points
    {
        public double x;
        public double y;
    }

    
    /// <summary>
    /// Структура для хранения результата работы BackgroundWorker-a.
    /// </summary>
    public struct eType
    {
        public Points[] worst;
        public Points[] average;
        public Points[] best;
        public double maxX;
       

        /// <summary>
        /// Конструктор структуры.
        /// </summary>
        /// <param name="w">Массив худших значений.</param>
        /// <param name="a">Массив средних значений.</param>
        /// <param name="b">Массив лучших значений</param>
        /// <param name="mX">Максимальное Х, которое следует отображать на оси Ох</param>
        public eType(Points[] w, Points[] a, Points[] b, double mX)
        {
            worst = w;
            average = a;
            best = b;
            maxX = mX;
        }
    }
    
    /// <summary>
    /// Перечисление для типов сортировок.
    /// </summary>
    public enum SortTypes { BubbleSort, HeapSort, QuickSort }

    public enum ProgramStages { ProgramJustStarted, TestingInProgress, TestingCompletedResultsNotShown, ResultsShown }

    public partial class MainForm : Form
    {
        ProgramStages PROGRAM_PROGRESS = ProgramStages.ProgramJustStarted;
        const string BUTTON_START = "Начать тестирование!";
        const string PROGRESS_PERCENTAGE = "Тестирование: {0}%"; //Константа строки для тестирования 
        /// <summary>
        /// Описывает точки
        /// </summary>
        public const int SORTS_COUNT = 3; //Константа количества сортировок
        SortTypes currentSort; //Переменная, обозначающая выбранную польщователем сортировку(нужна для вывода соответствующих подсказок)
        Points[] worst;
        Points[] average; // Массивы х и у - наши вычисленные данные
        Points[] best;

        double[] coeffWorst;
        double[] coeffAverage; // Коэффициенты полиномов
        double[] coeffBest;

        double maxX; //Максимальное значение по оси Ох, которое следует отображать на графике
        int[] tipIdCount = new int[SORTS_COUNT] {-1, -1, -1};
        int[] TotalTipCount = new int[SORTS_COUNT] { 1, 1, 6 };
        string TIPS_PATH = Application.StartupPath + @"\Tips";

        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Согласно данным в checkbox-ах показывает линии графика.
        /// </summary>
        public void ShowSeries()
        {
            Chart1.Series[0].Enabled = WorstCaseBox.Checked;
            Chart1.Series[1].Enabled = WorstCaseBox.Checked;
            Chart1.Series[2].Enabled = AverageCaseBox.Checked;
            Chart1.Series[3].Enabled = AverageCaseBox.Checked;
            Chart1.Series[4].Enabled = BestCaseBox.Checked;
            Chart1.Series[5].Enabled = BestCaseBox.Checked;

        }

        /// <summary>
        /// Подсчет значений функции, заданной массивом коэффициентов при х в полиноме степени n.
        /// </summary>
        /// <param name="coeff">Массив коэффициентов полинома.</param>
        /// <param name="n">Количество коэффициентов.</param>
        /// <param name="xVal">Значение X.</param>
        /// <returns>Значение полинома.</returns>
        static double CountFunctionValue(double[] coeff, int n, int xVal)
        {
            double res = 0;
            double multiplier = 1; // X-в-степени-i
            for (int i = 0; i < n; i++)
            {
                res = res + (coeff[i] * multiplier);
                multiplier *= xVal;
            }
            return res;
        }
        /// <summary>
        /// Получает все x-координаты массива точек.
        /// </summary>
        /// <param name="p">Массив точек, из которого будут выделяться координаты.</param>
        /// <returns>Массив double[] X координат.</returns>
        private double[] GetX(Points[] p)
        {
            double[] x = new double[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                x[i] = p[i].x;
            }
            return x;
        }

        /// <summary>
        /// Получает все y-координаты массива точек.
        /// </summary>
        /// <param name="p">Массив точек, из которого будут выделяться координаты.</param>
        /// <returns>Массив double[] Y координат.</returns>
        private double[] GetY(Points[] p)
        {
            double[] y = new double[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                y[i] = p[i].y;
            }
            return y;
        }

        /// <summary>
        /// Добавляет одну из линий на основе таблицы значений.
        /// </summary>
        /// <param name="p">Таблица значений.</param>
        /// <param name="seriesNum">Номер линии.</param>
        /// <param name="maxX">Максимальное значение по оси Ox, которое нужно отображать.</param>
        /*private void AddSeries(Points[] p, int seriesNum, double maxX)
        {
            double[] coeff = ApproximationClass.ApproximateFunction(GetX(p), GetY(p), p.Length);

            //Тип таблицы - линейный график
            Chart1.Series[seriesNum].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            // Добавляем точки
            for (int i = 0; i < worst.Length; i++)
            {
                Chart1.Series[seriesNum].Points.AddXY(worst[i].x, worst[i].y);
            }
        }*/
        
        private void AddSeries(Points[] p, double[] coeff, int seriesNum, double maxX, Color seriesColor)
        {
            //Тип таблицы - линейный график
            Chart1.Series[seriesNum].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            Chart1.Series[seriesNum].Color = seriesColor;
            // Добавляем точки
            for (int i = 1; i <= maxX; i += 100)
            {
                Chart1.Series[seriesNum].Points.AddXY(i, CountFunctionValue(coeff, p.Length, i));
            }
        }


        /// <summary>
        /// Добавляет на график точки, по которым функция аппроксимируется
        /// </summary>
        /// <param name="p">Массив точек, по которым проводилась аппроксимация</param>
        /// <param name="SeriesNum">Номер линии</param>
        /// <param name="seriesColor"></param>
        private void AddPointSeries(Points[] p, int seriesNum, Color seriesColor)
        {
            //Тип таблицы - точки
            Chart1.Series[seriesNum].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            Chart1.Series[seriesNum].Color = seriesColor;
            // Добавляем точки
            for (int i = 0; i < p.Length; i++)
            {
                Chart1.Series[seriesNum].Points.AddXY(p[i].x, p[i].y);
            }
        }


        /// <summary>
        /// Метод, строящий график на основе трех таблиц со значениями(аппроксимация - внутри).
        /// </summary>
        /// <param name="worst">Таблица худших значений.</param>
        /// <param name="average">Таблица средних значений.</param>
        /// <param name="best">Таблица лучших значений.</param>
        /// <param name="maxX">Максимальное значение по оси Ox, которое следует отображать.</param>
        private void MakeChart(Points[] worst, Points[] average, Points[] best, double maxX)
        {
            Chart1.Series.Clear();

            coeffWorst = ApproximationClass.ApproximateFunction(GetX(worst), GetY(worst), worst.Length);
            coeffAverage = ApproximationClass.ApproximateFunction(GetX(average), GetY(average), average.Length);
            coeffBest = ApproximationClass.ApproximateFunction(GetX(best), GetY(best), best.Length);

            Chart1.Series.Add("Время работы в худшем случае");
            AddSeries(worst, coeffWorst, 0, maxX, Color.Red);
            Chart1.Series.Add("Конкретные результаты работы в худшем случае");
            AddPointSeries(worst, 1, Color.Red);
            
            Chart1.Series.Add("Время работы в среднем случае");
            AddSeries(average, coeffAverage, 2, maxX, Color.Blue);
            Chart1.Series.Add("Конкретные результаты работы в среднем случае");
            AddPointSeries(average, 3, Color.Blue);
            
            Chart1.Series.Add("Время работы в лучшем случае");
            AddSeries(best, coeffBest, 4, maxX, Color.Green);
            Chart1.Series.Add("Конкретные результаты работы в лучшем случае");
            AddPointSeries(best, 5, Color.Green);


            ShowSeries();
        }

        /// <summary>
        /// Осуществляет вывод следующей подсказки для сортировки типа SortType.
        /// </summary>
        /// <param name="sortType">Тип сортировки, выбранной пользователем.</param>
        public void ShowNextTip(SortTypes sortType)
        {
            //Получаем ID следующей сортировки
            tipIdCount[(int)sortType] = (tipIdCount[(int)sortType] + 1) % TotalTipCount[(int)sortType];
            
            //Меняем путь до нее
            string path = TIPS_PATH + @"\" + Enum.GetName(sortType.GetType(), sortType)
                + @"\" + tipIdCount[(int)sortType].ToString() + ".rtf";

            //Выводим факт на экран
            TipsLabel.Text = String.Format("Немного фактов[{0}/{1}]...",tipIdCount[(int)sortType] + 1, TotalTipCount[(int)sortType]) ;
            TipsTextBox.LoadFile(path);
        }

        
        /// <summary>
        /// Тестирует сортировку и строит график.
        /// </summary>
        /// <param name="sortType">строка - тип сортировки</param>
        public void OperateWithSort(SortTypes sortType)
        {
            backgroundWorkerForTesting.RunWorkerAsync(sortType);
            currentSort = sortType;
            ShowNextTip(sortType);
        }

        private void InitializeProgressBar(bool visible)
        {
            if (visible)
            {
                labelTestingProgress.Show();
                progressBarTestingProgress.Show();
            }
            else
            {
                labelTestingProgress.Hide();
                progressBarTestingProgress.Hide();
            }

        }

        private void InitializeChart(bool visible)
        {
            if (visible)
            {
                Chart1.Show();
                CasesGroupBox.Show();
            }
            else
            {
                Chart1.Hide();
                CasesGroupBox.Hide();
            }
        }

        /// <summary>
        /// Обрабатывает нажатие на кнопку и выбор сортировок
        /// </summary>
        private void BuildChartButton_Click(object sender, EventArgs e)
        {
            if (PROGRAM_PROGRESS == ProgramStages.TestingInProgress)
                return;

            PROGRAM_PROGRESS = ProgramStages.TestingInProgress;
            SortGroupBox.Enabled = false;
            BuildChartButton.Hide();
            InitializeChart(false);
            InitializeTips(true);
            InitializeProgressBar(true);

            pictureBoxSortAnimation.Show();

            if (BubbleSortButton.Checked == true)
            {
                pictureBoxSortAnimation.Image = Properties.Resources.bubble_sort;
                OperateWithSort(SortTypes.BubbleSort);
                return;
            }
            if (HeapSortButton.Checked == true)
            {
                pictureBoxSortAnimation.Image = Properties.Resources.heap_sort;
                OperateWithSort(SortTypes.HeapSort);
                return;
            }
            if (QuickSortButton.Checked == true)
            {
                pictureBoxSortAnimation.Image = Properties.Resources.quick_sort;
                OperateWithSort(SortTypes.QuickSort);
                return;
            }
        }

        /// <summary>
        /// Обрабатывает изменение CheckBox для худшего случая
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorstCaseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Chart1.Series.Count >= 1)
            {
                Chart1.Series[0].Enabled = WorstCaseBox.Checked;
                Chart1.Series[1].Enabled = WorstCaseBox.Checked;
            }
        }

        /// <summary>
        /// Обрабатывает изменение CheckBox для среднего случая
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AverageCaseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Chart1.Series.Count >= 2)
            {
                Chart1.Series[2].Enabled = AverageCaseBox.Checked;
                Chart1.Series[3].Enabled = AverageCaseBox.Checked;
            }
        }

        /// <summary>
        /// Обрабатывает изменение CheckBox для лучшего случая
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BestCaseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Chart1.Series.Count >= 3)
            {
                Chart1.Series[4].Enabled = BestCaseBox.Checked;
                Chart1.Series[5].Enabled = BestCaseBox.Checked;
            }
        }

        private void backgroundWorkerForTesting_DoWork(object sender, DoWorkEventArgs e)
        {
            eType k = TesterClass.TestSort((SortTypes)e.Argument, backgroundWorkerForTesting);
            
            worst = k.worst;
            average = k.average;
            best = k.best;
            maxX = k.maxX;
        }

        private void backgroundWorkerForTesting_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelTestingProgress.Text = String.Format(PROGRESS_PERCENTAGE, e.ProgressPercentage);
            progressBarTestingProgress.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Спрашивает пользователя о его желании прекратить тестирование.
        /// </summary>
        /// <returns>true, если пользователь хочет прекратить тестирование.</returns>
        private bool AskForResults()
        {
            DialogResult result = MessageBox.Show("Тестирование завершено! Перейти к результатам?", "Тестирование завершено", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                ShowResultsButton.Show();
                return false;
            }
        }

        /// <summary>
        /// Инициализирует видимость элементов управления, связанных с подсказками.
        /// </summary>
        /// <param name="visible">true, если надо показать элементы управления.</param>
        private void InitializeTips(bool visible)
        {
            if (visible)
            {
                TipsLabel.Show();
                TipsTextBox.Show();
                NextTipButton.Show();
            }
            else
            {
                TipsLabel.Hide();
                TipsTextBox.Hide();
                NextTipButton.Hide();
            }

        }


        /// <summary>
        /// Отображает таблицу и скрывает элементы управления, связанные с прогрессом и подсказками
        /// </summary>
        private void ShowResults()
        {
            SortGroupBox.Enabled = true;
            pictureBoxSortAnimation.Hide();
            InitializeProgressBar(false);
            InitializeTips(false);
            MakeChart(worst, average, best, maxX);
            InitializeChart(true);
            BuildChartButton.Show();
            PROGRAM_PROGRESS = ProgramStages.ResultsShown;
            ShowResultsButton.Text = "Подробнее...";
        }

        /// <summary>
        /// При завершении работы BackgroundWorker-а прячем соответствующие эл-ты управления, и спрашиваем о результатах
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerForTesting_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (PROGRAM_PROGRESS == ProgramStages.ProgramJustStarted)
                return;

            PROGRAM_PROGRESS = ProgramStages.TestingCompletedResultsNotShown;
            BuildChartButton.Text = BUTTON_START;
            ShowResultsButton.Visible = true;
            if (AskForResults())
            {
                ShowResults();
                ShowResultsButton.Text = "Подробнее...";
            }
            else
            {
                ShowResultsButton.Text = "Перейти к результатам!";
            }
            
        }

        /// <summary>
        /// Обработчик нажатия на кнопку для отображения следующей подсказки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextTipButton_Click(object sender, EventArgs e)
        {
            ShowNextTip(currentSort);
        }


        /// <summary>
        /// Обработчик нажатия на кнопку для отображения результатов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowResultsButton_Click(object sender, EventArgs e)
        {
            if (PROGRAM_PROGRESS != ProgramStages.ResultsShown)
            {
                ShowResults();
            }
            else
            {
                FormWithResults FormRes = new FormWithResults(GetTestingResults());
                FormRes.ShowDialog();
            }
        }

        TestingResults GetTestingResults()
        {
            TestingResults res;
            res.n = 15;
            res.worst = worst;
            res.average = average;
            res.best = best;
            res.coeffWorst = coeffWorst;
            res.coeffAverage = coeffAverage;
            res.coeffBest = coeffBest;
            return res;
        }

        private void TipsTextBox_Click(object sender, EventArgs e)
        {

        }

        
    }

    public struct TestingResults
    {
        public Points[] worst;
        public Points[] average;
        public Points[] best;
        public double[] coeffWorst;
        public double[] coeffAverage;
        public double[] coeffBest;
        public int n;
    }

    public class TesterClass
    {
        static int totalNumberOfTests; //Общее количество тестов для одной сортировки
        static int testsCompleted = 0; //Количество тестов, которые уже протестированы
        /// <summary>
        /// Делегаты различных сортировок
        /// </summary>
        /// <param name="a">Массив, который нужно отсортировать</param>
        delegate void SortDelegate(int[] a);


        /*
        static long CountTime(SortDelegate Sort, int[] arr)
        {
            DateTime start = DateTime.Now;
            DateTime finish = DateTime.Now;
            start = DateTime.Now;
            Sort(arr);
            finish = DateTime.Now;
            TimeSpan delta = finish - start;
            return delta.Ticks;
        }*/

        /// <summary>
        /// Считает массивы Х и У по тестам, а так же возвращает maxX - максимальное вычисленное значение.
        /// </summary>
        /// <param name="Test">Строка, представляющая тест.</param>
        /// <param name="maxX">Максимальное значение Х для отображения на графике.</param>
        /// <param name="p">Массив точек.</param>
        /// <param name="Sort">делегат сортировки, для которой считаем таблицу.</param>
        static bool CountXYByTests(string Test, out double maxX, out Points[] p,
            SortDelegate Sort, BackgroundWorker bgw)
        {
            int[] arr;
            int curPosition = 0; // На каком числе из входного файла мы находимся в текущий момент
            string[] tests = Test.Split(' ');
            int numOfTests = Int32.Parse(tests[curPosition++]);
            maxX = 0;
            p = new Points[numOfTests];
            //Чтение тестов
            for (int q = 0; q < numOfTests; q++)
            {
                if (bgw.CancellationPending)
                    return true;
                
                int n;
                ReadTest(out n, out arr, tests, ref curPosition);
                //Засечение времени

                DateTime start = DateTime.Now;
                DateTime finish = DateTime.Now;
                start = DateTime.Now;
                Sort(arr);
                finish = DateTime.Now;
                TimeSpan delta = finish - start;
                p[q].y = delta.Ticks;
                 
                //p[q].y = CountTime(Sort, arr);
                p[q].x = n;
                ++testsCompleted;
                bgw.ReportProgress((int)(100 * ((double)testsCompleted / (double)totalNumberOfTests)));
            }
            maxX = p[numOfTests - 1].x;

            return false;
        }


        /// <summary>
        /// Считываем массив из строки с тестом
        /// </summary>
        /// <param name="n">Длина массива</param>
        /// <param name="arr">Полученный массив</param>
        /// <param name="tests">Строка с тестами</param>
        /// <param name="curPosition">Текущая позиция в строке с тестами</param>
        static void ReadTest(out int n, out int[] arr, string[] tests, ref int curPosition)
        {

            n = Int32.Parse(tests[curPosition++]);
            arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = Int32.Parse(tests[curPosition++]);
        }

        /// <summary>
        /// Тестирует сортировку
        /// </summary>
        /// <param name="sortType">Тип сортировки</param>
        /// <param name="worst">Таблица худших значений</param>
        /// <param name="average">Таблица средних значений</param>
        /// <param name="best">Таблица лучших значений</param>
        /// <param name="maxX">Максимальное значение X, отображаемое на графике</param>
        public static eType TestSort(SortTypes sortType, BackgroundWorker backgroundWorkerForTesting)
        {
            testsCompleted = 0;
            double maxX = 0;
            Points[] worst;
            Points[] average;
            Points[] best;
            eType res;
            string Test;
            string path;
            //Определяем по типу сортировки, что нам надо делать
            switch (sortType)
            {
                case SortTypes.BubbleSort:
                    {
                        SortDelegate BubbleSort = new SortDelegate(Sort.BubbleSort);
                        totalNumberOfTests = 45;

                        path = Application.StartupPath + @"\Tests\BubbleSort\worst.txt";
                        Test = File.ReadAllText(path);
                        //Test = File.ReadAllText(@"D:\Development\University\C#\Курсовая\Testers\TESTS\BubbleSort\worst.txt");
                        CountXYByTests(Test, out maxX, out worst, BubbleSort, backgroundWorkerForTesting);
            
                        path = Application.StartupPath + @"\Tests\BubbleSort\average.txt";
                        Test = File.ReadAllText(path);
                        //Test = File.ReadAllText(@"D:\Development\University\C#\Курсовая\Testers\TESTS\BubbleSort\average.txt");
                        CountXYByTests(Test, out maxX, out average, BubbleSort, backgroundWorkerForTesting);
            
                        path = Application.StartupPath + @"\Tests\BubbleSort\best.txt";
                        Test = File.ReadAllText(path);
                        //Test = File.ReadAllText(@"D:\Development\University\C#\Курсовая\Testers\TESTS\BubbleSort\best.txt");
                        CountXYByTests(Test, out maxX, out best, BubbleSort, backgroundWorkerForTesting);
                        
                        break;
                    }
                case SortTypes.QuickSort:
                    {
                        SortDelegate QuickSort = new SortDelegate(Sort.QuickSort);
                        totalNumberOfTests = 45;

                        path = Application.StartupPath + @"\Tests\QuickSort\worst.txt";
                        Test = File.ReadAllText(path);
                        //Test = File.ReadAllText(@"D:\Development\University\C#\Курсовая\Testers\TESTS\QuickSort\worst.txt");
                        CountXYByTests(Test, out maxX, out worst, QuickSort, backgroundWorkerForTesting);
                        
                        path = Application.StartupPath + @"\Tests\QuickSort\average.txt";
                        Test = File.ReadAllText(path);
                        //Test = File.ReadAllText(@"D:\Development\University\C#\Курсовая\Testers\TESTS\QuickSort\average.txt");
                        CountXYByTests(Test, out maxX, out average, QuickSort, backgroundWorkerForTesting);
                        
                        path = Application.StartupPath + @"\Tests\QuickSort\best.txt";
                        Test = File.ReadAllText(path);
                        //Test = File.ReadAllText(@"D:\Development\University\C#\Курсовая\Testers\TESTS\QuickSort\best.txt");
                        CountXYByTests(Test, out maxX, out best, QuickSort, backgroundWorkerForTesting);
                        
                        break;
                    }
                default:
                    //case SortTypes.HeapSort:
                    {
                        totalNumberOfTests = 45;
                        SortDelegate HeapSort = new SortDelegate(Sort.HeapSort);

                        path = Application.StartupPath + @"\Tests\HeapSort\worst.txt";
                        Test = File.ReadAllText(path);
                        //Test = File.ReadAllText(@"D:\Development\University\C#\Курсовая\Testers\TESTS\HeapSort\worst.txt");
                        CountXYByTests(Test, out maxX, out worst, HeapSort, backgroundWorkerForTesting);
                        
                        path = Application.StartupPath + @"\Tests\HeapSort\average.txt";
                        Test = File.ReadAllText(path);
                        //Test = File.ReadAllText(@"D:\Development\University\C#\Курсовая\Testers\TESTS\HeapSort\average.txt");
                        CountXYByTests(Test, out maxX, out average, HeapSort, backgroundWorkerForTesting);
                        
                        path = Application.StartupPath + @"\Tests\HeapSort\best.txt";
                        Test = File.ReadAllText(path);
                        //Test = File.ReadAllText(@"D:\Development\University\C#\Курсовая\Testers\TESTS\HeapSort\best.txt");
                        CountXYByTests(Test, out maxX, out best, HeapSort, backgroundWorkerForTesting);
                        break;
                    }
            }
            res.worst = worst;
            res.average = average;
            res.best = best;
            res.maxX = maxX;
            return res;
        }
    }
}
