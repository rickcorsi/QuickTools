namespace WebProject.Pages
{
    public partial class Index
    {
        //Widget Ordering
        int[] widgetOrder = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int tempOrder = 0;
        private void ReOrderWidgets()
        {
            int[] ordered = widgetOrder.OrderBy(x => x).ToArray();
            if (App_Calculator == true)
            {
                widgetOrder[0] = widgetOrder[0] - 1;
            }
            if (App_Calculator == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[0] = ordered[7] + 1;
            }
            if (App_ColorPicker == true)
            {
                widgetOrder[1] = widgetOrder[1] - 1;
            }
            if (App_ColorPicker == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[1] = ordered[7] + 1;
            }
            if (App_Stopwatch == true)
            {
                widgetOrder[2] = widgetOrder[2] - 1;
            }
            if (App_Stopwatch == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[2] = ordered[7] + 1;
            }
            if (App_Timer == true)
            {
                widgetOrder[3] = widgetOrder[3] - 1;
            }
            if (App_Timer == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[3] = ordered[7] + 1;
            }
            if (App_Notes == true)
            {
                widgetOrder[4] = widgetOrder[4] - 1;
            }
            if (App_Notes == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[4] = ordered[7] + 1;
            }
            if (App_Calendar == true)
            {
                widgetOrder[5] = widgetOrder[5] - 1;
            }
            if (App_Calendar == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[5] = ordered[7] + 1;
            }
            if (App_GraphBuilder == true)
            {
                widgetOrder[6] = widgetOrder[6] - 1;
            }
            if (App_GraphBuilder == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[6] = ordered[7] + 1;
            }
            if (App_TemperatureConverter == true)
            {
                widgetOrder[7] = widgetOrder[7] - 1;
            }
            if (App_TemperatureConverter == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[7] = ordered[7] + 1;
            }
            if (App_VolumeConverter == true)
            {
                widgetOrder[8] = widgetOrder[8] - 1;
            }
            if (App_VolumeConverter == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[8] = ordered[7] + 1;
            }
            if (App_LengthConverter == true)
            {
                widgetOrder[9] = widgetOrder[9] - 1;
            }
            if (App_LengthConverter == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[9] = ordered[7] + 1;
            }
            if (App_MassConverter == true)
            {
                widgetOrder[10] = widgetOrder[10] - 1;
            }
            if (App_MassConverter == false)
            {
                increaseAllWidgetOrder();
                widgetOrder[10] = ordered[7] + 1;
            }
        }
        private void increaseAllWidgetOrder()
        {
            widgetOrder[0] = widgetOrder[0] - 1;
            widgetOrder[1] = widgetOrder[1] - 1;
            widgetOrder[2] = widgetOrder[2] - 1;
            widgetOrder[3] = widgetOrder[3] - 1;
            widgetOrder[4] = widgetOrder[4] - 1;
            widgetOrder[5] = widgetOrder[5] - 1;
            widgetOrder[6] = widgetOrder[6] - 1;
            widgetOrder[7] = widgetOrder[7] - 1;
            widgetOrder[8] = widgetOrder[8] - 1;
            widgetOrder[9] = widgetOrder[9] - 1;
            widgetOrder[10] = widgetOrder[10] - 1;
        }
        private void MoveUp(string WidgetValue)
        {
            int val = Int32.Parse(WidgetValue);
            int[] ordered = widgetOrder.OrderBy(x => x).ToArray();
            if (ordered[0] != widgetOrder[val])
            {
                for (int i = 0; i < 11; i++)
                {
                    if (i != val)
                    {
                        widgetOrder[i] = widgetOrder[i] + 1;
                    }
                    else
                    {
                        widgetOrder[val] = widgetOrder[val] - 1;
                    }
                }
            }
        }
        private void MoveDown(string WidgetValue)
        {
            int val = Int32.Parse(WidgetValue);
            int[] ordered = widgetOrder.OrderBy(x => x).ToArray();
            if (ordered[9] != widgetOrder[val])
            {
                for (int i = 0; i < 11; i++)
                {
                    if (i != val)
                    {
                        widgetOrder[i] = widgetOrder[i] - 1;
                    }
                    else
                    {
                        widgetOrder[val] = widgetOrder[val] + 1;
                    }
                }
            }
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
    }
}
