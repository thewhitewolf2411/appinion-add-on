﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace appinion_add_on
{
    public partial class Ribbon1
    {
        

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            AddPresentationForm APF = new AddPresentationForm();
            APF.Show();
            
        }

        public void AddSlide()
        {
            PowerPoint.CustomLayout ppt_layout = Globals.ThisAddIn.Application.ActivePresentation.SlideMaster.CustomLayouts[PowerPoint.PpSlideLayout.ppLayoutBlank];
            PowerPoint.Slide slide;

            slide = Globals.ThisAddIn.Application.ActivePresentation.Slides.AddSlide(1, PowerPoint.PpSlideLayout.ppLayoutBlank);
            slide.Shapes[1].Delete();
            slide.Shapes.Placeholders[1].Delete();
        }



        
    }
}
