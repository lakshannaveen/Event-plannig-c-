namespace Event_plannig
{
    partial class CreateEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butcreateevent = new System.Windows.Forms.Button();
            this.butreset = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.startdatepicker = new System.Windows.Forms.DateTimePicker();
            this.enddatepicker = new System.Windows.Forms.DateTimePicker();
            this.txtdescription = new System.Windows.Forms.RichTextBox();
            this.txtlocations = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtendtime = new System.Windows.Forms.TextBox();
            this.txtstarttime = new System.Windows.Forms.TextBox();
            this.butcheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Event";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Event End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Locations";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price";
            // 
            // butcreateevent
            // 
            this.butcreateevent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.butcreateevent.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcreateevent.ForeColor = System.Drawing.SystemColors.Control;
            this.butcreateevent.Location = new System.Drawing.Point(453, 599);
            this.butcreateevent.Name = "butcreateevent";
            this.butcreateevent.Size = new System.Drawing.Size(150, 40);
            this.butcreateevent.TabIndex = 7;
            this.butcreateevent.Text = "Create Event";
            this.butcreateevent.UseVisualStyleBackColor = false;
            this.butcreateevent.Click += new System.EventHandler(this.button1_Click);
            // 
            // butreset
            // 
            this.butreset.BackColor = System.Drawing.Color.Red;
            this.butreset.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butreset.Location = new System.Drawing.Point(667, 599);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(150, 40);
            this.butreset.TabIndex = 8;
            this.butreset.Text = "Reset";
            this.butreset.UseVisualStyleBackColor = false;
            this.butreset.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(455, 61);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(362, 33);
            this.txtname.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(453, 531);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(362, 33);
            this.txtprice.TabIndex = 14;
            // 
            // startdatepicker
            // 
            this.startdatepicker.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdatepicker.Location = new System.Drawing.Point(455, 117);
            this.startdatepicker.Name = "startdatepicker";
            this.startdatepicker.Size = new System.Drawing.Size(362, 33);
            this.startdatepicker.TabIndex = 15;
            // 
            // enddatepicker
            // 
            this.enddatepicker.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddatepicker.Location = new System.Drawing.Point(455, 173);
            this.enddatepicker.Name = "enddatepicker";
            this.enddatepicker.Size = new System.Drawing.Size(361, 33);
            this.enddatepicker.TabIndex = 16;
            // 
            // txtdescription
            // 
            this.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(455, 437);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(362, 69);
            this.txtdescription.TabIndex = 18;
            this.txtdescription.Text = "";
            // 
            // txtlocations
            // 
            this.txtlocations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlocations.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocations.Location = new System.Drawing.Point(455, 343);
            this.txtlocations.Name = "txtlocations";
            this.txtlocations.Size = new System.Drawing.Size(362, 68);
            this.txtlocations.TabIndex = 19;
            this.txtlocations.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Event Start Time";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Event End Time";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtendtime
            // 
            this.txtendtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtendtime.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendtime.Location = new System.Drawing.Point(455, 287);
            this.txtendtime.Name = "txtendtime";
            this.txtendtime.Size = new System.Drawing.Size(360, 33);
            this.txtendtime.TabIndex = 23;
            // 
            // txtstarttime
            // 
            this.txtstarttime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstarttime.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstarttime.Location = new System.Drawing.Point(455, 231);
            this.txtstarttime.Name = "txtstarttime";
            this.txtstarttime.Size = new System.Drawing.Size(361, 33);
            this.txtstarttime.TabIndex = 22;
            // 
            // butcheck
            // 
            this.butcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butcheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.butcheck.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcheck.Location = new System.Drawing.Point(858, 599);
            this.butcheck.Name = "butcheck";
            this.butcheck.Size = new System.Drawing.Size(150, 40);
            this.butcheck.TabIndex = 24;
            this.butcheck.Text = "Check Status";
            this.butcheck.UseVisualStyleBackColor = false;
            this.butcheck.Click += new System.EventHandler(this.butcheck_Click);
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 663);
            this.Controls.Add(this.butcheck);
            this.Controls.Add(this.txtendtime);
            this.Controls.Add(this.txtstarttime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtlocations);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.enddatepicker);
            this.Controls.Add(this.startdatepicker);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.butcreateevent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateEvent";
            this.Text = "CreateEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butcreateevent;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DateTimePicker startdatepicker;
        private System.Windows.Forms.DateTimePicker enddatepicker;
        private System.Windows.Forms.RichTextBox txtdescription;
        private System.Windows.Forms.RichTextBox txtlocations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtendtime;
        private System.Windows.Forms.TextBox txtstarttime;
        private System.Windows.Forms.Button butcheck;
    }
}

