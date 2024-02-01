namespace CaseForm
{
    partial class Form1
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
            listBox1 = new ListBox();
            btn_list = new Button();
            lbl_id = new Label();
            lbl_title = new Label();
            lbl_category = new Label();
            lbl_price = new Label();
            btn_add = new Button();
            txt_id = new TextBox();
            txt_title = new TextBox();
            txt_category = new TextBox();
            txt_price = new TextBox();
            btn_update = new Button();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(488, 139);
            listBox1.TabIndex = 0;
            // 
            // btn_list
            // 
            btn_list.Location = new Point(6, 351);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(119, 36);
            btn_list.TabIndex = 1;
            btn_list.Text = "List";
            btn_list.UseVisualStyleBackColor = true;
            btn_list.Click += btn_list_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(16, 183);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(17, 15);
            lbl_id.TabIndex = 2;
            lbl_id.Text = "Id";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(16, 219);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(29, 15);
            lbl_title.TabIndex = 3;
            lbl_title.Text = "Title";
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Location = new Point(16, 254);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(87, 15);
            lbl_category.TabIndex = 4;
            lbl_category.Text = "CategoryName";
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Location = new Point(16, 292);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(33, 15);
            lbl_price.TabIndex = 5;
            lbl_price.Text = "Price";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(131, 351);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 36);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(119, 180);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 7;
            // 
            // txt_title
            // 
            txt_title.Location = new Point(119, 216);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(100, 23);
            txt_title.TabIndex = 8;
            // 
            // txt_category
            // 
            txt_category.Location = new Point(119, 251);
            txt_category.Name = "txt_category";
            txt_category.Size = new Size(100, 23);
            txt_category.TabIndex = 9;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(119, 289);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(100, 23);
            txt_price.TabIndex = 10;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(256, 351);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(119, 36);
            btn_update.TabIndex = 11;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(381, 351);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 36);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(txt_price);
            Controls.Add(txt_category);
            Controls.Add(txt_title);
            Controls.Add(txt_id);
            Controls.Add(btn_add);
            Controls.Add(lbl_price);
            Controls.Add(lbl_category);
            Controls.Add(lbl_title);
            Controls.Add(lbl_id);
            Controls.Add(btn_list);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btn_list;
        private Label lbl_id;
        private Label lbl_title;
        private Label lbl_category;
        private Label lbl_price;
        private Button btn_add;
        private TextBox txt_id;
        private TextBox txt_title;
        private TextBox txt_category;
        private TextBox txt_price;
        private Button btn_update;
        private Button btn_delete;
    }
}
