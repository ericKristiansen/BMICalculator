using System;
using System.Windows.Forms;
using Util;

/*
 * Purpose:
 * Create an application that lets the user enter their weight and height in pounds and inches.
 * It will then display the user's BMI.   *Note: BMI = weight * 703 / height^2
*/
namespace BodyMassIndex
{
    public partial class bodyMassIndexForm : Form
    {
        public bodyMassIndexForm()
        {
            InitializeComponent();
            heightTextBox.Select();
        }

        #region Button Handlers

        /// <summary>
        /// Calculate and display the BMI based on height and weight input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateBMIButton_Click(object sender, EventArgs e)
        {
            resetLabel(errorLabel);
            ValidationData vData = getValidationData();

            if (vData.getIsValidated())
            {
                vData.calculateBodyMassIndex();
                bodyMassIndexLabel.Text = String.Format(Utilities.FORMAT_1_DECIMAL_STRING,
                    vData.getCalculateBMI());
                diagnosisLabel.Text = vData.getDiagnosis();
            }
        }

        /// <summary>
        /// This method will reset the appropriate controls to their original
        /// values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearScreenButton_Click(object sender, EventArgs e)
        {
            //reset controls
            resetLabel(bodyMassIndexLabel, Utilities.ZERO_DOT_ZERO);
            resetLabel(errorLabel);
            resetLabel(diagnosisLabel);
            resetTextBox(weightTextBox);
            resetTextBox(heightTextBox);

            splitContainer1.Panel2.Select();
        }

        #endregion Button Handlers

        #region Clean Up Controls

        /// <summary>
        /// Reset the text box passed in to a default or a string passed in.
        /// </summary>
        /// <param name="passTextBox"></param>
        /// <param name="text"></param>
        private void resetTextBox(TextBox passTextBox, string text = "")
        {
            passTextBox.Text = text;
        }

        /// <summary>
        /// Reset the label passed in to a default or string passed in.
        /// </summary>
        /// <param name="passLabel"></param>
        /// <param name="text"></param>
        private void resetLabel(Label passLabel, string text = "")
        {
            passLabel.Text = text;
        }

        #endregion Clean Up Controls

        #region  Validation Helpers

        /// //////////////////////////////////////////////////
        /// <summary>
        /// populate the validated data
        /// </summary>
        /// <returns name="vData"></returns>
        /// //////////////////////////////////////////////////
        private ValidationData getValidationData()
        {
            ValidationData vData = new ValidationData();
            vData.setHeight(validateNumber(heightTextBox));
            vData.setWeight(validateNumber(weightTextBox));
            vData.validateData();
            return vData;
        }

        /// /////////////////////////////////////////////////////////////
        /// <summary>validate the text in the textbox param</summary>
        /// <param name="textBox"></param>
        /// <returns name="floatNumber">-1 if fails validation or 
        /// parsed float</returns>
        /// /////////////////////////////////////////////////////////////
        private float validateNumber(TextBox textBox)
        {
            float floatNumber = Utilities.NEGATIVE_ONE;
            bool isNumber = float.TryParse(textBox.Text, out floatNumber);
            if (isNumber && floatNumber >= Utilities.ZERO)
            {
                floatNumber = float.Parse(string.Format(Utilities.FORMAT_2_DECIMAL_STRING, textBox.Text));
            }
            else
            {
                displayError(errorLabel, "Error: " + textBox.Name +
                    " must be a number greater or equal to zero." + Environment.NewLine);

                textBox.Focus();
            }
            return floatNumber;
        }

        /// //////////////////////////////////////////////////
        /// <summary>
        /// Append the errorLabel with an error
        /// </summary>
        /// <param name="errorMessage"></param>
        /// //////////////////////////////////////////////////
        private void displayError(Label passLabel, string errorMessage)
        { passLabel.Text += errorMessage; }

        #endregion Validation Helpers

        #region Override

        /// //////////////////////////////////////////////////
        /// <summary>
        /// override some functionality: if Enter key is struck,
        /// similate tab key in order to move to next tab index
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        /// //////////////////////////////////////////////////
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion Override

        /// <summary>
        /// When the form loads, we want to direct the focus to the height
        /// control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bodyMassIndexForm_Load(object sender, EventArgs e)
        {
            //heightTextBox.Select();
        }
    }
}
