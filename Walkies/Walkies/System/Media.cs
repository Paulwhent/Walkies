﻿namespace System
{
    internal class Media
    {
        internal class SoundPlayer
        {
            private string v;

            public SoundPlayer(string v)
            {
                this.v = v;
            }

            internal void Play()
            {
                throw new NotImplementedException();
            }
        }
    }
}