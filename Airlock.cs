using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Tumbledryer_2D
{
    public partial class Tumbledryer_2D : Form
    {
        public static BlockingCollection<string> Airlock = new BlockingCollection<string>(1);
    }
}
