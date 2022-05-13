using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inter_result_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int marks11, marks12, practical;

            
            
            // calculating the Islamic education marks
            marks11 = Convert.ToInt32(is_11.Value);
            marks12 = Convert.ToInt32(is_12.Value);
            practical = Convert.ToInt32(is_practical.Value);
            int is_sum = marks11 + marks12 + practical;
            decimal is_per = (is_sum / Convert.ToDecimal(is_max.Text)) * 100;
            is_total.Text = is_sum.ToString();
            is_percentage.Text = is_per.ToString("#.##") + "%";

            // calculating the Pakistan Studies marks
            marks11 = Convert.ToInt32(ps_11.Value);
            marks12 = Convert.ToInt32(ps_12.Value);
            practical = Convert.ToInt32(ps_practical.Value);
            int ps_sum = marks11 + marks12 + practical;
            decimal ps_per = (ps_sum / Convert.ToDecimal(ps_max.Text)) * 100;
            ps_total.Text = ps_sum.ToString();
            ps_percentage.Text = ps_per.ToString("#.##") + "%";

            // calculating the Urdu marks
            marks11 = Convert.ToInt32(urdu_11.Value);
            marks12 = Convert.ToInt32(urdu_12.Value);
            practical = Convert.ToInt32(urdu_practical.Value);
            int urdu_sum = marks11 + marks12 + practical;
            decimal urdu_per = (urdu_sum / Convert.ToDecimal(urdu_max.Text)) * 100;
            urdu_total.Text = urdu_sum.ToString();
            urdu_percentage.Text = urdu_per.ToString("#.##") + "%";


            // calculating the eng marks
            marks11 = Convert.ToInt32(eng_11.Value);
            marks12 = Convert.ToInt32(eng_12.Value);
            practical = Convert.ToInt32(eng_practical.Value);
            int eng_sum = marks11 + marks12 + practical;
            decimal eng_per = (eng_sum / Convert.ToDecimal(eng_max.Text)) * 100;
            eng_total.Text = eng_sum.ToString();
            eng_percentage.Text = eng_per.ToString("#.##") + "%";

            // calculating the physic marks
            marks11 = Convert.ToInt32(physic_11.Value);
            marks12 = Convert.ToInt32(physic_12.Value);
            practical = Convert.ToInt32(physic_practical.Value);
            int physic_sum = marks11 + marks12 + practical;
            decimal physic_per = (physic_sum / Convert.ToDecimal(physic_max.Text)) * 100;
            physic_total.Text = physic_sum.ToString();
            physic_percentage.Text = physic_per.ToString("#.##") + "%";


            // calculating the computer marks
            marks11 = Convert.ToInt32(computer_11.Value);
            marks12 = Convert.ToInt32(computer_12.Value);
            practical = Convert.ToInt32(computer_practical.Value);
            int computer_sum = marks11 + marks12 + practical;
            decimal computer_per = (computer_sum / Convert.ToDecimal(computer_max.Text)) * 100;
            computer_total.Text = computer_sum.ToString();
            computer_percentage.Text = computer_per.ToString("#.##") + "%";


            // calculating the math marks
            marks11 = Convert.ToInt32(math_11.Value);
            marks12 = Convert.ToInt32(math_12.Value);
            practical = Convert.ToInt32(math_practical.Value);
            int math_sum = marks11 + marks12 + practical;
            decimal math_per = (math_sum / Convert.ToDecimal(math_max.Text)) * 100;
            math_total.Text = math_sum.ToString();
            math_percentage.Text = math_per.ToString("#.##") + "%";

            int total_obtained_marks = is_sum+ps_sum+urdu_sum+eng_sum+physic_sum+computer_sum+math_sum;

            decimal average_per = (is_per+ps_per+urdu_per+eng_per+physic_per+computer_per+math_per)/7;
            decimal actual_per = (total_obtained_marks/Convert.ToDecimal(max_total.Text))*100;


            obtained_total.Text = total_obtained_marks.ToString();
            avg_percentage.Text = average_per.ToString("#.##") + "%";
            actual_percentage.Text = actual_per.ToString("#.##")+"%";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      
        

       

        
        

        
    }
}
