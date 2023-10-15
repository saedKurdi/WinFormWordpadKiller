namespace WordPadKiller
{
    partial class Window1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            font_label = new Label();
            font_combobox = new ComboBox();
            richTextBox1 = new RichTextBox();
            size_combobox = new ComboBox();
            size_label = new Label();
            fontstyle_label = new Label();
            bold_button = new Button();
            italic_button = new Button();
            underlined_button = new Button();
            color_label = new Label();
            color_combobox = new ComboBox();
            loadfile_textbox = new TextBox();
            savefile_textbox = new TextBox();
            loadfile_button = new Button();
            savefile_button = new Button();
            SuspendLayout();
            // 
            // font_label
            // 
            font_label.AutoSize = true;
            font_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            font_label.Location = new Point(136, 9);
            font_label.Name = "font_label";
            font_label.Size = new Size(41, 20);
            font_label.TabIndex = 0;
            font_label.Text = "Font";
            // 
            // font_combobox
            // 
            font_combobox.BackColor = SystemColors.ScrollBar;
            font_combobox.FormattingEnabled = true;
            font_combobox.Location = new Point(12, 32);
            font_combobox.Name = "font_combobox";
            font_combobox.Size = new Size(297, 28);
            font_combobox.TabIndex = 7;
            font_combobox.SelectedIndexChanged += font_combobox_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 83);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1270, 569);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // size_combobox
            // 
            size_combobox.BackColor = SystemColors.ScrollBar;
            size_combobox.FormattingEnabled = true;
            size_combobox.Location = new Point(315, 32);
            size_combobox.Name = "size_combobox";
            size_combobox.Size = new Size(59, 28);
            size_combobox.TabIndex = 8;
            size_combobox.SelectedIndexChanged += size_combobox_SelectedIndexChanged;
            // 
            // size_label
            // 
            size_label.AutoSize = true;
            size_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            size_label.Location = new Point(326, 9);
            size_label.Name = "size_label";
            size_label.Size = new Size(37, 20);
            size_label.TabIndex = 9;
            size_label.Text = "Size";
            // 
            // fontstyle_label
            // 
            fontstyle_label.AutoSize = true;
            fontstyle_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            fontstyle_label.Location = new Point(420, 8);
            fontstyle_label.Name = "fontstyle_label";
            fontstyle_label.Size = new Size(80, 20);
            fontstyle_label.TabIndex = 10;
            fontstyle_label.Text = "Font Style";
            // 
            // bold_button
            // 
            bold_button.BackColor = SystemColors.ScrollBar;
            bold_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bold_button.Location = new Point(400, 32);
            bold_button.Name = "bold_button";
            bold_button.Size = new Size(27, 28);
            bold_button.TabIndex = 11;
            bold_button.Text = "B";
            bold_button.UseVisualStyleBackColor = false;
            bold_button.Click += bold_button_Click;
            // 
            // italic_button
            // 
            italic_button.BackColor = SystemColors.ScrollBar;
            italic_button.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            italic_button.ForeColor = Color.Black;
            italic_button.Location = new Point(485, 32);
            italic_button.Name = "italic_button";
            italic_button.Size = new Size(27, 28);
            italic_button.TabIndex = 12;
            italic_button.Text = "I";
            italic_button.UseVisualStyleBackColor = false;
            italic_button.Click += italic_button_Click;
            // 
            // underlined_button
            // 
            underlined_button.BackColor = SystemColors.ScrollBar;
            underlined_button.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            underlined_button.Location = new Point(442, 31);
            underlined_button.Name = "underlined_button";
            underlined_button.Size = new Size(27, 28);
            underlined_button.TabIndex = 13;
            underlined_button.Text = "U";
            underlined_button.UseVisualStyleBackColor = false;
            underlined_button.Click += underlined_button_Click;
            // 
            // color_label
            // 
            color_label.AutoSize = true;
            color_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            color_label.Location = new Point(602, 8);
            color_label.Name = "color_label";
            color_label.Size = new Size(48, 20);
            color_label.TabIndex = 14;
            color_label.Text = "Color";
            color_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // color_combobox
            // 
            color_combobox.BackColor = SystemColors.ScrollBar;
            color_combobox.FormattingEnabled = true;
            color_combobox.Location = new Point(539, 31);
            color_combobox.Name = "color_combobox";
            color_combobox.Size = new Size(178, 28);
            color_combobox.TabIndex = 15;
            color_combobox.SelectedIndexChanged += color_combobox_SelectedIndexChanged;
            // 
            // loadfile_textbox
            // 
            loadfile_textbox.ForeColor = SystemColors.WindowFrame;
            loadfile_textbox.Location = new Point(750, 9);
            loadfile_textbox.Name = "loadfile_textbox";
            loadfile_textbox.Size = new Size(438, 27);
            loadfile_textbox.TabIndex = 16;
            loadfile_textbox.Text = "Enter name and load file.";
            loadfile_textbox.Click += loadfile_textbox_Click;
            // 
            // savefile_textbox
            // 
            savefile_textbox.ForeColor = SystemColors.WindowFrame;
            savefile_textbox.Location = new Point(750, 50);
            savefile_textbox.Name = "savefile_textbox";
            savefile_textbox.Size = new Size(438, 27);
            savefile_textbox.TabIndex = 17;
            savefile_textbox.Text = "Enter name and save file.";
            savefile_textbox.Click += savefile_textbox_Click;
            // 
            // loadfile_button
            // 
            loadfile_button.BackColor = SystemColors.ScrollBar;
            loadfile_button.Location = new Point(1194, 9);
            loadfile_button.Name = "loadfile_button";
            loadfile_button.Size = new Size(88, 29);
            loadfile_button.TabIndex = 18;
            loadfile_button.Text = "Load";
            loadfile_button.UseVisualStyleBackColor = false;
            loadfile_button.Click += loadfile_button_Click;
            // 
            // savefile_button
            // 
            savefile_button.BackColor = SystemColors.ScrollBar;
            savefile_button.Location = new Point(1194, 49);
            savefile_button.Name = "savefile_button";
            savefile_button.Size = new Size(88, 29);
            savefile_button.TabIndex = 19;
            savefile_button.Text = "Save";
            savefile_button.UseVisualStyleBackColor = false;
            savefile_button.Click += savefile_button_Click;
            // 
            // Window1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 664);
            Controls.Add(savefile_button);
            Controls.Add(loadfile_button);
            Controls.Add(savefile_textbox);
            Controls.Add(loadfile_textbox);
            Controls.Add(color_combobox);
            Controls.Add(color_label);
            Controls.Add(underlined_button);
            Controls.Add(italic_button);
            Controls.Add(bold_button);
            Controls.Add(fontstyle_label);
            Controls.Add(size_label);
            Controls.Add(size_combobox);
            Controls.Add(font_combobox);
            Controls.Add(richTextBox1);
            Controls.Add(font_label);
            Name = "Window1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wordpad Killer";
            Load += Window1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label font_label;
        private ComboBox font_combobox;
        private RichTextBox richTextBox1;
        private ComboBox size_combobox;
        private Label size_label;
        private Label fontstyle_label;
        private Button bold_button;
        private Button italic_button;
        private Button underlined_button;
        private Label color_label;
        private ComboBox color_combobox;
        private TextBox loadfile_textbox;
        private TextBox savefile_textbox;
        private Button loadfile_button;
        private Button savefile_button;
    }
}