using SchoolAssistant;
using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

public class Methods
{
    public static string classChosen = "";
    private int classTime = 0;
    private string shift = "";
    private string dayOfWeekInBG = "";
    private TimeSpan[] TimeSpansForClasses = new TimeSpan[28];
    public static Time timeNow = new Time();
    private TimeSpan now = DateTime.Now.TimeOfDay;
    private System.Timers.Timer t = new System.Timers.Timer();
    private int[] hours = { 7, 8, 8, 9, 9, 9, 10, 10, 11, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 19 };
    private int[] minutes = { 30, 10, 20, 0, 10, 50, 10, 50, 0, 40, 50, 30, 40, 20, 30, 10, 20, 0, 20, 0, 10, 50, 0, 40, 50, 30, 40, 20 };
    private string pathTeachers = @"NewProgramsTeachersFilePath.txt";
    private string pathClasses = @"NewProgramsClassesFilePath.txt";
    private string classShiftDateLabelText = "";

    public string getShiftClassLabel(string classShiftDateLabelText)
    {
        for (int i = 0; i < hours.Length; i++) // get the times form arrays and convert them to TimeSpan
        {
            TimeSpansForClasses[i] = new TimeSpan(hours[i], minutes[i], 0);
        }
        int f = 1; // Check for current class time and shift
        int s = 1;
        for (int i = 1; i < 14; i += 2)
        {
            int a = i;
            a--;
            if ((now > TimeSpansForClasses[a]) && (now < TimeSpansForClasses[i]))
            {
                classTime = f;
                shift = "първа";
            }
            f++;
        }
        for (int i = 15; i < 28; i += 2)
        {
            int a = i;
            a--;
            if ((now > TimeSpansForClasses[a]) && (now < TimeSpansForClasses[i]))
            {
                classTime = s;
                shift = "втора";
            }
            s++;
        }



        switch (DateTime.Now.DayOfWeek.ToString())
        {
            #region Turn days of week to BG
            case "Monday": dayOfWeekInBG = "Понеделник"; break;
            case "Tuesday": dayOfWeekInBG = "Вторник"; break;
            case "Wednesday": dayOfWeekInBG = "Сряда"; break;
            case "Thursday": dayOfWeekInBG = "Четвъртък"; break;
            case "Friday": dayOfWeekInBG = "Петък"; break;
            case "Saturday": dayOfWeekInBG = "Събота"; break;
            case "Sunday": dayOfWeekInBG = "Неделя"; break;
                #endregion
        }



        if (classTime != 0 && shift != "") // sets the string for class time and shift
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                timeNow.dateNoClass = $"Неучебен ден. Днес е  {dayOfWeekInBG} - {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}г.";
                timeNow.dateInClass = "";
            }
            else
            {
                timeNow.dateInClass = $"Сега е {classTime} час от  {shift} смяна. Днес е {dayOfWeekInBG} - {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}г.";
            }
        }
        else
        {
            timeNow.dateNoClass = $"Часът не е започнал. Днес е  {dayOfWeekInBG} - {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}г.";
            timeNow.dateInClass = "";
        }
        if (timeNow.dateInClass != "") // sets the label for current class time and shift
        {
            classShiftDateLabelText = timeNow.dateInClass;
        }
        else
        {
            classShiftDateLabelText = timeNow.dateNoClass;
        }

        return classShiftDateLabelText;

    }




}
