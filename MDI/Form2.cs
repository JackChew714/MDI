using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace MDI
{
    public partial class Form2 : Form
    {
        
        SpeechSynthesizer sph = new SpeechSynthesizer();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PromptBuilder builder = new PromptBuilder();
            builder.StartSentence();
            builder.AppendText(textBox1.Text,PromptVolume.ExtraLoud);
            builder.EndSentence();
            builder.AppendBreak(new TimeSpan(0, 0, 1));
            builder.StartSentence();
            builder.AppendText("Nice to meet you", PromptEmphasis.Strong);
            builder.EndSentence();
            sph.Rate = trackBar1.Value;
      
            if(comboBox1.SelectedIndex != -1)
            {
                if (comboBox1.SelectedItem == "Male")
                {
                    sph.SelectVoiceByHints(VoiceGender.Male);
                }
                else
                {
                    sph.SelectVoiceByHints(VoiceGender.Female);
                }
            }
           
            sph.SpeakAsync(builder);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Choices command = new Choices();
            command.Add(new string[] { "say hello", "print my name" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(command);
            Grammar gm = new Grammar(gBuilder);
            sre.LoadGrammarAsync(gm);
            sre.SetInputToDefaultAudioDevice();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(sph.State == SynthesizerState.Speaking)
            {
                sph.Pause();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(sph.State == SynthesizerState.Paused)
            {
                sph.Resume();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sph.Dispose();
        }
    }
}
