﻿namespace OggVorbisEncoder.Setup.Templates.Stereo44.BookBlocks.Chapter8
{
    public class Page8_0 : IStaticCodeBook
    {
        public int Dimensions = 2;

        public byte[] LengthList = {
            1, 4, 4, 7, 6, 8, 8, 8, 7, 9, 8, 10, 10, 11, 10, 6,
            5, 5, 7, 7, 9, 9, 8, 8, 10, 10, 11, 11, 12, 11, 6, 5,
            5, 7, 7, 9, 9, 9, 9, 10, 10, 11, 11, 12, 12, 20, 8, 8,
            8, 8, 9, 9, 9, 9, 10, 10, 11, 11, 12, 12, 20, 8, 8, 8,
            8, 10, 9, 9, 9, 10, 10, 11, 11, 12, 12, 20, 12, 12, 9, 9,
            10, 10, 10, 10, 10, 11, 12, 12, 12, 12, 20, 12, 12, 9, 9, 10,
            10, 10, 10, 11, 11, 12, 12, 13, 13, 20, 20, 20, 9, 9, 9, 9,
            11, 10, 11, 11, 12, 12, 12, 13, 20, 19, 19, 9, 9, 9, 9, 11,
            11, 11, 12, 12, 12, 13, 13, 19, 19, 19, 13, 13, 10, 10, 11, 11,
            12, 12, 13, 13, 13, 13, 19, 19, 19, 14, 13, 11, 10, 11, 11, 12,
            12, 12, 13, 13, 13, 19, 19, 19, 19, 19, 12, 12, 12, 12, 13, 13,
            13, 13, 14, 13, 19, 19, 19, 19, 19, 12, 12, 12, 11, 12, 12, 13,
            14, 14, 14, 19, 19, 19, 19, 19, 16, 15, 13, 12, 13, 13, 13, 14,
            14, 14, 19, 19, 19, 19, 19, 17, 17, 13, 12, 13, 11, 14, 13, 15,
            15
        };

        public CodeBookMapType MapType = CodeBookMapType.Implicit;
        public int QuantMin = -520986624;
        public int QuantDelta = 1620377600;
        public int Quant = 4;
        public int QuantSequenceP = 0;

        public int[] QuantList = {
            7,
            6,
            8,
            5,
            9,
            4,
            10,
            3,
            11,
            2,
            12,
            1,
            13,
            0,
            14
        };
    }
}