using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioAnalyzer
{
    public enum AudioEvent
    {
        BEAT,
        LOWEST_HIT,
        LOWER_HIT,
        LOW_HIT,
        MID_HIT,
        HIGH_HIT,
        HIGHER_HIT,
        HIGHEST_HIT
    }

    public enum SpectrumType
    {
        DECIBAL,
        LINEAR,
        SQUARE
    }

    public delegate void AudioEventHandler(object sender, AudioEventArgs e);

    public class AudioEventArgs : EventArgs
    {
        private int _spectrumPoint;
        private SpectrumType _dataType;
        private double _actualValue;

        public int SpectrumPoint
        {
            get { return _spectrumPoint; }
            set { _spectrumPoint = value; }
        }

        public SpectrumType DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }

        public double ActualValue
        {
            get { return _actualValue; }
            set { _actualValue = value; }
        }

        public AudioEventArgs(int spectrumPoint, SpectrumType spectrumType, double actualValue)
        {
            this.SpectrumPoint = spectrumPoint;
            this.DataType = spectrumType;
            this.ActualValue = actualValue;
        }
    }
}
