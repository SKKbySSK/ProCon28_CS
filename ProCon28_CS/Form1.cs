using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace ProCon28_CS
{
    public partial class Form1 : Form
    {
        private VideoCapture VideoCapture { get; set; }
        private Task CaptureTask { get; set; }
        private List<IMatProcess> MatProcesses { get; } = new List<IMatProcess>();
        private bool IsPaused { get; set; } = false;
        private bool Abort { get; set; } = false;

        public Reactive.Bindings.ReactiveProperty<CaptureState> State { get; }
            = new Reactive.Bindings.ReactiveProperty<CaptureState>();

        public Form1()
        {
            InitializeComponent();

            State.PropertyChanged += State_PropertyChanged;
            State.Value = CaptureState.Stopped;
            
            MatProcesses.Add(new MatProcess.ImagePreviewer() { ConvertColor = true, ColorConversionCode = ColorConversionCodes.BGR2GRAY });

            MatProcesses.Add(ProcessManager.Contours);
            contoursMode.SelectedIndex = (int)ProcessManager.Contours.OutputMode;
        }

        private void State_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            beginB.Enabled = false;
            finishB.Enabled = false;
            pauseB.Enabled = false;

            switch (State.Value)
            {
                case CaptureState.Capturing:
                    pauseB.Enabled = true;
                    finishB.Enabled = true;
                    break;
                case CaptureState.Paused:
                    beginB.Enabled = true;
                    finishB.Enabled = true;
                    break;
                case CaptureState.Stopped:
                    beginB.Enabled = true;
                    break;
            }
        }

        private void UpdateImage()
        {
            while (true)
            {
                if (Abort)
                {
                    Abort = false;
                    return;
                }

                if (!IsPaused)
                {
                    using (Mat rmat = VideoCapture.RetrieveMat())
                    {
                        using (Mat cmat = new Mat())
                        {
                            rmat.CopyTo(cmat);

                            DoMatProcess((proc) =>
                            {
                                if (proc.UseRawMat)
                                {
                                    using (Mat pmat = new Mat())
                                    {
                                        rmat.CopyTo(pmat);
                                        proc.OnMatChanged(pmat);
                                    }
                                }
                                else
                                {
                                    proc.OnMatChanged(cmat);
                                }
                            });
                        }
                    }
                }
            }
        }

        private void beginB_Click(object sender, EventArgs e)
        {
            if(State.Value == CaptureState.Stopped)
            {
                DoMatProcess((proc) => proc.Begin());

                if (VideoCapture == null)
                    VideoCapture = new VideoCapture((int)deviceN.Value);

                if (CaptureTask == null)
                    CaptureTask = Task.Run(action: UpdateImage);
            }
            else
            {
                IsPaused = false;
            }

            State.Value = CaptureState.Capturing;
        }

        private void finishB_Click(object sender, EventArgs e)
        {
            DisposeOpenCV();
        }

        void DisposeOpenCV()
        {
            Abort = true;
            CaptureTask.Wait();
            CaptureTask = null;

            DoMatProcess((proc) => proc.End());

            VideoCapture?.Dispose();
            VideoCapture = null;

            Window.DestroyAllWindows();
            IsPaused = false;

            State.Value = CaptureState.Stopped;
        }

        void DoMatProcess(Action<IMatProcess> Action)
        {
            foreach (IMatProcess proc in MatProcesses) Action(proc);
        }

        private void pauseB_Click(object sender, EventArgs e)
        {
            IsPaused = true;
            State.Value = CaptureState.Paused;
        }

        private void contoursThresh_Scroll(object sender, EventArgs e)
        {
            ProcessManager.Contours.Threshold = contoursThresh.Value;
        }

        private void contoursMaxVal_Scroll(object sender, EventArgs e)
        {
            ProcessManager.Contours.MaxValue = contoursMaxVal.Value;
        }

        private void contoursMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (contoursMode.SelectedIndex)
            {
                case 0:
                    ProcessManager.Contours.OutputMode = MatProcess.Contours.OutputImage.Gray;
                    break;
                case 1:
                    ProcessManager.Contours.OutputMode = MatProcess.Contours.OutputImage.Binary;
                    break;
                case 2:
                    ProcessManager.Contours.OutputMode = MatProcess.Contours.OutputImage.Contours;
                    break;
            }
        }
    }

    public enum CaptureState
    {
        Capturing, Paused, Stopped
    }
}
