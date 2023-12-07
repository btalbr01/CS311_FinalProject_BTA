namespace CS311_FinalProject_BTA
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Checks which radio button is selected
            //Calculates the conversion with the respective formula and outputs it.
            float input = float.Parse(txtInput.Text);
            if (rdoMtoF.Checked)
                lblOutput.Text = (input * 3.28084).ToString() + " feet";
            if (rdoFtoM.Checked)
                lblOutput.Text = (input * 0.3048).ToString() + " meters";
            if (rdoKtoM.Checked)
                lblOutput.Text = (input * 0.621371).ToString() + " miles";
            if (rdoMtoK.Checked)
                lblOutput.Text = (input * 1.60934).ToString() + " kilometers";
            if (rdoCtoF.Checked)
                lblOutput.Text = ((input * 1.8) + 32).ToString() + " fahrenheit";
            if (rdoFtoC.Checked)
                lblOutput.Text = ((input - 32) * (0.555555555)).ToString() + " celsius";
            if (rdoKtoP.Checked)
                lblOutput.Text = (input * 2.20462).ToString() + " pounds";
            if (rdoPtoK.Checked)
                lblOutput.Text = (input * 0.453592).ToString() + " kilograms";
            if (rdoGtoO.Checked)
                lblOutput.Text = (input * 0.035274).ToString() + " ounces";
            if (rdoOtoG.Checked)
                lblOutput.Text = (input * 28.3495).ToString() + " grams";
        }
    }
}