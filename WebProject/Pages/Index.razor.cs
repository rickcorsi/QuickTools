namespace WebProject.Pages
{
    public partial class Index
    {


        //Widget Ordering
        int[] widgetOrder = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int tempOrder = 0;
        int widgetsOpened = 0;
        bool anyWidgetOpened = false;
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
            tab2();
            widgetsOpened = 1;
            App_Calculator = true;
            drawerOpen = false;
        }
        private void Tab_TemperatureConverter()
        {
            AllAppsFalse();
            tab3();
            widgetsOpened = 1;
            App_TemperatureConverter = true;
            drawerOpen = false;
        }
        private void Tab_VolumeConverter()
        {
            AllAppsFalse();
            tab3();
            widgetsOpened = 1;
            App_TemperatureConverter = false;
            App_VolumeConverter = true;
            drawerOpen = false;
        }
        private void Tab_Stopwatch()
        {
            AllAppsFalse();
            tab2();
            widgetsOpened = 1;
            App_Calculator = false;
            App_Stopwatch = true;
            drawerOpen = false;
            drawerOpen = false;
        }
        private void Tab_Timer()
        {
            AllAppsFalse();
            tab2();
            widgetsOpened = 1;
            App_Calculator = false;
            App_Timer = true;
            drawerOpen = false;
            drawerOpen = false;
        }
        private void Tab_ColorPicker()
        {
            AllAppsFalse();
            widgetsOpened = 1;
            App_ColorPicker = true;
        }
        private void Tab_Notes()
        {
            AllAppsFalse();
            widgetsOpened = 1;
            App_Notes = true;
        }
        private void Tab_LengthConverter()
        {
            AllAppsFalse();
            tab3();
            widgetsOpened = 1;
            App_TemperatureConverter = false;
            App_LengthConverter = true;
            drawerOpen = false;
        }
        private void Tab_MassConverter()
        {
            AllAppsFalse();
            tab3();
            widgetsOpened = 1;
            App_TemperatureConverter = false;
            App_MassConverter = true;
            drawerOpen = false;
        }
        private void Tab_Calendar()
        {
            AllAppsFalse();
            widgetsOpened = 1;
            App_Calendar = true;
        }
        private void Tab_GraphBuilder()
        {
            AllAppsFalse();
            widgetsOpened = 1;
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
            CloseAllWidgets();
            widgetsOpened = 0;
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
            widgetsOpened = 11;
        }

        private bool MassConverterIsOpen = false;
        private bool LengthConverterIsOpen = false;
        private bool TemperatureConverterIsOpen = false;
        private bool VolumeConverterIsOpen = false;
        private bool GraphBuilderIsOpen = false;
        private bool CalendarIsOpen = false;
        private bool NotesIsOpen = false;
        private bool TimerIsOpen = false;
        private bool StopwatchIsOpen = false;
        private bool ColorPickerIsOpen = false;
        private bool CalculatorIsOpen = false;
        private void CountOpenWidgets()
        {
            widgetsOpened = 0;
            if (MassConverterIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (LengthConverterIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (TemperatureConverterIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (VolumeConverterIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (GraphBuilderIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (CalendarIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (NotesIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (TimerIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (StopwatchIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (ColorPickerIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
            if (CalculatorIsOpen == true)
            {
                widgetsOpened = widgetsOpened + 1;
            }
        }
        private void CloseAllWidgets()
        {
            MassConverterIsOpen = false;
            LengthConverterIsOpen = false;
            TemperatureConverterIsOpen = false;
            VolumeConverterIsOpen = false;
            GraphBuilderIsOpen = false;
            CalendarIsOpen = false;
            NotesIsOpen = false;
            TimerIsOpen = false;
            StopwatchIsOpen = false;
            ColorPickerIsOpen = false;
            CalculatorIsOpen = false;
        }
        private void CloseMassConverter()
        {
            MassConverterIsOpen = false;
            App_MassConverter = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseLengthConverter()
        {
            LengthConverterIsOpen = false;
            App_LengthConverter = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseTemperatureConverter()
        {
            TemperatureConverterIsOpen = false;
            App_TemperatureConverter = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseVolumeConverter()
        {
            VolumeConverterIsOpen = false;
            App_VolumeConverter = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseGraphBuilder()
        {
            GraphBuilderIsOpen = false;
            App_GraphBuilder = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseCalendar()
        {
            CalendarIsOpen = false;
            App_Calendar = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseNotes()
        {
            NotesIsOpen = false;
            App_Notes = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseTimer()
        {
            TimerIsOpen = false;
            App_Timer = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseStopwatch()
        {
            StopwatchIsOpen = false;
            App_Stopwatch = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseColerPicker()
        {
            ColorPickerIsOpen = false;
            App_ColorPicker = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void CloseCalculator()
        {
            CalculatorIsOpen = false;
            App_Calculator = false;
            widgetsOpened = widgetsOpened - 1;
        }
        private void OpenMassConverter()
        {
            if (MassConverterIsOpen == false)
            {
                MassConverterIsOpen = true;
            }
        }
        private void OpenLengthConverter()
        {
            if (LengthConverterIsOpen == false)
            {
                LengthConverterIsOpen = true;
            }
        }
        private void OpenTemperatureConverter()
        {
            if (TemperatureConverterIsOpen == false)
            {
                TemperatureConverterIsOpen = true;
            }
        }
        private void OpenVolumeConverter()
        {
            if (VolumeConverterIsOpen == false)
            {
                VolumeConverterIsOpen = true;
            }
        }
        private void OpenGraphBuilder()
        {
            if (GraphBuilderIsOpen == false)
            {
                GraphBuilderIsOpen = true;
            }
        }
        private void OpenCalendar()
        {
            if (CalendarIsOpen == false)
            {
                CalendarIsOpen = true;
            }
        }
        private void OpenNotes()
        {
            if (NotesIsOpen == false)
            {
                NotesIsOpen = true;
            }
        }
        private void OpenTimer()
        {
            if (TimerIsOpen == false)
            {
                TimerIsOpen = true;
            }
        }
        private void OpenStopwatch()
        {
            if (StopwatchIsOpen == false)
            {
                StopwatchIsOpen = true;
            }
        }
        private void OpenColerPicker()
        {
            if (ColorPickerIsOpen == false)
            {
                ColorPickerIsOpen = true;
            }
        }
        private void OpenCalculator()
        {
            if (CalculatorIsOpen == false)
            {
                CalculatorIsOpen = true;
            }
        }
    }
}
