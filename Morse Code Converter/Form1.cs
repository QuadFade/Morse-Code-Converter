//John Fade IV 2307363
//I worked alone on this assignment 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Code_Converter
{
    public partial class Form1 : Form
    {
        //array for morse code letters
        char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                           'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                           'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                           '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        //array for morse code 
        string[] morse = 
        {
            "    ", ". ___", "___ . . .", "___ . ___ .", "___ . .", ".", ". . ___ .", "___ ___ .",
            ". . . .", ". .", ". ___ ___ ___", "___ . ___", ". ___ . .", "___ ___", "___ .", "___ ___ ___", ". ___ ___ .",
            "___ ___ . ___", ". ___ .", ". . .", "_", ". . ___", ". . . ___", ". ___ ___", "___ . . ___", "___ . ___ ___", "___ ___ . .",
            ". ___ ___ ___ ___", ". . ___ ___ ___", ". . . ___ ___", ". . . . ___", ". . . . .", "___ . . . .", "___ ___ . . .", "___ ___ ___ . .", "___ ___ ___ ___ .", "___ ___ ___ ___ ___"
        };


        public Form1()
        {
            InitializeComponent();
        }

        //converts text entered by the user into Morse code
        private void convertButton_Click(object sender, EventArgs e)
        {
            
            string input = convertTextBox.Text.Trim(); //assigns input from user
            input = input.ToLower();//sets the input to lowercases
            
            for (int i = 0; i < input.Length; i++) //for each letter contained in the word
            {
                  
                    char c = input[i];
                var index = Array.IndexOf(letters, c);
                if (index > 0)
                {
                    string code = morse[index];


                    outputTextBox.Text += code + "/";

                }              
                
            }
            
            MessageBox.Show(input);
        }
        //exits the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            convertTextBox.Clear();
            revertTextBox.Clear();
        }

    //reverts the entry from the user back to english and outputs it
        private void revertButton_Click(object sender, EventArgs e)
        {

            string input = outputTextBox.Text.Trim();
           
            string[] inputList = input.Split('/');
            

            for (int i = 0; i < inputList.Length; i++) //for each letter contained in the word
            {

                string c = inputList[i];
                var index = Array.IndexOf(morse, c);
                if (index > 0)
                {
                    char code = letters[index];
                    revertTextBox.Text += code;

                }


            }

            MessageBox.Show(input);
        }
    }
    }
