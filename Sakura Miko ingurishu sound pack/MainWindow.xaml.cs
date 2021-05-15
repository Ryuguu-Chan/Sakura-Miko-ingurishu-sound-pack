/****************************************/
/* MADE BY OGAN ÖZKUL AKA RYUGUU - CHAN */
/*                                      */
/*    FROM  05-09-2021 TO 05-10-2021    */
/****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sakura_Miko_ingurishu_sound_pack
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // just for refactoring sake
        private Dictionary<Key, string> SampleFileName = new Dictionary<Key, string>()
        {
            { Key.D0, "assets/MIKO_NYHALLO.wav"                     },  { Key.NumPad0,  "assets/MIKO_NYHALLO.wav"                   },
            { Key.D1, "assets/MIKO_HEY.wav"                         },  { Key.NumPad1,  "assets/MIKO_HEY.wav"                       },
            { Key.D2, "assets/MIKO_MY_NAME_IS_MIKO.wav"             },  { Key.NumPad2,  "assets/MIKO_MY_NAME_IS_MIKO.wav"           },
            { Key.D3, "assets/MIKO_I_WORK_AT_BIG_COMPANY,wav.wav"   },  { Key.NumPad3,  "assets/MIKO_I_WORK_AT_BIG_COMPANY,wav.wav" },
            { Key.D4, "assets/MIKO_ESKUSUME.wav"                    },  { Key.NumPad4,  "assets/MIKO_ESKUSUME.wav"                  },
            { Key.D5, "assets/MIKO_FREEDOM.wav"                     },  { Key.NumPad5,  "assets/MIKO_FREEDOM.wav"                   },
            { Key.D6, "assets/MIKO_EHHHHHHH.wav"                    },  { Key.NumPad6,  "assets/MIKO_EHHHHHHH.wav"                  },
            { Key.D7, "assets/MIKO_KILL_YOURSELF.wav"               },  { Key.NumPad7,  "assets/MIKO_KILL_YOURSELF.wav"             },
            { Key.D8, "assets/MIKO_ENGLISH.wav"                     },  { Key.NumPad8,  "assets/MIKO_ENGLISH.wav"                   },
            { Key.D9, "assets/MIKO_DO_YOU_SPEAK_IT.wav"             },  { Key.NumPad9,  "assets/MIKO_DO_YOU_SPEAK_IT.wav"           },
            { Key.A,  "assets/MIKO_LOL.wav"                         },  { Key.B,        "assets/MIKO_LOL_2.wav"                     },
            { Key.C,  "assets/MIKO_NONO.wav"                        },  { Key.D,        "assets/MIKO_NONONO.wav"                    },
            { Key.E,  "assets/MIKO_YEA.wav"                         },  { Key.F,        "assets/MIKO_YEA_HAPPY.wav"                 },
            { Key.G,  "assets/MIKO_YEAYEAYEA.wav"                   },  { Key.H,        "assets/MIKO_BIG_BODY.wav"                  },
            { Key.I,  "assets/MIKO_SMALL_BODY.wav"                  },  { Key.J,        "assets/MIKO_WAAAA.wav"                     },
            { Key.K,  "assets/MIKO_TOP_TOGETHER_GO.wav"             },  { Key.L,        "assets/MIKO_WOW.wav"                       },
            { Key.M,  "assets/MIKO_COCO.wav"                        },  { Key.N,        "assets/MIKO_FREEDOM_LEBADY.wav"            },
            { Key.O,  "assets/MIKO_JUMP_AND_PATAPATA.wav"           },  { Key.P,        "assets/MIKO_HUMAN.wav"                     },
            { Key.Q,  "assets/MIKO_OOOOO.wav"                       },  { Key.R,        "assets/MIKO_EXCUSE_ME_FREEDOM.wav"         },
            { Key.S,  "assets/MIKO_GO.wav"                          },  { Key.T,        "assets/MIKO_GOOD_AFTERNOON.wav"            },
            { Key.U,  "assets/MIKO_GO_FREEDOM_LADY_GO.wav"          },  { Key.V,        "assets/MIKO_SAKURA_MIKO.wav"               },
            { Key.W,  "assets/MIKO_YES_CLAPCLAP.wav"                }
        };

        private Dictionary<Button, Key> ButtonKeyDic;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // same here
            ButtonKeyDic = new Dictionary<Button, Key>()
            {
                { BUT_00, Key.D0 },  { BUT_01, Key.D1 },  { BUT_02, Key.D2 },  { BUT_03, Key.D3 },
                { BUT_04, Key.D4 },  { BUT_05, Key.D5 },  { BUT_06, Key.D6 },  { BUT_07, Key.D7 },
                { BUT_08, Key.D8 },  { BUT_09, Key.D9 },  { BUT_10, Key.A  },  { BUT_11, Key.B  },
                { BUT_12, Key.C  },  { BUT_13, Key.D  },  { BUT_14, Key.E  },  { BUT_15, Key.F  },
                { BUT_16, Key.G  },  { BUT_17, Key.H  },  { BUT_18, Key.I  },  { BUT_19, Key.J  },
                { BUT_20, Key.K  },  { BUT_21, Key.L  },  { BUT_22, Key.M  },  { BUT_23, Key.N  },
                { BUT_24, Key.O  },  { BUT_25, Key.P  },  { BUT_26, Key.Q  },  { BUT_27, Key.R  },
                { BUT_28, Key.S  },  { BUT_29, Key.T  },  { BUT_30, Key.U  },  { BUT_31, Key.V  },
                { BUT_32, Key.W  }
            };
        }

        private void BUT_Click(object sender, RoutedEventArgs e)
        {
            // just in case something went wrong while playing the media
            try { miko.Source = new Uri(SampleFileName[ButtonKeyDic[(Button)sender]], UriKind.RelativeOrAbsolute); }
            catch (Exception E) 
            { 
                if (E is System.Collections.Generic.KeyNotFoundException) { /* nothing */ }
                else { MessageBox.Show("Something went wrong\n\n" + E.ToString(), "Exception found!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // same here
            try { miko.Source = new Uri(SampleFileName[e.Key], UriKind.RelativeOrAbsolute); }
            catch (Exception E) 
            {
                if (E is System.Collections.Generic.KeyNotFoundException) { /* nothing */ }
                else { MessageBox.Show("Something went wrong\n\n" + E.ToString(), "Exception found!", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
    }
}
