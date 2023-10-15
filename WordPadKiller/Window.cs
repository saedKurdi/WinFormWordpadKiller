using System.Drawing.Text;

namespace WordPadKiller
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }
        bool bold_clicked = false;
        bool underlined_clicked = false;
        bool italic_clicked = false;


        public InstalledFontCollection InstalledFontCollection_ = new InstalledFontCollection() { };
        public List<Color> AllColors = new List<Color>() { };
        public List<int> Ints = new List<int>() { };

        private void Window1_Load(object sender, EventArgs e)
        {

            foreach (var font in InstalledFontCollection_.Families)
            {
                font_combobox.Items.Add(font.Name);
            }


            for (int i = 5; i < 51; i++)
            {
                Ints.Add(i);
            }

            size_combobox.DataSource = Ints;

            size_combobox.SelectedIndex = 10;



            foreach (Color color in new ColorConverter().GetStandardValues())
            {
                AllColors.Add(color);
            }

            foreach (var color in AllColors)
            {
                color_combobox.Items.Add(color.Name);
            }

            color_combobox.SelectedItem = null;
        }

        private void font_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = font_combobox.SelectedIndex;
            FontFamily font = InstalledFontCollection_.Families[index];
            richTextBox1.Font = new Font(font, richTextBox1.Font.Size, richTextBox1.Font.Style);
        }

        private void size_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = size_combobox.SelectedIndex;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Ints[index], richTextBox1.Font.Style);
        }

        private void bold_button_Click(object sender, EventArgs e)
        {
            underlined_clicked = false;
            italic_clicked = false;

            underlined_button.BackColor = SystemColors.ScrollBar;
            italic_button.BackColor = SystemColors.ScrollBar;


            if (bold_clicked)
            {
                bold_clicked = false;
                bold_button.BackColor = SystemColors.ScrollBar;
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
            }

            else
            {
                bold_clicked = true;
                bold_button.BackColor = Color.DarkGray;
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
            }

        }

        private void underlined_button_Click(object sender, EventArgs e)
        {
            bold_clicked = false;
            italic_clicked = false;

            bold_button.BackColor = SystemColors.ScrollBar;
            italic_button.BackColor = SystemColors.ScrollBar;

            if (underlined_clicked)
            {
                underlined_clicked = false;
                underlined_button.BackColor = SystemColors.ScrollBar;
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);

            }

            else
            {
                underlined_clicked = true;
                underlined_button.BackColor = Color.DarkGray;
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
            }
        }

        private void italic_button_Click(object sender, EventArgs e)
        {
            bold_clicked = false;
            underlined_clicked = false;

            bold_button.BackColor = SystemColors.ScrollBar;
            underlined_button.BackColor = SystemColors.ScrollBar;

            if (italic_clicked)
            {
                italic_clicked = false;
                italic_button.BackColor = SystemColors.ScrollBar;
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);

            }

            else
            {
                italic_clicked = true;
                italic_button.BackColor = Color.DarkGray;
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
            }
        }

        private void color_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = color_combobox.SelectedIndex;
            Font font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, richTextBox1.Font.Style);
            richTextBox1.Font = font;
            richTextBox1.ForeColor = AllColors[index];
        }

        private void loadfile_button_Click(object sender, EventArgs e)
        {
            if (File.Exists(loadfile_textbox.Text))
            {
                string text = File.ReadAllText(loadfile_textbox.Text);
                richTextBox1.Text = text;
                MessageBox.Show("Loaded !");
            }
            else
                MessageBox.Show("This File Doesn't Excist ! ", "NO EXCIST", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            loadfile_textbox.Text = "";
        }

        private void savefile_button_Click(object sender, EventArgs e)
        {
            File.WriteAllText(savefile_textbox.Text, richTextBox1.Text);
            MessageBox.Show("Saved !");
            savefile_textbox.Text = "";
        }



        private void savefile_textbox_Click(object sender, EventArgs e)
        {
            if (savefile_textbox.Text == "Enter name and save file.")
                savefile_textbox.Text = "";
        }

        private void loadfile_textbox_Click(object sender, EventArgs e)
        {
            if (loadfile_textbox.Text == "Enter name and load file.")
                loadfile_textbox.Text = "";
        }
    }
}