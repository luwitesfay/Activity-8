namespace Activity_8
{
    public partial class CaloriesCalculator : Form
    {
        public CaloriesCalculator()
        {
            InitializeComponent();
        }

        //buuton to display calculates calories when button is clicked
        private void buttonclculatefat_Click(object sender, EventArgs e)
        {
            // calling fat calories calculator method
            fatCaloriesCalc(fatCaloriesValue.Text); 
        }

        //fat calulating method
        private void fatCaloriesCalc(string FatGramsInput)
        {
            //try method to try what is passed in the logic
            try
            {
                // getting user input for fat grams and converting it to calories
                double fatCaloriesValues = double.Parse(fatGramsInput.Text) * 9;
                // Diplayeding calculated calries to the user
                fatCaloriesValue.Text = fatCaloriesValues.ToString(); 
            }
            //catch method to display a message if the user enters invalid value
            catch (Exception)
            {
                MessageBox.Show("please enter a valid fat grams in numbers");
            }
        }

        //Clearbutton to clear the value entered and the result
        private void button4_Click(object sender, EventArgs e)
        {

                fatGramsInput.Text = string.Empty;
                fatCaloriesValue.Text = string.Empty;
           
        }

        //buuton to display calculates calories when button is clicked
        private void buttonclculatecarbs_Click(object sender, EventArgs e)
        {

            // calling carb calories calculator method
            carbCaloriesCalc(fatGramsInput.Text); 

            
        }

        //Carb calulating method
        private void carbCaloriesCalc(string CarbGramsValue)
        {
            //try method to try what is passed in the logic
            try
            {
                //Getting user input for carb grams and converting it to calories
                double carbCaloriesValue = double.Parse(carbGramsInput.Text) * 4;
                // Diplayeding calculated calries to the user
                carbsCaloriesValue.Text = carbCaloriesValue.ToString();
            }
            //catch method to display a message if the user enters invalid value
            catch (Exception)
            {
                MessageBox.Show("please enter a valid carb grams in numbers");
            }
        }


        //Clearbutton to clear the value entered and the result
        private void button3_Click(object sender, EventArgs e)
        {

           
                carbGramsInput.Text= string.Empty;
                carbsCaloriesValue.Text= string.Empty;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}