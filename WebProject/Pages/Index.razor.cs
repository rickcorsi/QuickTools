namespace WebProject.Pages
{
    public partial class Index
    {
        //Calculator
        private bool App_Calculator = false;
        private bool isExpandedCalculator = false;
        string calculatorClass = "MudPaperSmallWidget";
        string buttonValue = "0";
        double App_Calculator_Value = 0;
        double App_Calculator_Value2 = 0;
        double negateTemp = 0;
        string App_Calculator_Display = "0";
        string App_Calculator_FirstNumber = "0";
        string App_Calculator_SecondNumber = "0";
        string App_Calculator_Mode = "Addition";
        string calcLog = "";
        string sign = " + ";
        string solution = "";
        int secondNumberLength = 0;
        private void Addition()
        {
            if (App_Calculator_Display.Contains('+') || App_Calculator_Display.Contains("- ") || App_Calculator_Display.Contains('*') || App_Calculator_Display.Contains('÷'))
            {
                Equals();
            }
            sign = " + ";
            App_Calculator_Mode = "Addition";
            App_Calculator_Value = Double.Parse(App_Calculator_FirstNumber);
            App_Calculator_Display = App_Calculator_Value + " + ";
        }
        private void Subtraction()
        {
            if (App_Calculator_Display.Contains('+') || App_Calculator_Display.Contains("- ") || App_Calculator_Display.Contains('*') || App_Calculator_Display.Contains('÷'))
            {
                Equals();
            }
            sign = " - ";
            App_Calculator_Mode = "Subtraction";
            App_Calculator_Value = Double.Parse(App_Calculator_FirstNumber);
            App_Calculator_Display = App_Calculator_Value + " - ";
        }
        private void Multiplication()
        {
            if (App_Calculator_Display.Contains('+') || App_Calculator_Display.Contains("- ") || App_Calculator_Display.Contains('*') || App_Calculator_Display.Contains('÷'))
            {
                Equals();
            }
            sign = " * ";
            App_Calculator_Mode = "Multiplication";
            App_Calculator_Value = Double.Parse(App_Calculator_FirstNumber);
            App_Calculator_Display = App_Calculator_Value + " * ";
        }
        private void Division()
        {
            if (App_Calculator_Display.Contains('+') || App_Calculator_Display.Contains("- ") || App_Calculator_Display.Contains('*') || App_Calculator_Display.Contains('÷'))
            {
                Equals();
            }
            sign = " ÷ ";
            App_Calculator_Mode = "Division";
            App_Calculator_Value = Double.Parse(App_Calculator_FirstNumber);
            App_Calculator_Display = App_Calculator_Value + " ÷ ";
        }
        private void Equals()
        {
            AddToLogCalc();
            if (App_Calculator_Mode == "Addition")
            {
                App_Calculator_Value = Double.Parse(App_Calculator_FirstNumber);
                App_Calculator_Value2 = Double.Parse(App_Calculator_SecondNumber);
                App_Calculator_Value = App_Calculator_Value + App_Calculator_Value2;
                App_Calculator_Display = App_Calculator_Value.ToString();
                App_Calculator_FirstNumber = App_Calculator_Value.ToString();
                App_Calculator_SecondNumber = "0";
            }
            if (App_Calculator_Mode == "Subtraction")
            {
                App_Calculator_Value = Double.Parse(App_Calculator_FirstNumber);
                App_Calculator_Value2 = Double.Parse(App_Calculator_SecondNumber);
                App_Calculator_Value = App_Calculator_Value - App_Calculator_Value2;
                App_Calculator_Display = App_Calculator_Value.ToString();
                App_Calculator_FirstNumber = App_Calculator_Value.ToString();
                App_Calculator_SecondNumber = "0";
            }
            if (App_Calculator_Mode == "Multiplication")
            {
                App_Calculator_Value = Double.Parse(App_Calculator_FirstNumber);
                App_Calculator_Value2 = Double.Parse(App_Calculator_SecondNumber);
                App_Calculator_Value = App_Calculator_Value * App_Calculator_Value2;
                App_Calculator_Display = App_Calculator_Value.ToString();
                App_Calculator_FirstNumber = App_Calculator_Value.ToString();
                App_Calculator_SecondNumber = "0";
            }
            if (App_Calculator_Mode == "Division")
            {
                App_Calculator_Value = Double.Parse(App_Calculator_FirstNumber);
                App_Calculator_Value2 = Double.Parse(App_Calculator_SecondNumber);
                App_Calculator_Value = App_Calculator_Value / App_Calculator_Value2;
                App_Calculator_Display = App_Calculator_Value.ToString();
                App_Calculator_FirstNumber = App_Calculator_Value.ToString();
                App_Calculator_SecondNumber = "0";
            }
            solution = App_Calculator_Display;
            AddToLogCalcSolution();
        }
        private void App_Calculator_Clear()
        {
            App_Calculator_SecondNumber = "0";
            App_Calculator_FirstNumber = "0";
            App_Calculator_Display = "0";
            App_Calculator_Mode = "";
            App_Calculator_Value = 0;
            App_Calculator_Value2 = 0;
            negateTemp = 0;
        }
        private void App_Calculator_ClearEntry()
        {
            if (App_Calculator_Display.Contains('+') || App_Calculator_Display.Contains("- ") || App_Calculator_Display.Contains('*') || App_Calculator_Display.Contains('÷'))
            {
                if (App_Calculator_SecondNumber != "0")
                {
                    secondNumberLength = App_Calculator_SecondNumber.Length;
                    App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - secondNumberLength);
                    App_Calculator_SecondNumber = "0";
                    App_Calculator_Value2 = 0;
                }
            }
            else
            {
                App_Calculator_Display = "0";
                App_Calculator_FirstNumber = "0";
                App_Calculator_Value = 0;
            }
        }
        private void App_Calculator_Decimal()
        {
            if (App_Calculator_Display.Contains('+') || App_Calculator_Display.Contains("- ") || App_Calculator_Display.Contains('*') || App_Calculator_Display.Contains('÷'))
            {
                if (!App_Calculator_SecondNumber.Contains('.'))
                {
                    App_Calculator_SecondNumber = App_Calculator_SecondNumber + ".";
                    App_Calculator_Display = App_Calculator_Display + ".";
                }
            }
            else
            {
                if (!App_Calculator_FirstNumber.Contains('.'))
                {
                    App_Calculator_FirstNumber = App_Calculator_FirstNumber + ".";
                    App_Calculator_Display = App_Calculator_Display + ".";
                }
            }
        }
        private void App_Calculator_PlusMinus()
        {
            if (App_Calculator_Display.Contains('+') || App_Calculator_Display.Contains("- ") || App_Calculator_Display.Contains('*') || App_Calculator_Display.Contains('÷'))
            {
                secondNumberLength = App_Calculator_SecondNumber.Length;
                if (App_Calculator_SecondNumber.Contains('-') == false)
                {
                    if (App_Calculator_SecondNumber == "0")
                    {
                        App_Calculator_Display = App_Calculator_Display + "-";
                        App_Calculator_SecondNumber = "-0";
                    }
                    else if (App_Calculator_SecondNumber == "0.")
                    {
                        App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - 1);
                        App_Calculator_Display = App_Calculator_Display + "-.";
                        App_Calculator_SecondNumber = "-0.";
                    }
                    else
                    {
                        App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - secondNumberLength);
                        negateTemp = Double.Parse(App_Calculator_SecondNumber);
                        negateTemp = negateTemp * -1;
                        App_Calculator_SecondNumber = negateTemp.ToString();
                        App_Calculator_Display = App_Calculator_Display + App_Calculator_SecondNumber;
                    }
                }
                else if (App_Calculator_SecondNumber.Contains('-') == true)
                {
                    if (App_Calculator_SecondNumber == "-0")
                    {
                        App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - 1);
                        App_Calculator_SecondNumber = "0";
                    }
                    else if (App_Calculator_SecondNumber.Contains("-0.") == true)
                    {
                        App_Calculator_SecondNumber = App_Calculator_SecondNumber.Replace("-.", string.Empty);
                        App_Calculator_Display = App_Calculator_Display.Replace(" -.", " .");
                        App_Calculator_SecondNumber = "0.";
                    }
                    else
                    {
                        App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - secondNumberLength);
                        App_Calculator_SecondNumber = App_Calculator_SecondNumber.Replace("-", string.Empty);
                        negateTemp = Double.Parse(App_Calculator_SecondNumber);
                        if (App_Calculator_SecondNumber == "")
                        {
                            App_Calculator_SecondNumber = "0";
                        }
                        App_Calculator_Display = App_Calculator_Display + App_Calculator_SecondNumber;
                    }
                }
            }
            else
            {
                if (App_Calculator_FirstNumber.Contains('-') == false)
                {
                    negateTemp = Double.Parse(App_Calculator_FirstNumber);
                    negateTemp = negateTemp * -1;
                    App_Calculator_FirstNumber = negateTemp.ToString();
                    App_Calculator_Display = App_Calculator_FirstNumber;
                    if (App_Calculator_Display == "-0")
                    {
                        App_Calculator_Display = "-";
                    }
                }
                else if (App_Calculator_FirstNumber.Contains('-') == true)
                {
                    App_Calculator_FirstNumber = App_Calculator_FirstNumber.Replace("-", string.Empty);
                    App_Calculator_Display = App_Calculator_FirstNumber;
                    if (App_Calculator_FirstNumber == "")
                    {
                        App_Calculator_FirstNumber = "0";
                        App_Calculator_Display = App_Calculator_FirstNumber;
                    }
                    negateTemp = 0;
                }
            }
        }
        private void Calc_Button_Backspace()
        {
            if (App_Calculator_Display.Contains('+') || App_Calculator_Display.Contains("- ") || App_Calculator_Display.Contains('*') || App_Calculator_Display.Contains('÷'))
            {
                if (App_Calculator_SecondNumber == "0")
                {
                    App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - 2);
                    App_Calculator_Mode = "";
                }
                if (App_Calculator_SecondNumber.Length > 1)
                {
                    App_Calculator_SecondNumber = App_Calculator_SecondNumber.Remove(App_Calculator_SecondNumber.Length - 1);
                    App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - 1);
                    if (App_Calculator_SecondNumber == "")
                    {
                        App_Calculator_SecondNumber = "0";
                    }
                }
                else
                {
                    App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - 1);
                    App_Calculator_SecondNumber = "0";
                }
            }
            else
            {
                if (App_Calculator_Display.Length > 1 && App_Calculator_FirstNumber.Length > 1)
                {
                    App_Calculator_FirstNumber = App_Calculator_FirstNumber.Remove(App_Calculator_FirstNumber.Length - 1);
                    App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - 1);
                }
                else
                {
                    App_Calculator_FirstNumber = "0";
                    App_Calculator_Display = "0";
                }
            }
            App_Calculator_Value = 0;
            App_Calculator_Value2 = 0;
        }
        private void Calc_Button_Number(string buttonValue)
        {
            if (App_Calculator_Display.Contains('+') || App_Calculator_Display.Contains("- ") || App_Calculator_Display.Contains('*') || App_Calculator_Display.Contains('÷'))
            {
                if (App_Calculator_SecondNumber == "0")
                {
                    App_Calculator_SecondNumber = "";
                }
                if (App_Calculator_SecondNumber == "-0")
                {
                    App_Calculator_SecondNumber = buttonValue;
                    App_Calculator_Display = App_Calculator_Display.Remove(App_Calculator_Display.Length - 1);
                    App_Calculator_Display = App_Calculator_Display + App_Calculator_SecondNumber;
                }
                else
                {
                    App_Calculator_Value2 = Double.Parse(buttonValue);
                    App_Calculator_Display = App_Calculator_Display + App_Calculator_Value2.ToString();
                    App_Calculator_SecondNumber = App_Calculator_SecondNumber + App_Calculator_Value2.ToString();
                }
            }
            else
            {
                if (App_Calculator_Display == "0")
                {
                    App_Calculator_Value = Double.Parse(buttonValue);
                    App_Calculator_Display = App_Calculator_Value.ToString();
                    App_Calculator_FirstNumber = App_Calculator_Display;
                }
                else
                {
                    App_Calculator_Value = Double.Parse(buttonValue);
                    App_Calculator_Display = App_Calculator_Display + App_Calculator_Value.ToString();
                    App_Calculator_FirstNumber = App_Calculator_Display;
                }
            }
        }
        private void ExpandCalculator()
        {
            if (isExpandedCalculator == false)
            {
                calculatorClass = "MudPaperSmallWidgetExpanded";
                isExpandedCalculator = true;
            }
            else if (isExpandedCalculator == true)
            {
                calculatorClass = "MudPaperSmallWidget";
                isExpandedCalculator = false;
            }
        }
        private void AddToLogCalc()
        {
            calcLog = calcLog + App_Calculator_FirstNumber + sign + App_Calculator_SecondNumber + " = " + "\n";
        }
        private void AddToLogCalcSolution()
        {
            calcLog = calcLog + solution + "\n" + "\n";
        }
        private void ClearLogCalc()
        {
            calcLog = "";
        }
        //Color Picker
        private bool App_ColorPicker = false;
        private bool isFirstColor = true;
        private bool isSecondColor = false;
        private bool isExpandedColorPicker = false;
        private bool isDarkMode = false;
        private bool _isDarkMode = false;
        private bool customThemeCreated = false;
        private bool theme1 = true;
        private bool theme2 = false;
        private bool theme3 = false;
        private bool theme4 = false;
        private bool theme5 = false;
        string firstColorConverted = "#0476f6";
        string colorValStr = "#######";
        string secondColorConverted = "#ed0c3d";
        string selectedTheme = "Default";
        string fontType = "Roboto";
        string colorPickerClass = "ColorPickerMediumWidget";
        string[] recentColor = { "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff",
    "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff",
    "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff",
    "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff", "ffffff",};
        private void SetTheme(String _theme)
        {
            if (_theme == "Light")
            {
                setAllThemesFalse();
                theme1 = true;
                selectedTheme = _theme;
                backcolor = "#e5ecf1";
                appbarcolor = "#121218";
                textColor = "ffffff";
                textColorInactive = "#c9cacb";
                fontType = "Fira Sans";
                widgetColor = "#ffffff";
                widgetTextColor = "#000000";
                accentcolor = "47476d";
                graphcolor = "121218";
                isDarkMode = false;
                _isDarkMode = false;
            }
            if (_theme == "Dark")
            {
                setAllThemesFalse();
                theme2 = true;
                selectedTheme = _theme;
                backcolor = "#1E1E2D";
                appbarcolor = "#121218";
                textColor = "ffffff";
                textColorInactive = "#c9cacb";
                fontType = "Fira Sans";
                widgetColor = "#151521";
                widgetTextColor = "#ffffff";
                accentcolor = "47476d";
                graphcolor = "ffffff";
                isDarkMode = true;
                _isDarkMode = true;
            }
            if (_theme == "Miami Vice")
            {
                setAllThemesFalse();
                theme3 = true;
                selectedTheme = _theme;
                backcolor = "#9ef9f9";
                appbarcolor = "#f7a1e9";
                textColor = "000000";
                textColorInactive = "#282828";
                fontType = "Broadway";
                widgetColor = "#ffffff";
                widgetTextColor = "#000000";
                accentcolor = "f50aed";
                graphcolor = "f7a1e9";
                isDarkMode = false;
                _isDarkMode = false;
            }
            if (_theme == "Cyberpunk")
            {
                setAllThemesFalse();
                theme4 = true;
                selectedTheme = _theme;
                backcolor = "#120324";
                appbarcolor = "#020d19";
                textColor = "ff0586";
                textColorInactive = "#8b064b";
                fontType = "Fira Sans";
                widgetColor = "#340939";
                widgetTextColor = "#ff0586";
                accentcolor = "8b064b";
                graphcolor = "ff0586";
                isDarkMode = true;
                _isDarkMode = true;
            }
            if (_theme == "Custom Theme")
            {
                setAllThemesFalse();
                theme5 = true;
                selectedTheme = _theme;
                backcolor = customBackColor;
                appbarcolor = customAppBarColor;
                widgetColor = customWidgetColor;
                accentcolor = customAccentColor;
                //textColor = customTextColor;
                //widgetTextColor = customTextColor;
                fontType = "Fira Sans";
                if (appbarcolor.L > .45)
                {
                    textColor = "000000";
                    textColorInactive = "282828";
                }
                if (appbarcolor.L < .45)
                {
                    textColor = "ffffff";
                    textColorInactive = "c9cacb";
                }
                if (widgetColor.L > .45)
                {
                    widgetTextColor = "000000";
                }
                if (widgetColor.L < .45)
                {
                    widgetTextColor = "ffffff";
                }
                isDarkMode = false;
                _isDarkMode = false;
            }
        }
        private void toggleDark()
        {
            if (isDarkMode == false)
            {
                isDarkMode = true;
                SetTheme("Dark");
            }
            else if (isDarkMode == true)
            {
                isDarkMode = false;
                SetTheme("Light");
            }
        }
        private void setAllThemesFalse()
        {
            theme1 = false;
            theme2 = false;
            theme3 = false;
            theme4 = false;
            theme5 = false;
        }

        public async Task Save()
        {
            await BrowserStorage.SetAsync("Custom Background Color", customBackColor);
            Console.Write("Custom Background Color Saved", customBackColor);
            await BrowserStorage.SetAsync("Custom Accent Color", customAccentColor);
            Console.Write("Custom Accent Color Saved", customAccentColor);
            await BrowserStorage.SetAsync("Custom Appbar Color", customAppBarColor);
            Console.Write("Custom Appbar Color Saved", customAppBarColor);
            await BrowserStorage.SetAsync("Custom Widget Color", customWidgetColor);
            Console.Write("Custom Widget Color Saved", customWidgetColor);
        }
        public async Task Read()
        {
            var result1 = await BrowserStorage.GetAsync<string>("Custom Background Color");
            customBackColor = result1.Success ? result1.Value : "";
            Console.Write("Custom Background Color Read", result1);
            var result2 = await BrowserStorage.GetAsync<string>("Custom Accent Color");
            customAccentColor = result2.Success ? result2.Value : "";
            Console.Write("Custom Accent Color Read", result2);
            var result3 = await BrowserStorage.GetAsync<string>("Custom Appbar Color");
            customAppBarColor = result3.Success ? result3.Value : "";
            Console.Write("Custom Appbar Color Read", result3);
            var result4 = await BrowserStorage.GetAsync<string>("Custom Widget Color");
            customWidgetColor = result4.Success ? result4.Value : "";
            Console.Write("Custom Widget Color Read", result4);
        }
        public async Task Delete()
        {
            await BrowserStorage.DeleteAsync("Custom Background Color");
            await BrowserStorage.DeleteAsync("Custom Accent Color");
            await BrowserStorage.DeleteAsync("Custom Appbar Color");
            await BrowserStorage.DeleteAsync("Custom Widget Color");
        }
        //Timer
        private bool App_Timer = false;
        private bool isTiming_Timer = false;
        private bool isReset_Timer = true;
        private bool isPaused_Timer = true;
        private bool isTimer_Done = false;
        private bool _pause = false;
        private bool SoundOn = false;
        string displaytimer_Timer = "00:00:00";
        TimeSpan TimeFromZero_Timer;
        private int Seconds { get; set; }
        private int Minutes { get; set; }
        private int Hours { get; set; }
        async Task TimerTiming()
        {
            isTimer_Done = false; //Set timer to not be done
            isTiming_Timer = true;
            isPaused_Timer = false;
            isReset_Timer = false;
            if (!_pause) TimeFromZero_Timer = new TimeSpan(Hours, Minutes, Seconds + 1); //if not paused create new timer
            else //resume timer where it left off
            {
                _pause = false;
                TimeFromZero_Timer = TimeFromZero_Timer.Duration(); //create new timer with previous timer's duration b/c timespan has no resume functionality
            }
            while (TimeFromZero_Timer > new TimeSpan()) //progress timer until 0
            {
                if (!_pause) //if not paused progress timer
                {
                    await Task.Delay(1000);
                    TimeFromZero_Timer = TimeFromZero_Timer.Subtract(new TimeSpan(0, 0, 1)); //Remove one second while timing is running
                    displaytimer_Timer = TimeFromZero_Timer.ToString();
                    StateHasChanged();
                }
                else
                { //stop timing when paused
                    break;
                }
            }
            isTiming_Timer = false;
            if (displaytimer_Timer == "00:00:00")
            {
                TimerReset();
                timerNotification();
            }
            StateHasChanged();
        }
        void TimerReset()
        {
            displaytimer_Timer = "00:00:00";
            Seconds = 0;
            Minutes = 0;
            Hours = 0;
            _pause = false;
            isTiming_Timer = false;
            isPaused_Timer = true;
            isReset_Timer = true;
            TimeFromZero_Timer = (new TimeSpan(Hours, Minutes, Seconds));
            TimeFromZero_Timer = TimeFromZero_Timer.Add(new TimeSpan(0, 0, 1));
        }
        void TimerPause()
        {
            TimeFromZero_Timer = TimeFromZero_Timer.Add(new TimeSpan(0, 0, 1));
            _pause = true;
            isTiming_Timer = false;
            isPaused_Timer = true;
        }
        private async void timerNotification()
        {
            bool? result = await timerNotificationMSG.Show();
        }
        //Stopwatch
        private bool App_Stopwatch = false;
        private bool isTiming = false;
        private bool isStopped = true;
        private bool LogStopwatch = false;
        string displaytimer = "00:00:00";
        int stopwatchStops = 0;
        string RecentTime = "";
        string swLog = "";
        TimeSpan TimeFromZero;
        async Task StopwatchTiming()
        {
            displaytimer = "00:00:00";
            isStopped = false;
            TimeFromZero = new TimeSpan(0, 0, 0);
            isTiming = true;
            while (isTiming)
            {
                await Task.Delay(1000);
                if (isTiming)
                {
                    TimeFromZero = TimeFromZero.Add(new TimeSpan(0, 0, 1));
                    displaytimer = TimeFromZero.ToString();
                    StateHasChanged();
                }
            }
        }
        void StopwatchStop()
        {
            RecentTime = TimeFromZero.ToString();
            AddToLogStopwatch();
            isTiming = false;
            isStopped = true;

            stopwatchStops++;
        }
        private void AddToLogStopwatch()
        {
            swLog = swLog + RecentTime + "\n";
        }
        private void ToggleLogStopwatch()
        {
            if (LogStopwatch == false)
            {
                LogStopwatch = true;
            }
            else if (LogStopwatch == true)
            {
                LogStopwatch = false;
            }
        }
        private void ClearLogStopwatch()
        {
            swLog = "";
        }
        //Notes
        private bool App_Notes = false;
        private bool isExpandedNotes = false;
        string notesText = "";
        string notesClass = "MudPaperSmallWidget";
        private void ExpandNotes()
        {
            if (isExpandedNotes == false)
            {
                notesClass = "MudPaperMediumWidget";
                isExpandedNotes = true;
            }
            else if (isExpandedNotes == true)
            {
                notesClass = "MudPaperSmallWidget";
                isExpandedNotes = false;
            }
        }
        //Temperature Converter
        private bool App_TemperatureConverter = false;
        private bool LogTemp = false;
        double App_TemperatureConverter_Value1 = 0;
        double App_TemperatureConverter_Value2 = 0;
        private string TempValue1 { get; set; } = "Fahrenheit";
        private string TempValue2 { get; set; } = "Celsius";
        string tempLog = "";
        private void ConvertTemp()
        {
            if (TempValue1 == "Fahrenheit" && TempValue2 == "Fahrenheit")
            {
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value1;
            }
            if (TempValue1 == "Fahrenheit" && TempValue2 == "Celsius")
            {
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value1;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 - 32;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 * 5 / 9;
            }
            if (TempValue1 == "Fahrenheit" && TempValue2 == "Kelvin")
            {
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value1;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 - 32;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 * 5 / 9;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 + 273.15;
            }
            if (TempValue1 == "Celsius" && TempValue2 == "Fahrenheit")
            {
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value1;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 * 9 / 5;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 + 32;
            }
            if (TempValue1 == "Celsius" && TempValue2 == "Celsius")
            {
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value1;
            }
            if (TempValue1 == "Celsius" && TempValue2 == "Kelvin")
            {
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value1;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 + 273.15;
            }
            if (TempValue1 == "Kelvin" && TempValue2 == "Fahrenheit")
            {
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value1;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 - 273.15;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 * 9 / 5;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 + 32;
            }
            if (TempValue1 == "Kelvin" && TempValue2 == "Celsius")
            {
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value1;
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value2 - 273.15;
            }
            if (TempValue1 == "Kelvin" && TempValue2 == "Kelvin")
            {
                App_TemperatureConverter_Value2 = App_TemperatureConverter_Value1;
            }
            AddToLogTemp();
        }
        private void AddToLogTemp()
        {
            tempLog = tempLog + App_TemperatureConverter_Value1 + " " + TempValue1 + " " + " = " + App_TemperatureConverter_Value2 + " " + TempValue2 + "\n";
        }
        private void ToggleLogTemp()
        {
            if (LogTemp == false)
            {
                LogTemp = true;
            }
            else if (LogTemp == true)
            {
                LogTemp = false;
            }
        }
        private void ClearLogTemp()
        {
            tempLog = "";
        }
        //Volume Converter
        private bool App_VolumeConverter = false;
        private bool LogVolume = false;
        double App_VolumeConverter_Value1 = 0;
        double App_VolumeConverter_Value2 = 0;
        private string VolumeValue1 { get; set; } = "US Gallon";
        private string VolumeValue2 { get; set; } = "US Quart";
        string volumeLog = "";
        private void ConvertVolume()
        {
            if (VolumeValue1 == "US Gallon" && VolumeValue2 == "US Gallon")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1;
            }
            if (VolumeValue1 == "US Gallon" && VolumeValue2 == "US Quart")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 4;
            }
            if (VolumeValue1 == "US Gallon" && VolumeValue2 == "US Pint")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 8;
            }
            if (VolumeValue1 == "US Gallon" && VolumeValue2 == "US Cup")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 15.773;
            }
            if (VolumeValue1 == "US Gallon" && VolumeValue2 == "Liter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 3.785;
            }
            if (VolumeValue1 == "US Gallon" && VolumeValue2 == "Milliliter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 3785;
            }
            if (VolumeValue1 == "US Quart" && VolumeValue2 == "US Gallon")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 4;
            }
            if (VolumeValue1 == "US Quart" && VolumeValue2 == "US Quart")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1;
            }
            if (VolumeValue1 == "US Quart" && VolumeValue2 == "US Pint")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 2;
            }
            if (VolumeValue1 == "US Quart" && VolumeValue2 == "US Cup")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 3.943;
            }
            if (VolumeValue1 == "US Quart" && VolumeValue2 == "Liter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 1.057;
            }
            if (VolumeValue1 == "US Quart" && VolumeValue2 == "Milliliter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 946.4;
            }
            if (VolumeValue1 == "US Pint" && VolumeValue2 == "US Gallon")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 8;
            }
            if (VolumeValue1 == "US Pint" && VolumeValue2 == "US Quart")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 2;
            }
            if (VolumeValue1 == "US Pint" && VolumeValue2 == "US Pint")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1;
            }
            if (VolumeValue1 == "US Pint" && VolumeValue2 == "US Cup")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 1.972;
            }
            if (VolumeValue1 == "US Pint" && VolumeValue2 == "Liter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 2.113;
            }
            if (VolumeValue1 == "US Pint" && VolumeValue2 == "Milliliter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 473.2;
            }
            if (VolumeValue1 == "US Cup" && VolumeValue2 == "US Gallon")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 15.772;
            }
            if (VolumeValue1 == "US Cup" && VolumeValue2 == "US Quart")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 3.943;
            }
            if (VolumeValue1 == "US Cup" && VolumeValue2 == "US Pint")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 1.972;
            }
            if (VolumeValue1 == "US Cup" && VolumeValue2 == "US Cup")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1;
            }
            if (VolumeValue1 == "US Cup" && VolumeValue2 == "Liter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 4.167;
            }
            if (VolumeValue1 == "US Cup" && VolumeValue2 == "Milliliter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 240;
            }
            if (VolumeValue1 == "Liter" && VolumeValue2 == "US Gallon")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 3.785;
            }
            if (VolumeValue1 == "Liter" && VolumeValue2 == "US Quart")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 1.057;
            }
            if (VolumeValue1 == "Liter" && VolumeValue2 == "US Pint")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 2.113;
            }
            if (VolumeValue1 == "Liter" && VolumeValue2 == "US Cup")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 4.167;
            }
            if (VolumeValue1 == "Liter" && VolumeValue2 == "Liter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1;
            }
            if (VolumeValue1 == "Liter" && VolumeValue2 == "Milliliter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 * 1000;
            }
            if (VolumeValue1 == "Milliliter" && VolumeValue2 == "US Gallon")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 3785;
            }
            if (VolumeValue1 == "Milliliter" && VolumeValue2 == "US Quart")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 946.4;
            }
            if (VolumeValue1 == "Milliliter" && VolumeValue2 == "US Pint")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 473.2;
            }
            if (VolumeValue1 == "Milliliter" && VolumeValue2 == "US Cup")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 240;
            }
            if (VolumeValue1 == "Milliliter" && VolumeValue2 == "Liter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1 / 1000;
            }
            if (VolumeValue1 == "Milliliter" && VolumeValue2 == "Milliliter")
            {
                App_VolumeConverter_Value2 = App_VolumeConverter_Value1;
            }
            AddToLogVolume();
        }
        private void AddToLogVolume()
        {
            volumeLog = volumeLog + App_VolumeConverter_Value1 + " " + VolumeValue1 + " " + " = " + App_VolumeConverter_Value2 + " " + VolumeValue2 + "\n";
        }
        private void ToggleLogVolume()
        {
            if (LogVolume == false)
            {
                LogVolume = true;
            }
            else if (LogVolume == true)
            {
                LogVolume = false;
            }
        }
        private void ClearLogVolume()
        {
            volumeLog = "";
        }
        //Length Converter
        protected bool App_LengthConverter = false;
        protected bool LogLength = false;
        protected double App_LengthConverter_Value1 = 0;
        protected double App_LengthConverter_Value2 = 0;
        protected string LengthValue1 { get; set; } = "Foot";
        protected string LengthValue2 { get; set; } = "Yard";
        protected string lengthLog = "";
        protected void ConvertLength()
        {
            if (LengthValue1 == "Foot" && LengthValue2 == "Foot")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1;
            }
            if (LengthValue1 == "Foot" && LengthValue2 == "Yard")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 1 / 3;
            }
            if (LengthValue1 == "Foot" && LengthValue2 == "Mile")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 5280;
            }
            if (LengthValue1 == "Foot" && LengthValue2 == "Inch")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 12;
            }
            if (LengthValue1 == "Foot" && LengthValue2 == "Meter")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 3.281;
            }
            if (LengthValue1 == "Foot" && LengthValue2 == "Kilometer")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 3281;
            }
            if (LengthValue1 == "Yard" && LengthValue2 == "Foot")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 3;
            }
            if (LengthValue1 == "Yard" && LengthValue2 == "Yard")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1;
            }
            if (LengthValue1 == "Yard" && LengthValue2 == "Mile")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 1760;
            }
            if (LengthValue1 == "Yard" && LengthValue2 == "Inch")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 36;
            }
            if (LengthValue1 == "Yard" && LengthValue2 == "Meter")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 1.094;
            }
            if (LengthValue1 == "Yard" && LengthValue2 == "Kilometer")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 1094;
            }
            if (LengthValue1 == "Mile" && LengthValue2 == "Foot")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 5280;
            }
            if (LengthValue1 == "Mile" && LengthValue2 == "Yard")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 1760;
            }
            if (LengthValue1 == "Mile" && LengthValue2 == "Mile")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1;
            }
            if (LengthValue1 == "Mile" && LengthValue2 == "Inch")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 63360;
            }
            if (LengthValue1 == "Mile" && LengthValue2 == "Meter")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 1609;
            }
            if (LengthValue1 == "Mile" && LengthValue2 == "Kilometer")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 1.609;
            }
            if (LengthValue1 == "Inch" && LengthValue2 == "Foot")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 12;
            }
            if (LengthValue1 == "Inch" && LengthValue2 == "Yard")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 36;
            }
            if (LengthValue1 == "Inch" && LengthValue2 == "Mile")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 63360;
            }
            if (LengthValue1 == "Inch" && LengthValue2 == "Inch")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1;
            }
            if (LengthValue1 == "Inch" && LengthValue2 == "Meter")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 39.37;
            }
            if (LengthValue1 == "Inch" && LengthValue2 == "Kilometer")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 39370;
            }
            if (LengthValue1 == "Meter" && LengthValue2 == "Foot")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 3.281;
            }
            if (LengthValue1 == "Meter" && LengthValue2 == "Yard")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 1.094;
            }
            if (LengthValue1 == "Meter" && LengthValue2 == "Mile")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 1609;
            }
            if (LengthValue1 == "Meter" && LengthValue2 == "Inch")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 39.37;
            }
            if (LengthValue1 == "Meter" && LengthValue2 == "Meter")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1;
            }
            if (LengthValue1 == "Meter" && LengthValue2 == "Kilometer")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 1000;
            }
            if (LengthValue1 == "Kilometer" && LengthValue2 == "Foot")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 3281;
            }
            if (LengthValue1 == "Kilometer" && LengthValue2 == "Yard")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 1094;
            }
            if (LengthValue1 == "Kilometer" && LengthValue2 == "Mile")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 / 1.609;
            }
            if (LengthValue1 == "Kilometer" && LengthValue2 == "Inch")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 39370;
            }
            if (LengthValue1 == "Kilometer" && LengthValue2 == "Meter")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1 * 1000;
            }
            if (LengthValue1 == "Kilometer" && LengthValue2 == "Kilometer")
            {
                App_LengthConverter_Value2 = App_LengthConverter_Value1;
            }
            AddToLogLength();
        }
        protected void AddToLogLength()
        {
            lengthLog = lengthLog + App_LengthConverter_Value1 + " " + LengthValue1 + " " + " = " + App_LengthConverter_Value2 + " " + LengthValue2 + "\n";
        }
        protected void ToggleLogLength()
        {
            if (LogLength == false)
            {
                LogLength = true;
            }
            else if (LogLength == true)
            {
                LogLength = false;
            }
        }
        protected void ClearLogLength()
        {
            lengthLog = "";
        }
        //Mass Converter
        private bool App_MassConverter = false;
        private bool LogMass = false;
        double App_MassConverter_Value1 = 0;
        double App_MassConverter_Value2 = 0;
        private string MassValue1 { get; set; } = "Pound";
        private string MassValue2 { get; set; } = "Kilogram";
        string massLog = "";
        private void ConvertMass()
        {
            if (MassValue1 == "Pound" && MassValue2 == "Pound")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1;
            }
            if (MassValue1 == "Pound" && MassValue2 == "Ounce")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 16;
            }
            if (MassValue1 == "Pound" && MassValue2 == "Kilogram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 2.205;
            }
            if (MassValue1 == "Pound" && MassValue2 == "Gram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 453.6;
            }
            if (MassValue1 == "Pound" && MassValue2 == "US Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 2000;
            }
            if (MassValue1 == "Pound" && MassValue2 == "Metric Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 2205;
            }
            if (MassValue1 == "Ounce" && MassValue2 == "Pound")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 16;
            }
            if (MassValue1 == "Ounce" && MassValue2 == "Ounce")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1;
            }
            if (MassValue1 == "Ounce" && MassValue2 == "Kilogram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 35.274;
            }
            if (MassValue1 == "Ounce" && MassValue2 == "Gram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 28.35;
            }
            if (MassValue1 == "Ounce" && MassValue2 == "US Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 32000;
            }
            if (MassValue1 == "Ounce" && MassValue2 == "Metric Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 35270;
            }
            if (MassValue1 == "Kilogram" && MassValue2 == "Pound")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 2.205;
            }
            if (MassValue1 == "Kilogram" && MassValue2 == "Ounce")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 35.274;
            }
            if (MassValue1 == "Kilogram" && MassValue2 == "Kilogram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1;
            }
            if (MassValue1 == "Kilogram" && MassValue2 == "Gram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 1000;
            }
            if (MassValue1 == "Kilogram" && MassValue2 == "US Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 907.2;
            }
            if (MassValue1 == "Kilogram" && MassValue2 == "Metric Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 1000;
            }
            if (MassValue1 == "Gram" && MassValue2 == "Pound")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 453.6;
            }
            if (MassValue1 == "Gram" && MassValue2 == "Ounce")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 28.35;
            }
            if (MassValue1 == "Gram" && MassValue2 == "Kilogram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 63360;
            }
            if (MassValue1 == "Gram" && MassValue2 == "Gram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1;
            }
            if (MassValue1 == "Gram" && MassValue2 == "US Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 907200;
            }
            if (MassValue1 == "Gram" && MassValue2 == "Metric Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 0.000001;
            }
            if (MassValue1 == "US Ton" && MassValue2 == "Pound")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 2000;
            }
            if (MassValue1 == "US Ton" && MassValue2 == "Ounce")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 32000;
            }
            if (MassValue1 == "US Ton" && MassValue2 == "Kilogram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 907.2;
            }
            if (MassValue1 == "US Ton" && MassValue2 == "Gram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 907200;
            }
            if (MassValue1 == "US Ton" && MassValue2 == "US Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1;
            }
            if (MassValue1 == "US Ton" && MassValue2 == "Metric Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 / 1.102;
            }
            if (MassValue1 == "Metric Ton" && MassValue2 == "Pound")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 2205;
            }
            if (MassValue1 == "Metric Ton" && MassValue2 == "Ounce")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 35270;
            }
            if (MassValue1 == "Metric Ton" && MassValue2 == "Kilogram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 1000;
            }
            if (MassValue1 == "Metric Ton" && MassValue2 == "Gram")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 0.000001;
            }
            if (MassValue1 == "Metric Ton" && MassValue2 == "US Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1 * 1.102;
            }
            if (MassValue1 == "Metric Ton" && MassValue2 == "Metric Ton")
            {
                App_MassConverter_Value2 = App_MassConverter_Value1;
            }
            AddToLogMass();
        }
        private void AddToLogMass()
        {
            massLog = massLog + App_MassConverter_Value1 + " " + MassValue1 + " " + " = " + App_MassConverter_Value2 + " " + MassValue2 + "\n";
        }
        private void ToggleLogMass()
        {
            if (LogMass == false)
            {
                LogMass = true;
            }
            else if (LogMass == true)
            {
                LogMass = false;
            }
        }
        private void ClearLogMass()
        {
            massLog = "";
        }
        //Calendar
        private bool App_Calendar = false;
        string todayDate = DateTime.Now.ToShortDateString();
        //Graph Builder
        private bool App_GraphBuilder = false;
        private bool isExpandedGraphBuilder = false;
        private bool graphTabBars = true;
        string graphBuilderClass = "GraphBuilderMediumWidget";
        private double GraphBuilderMin = 0;
        private double GraphBuilderMax = 100;
        string GraphTitle = "Title";
        private int GraphNumberOfBars = 2;
        private double graphMax = 0;
        double[] GraphBar = { 0, 0, 0, 0, 0, 0 };
        double[] barHeight = { 0, 0, 0, 0, 0, 0 };
        string[] GraphBarLabel = { "Bar 1", "Bar 2", "Bar 3", "Bar 4", "Bar 5", "Bar 6" };
        public bool CheckBoxLabels { get; set; } = false;
        public bool CheckBoxValues { get; set; } = false;
        private void ExpandGraphBuilder()
        {
            if (isExpandedGraphBuilder == false)
            {
                graphBuilderClass = "GraphBuilderMediumWidgetExpanded";
                isExpandedGraphBuilder = true;
            }
            else if (isExpandedGraphBuilder == true)
            {
                graphBuilderClass = "GraphBuilderMediumWidget";
                isExpandedGraphBuilder = false;
            }
        }
        private void BuildGraph()
        {
            FindMax();
            for (int i = 0; i < 6; i++)
            {
                barHeight[i] = GraphBar[i] / GraphBuilderMax;
                barHeight[i] = barHeight[i] * 100;
            }
        }
        private void ChangeGraphTab()
        {
            if (graphTabBars == false)
            {
                graphTabBars = true;
            }
            else if (graphTabBars == true)
            {
                graphTabBars = false;
            }
        }
        private void FindMax()
        {
            graphMax = GraphBar.Max();
            Console.Write("Graph Max: " + graphMax);
            if (GraphBuilderMax < graphMax)
            {
                GraphBuilderMax = graphMax;
            }
        }
        bool drawerOpen = false;

        void ToggleDrawer()
        {
            if (drawerOpen == false)
            {
                drawerOpen = true;
            }
            else if (drawerOpen == true)
            {
                drawerOpen = false;
            }
        }
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
            App_SelectAll();
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
        }
        private void Tab_Timer()
        {
            AllAppsFalse();
            tab2();
            widgetsOpened = 1;
            App_Calculator = false;
            App_Timer = true;
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
            tab2();
            widgetsOpened = 1;
            App_Calculator = false;
            App_Notes = true;
            drawerOpen = false;
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
