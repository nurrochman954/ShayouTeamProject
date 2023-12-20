﻿namespace ShayouShop
{
    partial class AdminAddUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminAddUsers_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminAddUsers_imageView = new System.Windows.Forms.PictureBox();
            this.adminAddUsers_clearBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_deleteBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_updateBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_addBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_status = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminAddUsers_role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminAddUsers_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminAddUsers_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imageView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of Users";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(617, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 1044);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(33, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(821, 904);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adminAddUsers_importBtn
            // 
            this.adminAddUsers_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUsers_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUsers_importBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_importBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_importBtn.Location = new System.Drawing.Point(190, 218);
            this.adminAddUsers_importBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_importBtn.Name = "adminAddUsers_importBtn";
            this.adminAddUsers_importBtn.Size = new System.Drawing.Size(154, 51);
            this.adminAddUsers_importBtn.TabIndex = 17;
            this.adminAddUsers_importBtn.Text = "Import";
            this.adminAddUsers_importBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_importBtn.Click += new System.EventHandler(this.adminAddUsers_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.adminAddUsers_imageView);
            this.panel3.Location = new System.Drawing.Point(190, 37);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 171);
            this.panel3.TabIndex = 16;
            // 
            // adminAddUsers_imageView
            // 
            this.adminAddUsers_imageView.Location = new System.Drawing.Point(0, 5);
            this.adminAddUsers_imageView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_imageView.Name = "adminAddUsers_imageView";
            this.adminAddUsers_imageView.Size = new System.Drawing.Size(154, 166);
            this.adminAddUsers_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminAddUsers_imageView.TabIndex = 0;
            this.adminAddUsers_imageView.TabStop = false;
            // 
            // adminAddUsers_clearBtn
            // 
            this.adminAddUsers_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUsers_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUsers_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_clearBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_clearBtn.Location = new System.Drawing.Point(318, 838);
            this.adminAddUsers_clearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_clearBtn.Name = "adminAddUsers_clearBtn";
            this.adminAddUsers_clearBtn.Size = new System.Drawing.Size(184, 75);
            this.adminAddUsers_clearBtn.TabIndex = 15;
            this.adminAddUsers_clearBtn.Text = "CLEAR";
            this.adminAddUsers_clearBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_clearBtn.Click += new System.EventHandler(this.adminAddUsers_clearBtn_Click);
            // 
            // adminAddUsers_deleteBtn
            // 
            this.adminAddUsers_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUsers_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUsers_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_deleteBtn.Location = new System.Drawing.Point(56, 838);
            this.adminAddUsers_deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_deleteBtn.Name = "adminAddUsers_deleteBtn";
            this.adminAddUsers_deleteBtn.Size = new System.Drawing.Size(184, 75);
            this.adminAddUsers_deleteBtn.TabIndex = 14;
            this.adminAddUsers_deleteBtn.Text = "DELETE";
            this.adminAddUsers_deleteBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_deleteBtn.Click += new System.EventHandler(this.adminAddUsers_deleteBtn_Click);
            // 
            // adminAddUsers_updateBtn
            // 
            this.adminAddUsers_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUsers_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUsers_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_updateBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_updateBtn.Location = new System.Drawing.Point(318, 714);
            this.adminAddUsers_updateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_updateBtn.Name = "adminAddUsers_updateBtn";
            this.adminAddUsers_updateBtn.Size = new System.Drawing.Size(184, 75);
            this.adminAddUsers_updateBtn.TabIndex = 13;
            this.adminAddUsers_updateBtn.Text = "UPDATE";
            this.adminAddUsers_updateBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_updateBtn.Click += new System.EventHandler(this.adminAddUsers_updateBtn_Click);
            // 
            // adminAddUsers_addBtn
            // 
            this.adminAddUsers_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUsers_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUsers_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_addBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_addBtn.Location = new System.Drawing.Point(56, 714);
            this.adminAddUsers_addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_addBtn.Name = "adminAddUsers_addBtn";
            this.adminAddUsers_addBtn.Size = new System.Drawing.Size(184, 75);
            this.adminAddUsers_addBtn.TabIndex = 12;
            this.adminAddUsers_addBtn.Text = "ADD";
            this.adminAddUsers_addBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_addBtn.Click += new System.EventHandler(this.adminAddUsers_addBtn_Click);
            // 
            // adminAddUsers_status
            // 
            this.adminAddUsers_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_status.FormattingEnabled = true;
            this.adminAddUsers_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.adminAddUsers_status.Location = new System.Drawing.Point(204, 548);
            this.adminAddUsers_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_status.Name = "adminAddUsers_status";
            this.adminAddUsers_status.Size = new System.Drawing.Size(316, 41);
            this.adminAddUsers_status.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.adminAddUsers_importBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.adminAddUsers_clearBtn);
            this.panel1.Controls.Add(this.adminAddUsers_deleteBtn);
            this.panel1.Controls.Add(this.adminAddUsers_updateBtn);
            this.panel1.Controls.Add(this.adminAddUsers_addBtn);
            this.panel1.Controls.Add(this.adminAddUsers_status);
            this.panel1.Controls.Add(this.adminAddUsers_role);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.adminAddUsers_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adminAddUsers_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 1044);
            this.panel1.TabIndex = 2;
            // 
            // adminAddUsers_role
            // 
            this.adminAddUsers_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_role.FormattingEnabled = true;
            this.adminAddUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.adminAddUsers_role.Location = new System.Drawing.Point(204, 477);
            this.adminAddUsers_role.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_role.Name = "adminAddUsers_role";
            this.adminAddUsers_role.Size = new System.Drawing.Size(316, 41);
            this.adminAddUsers_role.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 560);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 489);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Role:";
            // 
            // adminAddUsers_password
            // 
            this.adminAddUsers_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_password.Location = new System.Drawing.Point(204, 414);
            this.adminAddUsers_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_password.Name = "adminAddUsers_password";
            this.adminAddUsers_password.Size = new System.Drawing.Size(316, 35);
            this.adminAddUsers_password.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 422);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // adminAddUsers_username
            // 
            this.adminAddUsers_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_username.Location = new System.Drawing.Point(204, 343);
            this.adminAddUsers_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminAddUsers_username.Name = "adminAddUsers_username";
            this.adminAddUsers_username.Size = new System.Drawing.Size(316, 35);
            this.adminAddUsers_username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // AdminAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddUsers";
            this.Size = new System.Drawing.Size(1500, 1106);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imageView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adminAddUsers_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox adminAddUsers_imageView;
        private System.Windows.Forms.Button adminAddUsers_clearBtn;
        private System.Windows.Forms.Button adminAddUsers_deleteBtn;
        private System.Windows.Forms.Button adminAddUsers_updateBtn;
        private System.Windows.Forms.Button adminAddUsers_addBtn;
        private System.Windows.Forms.ComboBox adminAddUsers_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox adminAddUsers_role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adminAddUsers_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminAddUsers_username;
        private System.Windows.Forms.Label label2;
    }
}
