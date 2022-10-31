using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Text;
using System.Windows.Forms;

namespace AuxWallet
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.WHITE);

            // Add dummy data to the listview
            MaterialCheckListBox1.Items.Add("Item1", false);
            MaterialCheckListBox1.Items.Add("Item2", true);
            MaterialCheckListBox1.Items.Add("Item3", true);
            MaterialCheckListBox1.Items.Add("Item4", false);
            MaterialCheckListBox1.Items.Add("Item5", true);
            MaterialCheckListBox1.Items.Add("Item6", false);
            MaterialCheckListBox1.Items.Add("Item7", false);

            materialComboBox6.SelectedIndex = 0;

            materialListBoxFormStyle.Clear();
            foreach (string FormStyleItem in System.Enum.GetNames(typeof(FormStyles)))
            {
                materialListBoxFormStyle.AddItem(FormStyleItem);
                if (FormStyleItem == this.FormStyle.ToString())
                {
                    materialListBoxFormStyle.SelectedIndex = materialListBoxFormStyle.Items.Count - 1;
                }
            }

            materialListBoxFormStyle.SelectedIndexChanged += (sender, args) =>
            {
                FormStyles SelectedStyle = (FormStyles)System.Enum.Parse(typeof(FormStyles), args.Text);
                if (this.FormStyle != SelectedStyle)
                {
                    this.FormStyle = SelectedStyle;
                }
            };

        }
        void Init()
        {
            DrawerUseColors = true;
            DrawerHighlightWithAccent = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerAutoShow = true;
        }

       

        private int colorSchemeIndex;

        private void ColorScheme_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2)
            {
                colorSchemeIndex = 0;
            }

            UpdateColor();
        }

        private void UpdateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialPrimary.Teal500 : MaterialPrimary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialPrimary.Teal700 : MaterialPrimary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialPrimary.Teal200 : MaterialPrimary.Indigo100,
                        MaterialAccent.Pink200,
                        MaterialTextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.Green600,
                        MaterialPrimary.Green700,
                        MaterialPrimary.Green200,
                        MaterialAccent.Red100,
                        MaterialTextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.BlueGrey800,
                        MaterialPrimary.BlueGrey900,
                        MaterialPrimary.BlueGrey500,
                        MaterialAccent.LightBlue200,
                        MaterialTextShade.WHITE);
                    break;
            }
            Invalidate();
        }


        private void MaterialButton3_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new("Batch operation report:\n\n");
            Random random = new();
            int result = 0;

            for (int i = 0; i < 200; i++)
            {
                result = random.Next(1000);

                if (result < 950)
                {
                    builder.AppendFormat(" - Task {0}: Operation completed sucessfully.\n", i);
                }
                else
                {
                    builder.AppendFormat(" - Task {0}: Operation failed! A very very very very very very very very very very very very serious error has occured during this sub-operation. The errorcode is: {1}).\n", i, result);
                }
            }

            string batchOperationResults = builder.ToString();
            batchOperationResults = "Simple text";
            DialogResult mresult = MaterialMessageBox.Show(batchOperationResults, "Batch Operation", MessageBoxButtons.YesNoCancel, MaterialFlexibleForm.ButtonsPosition.Center);
            materialComboBox1.Items.Add("this is a very long string");
        }

        private void MaterialTextBox2_LeadingIconClick(object sender, EventArgs e)
        {
            MaterialSnackBar SnackBarMessage = new("Leading Icon Click");
            SnackBarMessage.Show(this);

        }

        private void MaterialButton6_Click(object sender, EventArgs e)
        {
            MaterialSnackBar SnackBarMessage = new("SnackBar started succesfully", "OK", true);
            SnackBarMessage.Show(this);
        }

   

        private void MaterialTextBox21_LeadingIconClick(object sender, EventArgs e)
        {
            MaterialSnackBar SnackBarMessage = new("Leading Icon Click");
            SnackBarMessage.Show(this);
        }

        private void MaterialTextBox21_TrailingIconClick(object sender, EventArgs e)
        {
            MaterialSnackBar SnackBarMessage = new("Trailing Icon Click");
            SnackBarMessage.Show(this);
        }

        private void MsReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            materialCheckbox1.ReadOnly = msReadOnly.Checked;
        }

        private void MaterialButton25_Click(object sender, EventArgs e)
        {
            MaterialDialog materialDialog = new(this, "Dialog Title", "Dialogs inform users about a task and can contain critical information, require decisions, or involve multiple tasks.", "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);

            MaterialSnackBar SnackBarMessage = new(result.ToString(), 750);
            SnackBarMessage.Show(this);

        }

    


        private void MaterialButton27_Click(object sender, EventArgs e)
        {
            DrawerNonClickTabPage = Array.Empty<System.Windows.Forms.TabPage>();
        }

        private void MaterialButton28_Click(object sender, EventArgs e)
        {
            MaterialAnimations.AnimationRun = MaterialAnimations.AnimationRunType.Normal;
        }

        private void MaterialButton29_Click(object sender, EventArgs e)
        {
            MaterialAnimations.AnimationRun = MaterialAnimations.AnimationRunType.Fast;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            UpdateColor();
        }
    }
}