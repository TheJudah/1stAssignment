using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /*
    Insert comments here. When written, rationale, et al.
    */

        /// <summary>
        /// This is also a way to comment into an xlm document. TBD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GetTimeTillBirthday();
    }

    protected void GetTimeTillBirthday()
    {
        DateTime birthDay;

        if (Calendar1.SelectedDate==null)
        {
           birthDay = DateTime.Now;
        }

        else
    {
    birthDay = Calendar1.SelectedDate;

}

        string name = NameTextBox.Text;

        TimeSpan daysUntilBirthday = birthDay.Subtract(DateTime.Now);
        ResultLabel.Text ="Days until birthday " +
            Math.Abs( daysUntilBirthday.Days).ToString() +
            "hours" + Math.Abs(daysUntilBirthday.Hours).ToString();
        }