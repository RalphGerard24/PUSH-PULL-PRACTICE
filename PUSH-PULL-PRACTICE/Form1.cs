using System;
using System.Windows.Forms;

namespace PUSH_PULL_PRACTICE

{
    public partial class Form1 : Form
    {
        private Label demoLabel;
        private Button demoButton;
        private MessageService messageService;

        public Form1()
        {
            InitializeComponent();
            messageService = new MessageService();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            demoLabel = new Label
            {
                Text = messageService.GetInitialMessage(),
                Location = new System.Drawing.Point(50, 50),
                AutoSize = true
            };
            this.Controls.Add(demoLabel);

            demoButton = new Button
            {
                Text = "Click Me",
                Location = new System.Drawing.Point(50, 100)
            };
            demoButton.Click += DemoButton_Click;
            this.Controls.Add(demoButton);
        }

        private void DemoButton_Click(object sender, EventArgs e)
        {
            demoLabel.Text = messageService.GetClickedMessage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
