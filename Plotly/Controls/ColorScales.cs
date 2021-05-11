using System.Runtime.CompilerServices;

namespace Plotly
{
    public static class ColorScales
    {


        public static object[] Greys = new object[]{
                    new object[]{0.0, "rgb(0,0,0)"}, new object[]{1.0, "rgb(255,255,255)"}
        };

        public static object[] YlGnBu = new object[]{
                new object[]{0.0, "rgb(8,29,88)"}, new object[]{0.125, "rgb(37,52,148)"},
                new object[]{0.25, "rgb(34,94,168)"}, new object[]{0.375, "rgb(29,145,192)"},
                new object[]{0.5, "rgb(65,182,196)"}, new object[]{0.625, "rgb(127,205,187)"},
                new object[]{0.75, "rgb(199,233,180)"}, new object[]{0.875, "rgb(237,248,217)"},
                new object[]{1.0, "rgb(255,255,217)"}
        };

        public static object[] Greens = new object[]{
                new object[]{0.0, "rgb(0,68,27)"}, new object[]{0.125, "rgb(0,109,44)"},
                new object[]{0.25, "rgb(35,139,69)"}, new object[]{0.375, "rgb(65,171,93)"},
                new object[]{0.5, "rgb(116,196,118)"}, new object[]{0.625, "rgb(161,217,155)"},
                new object[]{0.75, "rgb(199,233,192)"}, new object[]{0.875, "rgb(229,245,224)"},
                new object[]{1.0, "rgb(247,252,245)"}
        };

        public static object[] YlOrRd = new object[]{
                new object[]{0.0, "rgb(128,0,38)"}, new object[]{0.125, "rgb(189,0,38)"},
                new object[]{0.25, "rgb(227,26,28)"}, new object[]{0.375, "rgb(252,78,42)"},
                new object[]{0.5, "rgb(253,141,60)"}, new object[]{0.625, "rgb(254,178,76)"},
                new object[]{0.75, "rgb(254,217,118)"}, new object[]{0.875, "rgb(255,237,160)"},
                new object[]{1.0, "rgb(255,255,204)"}
        };

        public static object[] Bluered = new object[]{
                new object[]{0.0, "rgb(0,0,255)"}, new object[]{1.0, "rgb(255,0,0)"}
        };
            
        public static object[] RdBu = new object[]{
                new object[]{0.0, "rgb(5,10,172)"}, new object[]{0.35, "rgb(106,137,247)"},
                new object[]{0.5, "rgb(190,190,190)"}, new object[]{0.6, "rgb(220,170,132)"},
                new object[]{0.7, "rgb(230,145,90)"}, new object[]{1.0, "rgb(178,10,28)"}
        };
            
        public static object[] Reds = new object[]{
                new object[]{0.0, "rgb(220,220,220)"}, new object[]{0.2, "rgb(245,195,157)"},
                new object[]{0.4, "rgb(245,160,105)"}, new object[]{1.0, "rgb(178,10,28)"}
        };
            
        public static object[] Blues = new object[]{
                new object[]{0.0, "rgb(5,10,172)"}, new object[]{0.35, "rgb(40,60,190)"},
                new object[]{0.5, "rgb(70,100,245)"}, new object[]{0.6, "rgb(90,120,245)"},
                new object[]{0.7, "rgb(106,137,247)"}, new object[]{1.0, "rgb(220,220,220)"}
        };

        public static object[] Picnic = new object[]{
                new object[]{0.0, "rgb(0,0,255)"}, new object[]{0.1, "rgb(51,153,255)"},
                new object[]{0.2, "rgb(102,204,255)"}, new object[]{0.3, "rgb(153,204,255)"},
                new object[]{0.4, "rgb(204,204,255)"}, new object[]{0.5, "rgb(255,255,255)"},
                new object[]{0.6, "rgb(255,204,255)"}, new object[]{0.7, "rgb(255,153,255)"},
                new object[]{0.8, "rgb(255,102,204)"}, new object[]{0.9, "rgb(255,102,102)"},
                new object[]{1.0, "rgb(255,0,0)"}
        };

        public static object[] Rainbow = new object[]{
                new object[]{0.0, "rgb(150,0,90)"}, new object[]{0.125, "rgb(0,0,200)"},
                new object[]{0.25, "rgb(0,25,255)"}, new object[]{0.375, "rgb(0,152,255)"},
                new object[]{0.5, "rgb(44,255,150)"}, new object[]{0.625, "rgb(151,255,0)"},
                new object[]{0.75, "rgb(255,234,0)"}, new object[]{0.875, "rgb(255,111,0)"},
                new object[]{1.0, "rgb(255,0,0)"}
        };

        public static object[] Portland = new object[]{
                new object[]{0.0, "rgb(12,51,131)"}, new object[]{0.25, "rgb(10,136,186)"},
                new object[]{0.5, "rgb(242,211,56)"}, new object[]{0.75, "rgb(242,143,56)"},
                new object[]{1.0, "rgb(217,30,30)"}
        };

        public static object[] Jet = new object[]{
                new object[]{0.0, "rgb(0,0,131)"}, new object[]{0.125, "rgb(0,60,170)"},
                new object[]{0.375, "rgb(5,255,255)"}, new object[]{0.625, "rgb(255,255,0)"},
                new object[]{0.875, "rgb(250,0,0)"}, new object[]{1.0, "rgb(128,0,0)"}
        };

        public static object[] Hot = new object[]{
                new object[]{0.0, "rgb(0,0,0)"}, new object[]{0.3, "rgb(230,0,0)"},
                new object[]{0.6, "rgb(255,210,0)"}, new object[]{1.0, "rgb(255,255,255)"}
        };

        public static object[] Blackbody = new object[]{
                new object[]{0.0, "rgb(0,0,0)"}, new object[]{0.2, "rgb(230,0,0)"},
                new object[]{0.4, "rgb(230,210,0)"}, new object[]{0.7, "rgb(255,255,255)"},
                new object[]{1.0, "rgb(160,200,255)"}
        };

        public static object[] Earth = new object[]{
                new object[]{0.0, "rgb(0,0,130)"}, new object[]{0.1, "rgb(0,180,180)"},
                new object[]{0.2, "rgb(40,210,40)"}, new object[]{0.4, "rgb(230,230,50)"},
                new object[]{0.6, "rgb(120,70,20)"}, new object[]{1.0, "rgb(255,255,255)"}
        };

        public static object[] Electric = new object[]{
                new object[]{0.0, "rgb(0,0,0)"}, new object[]{0.15, "rgb(30,0,100)"},
                new object[]{0.4, "rgb(120,0,100)"}, new object[]{0.6, "rgb(160,90,0)"},
                new object[]{0.8, "rgb(230,200,0)"}, new object[]{1.0, "rgb(255,250,220)"}
        };

        public static object[] Viridis = new object[]{
                new object[]{0.0, "#440154"}, new object[]{0.06274509803921569, "#48186a"},
                new object[]{0.12549019607843137, "#472d7b"}, new object[]{0.18823529411764706, "#424086"},
                new object[]{0.25098039215686274, "#3b528b"}, new object[]{0.3137254901960784, "#33638d"},
                new object[]{0.3764705882352941, "#2c728e"}, new object[]{0.4392156862745098, "#26828e"},
                new object[]{0.5019607843137255, "#21918c"}, new object[]{0.5647058823529412, "#1fa088"},
                new object[]{0.6274509803921569, "#28ae80"}, new object[]{0.6901960784313725, "#3fbc73"},
                new object[]{0.7529411764705882, "#5ec962"}, new object[]{0.8156862745098039, "#84d44b"},
                new object[]{0.8784313725490196, "#addc30"}, new object[]{0.9411764705882353, "#d8e219"},
                new object[]{1.0, "#fde725"}
        };

        public static object[] Cividis = new object[]{
                new object[]{0.000000, "rgb(0,32,76)"}, new object[]{0.058824, "rgb(0,42,102)"},
                new object[]{0.117647, "rgb(0,52,110)"}, new object[]{0.176471, "rgb(39,63,108)"},
                new object[]{0.235294, "rgb(60,74,107)"}, new object[]{0.294118, "rgb(76,85,107)"},
                new object[]{0.352941, "rgb(91,95,109)"}, new object[]{0.411765, "rgb(104,106,112)"},
                new object[]{0.470588, "rgb(117,117,117)"}, new object[]{0.529412, "rgb(131,129,120)"},
                new object[]{0.588235, "rgb(146,140,120)"}, new object[]{0.647059, "rgb(161,152,118)"},
                new object[]{0.705882, "rgb(176,165,114)"}, new object[]{0.764706, "rgb(192,177,109)"},
                new object[]{0.823529, "rgb(209,191,102)"}, new object[]{0.882353, "rgb(225,204,92)"},
                new object[]{0.941176, "rgb(243,219,79)"}, new object[]{1.000000, "rgb(255,233,69)"}
            };

    }
}
