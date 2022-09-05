using System;
using System.Collections.Generic;
using System.Text;

namespace RtspClientSharp.MediaParsers
{
    internal class MetadataParser : MediaPayloadParser
    {
        public override void Parse(TimeSpan timeOffset, ArraySegment<byte> byteSegment, bool markerBit)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine(timeOffset);
            Console.WriteLine(markerBit);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(byteSegment.Array, byteSegment.Offset, byteSegment.Count));
        }

        public override void ResetState()
        {
        }
    }
}