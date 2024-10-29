namespace project2
{
    partial class crud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblemployeeid = new Label();
            lblempname = new Label();
            lblempdesignation = new Label();
            lblempdoj = new Label();
            lblempsal = new Label();
            lblempdeptno = new Label();
            Empid = new TextBox();
            Empname = new TextBox();
            Empdesignation = new TextBox();
            Empdoj = new TextBox();
            Empsalary = new TextBox();
            Empdeptno = new TextBox();
            btninsert = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            btnclear = new Button();
            SuspendLayout();
            // 
            // lblemployeeid
            // 
            lblemployeeid.AutoSize = true;
            lblemployeeid.Location = new Point(155, 109);
            lblemployeeid.Name = "lblemployeeid";
            lblemployeeid.Size = new Size(68, 25);
            lblemployeeid.TabIndex = 0;
            lblemployeeid.Text = "Emp id";
            //lblemployeeid.Click += label1_Click;
            // 
            // lblempname
            // 
            lblempname.AutoSize = true;
            lblempname.Location = new Point(155, 146);
            lblempname.Name = "lblempname";
            lblempname.Size = new Size(97, 25);
            lblempname.TabIndex = 1;
            lblempname.Text = "Emp name";
            // 
            // lblempdesignation
            // 
            lblempdesignation.AutoSize = true;
            lblempdesignation.Location = new Point(155, 187);
            lblempdesignation.Name = "lblempdesignation";
            lblempdesignation.Size = new Size(146, 25);
            lblempdesignation.TabIndex = 2;
            lblempdesignation.Text = "Emp designation";
            //lblempdesignation.Click += label3_Click;
            // 
            // lblempdoj
            // 
            lblempdoj.AutoSize = true;
            lblempdoj.Location = new Point(155, 230);
            lblempdoj.Name = "lblempdoj";
            lblempdoj.Size = new Size(86, 25);
            lblempdoj.TabIndex = 3;
            lblempdoj.Text = "Emp DOJ";
            // 
            // lblempsal
            // 
            lblempsal.AutoSize = true;
            lblempsal.Location = new Point(155, 275);
            lblempsal.Name = "lblempsal";
            lblempsal.Size = new Size(100, 25);
            lblempsal.TabIndex = 4;
            lblempsal.Text = "Emp Salary";
            // 
            // lblempdeptno
            // 
            lblempdeptno.AutoSize = true;
            lblempdeptno.Location = new Point(155, 314);
            lblempdeptno.Name = "lblempdeptno";
            lblempdeptno.Size = new Size(116, 25);
            lblempdeptno.TabIndex = 5;
            lblempdeptno.Text = "Emp DeptNo";
            // 
            // Empid
            // 
            Empid.Location = new Point(357, 103);
            Empid.Name = "Empid";
            Empid.Size = new Size(150, 31);
            Empid.TabIndex = 6;
            // 
            // Empname
            // 
            Empname.Location = new Point(357, 140);
            Empname.Name = "Empname";
            Empname.Size = new Size(150, 31);
            Empname.TabIndex = 8;
            // 
            // Empdesignation
            // 
            Empdesignation.Location = new Point(357, 181);
            Empdesignation.Name = "Empdesignation";
            Empdesignation.Size = new Size(150, 31);
            Empdesignation.TabIndex = 9;
            // 
            // Empdoj
            // 
            Empdoj.Location = new Point(357, 224);
            Empdoj.Name = "Empdoj";
            Empdoj.Size = new Size(150, 31);
            Empdoj.TabIndex = 10;
            // 
            // Empsalary
            // 
            Empsalary.Location = new Point(357, 269);
            Empsalary.Name = "Empsalary";
            Empsalary.Size = new Size(150, 31);
            Empsalary.TabIndex = 11;
            // 
            // Empdeptno
            // 
            Empdeptno.Location = new Point(357, 308);
            Empdeptno.Name = "Empdeptno";
            Empdeptno.Size = new Size(150, 31);
            Empdeptno.TabIndex = 12;
            // 
            // btninsert
            // 
            btninsert.Location = new Point(288, 383);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(112, 34);
            btninsert.TabIndex = 13;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(395, 383);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(112, 34);
            btnupdate.TabIndex = 14;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(288, 414);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(112, 34);
            btndelete.TabIndex = 15;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(395, 414);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(112, 34);
            btnclear.TabIndex = 16;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // crud
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 477);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btninsert);
            Controls.Add(Empdeptno);
            Controls.Add(Empsalary);
            Controls.Add(Empdoj);
            Controls.Add(Empdesignation);
            Controls.Add(Empname);
            Controls.Add(Empid);
            Controls.Add(lblempdeptno);
            Controls.Add(lblempsal);
            Controls.Add(lblempdoj);
            Controls.Add(lblempdesignation);
            Controls.Add(lblempname);
            Controls.Add(lblemployeeid);
            Name = "crud";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblemployeeid;
        private Label lblempname;
        private Label lblempdesignation;
        private Label lblempdoj;
        private Label lblempsal;
        private Label lblempdeptno;
        private TextBox Empid;
        private TextBox Empname;
        private TextBox Empdesignation;
        private TextBox Empdoj;
        private TextBox Empsalary;
        private TextBox Empdeptno;
        private Button btninsert;
        private Button btnupdate;
        private Button btndelete;
        private Button btnclear;
    }
}