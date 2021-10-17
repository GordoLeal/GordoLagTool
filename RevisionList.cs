using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GordoLagTool
{
    class RevisionList
    {
        public static RevisionList ins;
        public struct GameRevision
        {
            public int revision;
            public int MainPointer;
            public int[] offsets;
        }
        private List<GameRevision> Revisions = new List<GameRevision>();
        public RevisionList()
        {
            ins = this;

            Revisions.Add(new GameRevision()
            {
                MainPointer = 0x0341D868,
                revision = 611616,
                offsets = new int[]
   {
                    0x48,
                    0x378
   }
            });

            Revisions.Add(new GameRevision()
            {
                MainPointer = 0x03429B98,
                revision = 604909,
                offsets = new int[]
              {
                    0x48,
                    0x378
              }
            });

            Revisions.Add(new GameRevision()
            {
                MainPointer = 0x03414EA0,
                revision = 603899,
                offsets = new int[]
               {
                    0x10,
                    0x378
               }
            });

            Revisions.Add(new GameRevision()
            {
                MainPointer = 0x03415F98,
                revision = 603442,
                offsets = new int[]
                {
                    0x48,
                    0x378
                }
            });

            Revisions.Add(new GameRevision()
            {
                MainPointer = 0x3487218,
                revision = 603296,
                offsets = new int[]
                {
                    0x48,
                    0x378
                }
            });

            Revisions.Add(new GameRevision()
            {
                MainPointer = 0x034693D8,
                revision = 600294,
                offsets = new int[]
                {
                    0x48,
                    0x378
                }
            }
            );
        }

        public List<GameRevision> ReturnRevisionList()
        {
            return Revisions;
        }

    }
}
