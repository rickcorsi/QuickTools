namespace WebProject.Pages
{
    public partial class Index
    {
        //Widget Ordering
        int[] widgetOrder = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int tempOrder = 0;
        int widgetsOpened = 0;
        private void ReOrderWidgets()
        {
        }
        private void increaseAllWidgetOrder()
        {
        }   
        private void MoveUp(string WidgetValue)
        {
        }
        private void MoveDown(string WidgetValue)
        {
        }
        //Tab Controls
        private bool home = true;
        private bool Utilities = false;
        private bool Converters = false;
        private bool Advanced = false;

        private void tab1()
        {
            AllTabsFalse();
            className = "MultipleWidgetsDiv";
            AllAppsFalse();
            home = true;
        }
        private void tab2()
        {
            AllTabsFalse();
            className = "MainDiv";
            AllAppsFalse();
            Utilities = true;
            App_Calculator = true;
        }
        private void tab3()
        {
            AllTabsFalse();
            className = "MainDiv";
            AllAppsFalse();
            Converters = true;
            App_TemperatureConverter = true;
        }
        private void Tab_Calculator()
        {
            AllAppsFalse();
            App_Calculator = true;
        }
        private void Tab_TemperatureConverter()
        {
            AllAppsFalse();
            App_TemperatureConverter = true;
        }
        private void Tab_VolumeConverter()
        {
            AllAppsFalse();
            App_VolumeConverter = true;
        }
        private void Tab_Stopwatch()
        {
            AllAppsFalse();
            App_Stopwatch = true;
        }
        private void Tab_Timer()
        {
            AllAppsFalse();
            App_Timer = true;
        }
        private void Tab_ColorPicker()
        {
            AllAppsFalse();
            App_ColorPicker = true;
        }
        private void Tab_Notes()
        {
            AllAppsFalse();
            App_Notes = true;
        }
        private void Tab_LengthConverter()
        {
            AllAppsFalse();
            App_LengthConverter = true;
        }
        private void Tab_MassConverter()
        {
            AllAppsFalse();
            App_MassConverter = true;
        }
        private void Tab_Calendar()
        {
            AllAppsFalse();
            App_Calendar = true;
        }
        private void Tab_GraphBuilder()
        {
            AllAppsFalse();
            App_GraphBuilder = true;
        }
        private void AllTabsFalse()
        {
            home = false;
            Utilities = false;
            Converters = false;
            Advanced = false;
        }
        private void AllAppsFalse()
        {
            App_Calculator = false;
            App_Stopwatch = false;
            App_ColorPicker = false;
            App_Notes = false;
            App_TemperatureConverter = false;
            App_VolumeConverter = false;
            App_LengthConverter = false;
            App_MassConverter = false;
            App_Timer = false;
            App_Calendar = false;
            App_GraphBuilder = false;
        }
        private void App_SelectAll()
        {
            if (App_Calculator == false && App_TemperatureConverter == false && App_ColorPicker == false && App_Stopwatch == false && App_Timer == false && App_VolumeConverter == false && App_Notes == false && App_LengthConverter == false && App_MassConverter == false && App_Calendar == false && App_GraphBuilder == false)
            {
                widgetOrder[0] = 1;
                widgetOrder[1] = 2;
                widgetOrder[2] = 3;
                widgetOrder[3] = 4;
                widgetOrder[4] = 5;
                widgetOrder[5] = 6;
                widgetOrder[6] = 7;
                widgetOrder[7] = 8;
                widgetOrder[8] = 9;
                widgetOrder[9] = 10;
                widgetOrder[10] = 11;
            }
            widgetsOpened = 11;
            App_Calculator = true;
            App_TemperatureConverter = true;
            App_VolumeConverter = true;
            App_Stopwatch = true;
            App_Timer = true;
            App_ColorPicker = true;
            App_Notes = true;
            App_LengthConverter = true;
            App_MassConverter = true;
            App_Calendar = true;
            App_GraphBuilder = true;
        }
        private void CloseMassConverter()
        {
            App_MassConverter = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseLengthConverter()
        {
            App_LengthConverter = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseTemperatureConverter()
        {
            App_TemperatureConverter = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseVolumeConverter()
        {
            App_VolumeConverter = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseGraphBuilder()
        {
            App_GraphBuilder = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseCalendar()
        {
            App_Calendar = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseNotes()
        {
            App_Notes = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseTimer()
        {
            App_Timer = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseStopwatch()
        {
            App_Stopwatch = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseColerPicker()
        {
            App_ColorPicker = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseCalculator()
        {
            App_Calculator = false;
            widgetsOpened = widgetsOpened - 1;
        }
    }
}
