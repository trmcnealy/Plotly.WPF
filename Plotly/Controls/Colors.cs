using System.Runtime.CompilerServices;

namespace Plotly
{
    public struct Colors
    {
        private static readonly Color _indian_Red           = new Color(0xFFB0171F);
        private static readonly Color _crimson              = new Color(0xFFDC143C);
        private static readonly Color _lightPink            = new Color(0xFFFFB6C1);
        private static readonly Color _lightPink_1          = new Color(0xFFFFAEB9);
        private static readonly Color _lightPink_2          = new Color(0xFFEEA2AD);
        private static readonly Color _lightPink_3          = new Color(0xFFCD8C95);
        private static readonly Color _lightPink_4          = new Color(0xFF8B5F65);
        private static readonly Color _Pink                 = new Color(0xFFFFC0CB);
        private static readonly Color _Pink_1               = new Color(0xFFFFB5C5);
        private static readonly Color _Pink_2               = new Color(0xFFEEA9B8);
        private static readonly Color _Pink_3               = new Color(0xFFCD919E);
        private static readonly Color _Pink_4               = new Color(0xFF8B636C);
        private static readonly Color _paleVioletRed        = new Color(0xFFDB7093);
        private static readonly Color _paleVioletRed_1      = new Color(0xFFFF82AB);
        private static readonly Color _paleVioletRed_2      = new Color(0xFFEE799F);
        private static readonly Color _paleVioletRed_3      = new Color(0xFFCD6889);
        private static readonly Color _paleVioletRed_4      = new Color(0xFF8B475D);
        private static readonly Color _lavenderblush        = new Color(0xFFFFF0F5);
        private static readonly Color _lavenderblush_2      = new Color(0xFFEEE0E5);
        private static readonly Color _lavenderblush_3      = new Color(0xFFCDC1C5);
        private static readonly Color _lavenderblush_4      = new Color(0xFF8B8386);
        private static readonly Color _VioletRed_1          = new Color(0xFFFF3E96);
        private static readonly Color _VioletRed_2          = new Color(0xFFEE3A8C);
        private static readonly Color _VioletRed_3          = new Color(0xFFCD3278);
        private static readonly Color _VioletRed_4          = new Color(0xFF8B2252);
        private static readonly Color _hotPink              = new Color(0xFFFF69B4);
        private static readonly Color _hotPink_1            = new Color(0xFFFF6EB4);
        private static readonly Color _hotPink_2            = new Color(0xFFEE6AA7);
        private static readonly Color _hotPink_3            = new Color(0xFFCD6090);
        private static readonly Color _hotPink_4            = new Color(0xFF8B3A62);
        private static readonly Color _raspberry            = new Color(0xFF872657);
        private static readonly Color _deepPink             = new Color(0xFFFF1493);
        private static readonly Color _deepPink_2           = new Color(0xFFEE1289);
        private static readonly Color _deepPink_3           = new Color(0xFFCD1076);
        private static readonly Color _deepPink_4           = new Color(0xFF8B0A50);
        private static readonly Color _maroon_1             = new Color(0xFFFF34B3);
        private static readonly Color _maroon_2             = new Color(0xFFEE30A7);
        private static readonly Color _maroon_3             = new Color(0xFFCD2990);
        private static readonly Color _maroon_4             = new Color(0xFF8B1C62);
        private static readonly Color _mediumVioletRed      = new Color(0xFFC71585);
        private static readonly Color _VioletRed            = new Color(0xFFD02090);
        private static readonly Color _orchid               = new Color(0xFFDA70D6);
        private static readonly Color _orchid_1             = new Color(0xFFFF83FA);
        private static readonly Color _orchid_2             = new Color(0xFFEE7AE9);
        private static readonly Color _orchid_3             = new Color(0xFFCD69C9);
        private static readonly Color _orchid_4             = new Color(0xFF8B4789);
        private static readonly Color _thistle              = new Color(0xFFD8BFD8);
        private static readonly Color _thistle_1            = new Color(0xFFFFE1FF);
        private static readonly Color _thistle_2            = new Color(0xFFEED2EE);
        private static readonly Color _thistle_3            = new Color(0xFFCDB5CD);
        private static readonly Color _thistle_4            = new Color(0xFF8B7B8B);
        private static readonly Color _plum_1               = new Color(0xFFFFBBFF);
        private static readonly Color _plum_2               = new Color(0xFFEEAEEE);
        private static readonly Color _plum_3               = new Color(0xFFCD96CD);
        private static readonly Color _plum_4               = new Color(0xFF8B668B);
        private static readonly Color _plum                 = new Color(0xFFDDA0DD);
        private static readonly Color _Violet               = new Color(0xFFEE82EE);
        private static readonly Color _fuchsia              = new Color(0xFFFF00FF);
        private static readonly Color _magenta_2            = new Color(0xFFEE00EE);
        private static readonly Color _magenta_3            = new Color(0xFFCD00CD);
        private static readonly Color _darkmagenta          = new Color(0xFF8B008B);
        private static readonly Color _purple               = new Color(0xFF800080);
        private static readonly Color _mediumorchid         = new Color(0xFFBA55D3);
        private static readonly Color _mediumorchid_1       = new Color(0xFFE066FF);
        private static readonly Color _mediumorchid_2       = new Color(0xFFD15FEE);
        private static readonly Color _mediumorchid_3       = new Color(0xFFB452CD);
        private static readonly Color _mediumorchid_4       = new Color(0xFF7A378B);
        private static readonly Color _darkViolet           = new Color(0xFF9400D3);
        private static readonly Color _darkorchid           = new Color(0xFF9932CC);
        private static readonly Color _darkorchid_1         = new Color(0xFFBF3EFF);
        private static readonly Color _darkorchid_2         = new Color(0xFFB23AEE);
        private static readonly Color _darkorchid_3         = new Color(0xFF9A32CD);
        private static readonly Color _darkorchid_4         = new Color(0xFF68228B);
        private static readonly Color _indigo               = new Color(0xFF4B0082);
        private static readonly Color _BlueViolet           = new Color(0xFF8A2BE2);
        private static readonly Color _purple_1             = new Color(0xFF9B30FF);
        private static readonly Color _purple_2             = new Color(0xFF912CEE);
        private static readonly Color _purple_3             = new Color(0xFF7D26CD);
        private static readonly Color _purple_4             = new Color(0xFF551A8B);
        private static readonly Color _mediumpurple         = new Color(0xFF9370DB);
        private static readonly Color _mediumpurple_1       = new Color(0xFFAB82FF);
        private static readonly Color _mediumpurple_2       = new Color(0xFF9F79EE);
        private static readonly Color _mediumpurple_3       = new Color(0xFF8968CD);
        private static readonly Color _mediumpurple_4       = new Color(0xFF5D478B);
        private static readonly Color _darkslateBlue        = new Color(0xFF483D8B);
        private static readonly Color _lightslateBlue       = new Color(0xFF8470FF);
        private static readonly Color _mediumslateBlue      = new Color(0xFF7B68EE);
        private static readonly Color _slateBlue            = new Color(0xFF6A5ACD);
        private static readonly Color _slateBlue_1          = new Color(0xFF836FFF);
        private static readonly Color _slateBlue_2          = new Color(0xFF7A67EE);
        private static readonly Color _slateBlue_3          = new Color(0xFF6959CD);
        private static readonly Color _slateBlue_4          = new Color(0xFF473C8B);
        private static readonly Color _ghostwhite           = new Color(0xFFF8F8FF);
        private static readonly Color _lavender             = new Color(0xFFE6E6FA);
        private static readonly Color _Blue                 = new Color(0xFF0000FF);
        private static readonly Color _Blue_2               = new Color(0xFF0000EE);
        private static readonly Color _mediumBlue           = new Color(0xFF0000CD);
        private static readonly Color _darkBlue             = new Color(0xFF00008B);
        private static readonly Color _navy                 = new Color(0xFF000080);
        private static readonly Color _midnightBlue         = new Color(0xFF191970);
        private static readonly Color _cobalt               = new Color(0xFF3D59AB);
        private static readonly Color _royalBlue            = new Color(0xFF4169E1);
        private static readonly Color _royalBlue_1          = new Color(0xFF4876FF);
        private static readonly Color _royalBlue_2          = new Color(0xFF436EEE);
        private static readonly Color _royalBlue_3          = new Color(0xFF3A5FCD);
        private static readonly Color _royalBlue_4          = new Color(0xFF27408B);
        private static readonly Color _cornflowerBlue       = new Color(0xFF6495ED);
        private static readonly Color _lightsteelBlue       = new Color(0xFFB0C4DE);
        private static readonly Color _lightsteelBlue_1     = new Color(0xFFCAE1FF);
        private static readonly Color _lightsteelBlue_2     = new Color(0xFFBCD2EE);
        private static readonly Color _lightsteelBlue_3     = new Color(0xFFA2B5CD);
        private static readonly Color _lightsteelBlue_4     = new Color(0xFF6E7B8B);
        private static readonly Color _lightslategray       = new Color(0xFF778899);
        private static readonly Color _slategray            = new Color(0xFF708090);
        private static readonly Color _slategray_1          = new Color(0xFFC6E2FF);
        private static readonly Color _slategray_2          = new Color(0xFFB9D3EE);
        private static readonly Color _slategray_3          = new Color(0xFF9FB6CD);
        private static readonly Color _slategray_4          = new Color(0xFF6C7B8B);
        private static readonly Color _dodgerBlue           = new Color(0xFF1E90FF);
        private static readonly Color _dodgerBlue_2         = new Color(0xFF1C86EE);
        private static readonly Color _dodgerBlue_3         = new Color(0xFF1874CD);
        private static readonly Color _dodgerBlue_4         = new Color(0xFF104E8B);
        private static readonly Color _aliceBlue            = new Color(0xFFF0F8FF);
        private static readonly Color _steelBlue            = new Color(0xFF4682B4);
        private static readonly Color _steelBlue_1          = new Color(0xFF63B8FF);
        private static readonly Color _steelBlue_2          = new Color(0xFF5CACEE);
        private static readonly Color _steelBlue_3          = new Color(0xFF4F94CD);
        private static readonly Color _steelBlue_4          = new Color(0xFF36648B);
        private static readonly Color _lightskyBlue         = new Color(0xFF87CEFA);
        private static readonly Color _lightskyBlue_1       = new Color(0xFFB0E2FF);
        private static readonly Color _lightskyBlue_2       = new Color(0xFFA4D3EE);
        private static readonly Color _lightskyBlue_3       = new Color(0xFF8DB6CD);
        private static readonly Color _lightskyBlue_4       = new Color(0xFF607B8B);
        private static readonly Color _skyBlue_1            = new Color(0xFF87CEFF);
        private static readonly Color _skyBlue_2            = new Color(0xFF7EC0EE);
        private static readonly Color _skyBlue_3            = new Color(0xFF6CA6CD);
        private static readonly Color _skyBlue_4            = new Color(0xFF4A708B);
        private static readonly Color _skyBlue              = new Color(0xFF87CEEB);
        private static readonly Color _deepskyBlue          = new Color(0xFF00BFFF);
        private static readonly Color _deepskyBlue_2        = new Color(0xFF00B2EE);
        private static readonly Color _deepskyBlue_3        = new Color(0xFF009ACD);
        private static readonly Color _deepskyBlue_4        = new Color(0xFF00688B);
        private static readonly Color _peacock              = new Color(0xFF33A1C9);
        private static readonly Color _lightBlue            = new Color(0xFFADD8E6);
        private static readonly Color _lightBlue_1          = new Color(0xFFBFEFFF);
        private static readonly Color _lightBlue_2          = new Color(0xFFB2DFEE);
        private static readonly Color _lightBlue_3          = new Color(0xFF9AC0CD);
        private static readonly Color _lightBlue_4          = new Color(0xFF68838B);
        private static readonly Color _powderBlue           = new Color(0xFFB0E0E6);
        private static readonly Color _cadetBlue_1          = new Color(0xFF98F5FF);
        private static readonly Color _cadetBlue_2          = new Color(0xFF8EE5EE);
        private static readonly Color _cadetBlue_3          = new Color(0xFF7AC5CD);
        private static readonly Color _cadetBlue_4          = new Color(0xFF53868B);
        private static readonly Color _turquoise_1          = new Color(0xFF00F5FF);
        private static readonly Color _turquoise_2          = new Color(0xFF00E5EE);
        private static readonly Color _turquoise_3          = new Color(0xFF00C5CD);
        private static readonly Color _turquoise_4          = new Color(0xFF00868B);
        private static readonly Color _cadetBlue            = new Color(0xFF5F9EA0);
        private static readonly Color _darkturquoise        = new Color(0xFF00CED1);
        private static readonly Color _azure                = new Color(0xFFF0FFFF);
        private static readonly Color _azure_2              = new Color(0xFFE0EEEE);
        private static readonly Color _azure_3              = new Color(0xFFC1CDCD);
        private static readonly Color _azure_4              = new Color(0xFF838B8B);
        private static readonly Color _lightcyan            = new Color(0xFFE0FFFF);
        private static readonly Color _lightcyan_2          = new Color(0xFFD1EEEE);
        private static readonly Color _lightcyan_3          = new Color(0xFFB4CDCD);
        private static readonly Color _lightcyan_4          = new Color(0xFF7A8B8B);
        private static readonly Color _paleturquoise_1      = new Color(0xFFBBFFFF);
        private static readonly Color _paleturquoise_2      = new Color(0xFFAEEEEE);
        private static readonly Color _paleturquoise_3      = new Color(0xFF96CDCD);
        private static readonly Color _paleturquoise_4      = new Color(0xFF668B8B);
        private static readonly Color _darkslategray        = new Color(0xFF2F4F4F);
        private static readonly Color _darkslategray_1      = new Color(0xFF97FFFF);
        private static readonly Color _darkslategray_2      = new Color(0xFF8DEEEE);
        private static readonly Color _darkslategray_3      = new Color(0xFF79CDCD);
        private static readonly Color _darkslategray_4      = new Color(0xFF528B8B);
        private static readonly Color _aqua                 = new Color(0xFF00FFFF);
        private static readonly Color _cyan_2               = new Color(0xFF00EEEE);
        private static readonly Color _cyan_3               = new Color(0xFF00CDCD);
        private static readonly Color _darkcyan             = new Color(0xFF008B8B);
        private static readonly Color _teal                 = new Color(0xFF008080);
        private static readonly Color _mediumturquoise      = new Color(0xFF48D1CC);
        private static readonly Color _lightseaGreen        = new Color(0xFF20B2AA);
        private static readonly Color _manganeseBlue        = new Color(0xFF03A89E);
        private static readonly Color _turquoise            = new Color(0xFF40E0D0);
        private static readonly Color _coldgrey             = new Color(0xFF808A87);
        private static readonly Color _turquoiseBlue        = new Color(0xFF00C78C);
        private static readonly Color _aquamarine           = new Color(0xFF7FFFD4);
        private static readonly Color _aquamarine_2         = new Color(0xFF76EEC6);
        private static readonly Color _aquamarine_3         = new Color(0xFF66CDAA);
        private static readonly Color _aquamarine_4         = new Color(0xFF458B74);
        private static readonly Color _mediumspringGreen    = new Color(0xFF00FA9A);
        private static readonly Color _mintcream            = new Color(0xFFF5FFFA);
        private static readonly Color _springGreen          = new Color(0xFF00FF7F);
        private static readonly Color _springGreen_1        = new Color(0xFF00EE76);
        private static readonly Color _springGreen_2        = new Color(0xFF00CD66);
        private static readonly Color _springGreen_3        = new Color(0xFF008B45);
        private static readonly Color _mediumseaGreen       = new Color(0xFF3CB371);
        private static readonly Color _seaGreen_1           = new Color(0xFF54FF9F);
        private static readonly Color _seaGreen_2           = new Color(0xFF4EEE94);
        private static readonly Color _seaGreen_3           = new Color(0xFF43CD80);
        private static readonly Color _seaGreen_4           = new Color(0xFF2E8B57);
        private static readonly Color _emeraldGreen         = new Color(0xFF00C957);
        private static readonly Color _mint                 = new Color(0xFFBDFCC9);
        private static readonly Color _cobaltGreen          = new Color(0xFF3D9140);
        private static readonly Color _honeydew_1           = new Color(0xFFF0FFF0);
        private static readonly Color _honeydew_2           = new Color(0xFFE0EEE0);
        private static readonly Color _honeydew_3           = new Color(0xFFC1CDC1);
        private static readonly Color _honeydew_4           = new Color(0xFF838B83);
        private static readonly Color _darkseaGreen         = new Color(0xFF8FBC8F);
        private static readonly Color _darkseaGreen_1       = new Color(0xFFC1FFC1);
        private static readonly Color _darkseaGreen_2       = new Color(0xFFB4EEB4);
        private static readonly Color _darkseaGreen_3       = new Color(0xFF9BCD9B);
        private static readonly Color _darkseaGreen_4       = new Color(0xFF698B69);
        private static readonly Color _paleGreen            = new Color(0xFF98FB98);
        private static readonly Color _paleGreen_1          = new Color(0xFF9AFF9A);
        private static readonly Color _paleGreen_2          = new Color(0xFF90EE90);
        private static readonly Color _paleGreen_3          = new Color(0xFF7CCD7C);
        private static readonly Color _paleGreen_4          = new Color(0xFF548B54);
        private static readonly Color _limeGreen            = new Color(0xFF32CD32);
        private static readonly Color _forestGreen          = new Color(0xFF228B22);
        private static readonly Color _Green_1              = new Color(0xFF00FF00);
        private static readonly Color _Green_2              = new Color(0xFF00EE00);
        private static readonly Color _Green_3              = new Color(0xFF00CD00);
        private static readonly Color _Green_4              = new Color(0xFF008B00);
        private static readonly Color _Green                = new Color(0xFF008000);
        private static readonly Color _darkGreen            = new Color(0xFF006400);
        private static readonly Color _sapGreen             = new Color(0xFF308014);
        private static readonly Color _lawnGreen            = new Color(0xFF7CFC00);
        private static readonly Color _chartreuse_1         = new Color(0xFF7FFF00);
        private static readonly Color _chartreuse_2         = new Color(0xFF76EE00);
        private static readonly Color _chartreuse_3         = new Color(0xFF66CD00);
        private static readonly Color _chartreuse_4         = new Color(0xFF458B00);
        private static readonly Color _GreenYellow          = new Color(0xFFADFF2F);
        private static readonly Color _darkoliveGreen_1     = new Color(0xFFCAFF70);
        private static readonly Color _darkoliveGreen_2     = new Color(0xFFBCEE68);
        private static readonly Color _darkoliveGreen_3     = new Color(0xFFA2CD5A);
        private static readonly Color _darkoliveGreen_4     = new Color(0xFF6E8B3D);
        private static readonly Color _darkoliveGreen       = new Color(0xFF556B2F);
        private static readonly Color _olivedrab            = new Color(0xFF6B8E23);
        private static readonly Color _olivedrab_1          = new Color(0xFFC0FF3E);
        private static readonly Color _olivedrab_2          = new Color(0xFFB3EE3A);
        private static readonly Color _olivedrab_3          = new Color(0xFF9ACD32);
        private static readonly Color _olivedrab_4          = new Color(0xFF698B22);
        private static readonly Color _ivory_1              = new Color(0xFFFFFFF0);
        private static readonly Color _ivory_2              = new Color(0xFFEEEEE0);
        private static readonly Color _ivory_3              = new Color(0xFFCDCDC1);
        private static readonly Color _ivory_4              = new Color(0xFF8B8B83);
        private static readonly Color _beige                = new Color(0xFFF5F5DC);
        private static readonly Color _lightYellow_1        = new Color(0xFFFFFFE0);
        private static readonly Color _lightYellow_2        = new Color(0xFFEEEED1);
        private static readonly Color _lightYellow_3        = new Color(0xFFCDCDB4);
        private static readonly Color _lightYellow_4        = new Color(0xFF8B8B7A);
        private static readonly Color _lightgoldenrodYellow = new Color(0xFFFAFAD2);
        private static readonly Color _Yellow_1             = new Color(0xFFFFFF00);
        private static readonly Color _Yellow_2             = new Color(0xFFEEEE00);
        private static readonly Color _Yellow_3             = new Color(0xFFCDCD00);
        private static readonly Color _Yellow_4             = new Color(0xFF8B8B00);
        private static readonly Color _warmgrey             = new Color(0xFF808069);
        private static readonly Color _olive                = new Color(0xFF808000);
        private static readonly Color _darkkhaki            = new Color(0xFFBDB76B);
        private static readonly Color _khaki_1              = new Color(0xFFFFF68F);
        private static readonly Color _khaki_2              = new Color(0xFFEEE685);
        private static readonly Color _khaki_3              = new Color(0xFFCDC673);
        private static readonly Color _khaki_4              = new Color(0xFF8B864E);
        private static readonly Color _khaki                = new Color(0xFFF0E68C);
        private static readonly Color _palegoldenrod        = new Color(0xFFEEE8AA);
        private static readonly Color _lemonchiffon_1       = new Color(0xFFFFFACD);
        private static readonly Color _lemonchiffon_2       = new Color(0xFFEEE9BF);
        private static readonly Color _lemonchiffon_3       = new Color(0xFFCDC9A5);
        private static readonly Color _lemonchiffon_4       = new Color(0xFF8B8970);
        private static readonly Color _lightgoldenrod_1     = new Color(0xFFFFEC8B);
        private static readonly Color _lightgoldenrod_2     = new Color(0xFFEEDC82);
        private static readonly Color _lightgoldenrod_3     = new Color(0xFFCDBE70);
        private static readonly Color _lightgoldenrod_4     = new Color(0xFF8B814C);
        private static readonly Color _banana               = new Color(0xFFE3CF57);
        private static readonly Color _gold_1               = new Color(0xFFFFD700);
        private static readonly Color _gold_2               = new Color(0xFFEEC900);
        private static readonly Color _gold_3               = new Color(0xFFCDAD00);
        private static readonly Color _gold_4               = new Color(0xFF8B7500);
        private static readonly Color _cornsilk_1           = new Color(0xFFFFF8DC);
        private static readonly Color _cornsilk_2           = new Color(0xFFEEE8CD);
        private static readonly Color _cornsilk_3           = new Color(0xFFCDC8B1);
        private static readonly Color _cornsilk_4           = new Color(0xFF8B8878);
        private static readonly Color _goldenrod            = new Color(0xFFDAA520);
        private static readonly Color _goldenrod_1          = new Color(0xFFFFC125);
        private static readonly Color _goldenrod_2          = new Color(0xFFEEB422);
        private static readonly Color _goldenrod_3          = new Color(0xFFCD9B1D);
        private static readonly Color _goldenrod_4          = new Color(0xFF8B6914);
        private static readonly Color _darkgoldenrod        = new Color(0xFFB8860B);
        private static readonly Color _darkgoldenrod_1      = new Color(0xFFFFB90F);
        private static readonly Color _darkgoldenrod_2      = new Color(0xFFEEAD0E);
        private static readonly Color _darkgoldenrod_3      = new Color(0xFFCD950C);
        private static readonly Color _darkgoldenrod_4      = new Color(0xFF8B6508);
        private static readonly Color _orange_1             = new Color(0xFFFFA500);
        private static readonly Color _orange_2             = new Color(0xFFEE9A00);
        private static readonly Color _orange_3             = new Color(0xFFCD8500);
        private static readonly Color _orange_4             = new Color(0xFF8B5A00);
        private static readonly Color _floralwhite          = new Color(0xFFFFFAF0);
        private static readonly Color _oldlace              = new Color(0xFFFDF5E6);
        private static readonly Color _wheat                = new Color(0xFFF5DEB3);
        private static readonly Color _wheat_1              = new Color(0xFFFFE7BA);
        private static readonly Color _wheat_2              = new Color(0xFFEED8AE);
        private static readonly Color _wheat_3              = new Color(0xFFCDBA96);
        private static readonly Color _wheat_4              = new Color(0xFF8B7E66);
        private static readonly Color _moccasin             = new Color(0xFFFFE4B5);
        private static readonly Color _papayawhip           = new Color(0xFFFFEFD5);
        private static readonly Color _blanchedalmond       = new Color(0xFFFFEBCD);
        private static readonly Color _navajowhite_1        = new Color(0xFFFFDEAD);
        private static readonly Color _navajowhite_2        = new Color(0xFFEECFA1);
        private static readonly Color _navajowhite_3        = new Color(0xFFCDB38B);
        private static readonly Color _navajowhite_4        = new Color(0xFF8B795E);
        private static readonly Color _eggshell             = new Color(0xFFFCE6C9);
        private static readonly Color _tan                  = new Color(0xFFD2B48C);
        private static readonly Color _brick                = new Color(0xFF9C661F);
        private static readonly Color _cadmiumYellow        = new Color(0xFFFF9912);
        private static readonly Color _antiquewhite         = new Color(0xFFFAEBD7);
        private static readonly Color _antiquewhite_1       = new Color(0xFFFFEFDB);
        private static readonly Color _antiquewhite_2       = new Color(0xFFEEDFCC);
        private static readonly Color _antiquewhite_3       = new Color(0xFFCDC0B0);
        private static readonly Color _antiquewhite_4       = new Color(0xFF8B8378);
        private static readonly Color _burlywood            = new Color(0xFFDEB887);
        private static readonly Color _burlywood_1          = new Color(0xFFFFD39B);
        private static readonly Color _burlywood_2          = new Color(0xFFEEC591);
        private static readonly Color _burlywood_3          = new Color(0xFFCDAA7D);
        private static readonly Color _burlywood_4          = new Color(0xFF8B7355);
        private static readonly Color _bisque_1             = new Color(0xFFFFE4C4);
        private static readonly Color _bisque_2             = new Color(0xFFEED5B7);
        private static readonly Color _bisque_3             = new Color(0xFFCDB79E);
        private static readonly Color _bisque_4             = new Color(0xFF8B7D6B);
        private static readonly Color _melon                = new Color(0xFFE3A869);
        private static readonly Color _carrot               = new Color(0xFFED9121);
        private static readonly Color _darkorange           = new Color(0xFFFF8C00);
        private static readonly Color _darkorange_1         = new Color(0xFFFF7F00);
        private static readonly Color _darkorange_2         = new Color(0xFFEE7600);
        private static readonly Color _darkorange_3         = new Color(0xFFCD6600);
        private static readonly Color _darkorange_4         = new Color(0xFF8B4500);
        private static readonly Color _orange               = new Color(0xFFFF8000);
        private static readonly Color _tan_1                = new Color(0xFFFFA54F);
        private static readonly Color _tan_2                = new Color(0xFFEE9A49);
        private static readonly Color _tan_3                = new Color(0xFFCD853F);
        private static readonly Color _tan_4                = new Color(0xFF8B5A2B);
        private static readonly Color _linen                = new Color(0xFFFAF0E6);
        private static readonly Color _peachpuff_1          = new Color(0xFFFFDAB9);
        private static readonly Color _peachpuff_2          = new Color(0xFFEECBAD);
        private static readonly Color _peachpuff_3          = new Color(0xFFCDAF95);
        private static readonly Color _peachpuff_4          = new Color(0xFF8B7765);
        private static readonly Color _seashell_1           = new Color(0xFFFFF5EE);
        private static readonly Color _seashell_2           = new Color(0xFFEEE5DE);
        private static readonly Color _seashell_3           = new Color(0xFFCDC5BF);
        private static readonly Color _seashell_4           = new Color(0xFF8B8682);
        private static readonly Color _sandybrown           = new Color(0xFFF4A460);
        private static readonly Color _rawsienna            = new Color(0xFFC76114);
        private static readonly Color _chocolate            = new Color(0xFFD2691E);
        private static readonly Color _chocolate_1          = new Color(0xFFFF7F24);
        private static readonly Color _chocolate_2          = new Color(0xFFEE7621);
        private static readonly Color _chocolate_3          = new Color(0xFFCD661D);
        private static readonly Color _chocolate_4          = new Color(0xFF8B4513);
        private static readonly Color _ivoryblack           = new Color(0xFF292421);
        private static readonly Color _flesh                = new Color(0xFFFF7D40);
        private static readonly Color _cadmiumorange        = new Color(0xFFFF6103);
        private static readonly Color _burntsienna          = new Color(0xFF8A360F);
        private static readonly Color _sienna               = new Color(0xFFA0522D);
        private static readonly Color _sienna_1             = new Color(0xFFFF8247);
        private static readonly Color _sienna_2             = new Color(0xFFEE7942);
        private static readonly Color _sienna_3             = new Color(0xFFCD6839);
        private static readonly Color _sienna_4             = new Color(0xFF8B4726);
        private static readonly Color _lightsalmon_1        = new Color(0xFFFFA07A);
        private static readonly Color _lightsalmon_2        = new Color(0xFFEE9572);
        private static readonly Color _lightsalmon_3        = new Color(0xFFCD8162);
        private static readonly Color _lightsalmon_4        = new Color(0xFF8B5742);
        private static readonly Color _coral                = new Color(0xFFFF7F50);
        private static readonly Color _orangeRed_1          = new Color(0xFFFF4500);
        private static readonly Color _orangeRed_2          = new Color(0xFFEE4000);
        private static readonly Color _orangeRed_3          = new Color(0xFFCD3700);
        private static readonly Color _orangeRed_4          = new Color(0xFF8B2500);
        private static readonly Color _sepia                = new Color(0xFF5E2612);
        private static readonly Color _darksalmon           = new Color(0xFFE9967A);
        private static readonly Color _salmon_1             = new Color(0xFFFF8C69);
        private static readonly Color _salmon_2             = new Color(0xFFEE8262);
        private static readonly Color _salmon_3             = new Color(0xFFCD7054);
        private static readonly Color _salmon_4             = new Color(0xFF8B4C39);
        private static readonly Color _coral_1              = new Color(0xFFFF7256);
        private static readonly Color _coral_2              = new Color(0xFFEE6A50);
        private static readonly Color _coral_3              = new Color(0xFFCD5B45);
        private static readonly Color _coral_4              = new Color(0xFF8B3E2F);
        private static readonly Color _burntumber           = new Color(0xFF8A3324);
        private static readonly Color _tomato_1             = new Color(0xFFFF6347);
        private static readonly Color _tomato_2             = new Color(0xFFEE5C42);
        private static readonly Color _tomato_3             = new Color(0xFFCD4F39);
        private static readonly Color _tomato_4             = new Color(0xFF8B3626);
        private static readonly Color _salmon               = new Color(0xFFFA8072);
        private static readonly Color _mistyrose_1          = new Color(0xFFFFE4E1);
        private static readonly Color _mistyrose_2          = new Color(0xFFEED5D2);
        private static readonly Color _mistyrose_3          = new Color(0xFFCDB7B5);
        private static readonly Color _mistyrose_4          = new Color(0xFF8B7D7B);
        private static readonly Color _snow_1               = new Color(0xFFFFFAFA);
        private static readonly Color _snow_2               = new Color(0xFFEEE9E9);
        private static readonly Color _snow_3               = new Color(0xFFCDC9C9);
        private static readonly Color _snow_4               = new Color(0xFF8B8989);
        private static readonly Color _rosybrown            = new Color(0xFFBC8F8F);
        private static readonly Color _rosybrown_1          = new Color(0xFFFFC1C1);
        private static readonly Color _rosybrown_2          = new Color(0xFFEEB4B4);
        private static readonly Color _rosybrown_3          = new Color(0xFFCD9B9B);
        private static readonly Color _rosybrown_4          = new Color(0xFF8B6969);
        private static readonly Color _lightcoral           = new Color(0xFFF08080);
        private static readonly Color _indianRed            = new Color(0xFFCD5C5C);
        private static readonly Color _indianRed_1          = new Color(0xFFFF6A6A);
        private static readonly Color _indianRed_2          = new Color(0xFFEE6363);
        private static readonly Color _indianRed_4          = new Color(0xFF8B3A3A);
        private static readonly Color _indianRed_3          = new Color(0xFFCD5555);
        private static readonly Color _brown                = new Color(0xFFA52A2A);
        private static readonly Color _brown_1              = new Color(0xFFFF4040);
        private static readonly Color _brown_2              = new Color(0xFFEE3B3B);
        private static readonly Color _brown_3              = new Color(0xFFCD3333);
        private static readonly Color _brown_4              = new Color(0xFF8B2323);
        private static readonly Color _firebrick            = new Color(0xFFB22222);
        private static readonly Color _firebrick_1          = new Color(0xFFFF3030);
        private static readonly Color _firebrick_2          = new Color(0xFFEE2C2C);
        private static readonly Color _firebrick_3          = new Color(0xFFCD2626);
        private static readonly Color _firebrick_4          = new Color(0xFF8B1A1A);
        private static readonly Color _Red_1                = new Color(0xFFFF0000);
        private static readonly Color _Red_2                = new Color(0xFFEE0000);
        private static readonly Color _Red_3                = new Color(0xFFCD0000);
        private static readonly Color _Red_4                = new Color(0xFF8B0000);
        private static readonly Color _maroon               = new Color(0xFF800000);
        private static readonly Color _sgi_beet             = new Color(0xFF8E388E);
        private static readonly Color _sgi_slateBlue        = new Color(0xFF7171C6);
        private static readonly Color _sgi_lightBlue        = new Color(0xFF7D9EC0);
        private static readonly Color _sgi_teal             = new Color(0xFF388E8E);
        private static readonly Color _sgi_chartreuse       = new Color(0xFF71C671);
        private static readonly Color _sgi_olivedrab        = new Color(0xFF8E8E38);
        private static readonly Color _sgi_brightgray       = new Color(0xFFC5C1AA);
        private static readonly Color _sgi_salmon           = new Color(0xFFC67171);
        private static readonly Color _sgi_darkgray         = new Color(0xFF555555);
        private static readonly Color _sgi_gray_12          = new Color(0xFF1E1E1E);
        private static readonly Color _sgi_gray_16          = new Color(0xFF282828);
        private static readonly Color _sgi_gray_32          = new Color(0xFF515151);
        private static readonly Color _sgi_gray_36          = new Color(0xFF5B5B5B);
        private static readonly Color _sgi_gray_52          = new Color(0xFF848484);
        private static readonly Color _sgi_gray_56          = new Color(0xFF8E8E8E);
        private static readonly Color _sgi_lightgray        = new Color(0xFFAAAAAA);
        private static readonly Color _sgi_gray_72          = new Color(0xFFB7B7B7);
        private static readonly Color _sgi_gray_76          = new Color(0xFFC1C1C1);
        private static readonly Color _sgi_gray_92          = new Color(0xFFEAEAEA);
        private static readonly Color _sgi_gray_96          = new Color(0xFFF4F4F4);
        private static readonly Color _white                = new Color(0xFFFFFFFF);
        private static readonly Color _white_smoke          = new Color(0xFFF5F5F5);
        private static readonly Color _gainsboro            = new Color(0xFFDCDCDC);
        private static readonly Color _lightgrey            = new Color(0xFFD3D3D3);
        private static readonly Color _silver               = new Color(0xFFC0C0C0);
        private static readonly Color _darkgray             = new Color(0xFFA9A9A9);
        private static readonly Color _gray                 = new Color(0xFF808080);
        private static readonly Color _dimgray              = new Color(0xFF696969);
        private static readonly Color _black                = new Color(0xFF000000);
        private static readonly Color _gray_99              = new Color(0xFFFCFCFC);
        private static readonly Color _gray_98              = new Color(0xFFFAFAFA);
        private static readonly Color _gray_97              = new Color(0xFFF7F7F7);
        private static readonly Color _gray_96              = new Color(0xFFF5F5F5);
        private static readonly Color _gray_95              = new Color(0xFFF2F2F2);
        private static readonly Color _gray_94              = new Color(0xFFF0F0F0);
        private static readonly Color _gray_93              = new Color(0xFFEDEDED);
        private static readonly Color _gray_92              = new Color(0xFFEBEBEB);
        private static readonly Color _gray_91              = new Color(0xFFE8E8E8);
        private static readonly Color _gray_90              = new Color(0xFFE5E5E5);
        private static readonly Color _gray_89              = new Color(0xFFE3E3E3);
        private static readonly Color _gray_88              = new Color(0xFFE0E0E0);
        private static readonly Color _gray_87              = new Color(0xFFDEDEDE);
        private static readonly Color _gray_86              = new Color(0xFFDBDBDB);
        private static readonly Color _gray_85              = new Color(0xFFD9D9D9);
        private static readonly Color _gray_84              = new Color(0xFFD6D6D6);
        private static readonly Color _gray_83              = new Color(0xFFD4D4D4);
        private static readonly Color _gray_82              = new Color(0xFFD1D1D1);
        private static readonly Color _gray_81              = new Color(0xFFCFCFCF);
        private static readonly Color _gray_80              = new Color(0xFFCCCCCC);
        private static readonly Color _gray_79              = new Color(0xFFC9C9C9);
        private static readonly Color _gray_78              = new Color(0xFFC7C7C7);
        private static readonly Color _gray_77              = new Color(0xFFC4C4C4);
        private static readonly Color _gray_76              = new Color(0xFFC2C2C2);
        private static readonly Color _gray_75              = new Color(0xFFBFBFBF);
        private static readonly Color _gray_74              = new Color(0xFFBDBDBD);
        private static readonly Color _gray_73              = new Color(0xFFBABABA);
        private static readonly Color _gray_72              = new Color(0xFFB8B8B8);
        private static readonly Color _gray_71              = new Color(0xFFB5B5B5);
        private static readonly Color _gray_70              = new Color(0xFFB3B3B3);
        private static readonly Color _gray_69              = new Color(0xFFB0B0B0);
        private static readonly Color _gray_68              = new Color(0xFFADADAD);
        private static readonly Color _gray_67              = new Color(0xFFABABAB);
        private static readonly Color _gray_66              = new Color(0xFFA8A8A8);
        private static readonly Color _gray_65              = new Color(0xFFA6A6A6);
        private static readonly Color _gray_64              = new Color(0xFFA3A3A3);
        private static readonly Color _gray_63              = new Color(0xFFA1A1A1);
        private static readonly Color _gray_62              = new Color(0xFF9E9E9E);
        private static readonly Color _gray_61              = new Color(0xFF9C9C9C);
        private static readonly Color _gray_60              = new Color(0xFF999999);
        private static readonly Color _gray_59              = new Color(0xFF969696);
        private static readonly Color _gray_58              = new Color(0xFF949494);
        private static readonly Color _gray_57              = new Color(0xFF919191);
        private static readonly Color _gray_56              = new Color(0xFF8F8F8F);
        private static readonly Color _gray_55              = new Color(0xFF8C8C8C);
        private static readonly Color _gray_54              = new Color(0xFF8A8A8A);
        private static readonly Color _gray_53              = new Color(0xFF878787);
        private static readonly Color _gray_52              = new Color(0xFF858585);
        private static readonly Color _gray_51              = new Color(0xFF828282);
        private static readonly Color _gray_50              = new Color(0xFF7F7F7F);
        private static readonly Color _gray_49              = new Color(0xFF7D7D7D);
        private static readonly Color _gray_48              = new Color(0xFF7A7A7A);
        private static readonly Color _gray_47              = new Color(0xFF787878);
        private static readonly Color _gray_46              = new Color(0xFF757575);
        private static readonly Color _gray_45              = new Color(0xFF737373);
        private static readonly Color _gray_44              = new Color(0xFF707070);
        private static readonly Color _gray_43              = new Color(0xFF6E6E6E);
        private static readonly Color _gray_42              = new Color(0xFF6B6B6B);
        private static readonly Color _gray_41              = new Color(0xFF696969);
        private static readonly Color _gray_40              = new Color(0xFF666666);
        private static readonly Color _gray_39              = new Color(0xFF636363);
        private static readonly Color _gray_38              = new Color(0xFF616161);
        private static readonly Color _gray_37              = new Color(0xFF5E5E5E);
        private static readonly Color _gray_36              = new Color(0xFF5C5C5C);
        private static readonly Color _gray_35              = new Color(0xFF595959);
        private static readonly Color _gray_34              = new Color(0xFF575757);
        private static readonly Color _gray_33              = new Color(0xFF545454);
        private static readonly Color _gray_32              = new Color(0xFF525252);
        private static readonly Color _gray_31              = new Color(0xFF4F4F4F);
        private static readonly Color _gray_30              = new Color(0xFF4D4D4D);
        private static readonly Color _gray_29              = new Color(0xFF4A4A4A);
        private static readonly Color _gray_28              = new Color(0xFF474747);
        private static readonly Color _gray_27              = new Color(0xFF454545);
        private static readonly Color _gray_26              = new Color(0xFF424242);
        private static readonly Color _gray_25              = new Color(0xFF404040);
        private static readonly Color _gray_24              = new Color(0xFF3D3D3D);
        private static readonly Color _gray_23              = new Color(0xFF3B3B3B);
        private static readonly Color _gray_22              = new Color(0xFF383838);
        private static readonly Color _gray_21              = new Color(0xFF363636);
        private static readonly Color _gray_20              = new Color(0xFF333333);
        private static readonly Color _gray_19              = new Color(0xFF303030);
        private static readonly Color _gray_18              = new Color(0xFF2E2E2E);
        private static readonly Color _gray_17              = new Color(0xFF2B2B2B);
        private static readonly Color _gray_16              = new Color(0xFF292929);
        private static readonly Color _gray_15              = new Color(0xFF262626);
        private static readonly Color _gray_14              = new Color(0xFF242424);
        private static readonly Color _gray_13              = new Color(0xFF212121);
        private static readonly Color _gray_12              = new Color(0xFF1F1F1F);
        private static readonly Color _gray_11              = new Color(0xFF1C1C1C);
        private static readonly Color _gray_10              = new Color(0xFF1A1A1A);
        private static readonly Color _gray_9               = new Color(0xFF171717);
        private static readonly Color _gray_8               = new Color(0xFF141414);
        private static readonly Color _gray_7               = new Color(0xFF121212);
        private static readonly Color _gray_6               = new Color(0xFF0F0F0F);
        private static readonly Color _gray_5               = new Color(0xFF0D0D0D);
        private static readonly Color _gray_4               = new Color(0xFF0A0A0A);
        private static readonly Color _gray_3               = new Color(0xFF080808);
        private static readonly Color _gray_2               = new Color(0xFF050505);
        private static readonly Color _gray_1               = new Color(0xFF030303);

        public static ref readonly Color indian_Red
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _indian_Red; }
        }

        public static ref readonly Color crimson
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _crimson; }
        }

        public static ref readonly Color lightPink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightPink; }
        }

        public static ref readonly Color lightPink_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightPink_1; }
        }

        public static ref readonly Color lightPink_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightPink_2; }
        }

        public static ref readonly Color lightPink_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightPink_3; }
        }

        public static ref readonly Color lightPink_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightPink_4; }
        }

        public static ref readonly Color Pink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Pink; }
        }

        public static ref readonly Color Pink_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Pink_1; }
        }

        public static ref readonly Color Pink_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Pink_2; }
        }

        public static ref readonly Color Pink_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Pink_3; }
        }

        public static ref readonly Color Pink_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Pink_4; }
        }

        public static ref readonly Color paleVioletRed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleVioletRed; }
        }

        public static ref readonly Color paleVioletRed_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleVioletRed_1; }
        }

        public static ref readonly Color paleVioletRed_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleVioletRed_2; }
        }

        public static ref readonly Color paleVioletRed_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleVioletRed_3; }
        }

        public static ref readonly Color paleVioletRed_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleVioletRed_4; }
        }

        public static ref readonly Color lavenderblush_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lavenderblush; }
        }

        public static ref readonly Color lavenderblush_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lavenderblush_2; }
        }

        public static ref readonly Color lavenderblush_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lavenderblush_3; }
        }

        public static ref readonly Color lavenderblush_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lavenderblush_4; }
        }

        public static ref readonly Color VioletRed_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _VioletRed_1; }
        }

        public static ref readonly Color VioletRed_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _VioletRed_2; }
        }

        public static ref readonly Color VioletRed_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _VioletRed_3; }
        }

        public static ref readonly Color VioletRed_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _VioletRed_4; }
        }

        public static ref readonly Color hotPink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _hotPink; }
        }

        public static ref readonly Color hotPink_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _hotPink_1; }
        }

        public static ref readonly Color hotPink_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _hotPink_2; }
        }

        public static ref readonly Color hotPink_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _hotPink_3; }
        }

        public static ref readonly Color hotPink_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _hotPink_4; }
        }

        public static ref readonly Color raspberry
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _raspberry; }
        }

        public static ref readonly Color deepPink_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _deepPink; }
        }

        public static ref readonly Color deepPink_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _deepPink_2; }
        }

        public static ref readonly Color deepPink_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _deepPink_3; }
        }

        public static ref readonly Color deepPink_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _deepPink_4; }
        }

        public static ref readonly Color maroon_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _maroon_1; }
        }

        public static ref readonly Color maroon_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _maroon_2; }
        }

        public static ref readonly Color maroon_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _maroon_3; }
        }

        public static ref readonly Color maroon_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _maroon_4; }
        }

        public static ref readonly Color mediumVioletRed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumVioletRed; }
        }

        public static ref readonly Color VioletRed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _VioletRed; }
        }

        public static ref readonly Color orchid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orchid; }
        }

        public static ref readonly Color orchid_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orchid_1; }
        }

        public static ref readonly Color orchid_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orchid_2; }
        }

        public static ref readonly Color orchid_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orchid_3; }
        }

        public static ref readonly Color orchid_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orchid_4; }
        }

        public static ref readonly Color thistle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _thistle; }
        }

        public static ref readonly Color thistle_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _thistle_1; }
        }

        public static ref readonly Color thistle_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _thistle_2; }
        }

        public static ref readonly Color thistle_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _thistle_3; }
        }

        public static ref readonly Color thistle_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _thistle_4; }
        }

        public static ref readonly Color plum_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _plum_1; }
        }

        public static ref readonly Color plum_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _plum_2; }
        }

        public static ref readonly Color plum_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _plum_3; }
        }

        public static ref readonly Color plum_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _plum_4; }
        }

        public static ref readonly Color plum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _plum; }
        }

        public static ref readonly Color Violet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Violet; }
        }

        public static ref readonly Color magenta
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _fuchsia; }
        }

        public static ref readonly Color magenta_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _magenta_2; }
        }

        public static ref readonly Color magenta_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _magenta_3; }
        }

        public static ref readonly Color magenta_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkmagenta; }
        }

        public static ref readonly Color purple
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _purple; }
        }

        public static ref readonly Color mediumorchid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumorchid; }
        }

        public static ref readonly Color mediumorchid_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumorchid_1; }
        }

        public static ref readonly Color mediumorchid_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumorchid_2; }
        }

        public static ref readonly Color mediumorchid_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumorchid_3; }
        }

        public static ref readonly Color mediumorchid_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumorchid_4; }
        }

        public static ref readonly Color darkViolet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkViolet; }
        }

        public static ref readonly Color darkorchid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorchid; }
        }

        public static ref readonly Color darkorchid_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorchid_1; }
        }

        public static ref readonly Color darkorchid_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorchid_2; }
        }

        public static ref readonly Color darkorchid_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorchid_3; }
        }

        public static ref readonly Color darkorchid_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorchid_4; }
        }

        public static ref readonly Color indigo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _indigo; }
        }

        public static ref readonly Color BlueViolet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _BlueViolet; }
        }

        public static ref readonly Color purple_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _purple_1; }
        }

        public static ref readonly Color purple_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _purple_2; }
        }

        public static ref readonly Color purple_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _purple_3; }
        }

        public static ref readonly Color purple_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _purple_4; }
        }

        public static ref readonly Color mediumpurple
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumpurple; }
        }

        public static ref readonly Color mediumpurple_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumpurple_1; }
        }

        public static ref readonly Color mediumpurple_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumpurple_2; }
        }

        public static ref readonly Color mediumpurple_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumpurple_3; }
        }

        public static ref readonly Color mediumpurple_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumpurple_4; }
        }

        public static ref readonly Color darkslateBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkslateBlue; }
        }

        public static ref readonly Color lightslateBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightslateBlue; }
        }

        public static ref readonly Color mediumslateBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumslateBlue; }
        }

        public static ref readonly Color slateBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slateBlue; }
        }

        public static ref readonly Color slateBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slateBlue_1; }
        }

        public static ref readonly Color slateBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slateBlue_2; }
        }

        public static ref readonly Color slateBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slateBlue_3; }
        }

        public static ref readonly Color slateBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slateBlue_4; }
        }

        public static ref readonly Color ghostwhite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _ghostwhite; }
        }

        public static ref readonly Color lavender
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lavender; }
        }

        public static ref readonly Color Blue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Blue; }
        }

        public static ref readonly Color Blue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Blue_2; }
        }

        public static ref readonly Color Blue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumBlue; }
        }

        public static ref readonly Color Blue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkBlue; }
        }

        public static ref readonly Color navy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _navy; }
        }

        public static ref readonly Color midnightBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _midnightBlue; }
        }

        public static ref readonly Color cobalt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cobalt; }
        }

        public static ref readonly Color royalBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _royalBlue; }
        }

        public static ref readonly Color royalBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _royalBlue_1; }
        }

        public static ref readonly Color royalBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _royalBlue_2; }
        }

        public static ref readonly Color royalBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _royalBlue_3; }
        }

        public static ref readonly Color royalBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _royalBlue_4; }
        }

        public static ref readonly Color cornflowerBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cornflowerBlue; }
        }

        public static ref readonly Color lightsteelBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightsteelBlue; }
        }

        public static ref readonly Color lightsteelBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightsteelBlue_1; }
        }

        public static ref readonly Color lightsteelBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightsteelBlue_2; }
        }

        public static ref readonly Color lightsteelBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightsteelBlue_3; }
        }

        public static ref readonly Color lightsteelBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightsteelBlue_4; }
        }

        public static ref readonly Color lightslategray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightslategray; }
        }

        public static ref readonly Color slategray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slategray; }
        }

        public static ref readonly Color slategray_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slategray_1; }
        }

        public static ref readonly Color slategray_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slategray_2; }
        }

        public static ref readonly Color slategray_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slategray_3; }
        }

        public static ref readonly Color slategray_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _slategray_4; }
        }

        public static ref readonly Color dodgerBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _dodgerBlue; }
        }

        public static ref readonly Color dodgerBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _dodgerBlue_2; }
        }

        public static ref readonly Color dodgerBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _dodgerBlue_3; }
        }

        public static ref readonly Color dodgerBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _dodgerBlue_4; }
        }

        public static ref readonly Color aliceBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _aliceBlue; }
        }

        public static ref readonly Color steelBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _steelBlue; }
        }

        public static ref readonly Color steelBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _steelBlue_1; }
        }

        public static ref readonly Color steelBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _steelBlue_2; }
        }

        public static ref readonly Color steelBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _steelBlue_3; }
        }

        public static ref readonly Color steelBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _steelBlue_4; }
        }

        public static ref readonly Color lightskyBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightskyBlue; }
        }

        public static ref readonly Color lightskyBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightskyBlue_1; }
        }

        public static ref readonly Color lightskyBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightskyBlue_2; }
        }

        public static ref readonly Color lightskyBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightskyBlue_3; }
        }

        public static ref readonly Color lightskyBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightskyBlue_4; }
        }

        public static ref readonly Color skyBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _skyBlue_1; }
        }

        public static ref readonly Color skyBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _skyBlue_2; }
        }

        public static ref readonly Color skyBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _skyBlue_3; }
        }

        public static ref readonly Color skyBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _skyBlue_4; }
        }

        public static ref readonly Color skyBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _skyBlue; }
        }

        public static ref readonly Color deepskyBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _deepskyBlue; }
        }

        public static ref readonly Color deepskyBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _deepskyBlue_2; }
        }

        public static ref readonly Color deepskyBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _deepskyBlue_3; }
        }

        public static ref readonly Color deepskyBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _deepskyBlue_4; }
        }

        public static ref readonly Color peacock
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _peacock; }
        }

        public static ref readonly Color lightBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightBlue; }
        }

        public static ref readonly Color lightBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightBlue_1; }
        }

        public static ref readonly Color lightBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightBlue_2; }
        }

        public static ref readonly Color lightBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightBlue_3; }
        }

        public static ref readonly Color lightBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightBlue_4; }
        }

        public static ref readonly Color powderBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _powderBlue; }
        }

        public static ref readonly Color cadetBlue_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cadetBlue_1; }
        }

        public static ref readonly Color cadetBlue_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cadetBlue_2; }
        }

        public static ref readonly Color cadetBlue_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cadetBlue_3; }
        }

        public static ref readonly Color cadetBlue_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cadetBlue_4; }
        }

        public static ref readonly Color turquoise_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _turquoise_1; }
        }

        public static ref readonly Color turquoise_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _turquoise_2; }
        }

        public static ref readonly Color turquoise_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _turquoise_3; }
        }

        public static ref readonly Color turquoise_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _turquoise_4; }
        }

        public static ref readonly Color cadetBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cadetBlue; }
        }

        public static ref readonly Color darkturquoise
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkturquoise; }
        }

        public static ref readonly Color azure_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _azure; }
        }

        public static ref readonly Color azure_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _azure_2; }
        }

        public static ref readonly Color azure_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _azure_3; }
        }

        public static ref readonly Color azure_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _azure_4; }
        }

        public static ref readonly Color lightcyan_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightcyan; }
        }

        public static ref readonly Color lightcyan_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightcyan_2; }
        }

        public static ref readonly Color lightcyan_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightcyan_3; }
        }

        public static ref readonly Color lightcyan_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightcyan_4; }
        }

        public static ref readonly Color paleturquoise_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleturquoise_1; }
        }

        public static ref readonly Color paleturquoise_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleturquoise_2; }
        }

        public static ref readonly Color paleturquoise_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleturquoise_3; }
        }

        public static ref readonly Color paleturquoise_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleturquoise_4; }
        }

        public static ref readonly Color darkslategray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkslategray; }
        }

        public static ref readonly Color darkslategray_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkslategray_1; }
        }

        public static ref readonly Color darkslategray_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkslategray_2; }
        }

        public static ref readonly Color darkslategray_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkslategray_3; }
        }

        public static ref readonly Color darkslategray_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkslategray_4; }
        }

        public static ref readonly Color aqua
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _aqua; }
        }

        public static ref readonly Color cyan_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cyan_2; }
        }

        public static ref readonly Color cyan_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cyan_3; }
        }

        public static ref readonly Color cyan_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkcyan; }
        }

        public static ref readonly Color teal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _teal; }
        }

        public static ref readonly Color mediumturquoise
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumturquoise; }
        }

        public static ref readonly Color lightseaGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightseaGreen; }
        }

        public static ref readonly Color manganeseBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _manganeseBlue; }
        }

        public static ref readonly Color turquoise
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _turquoise; }
        }

        public static ref readonly Color coldgrey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _coldgrey; }
        }

        public static ref readonly Color turquoiseBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _turquoiseBlue; }
        }

        public static ref readonly Color aquamarine
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _aquamarine; }
        }

        public static ref readonly Color aquamarine_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _aquamarine_2; }
        }

        public static ref readonly Color aquamarine_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _aquamarine_3; }
        }

        public static ref readonly Color aquamarine_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _aquamarine_4; }
        }

        public static ref readonly Color mediumspringGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumspringGreen; }
        }

        public static ref readonly Color mintcream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mintcream; }
        }

        public static ref readonly Color springGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _springGreen; }
        }

        public static ref readonly Color springGreen_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _springGreen_1; }
        }

        public static ref readonly Color springGreen_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _springGreen_2; }
        }

        public static ref readonly Color springGreen_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _springGreen_3; }
        }

        public static ref readonly Color mediumseaGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mediumseaGreen; }
        }

        public static ref readonly Color seaGreen_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _seaGreen_1; }
        }

        public static ref readonly Color seaGreen_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _seaGreen_2; }
        }

        public static ref readonly Color seaGreen_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _seaGreen_3; }
        }

        public static ref readonly Color seaGreen_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _seaGreen_4; }
        }

        public static ref readonly Color emeraldGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _emeraldGreen; }
        }

        public static ref readonly Color mint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mint; }
        }

        public static ref readonly Color cobaltGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cobaltGreen; }
        }

        public static ref readonly Color honeydew_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _honeydew_1; }
        }

        public static ref readonly Color honeydew_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _honeydew_2; }
        }

        public static ref readonly Color honeydew_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _honeydew_3; }
        }

        public static ref readonly Color honeydew_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _honeydew_4; }
        }

        public static ref readonly Color darkseaGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkseaGreen; }
        }

        public static ref readonly Color darkseaGreen_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkseaGreen_1; }
        }

        public static ref readonly Color darkseaGreen_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkseaGreen_2; }
        }

        public static ref readonly Color darkseaGreen_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkseaGreen_3; }
        }

        public static ref readonly Color darkseaGreen_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkseaGreen_4; }
        }

        public static ref readonly Color paleGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleGreen; }
        }

        public static ref readonly Color paleGreen_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleGreen_1; }
        }

        public static ref readonly Color paleGreen_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleGreen_2; }
        }

        public static ref readonly Color paleGreen_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleGreen_3; }
        }

        public static ref readonly Color paleGreen_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _paleGreen_4; }
        }

        public static ref readonly Color limeGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _limeGreen; }
        }

        public static ref readonly Color forestGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _forestGreen; }
        }

        public static ref readonly Color Green_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Green_1; }
        }

        public static ref readonly Color Green_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Green_2; }
        }

        public static ref readonly Color Green_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Green_3; }
        }

        public static ref readonly Color Green_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Green_4; }
        }

        public static ref readonly Color Green
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Green; }
        }

        public static ref readonly Color darkGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkGreen; }
        }

        public static ref readonly Color sapGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sapGreen; }
        }

        public static ref readonly Color lawnGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lawnGreen; }
        }

        public static ref readonly Color chartreuse_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _chartreuse_1; }
        }

        public static ref readonly Color chartreuse_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _chartreuse_2; }
        }

        public static ref readonly Color chartreuse_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _chartreuse_3; }
        }

        public static ref readonly Color chartreuse_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _chartreuse_4; }
        }

        public static ref readonly Color GreenYellow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _GreenYellow; }
        }

        public static ref readonly Color darkoliveGreen_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkoliveGreen_1; }
        }

        public static ref readonly Color darkoliveGreen_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkoliveGreen_2; }
        }

        public static ref readonly Color darkoliveGreen_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkoliveGreen_3; }
        }

        public static ref readonly Color darkoliveGreen_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkoliveGreen_4; }
        }

        public static ref readonly Color darkoliveGreen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkoliveGreen; }
        }

        public static ref readonly Color olivedrab
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _olivedrab; }
        }

        public static ref readonly Color olivedrab_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _olivedrab_1; }
        }

        public static ref readonly Color olivedrab_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _olivedrab_2; }
        }

        public static ref readonly Color olivedrab_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _olivedrab_3; }
        }

        public static ref readonly Color olivedrab_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _olivedrab_4; }
        }

        public static ref readonly Color ivory_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _ivory_1; }
        }

        public static ref readonly Color ivory_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _ivory_2; }
        }

        public static ref readonly Color ivory_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _ivory_3; }
        }

        public static ref readonly Color ivory_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _ivory_4; }
        }

        public static ref readonly Color beige
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _beige; }
        }

        public static ref readonly Color lightYellow_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightYellow_1; }
        }

        public static ref readonly Color lightYellow_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightYellow_2; }
        }

        public static ref readonly Color lightYellow_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightYellow_3; }
        }

        public static ref readonly Color lightYellow_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightYellow_4; }
        }

        public static ref readonly Color lightgoldenrodYellow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightgoldenrodYellow; }
        }

        public static ref readonly Color Yellow_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Yellow_1; }
        }

        public static ref readonly Color Yellow_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Yellow_2; }
        }

        public static ref readonly Color Yellow_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Yellow_3; }
        }

        public static ref readonly Color Yellow_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Yellow_4; }
        }

        public static ref readonly Color warmgrey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _warmgrey; }
        }

        public static ref readonly Color olive
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _olive; }
        }

        public static ref readonly Color darkkhaki
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkkhaki; }
        }

        public static ref readonly Color khaki_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _khaki_1; }
        }

        public static ref readonly Color khaki_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _khaki_2; }
        }

        public static ref readonly Color khaki_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _khaki_3; }
        }

        public static ref readonly Color khaki_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _khaki_4; }
        }

        public static ref readonly Color khaki
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _khaki; }
        }

        public static ref readonly Color palegoldenrod
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _palegoldenrod; }
        }

        public static ref readonly Color lemonchiffon_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lemonchiffon_1; }
        }

        public static ref readonly Color lemonchiffon_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lemonchiffon_2; }
        }

        public static ref readonly Color lemonchiffon_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lemonchiffon_3; }
        }

        public static ref readonly Color lemonchiffon_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lemonchiffon_4; }
        }

        public static ref readonly Color lightgoldenrod_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightgoldenrod_1; }
        }

        public static ref readonly Color lightgoldenrod_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightgoldenrod_2; }
        }

        public static ref readonly Color lightgoldenrod_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightgoldenrod_3; }
        }

        public static ref readonly Color lightgoldenrod_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightgoldenrod_4; }
        }

        public static ref readonly Color banana
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _banana; }
        }

        public static ref readonly Color gold_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gold_1; }
        }

        public static ref readonly Color gold_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gold_2; }
        }

        public static ref readonly Color gold_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gold_3; }
        }

        public static ref readonly Color gold_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gold_4; }
        }

        public static ref readonly Color cornsilk_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cornsilk_1; }
        }

        public static ref readonly Color cornsilk_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cornsilk_2; }
        }

        public static ref readonly Color cornsilk_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cornsilk_3; }
        }

        public static ref readonly Color cornsilk_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cornsilk_4; }
        }

        public static ref readonly Color goldenrod
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _goldenrod; }
        }

        public static ref readonly Color goldenrod_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _goldenrod_1; }
        }

        public static ref readonly Color goldenrod_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _goldenrod_2; }
        }

        public static ref readonly Color goldenrod_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _goldenrod_3; }
        }

        public static ref readonly Color goldenrod_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _goldenrod_4; }
        }

        public static ref readonly Color darkgoldenrod
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkgoldenrod; }
        }

        public static ref readonly Color darkgoldenrod_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkgoldenrod_1; }
        }

        public static ref readonly Color darkgoldenrod_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkgoldenrod_2; }
        }

        public static ref readonly Color darkgoldenrod_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkgoldenrod_3; }
        }

        public static ref readonly Color darkgoldenrod_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkgoldenrod_4; }
        }

        public static ref readonly Color orange_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orange_1; }
        }

        public static ref readonly Color orange_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orange_2; }
        }

        public static ref readonly Color orange_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orange_3; }
        }

        public static ref readonly Color orange_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orange_4; }
        }

        public static ref readonly Color floralwhite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _floralwhite; }
        }

        public static ref readonly Color oldlace
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _oldlace; }
        }

        public static ref readonly Color wheat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _wheat; }
        }

        public static ref readonly Color wheat_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _wheat_1; }
        }

        public static ref readonly Color wheat_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _wheat_2; }
        }

        public static ref readonly Color wheat_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _wheat_3; }
        }

        public static ref readonly Color wheat_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _wheat_4; }
        }

        public static ref readonly Color moccasin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _moccasin; }
        }

        public static ref readonly Color papayawhip
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _papayawhip; }
        }

        public static ref readonly Color blanchedalmond
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _blanchedalmond; }
        }

        public static ref readonly Color navajowhite_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _navajowhite_1; }
        }

        public static ref readonly Color navajowhite_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _navajowhite_2; }
        }

        public static ref readonly Color navajowhite_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _navajowhite_3; }
        }

        public static ref readonly Color navajowhite_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _navajowhite_4; }
        }

        public static ref readonly Color eggshell
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _eggshell; }
        }

        public static ref readonly Color tan
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _tan; }
        }

        public static ref readonly Color brick
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _brick; }
        }

        public static ref readonly Color cadmiumYellow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cadmiumYellow; }
        }

        public static ref readonly Color antiquewhite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _antiquewhite; }
        }

        public static ref readonly Color antiquewhite_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _antiquewhite_1; }
        }

        public static ref readonly Color antiquewhite_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _antiquewhite_2; }
        }

        public static ref readonly Color antiquewhite_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _antiquewhite_3; }
        }

        public static ref readonly Color antiquewhite_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _antiquewhite_4; }
        }

        public static ref readonly Color burlywood
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _burlywood; }
        }

        public static ref readonly Color burlywood_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _burlywood_1; }
        }

        public static ref readonly Color burlywood_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _burlywood_2; }
        }

        public static ref readonly Color burlywood_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _burlywood_3; }
        }

        public static ref readonly Color burlywood_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _burlywood_4; }
        }

        public static ref readonly Color bisque_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _bisque_1; }
        }

        public static ref readonly Color bisque_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _bisque_2; }
        }

        public static ref readonly Color bisque_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _bisque_3; }
        }

        public static ref readonly Color bisque_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _bisque_4; }
        }

        public static ref readonly Color melon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _melon; }
        }

        public static ref readonly Color carrot
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _carrot; }
        }

        public static ref readonly Color darkorange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorange; }
        }

        public static ref readonly Color darkorange_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorange_1; }
        }

        public static ref readonly Color darkorange_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorange_2; }
        }

        public static ref readonly Color darkorange_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorange_3; }
        }

        public static ref readonly Color darkorange_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkorange_4; }
        }

        public static ref readonly Color orange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orange; }
        }

        public static ref readonly Color tan_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _tan_1; }
        }

        public static ref readonly Color tan_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _tan_2; }
        }

        public static ref readonly Color tan_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _tan_3; }
        }

        public static ref readonly Color tan_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _tan_4; }
        }

        public static ref readonly Color linen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _linen; }
        }

        public static ref readonly Color peachpuff_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _peachpuff_1; }
        }

        public static ref readonly Color peachpuff_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _peachpuff_2; }
        }

        public static ref readonly Color peachpuff_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _peachpuff_3; }
        }

        public static ref readonly Color peachpuff_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _peachpuff_4; }
        }

        public static ref readonly Color seashell_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _seashell_1; }
        }

        public static ref readonly Color seashell_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _seashell_2; }
        }

        public static ref readonly Color seashell_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _seashell_3; }
        }

        public static ref readonly Color seashell_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _seashell_4; }
        }

        public static ref readonly Color sandybrown
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sandybrown; }
        }

        public static ref readonly Color rawsienna
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _rawsienna; }
        }

        public static ref readonly Color chocolate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _chocolate; }
        }

        public static ref readonly Color chocolate_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _chocolate_1; }
        }

        public static ref readonly Color chocolate_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _chocolate_2; }
        }

        public static ref readonly Color chocolate_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _chocolate_3; }
        }

        public static ref readonly Color chocolate_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _chocolate_4; }
        }

        public static ref readonly Color ivoryblack
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _ivoryblack; }
        }

        public static ref readonly Color flesh
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _flesh; }
        }

        public static ref readonly Color cadmiumorange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _cadmiumorange; }
        }

        public static ref readonly Color burntsienna
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _burntsienna; }
        }

        public static ref readonly Color sienna
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sienna; }
        }

        public static ref readonly Color sienna_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sienna_1; }
        }

        public static ref readonly Color sienna_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sienna_2; }
        }

        public static ref readonly Color sienna_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sienna_3; }
        }

        public static ref readonly Color sienna_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sienna_4; }
        }

        public static ref readonly Color lightsalmon_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightsalmon_1; }
        }

        public static ref readonly Color lightsalmon_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightsalmon_2; }
        }

        public static ref readonly Color lightsalmon_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightsalmon_3; }
        }

        public static ref readonly Color lightsalmon_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightsalmon_4; }
        }

        public static ref readonly Color coral
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _coral; }
        }

        public static ref readonly Color orangeRed_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orangeRed_1; }
        }

        public static ref readonly Color orangeRed_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orangeRed_2; }
        }

        public static ref readonly Color orangeRed_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orangeRed_3; }
        }

        public static ref readonly Color orangeRed_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _orangeRed_4; }
        }

        public static ref readonly Color sepia
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sepia; }
        }

        public static ref readonly Color darksalmon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darksalmon; }
        }

        public static ref readonly Color salmon_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _salmon_1; }
        }

        public static ref readonly Color salmon_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _salmon_2; }
        }

        public static ref readonly Color salmon_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _salmon_3; }
        }

        public static ref readonly Color salmon_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _salmon_4; }
        }

        public static ref readonly Color coral_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _coral_1; }
        }

        public static ref readonly Color coral_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _coral_2; }
        }

        public static ref readonly Color coral_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _coral_3; }
        }

        public static ref readonly Color coral_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _coral_4; }
        }

        public static ref readonly Color burntumber
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _burntumber; }
        }

        public static ref readonly Color tomato_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _tomato_1; }
        }

        public static ref readonly Color tomato_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _tomato_2; }
        }

        public static ref readonly Color tomato_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _tomato_3; }
        }

        public static ref readonly Color tomato_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _tomato_4; }
        }

        public static ref readonly Color salmon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _salmon; }
        }

        public static ref readonly Color mistyrose_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mistyrose_1; }
        }

        public static ref readonly Color mistyrose_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mistyrose_2; }
        }

        public static ref readonly Color mistyrose_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mistyrose_3; }
        }

        public static ref readonly Color mistyrose_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _mistyrose_4; }
        }

        public static ref readonly Color snow_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _snow_1; }
        }

        public static ref readonly Color snow_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _snow_2; }
        }

        public static ref readonly Color snow_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _snow_3; }
        }

        public static ref readonly Color snow_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _snow_4; }
        }

        public static ref readonly Color rosybrown
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _rosybrown; }
        }

        public static ref readonly Color rosybrown_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _rosybrown_1; }
        }

        public static ref readonly Color rosybrown_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _rosybrown_2; }
        }

        public static ref readonly Color rosybrown_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _rosybrown_3; }
        }

        public static ref readonly Color rosybrown_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _rosybrown_4; }
        }

        public static ref readonly Color lightcoral
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightcoral; }
        }

        public static ref readonly Color indianRed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _indianRed; }
        }

        public static ref readonly Color indianRed_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _indianRed_1; }
        }

        public static ref readonly Color indianRed_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _indianRed_2; }
        }

        public static ref readonly Color indianRed_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _indianRed_4; }
        }

        public static ref readonly Color indianRed_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _indianRed_3; }
        }

        public static ref readonly Color brown
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _brown; }
        }

        public static ref readonly Color brown_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _brown_1; }
        }

        public static ref readonly Color brown_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _brown_2; }
        }

        public static ref readonly Color brown_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _brown_3; }
        }

        public static ref readonly Color brown_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _brown_4; }
        }

        public static ref readonly Color firebrick
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _firebrick; }
        }

        public static ref readonly Color firebrick_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _firebrick_1; }
        }

        public static ref readonly Color firebrick_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _firebrick_2; }
        }

        public static ref readonly Color firebrick_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _firebrick_3; }
        }

        public static ref readonly Color firebrick_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _firebrick_4; }
        }

        public static ref readonly Color Red_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Red_1; }
        }

        public static ref readonly Color Red_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Red_2; }
        }

        public static ref readonly Color Red_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Red_3; }
        }

        public static ref readonly Color Red_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _Red_4; }
        }

        public static ref readonly Color maroon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _maroon; }
        }

        public static ref readonly Color sgi_beet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_beet; }
        }

        public static ref readonly Color sgi_slateBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_slateBlue; }
        }

        public static ref readonly Color sgi_lightBlue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_lightBlue; }
        }

        public static ref readonly Color sgi_teal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_teal; }
        }

        public static ref readonly Color sgi_chartreuse
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_chartreuse; }
        }

        public static ref readonly Color sgi_olivedrab
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_olivedrab; }
        }

        public static ref readonly Color sgi_brightgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_brightgray; }
        }

        public static ref readonly Color sgi_salmon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_salmon; }
        }

        public static ref readonly Color sgi_darkgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_darkgray; }
        }

        public static ref readonly Color sgi_gray_12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_12; }
        }

        public static ref readonly Color sgi_gray_16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_16; }
        }

        public static ref readonly Color sgi_gray_32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_32; }
        }

        public static ref readonly Color sgi_gray_36
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_36; }
        }

        public static ref readonly Color sgi_gray_52
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_52; }
        }

        public static ref readonly Color sgi_gray_56
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_56; }
        }

        public static ref readonly Color sgi_lightgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_lightgray; }
        }

        public static ref readonly Color sgi_gray_72
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_72; }
        }

        public static ref readonly Color sgi_gray_76
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_76; }
        }

        public static ref readonly Color sgi_gray_92
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_92; }
        }

        public static ref readonly Color sgi_gray_96
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _sgi_gray_96; }
        }

        public static ref readonly Color white
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _white; }
        }

        public static ref readonly Color white_smoke
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _white_smoke; }
        }

        public static ref readonly Color gainsboro
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gainsboro; }
        }

        public static ref readonly Color lightgrey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _lightgrey; }
        }

        public static ref readonly Color silver
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _silver; }
        }

        public static ref readonly Color darkgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _darkgray; }
        }

        public static ref readonly Color gray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray; }
        }

        public static ref readonly Color dimgray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _dimgray; }
        }

        public static ref readonly Color black
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _black; }
        }

        public static ref readonly Color gray_99
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_99; }
        }

        public static ref readonly Color gray_98
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_98; }
        }

        public static ref readonly Color gray_97
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_97; }
        }

        public static ref readonly Color gray_96
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_96; }
        }

        public static ref readonly Color gray_95
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_95; }
        }

        public static ref readonly Color gray_94
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_94; }
        }

        public static ref readonly Color gray_93
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_93; }
        }

        public static ref readonly Color gray_92
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_92; }
        }

        public static ref readonly Color gray_91
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_91; }
        }

        public static ref readonly Color gray_90
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_90; }
        }

        public static ref readonly Color gray_89
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_89; }
        }

        public static ref readonly Color gray_88
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_88; }
        }

        public static ref readonly Color gray_87
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_87; }
        }

        public static ref readonly Color gray_86
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_86; }
        }

        public static ref readonly Color gray_85
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_85; }
        }

        public static ref readonly Color gray_84
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_84; }
        }

        public static ref readonly Color gray_83
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_83; }
        }

        public static ref readonly Color gray_82
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_82; }
        }

        public static ref readonly Color gray_81
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_81; }
        }

        public static ref readonly Color gray_80
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_80; }
        }

        public static ref readonly Color gray_79
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_79; }
        }

        public static ref readonly Color gray_78
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_78; }
        }

        public static ref readonly Color gray_77
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_77; }
        }

        public static ref readonly Color gray_76
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_76; }
        }

        public static ref readonly Color gray_75
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_75; }
        }

        public static ref readonly Color gray_74
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_74; }
        }

        public static ref readonly Color gray_73
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_73; }
        }

        public static ref readonly Color gray_72
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_72; }
        }

        public static ref readonly Color gray_71
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_71; }
        }

        public static ref readonly Color gray_70
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_70; }
        }

        public static ref readonly Color gray_69
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_69; }
        }

        public static ref readonly Color gray_68
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_68; }
        }

        public static ref readonly Color gray_67
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_67; }
        }

        public static ref readonly Color gray_66
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_66; }
        }

        public static ref readonly Color gray_65
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_65; }
        }

        public static ref readonly Color gray_64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_64; }
        }

        public static ref readonly Color gray_63
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_63; }
        }

        public static ref readonly Color gray_62
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_62; }
        }

        public static ref readonly Color gray_61
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_61; }
        }

        public static ref readonly Color gray_60
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_60; }
        }

        public static ref readonly Color gray_59
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_59; }
        }

        public static ref readonly Color gray_58
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_58; }
        }

        public static ref readonly Color gray_57
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_57; }
        }

        public static ref readonly Color gray_56
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_56; }
        }

        public static ref readonly Color gray_55
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_55; }
        }

        public static ref readonly Color gray_54
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_54; }
        }

        public static ref readonly Color gray_53
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_53; }
        }

        public static ref readonly Color gray_52
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_52; }
        }

        public static ref readonly Color gray_51
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_51; }
        }

        public static ref readonly Color gray_50
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_50; }
        }

        public static ref readonly Color gray_49
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_49; }
        }

        public static ref readonly Color gray_48
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_48; }
        }

        public static ref readonly Color gray_47
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_47; }
        }

        public static ref readonly Color gray_46
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_46; }
        }

        public static ref readonly Color gray_45
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_45; }
        }

        public static ref readonly Color gray_44
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_44; }
        }

        public static ref readonly Color gray_43
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_43; }
        }

        public static ref readonly Color gray_42
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_42; }
        }

        public static ref readonly Color gray_41
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_41; }
        }

        public static ref readonly Color gray_40
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_40; }
        }

        public static ref readonly Color gray_39
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_39; }
        }

        public static ref readonly Color gray_38
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_38; }
        }

        public static ref readonly Color gray_37
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_37; }
        }

        public static ref readonly Color gray_36
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_36; }
        }

        public static ref readonly Color gray_35
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_35; }
        }

        public static ref readonly Color gray_34
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_34; }
        }

        public static ref readonly Color gray_33
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_33; }
        }

        public static ref readonly Color gray_32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_32; }
        }

        public static ref readonly Color gray_31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_31; }
        }

        public static ref readonly Color gray_30
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_30; }
        }

        public static ref readonly Color gray_29
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_29; }
        }

        public static ref readonly Color gray_28
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_28; }
        }

        public static ref readonly Color gray_27
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_27; }
        }

        public static ref readonly Color gray_26
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_26; }
        }

        public static ref readonly Color gray_25
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_25; }
        }

        public static ref readonly Color gray_24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_24; }
        }

        public static ref readonly Color gray_23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_23; }
        }

        public static ref readonly Color gray_22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_22; }
        }

        public static ref readonly Color gray_21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_21; }
        }

        public static ref readonly Color gray_20
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_20; }
        }

        public static ref readonly Color gray_19
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_19; }
        }

        public static ref readonly Color gray_18
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_18; }
        }

        public static ref readonly Color gray_17
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_17; }
        }

        public static ref readonly Color gray_16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_16; }
        }

        public static ref readonly Color gray_15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_15; }
        }

        public static ref readonly Color gray_14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_14; }
        }

        public static ref readonly Color gray_13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_13; }
        }

        public static ref readonly Color gray_12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_12; }
        }

        public static ref readonly Color gray_11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_11; }
        }

        public static ref readonly Color gray_10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_10; }
        }

        public static ref readonly Color gray_9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_9; }
        }

        public static ref readonly Color gray_8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_8; }
        }

        public static ref readonly Color gray_7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_7; }
        }

        public static ref readonly Color gray_6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_6; }
        }

        public static ref readonly Color gray_5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_5; }
        }

        public static ref readonly Color gray_4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_4; }
        }

        public static ref readonly Color gray_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_3; }
        }

        public static ref readonly Color gray_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_2; }
        }

        public static ref readonly Color gray_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref _gray_1; }
        }
    }
}