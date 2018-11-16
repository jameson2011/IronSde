namespace IronSde.ItemTypes
open IronSde.Types
module internal ItemTypeGroups=
    let group = function
        | 0 -> Some { ItemTypeGroupData.id = 0; categoryId = 0 }
        | 1 -> Some { ItemTypeGroupData.id = 1; categoryId = 1 }
        | 2 -> Some { ItemTypeGroupData.id = 2; categoryId = 1 }
        | 19 -> Some { ItemTypeGroupData.id = 19; categoryId = 1 }
        | 32 -> Some { ItemTypeGroupData.id = 32; categoryId = 1 }
        | 3 -> Some { ItemTypeGroupData.id = 3; categoryId = 2 }
        | 4 -> Some { ItemTypeGroupData.id = 4; categoryId = 2 }
        | 5 -> Some { ItemTypeGroupData.id = 5; categoryId = 2 }
        | 6 -> Some { ItemTypeGroupData.id = 6; categoryId = 2 }
        | 7 -> Some { ItemTypeGroupData.id = 7; categoryId = 2 }
        | 8 -> Some { ItemTypeGroupData.id = 8; categoryId = 2 }
        | 9 -> Some { ItemTypeGroupData.id = 9; categoryId = 2 }
        | 10 -> Some { ItemTypeGroupData.id = 10; categoryId = 2 }
        | 11 -> Some { ItemTypeGroupData.id = 11; categoryId = 2 }
        | 12 -> Some { ItemTypeGroupData.id = 12; categoryId = 2 }
        | 13 -> Some { ItemTypeGroupData.id = 13; categoryId = 2 }
        | 14 -> Some { ItemTypeGroupData.id = 14; categoryId = 2 }
        | 186 -> Some { ItemTypeGroupData.id = 186; categoryId = 2 }
        | 226 -> Some { ItemTypeGroupData.id = 226; categoryId = 2 }
        | 227 -> Some { ItemTypeGroupData.id = 227; categoryId = 2 }
        | 305 -> Some { ItemTypeGroupData.id = 305; categoryId = 2 }
        | 307 -> Some { ItemTypeGroupData.id = 307; categoryId = 2 }
        | 310 -> Some { ItemTypeGroupData.id = 310; categoryId = 2 }
        | 312 -> Some { ItemTypeGroupData.id = 312; categoryId = 2 }
        | 318 -> Some { ItemTypeGroupData.id = 318; categoryId = 2 }
        | 336 -> Some { ItemTypeGroupData.id = 336; categoryId = 2 }
        | 340 -> Some { ItemTypeGroupData.id = 340; categoryId = 2 }
        | 366 -> Some { ItemTypeGroupData.id = 366; categoryId = 2 }
        | 368 -> Some { ItemTypeGroupData.id = 368; categoryId = 2 }
        | 382 -> Some { ItemTypeGroupData.id = 382; categoryId = 2 }
        | 411 -> Some { ItemTypeGroupData.id = 411; categoryId = 2 }
        | 448 -> Some { ItemTypeGroupData.id = 448; categoryId = 2 }
        | 502 -> Some { ItemTypeGroupData.id = 502; categoryId = 2 }
        | 517 -> Some { ItemTypeGroupData.id = 517; categoryId = 2 }
        | 649 -> Some { ItemTypeGroupData.id = 649; categoryId = 2 }
        | 711 -> Some { ItemTypeGroupData.id = 711; categoryId = 2 }
        | 835 -> Some { ItemTypeGroupData.id = 835; categoryId = 2 }
        | 836 -> Some { ItemTypeGroupData.id = 836; categoryId = 2 }
        | 874 -> Some { ItemTypeGroupData.id = 874; categoryId = 2 }
        | 885 -> Some { ItemTypeGroupData.id = 885; categoryId = 2 }
        | 897 -> Some { ItemTypeGroupData.id = 897; categoryId = 2 }
        | 920 -> Some { ItemTypeGroupData.id = 920; categoryId = 2 }
        | 988 -> Some { ItemTypeGroupData.id = 988; categoryId = 2 }
        | 995 -> Some { ItemTypeGroupData.id = 995; categoryId = 2 }
        | 1071 -> Some { ItemTypeGroupData.id = 1071; categoryId = 2 }
        | 1165 -> Some { ItemTypeGroupData.id = 1165; categoryId = 2 }
        | 1198 -> Some { ItemTypeGroupData.id = 1198; categoryId = 2 }
        | 1316 -> Some { ItemTypeGroupData.id = 1316; categoryId = 2 }
        | 1704 -> Some { ItemTypeGroupData.id = 1704; categoryId = 2 }
        | 1882 -> Some { ItemTypeGroupData.id = 1882; categoryId = 2 }
        | 1915 -> Some { ItemTypeGroupData.id = 1915; categoryId = 2 }
        | 1940 -> Some { ItemTypeGroupData.id = 1940; categoryId = 2 }
        | 1971 -> Some { ItemTypeGroupData.id = 1971; categoryId = 2 }
        | 1973 -> Some { ItemTypeGroupData.id = 1973; categoryId = 2 }
        | 1975 -> Some { ItemTypeGroupData.id = 1975; categoryId = 2 }
        | 1978 -> Some { ItemTypeGroupData.id = 1978; categoryId = 2 }
        | 1980 -> Some { ItemTypeGroupData.id = 1980; categoryId = 2 }
        | 1981 -> Some { ItemTypeGroupData.id = 1981; categoryId = 2 }
        | 1983 -> Some { ItemTypeGroupData.id = 1983; categoryId = 2 }
        | 1991 -> Some { ItemTypeGroupData.id = 1991; categoryId = 2 }
        | 1998 -> Some { ItemTypeGroupData.id = 1998; categoryId = 2 }
        | 15 -> Some { ItemTypeGroupData.id = 15; categoryId = 3 }
        | 16 -> Some { ItemTypeGroupData.id = 16; categoryId = 3 }
        | 17 -> Some { ItemTypeGroupData.id = 17; categoryId = 4 }
        | 18 -> Some { ItemTypeGroupData.id = 18; categoryId = 4 }
        | 20 -> Some { ItemTypeGroupData.id = 20; categoryId = 4 }
        | 422 -> Some { ItemTypeGroupData.id = 422; categoryId = 4 }
        | 423 -> Some { ItemTypeGroupData.id = 423; categoryId = 4 }
        | 427 -> Some { ItemTypeGroupData.id = 427; categoryId = 4 }
        | 428 -> Some { ItemTypeGroupData.id = 428; categoryId = 4 }
        | 429 -> Some { ItemTypeGroupData.id = 429; categoryId = 4 }
        | 712 -> Some { ItemTypeGroupData.id = 712; categoryId = 4 }
        | 754 -> Some { ItemTypeGroupData.id = 754; categoryId = 4 }
        | 886 -> Some { ItemTypeGroupData.id = 886; categoryId = 4 }
        | 966 -> Some { ItemTypeGroupData.id = 966; categoryId = 4 }
        | 967 -> Some { ItemTypeGroupData.id = 967; categoryId = 4 }
        | 974 -> Some { ItemTypeGroupData.id = 974; categoryId = 4 }
        | 1136 -> Some { ItemTypeGroupData.id = 1136; categoryId = 4 }
        | 1676 -> Some { ItemTypeGroupData.id = 1676; categoryId = 4 }
        | 1996 -> Some { ItemTypeGroupData.id = 1996; categoryId = 4 }
        | 23 -> Some { ItemTypeGroupData.id = 23; categoryId = 5 }
        | 24 -> Some { ItemTypeGroupData.id = 24; categoryId = 5 }
        | 872 -> Some { ItemTypeGroupData.id = 872; categoryId = 5 }
        | 876 -> Some { ItemTypeGroupData.id = 876; categoryId = 5 }
        | 943 -> Some { ItemTypeGroupData.id = 943; categoryId = 5 }
        | 1301 -> Some { ItemTypeGroupData.id = 1301; categoryId = 5 }
        | 1311 -> Some { ItemTypeGroupData.id = 1311; categoryId = 5 }
        | 1739 -> Some { ItemTypeGroupData.id = 1739; categoryId = 5 }
        | 1875 -> Some { ItemTypeGroupData.id = 1875; categoryId = 5 }
        | 25 -> Some { ItemTypeGroupData.id = 25; categoryId = 6 }
        | 26 -> Some { ItemTypeGroupData.id = 26; categoryId = 6 }
        | 27 -> Some { ItemTypeGroupData.id = 27; categoryId = 6 }
        | 28 -> Some { ItemTypeGroupData.id = 28; categoryId = 6 }
        | 29 -> Some { ItemTypeGroupData.id = 29; categoryId = 6 }
        | 30 -> Some { ItemTypeGroupData.id = 30; categoryId = 6 }
        | 31 -> Some { ItemTypeGroupData.id = 31; categoryId = 6 }
        | 237 -> Some { ItemTypeGroupData.id = 237; categoryId = 6 }
        | 324 -> Some { ItemTypeGroupData.id = 324; categoryId = 6 }
        | 358 -> Some { ItemTypeGroupData.id = 358; categoryId = 6 }
        | 380 -> Some { ItemTypeGroupData.id = 380; categoryId = 6 }
        | 381 -> Some { ItemTypeGroupData.id = 381; categoryId = 6 }
        | 419 -> Some { ItemTypeGroupData.id = 419; categoryId = 6 }
        | 420 -> Some { ItemTypeGroupData.id = 420; categoryId = 6 }
        | 463 -> Some { ItemTypeGroupData.id = 463; categoryId = 6 }
        | 485 -> Some { ItemTypeGroupData.id = 485; categoryId = 6 }
        | 513 -> Some { ItemTypeGroupData.id = 513; categoryId = 6 }
        | 540 -> Some { ItemTypeGroupData.id = 540; categoryId = 6 }
        | 541 -> Some { ItemTypeGroupData.id = 541; categoryId = 6 }
        | 543 -> Some { ItemTypeGroupData.id = 543; categoryId = 6 }
        | 547 -> Some { ItemTypeGroupData.id = 547; categoryId = 6 }
        | 659 -> Some { ItemTypeGroupData.id = 659; categoryId = 6 }
        | 830 -> Some { ItemTypeGroupData.id = 830; categoryId = 6 }
        | 831 -> Some { ItemTypeGroupData.id = 831; categoryId = 6 }
        | 832 -> Some { ItemTypeGroupData.id = 832; categoryId = 6 }
        | 833 -> Some { ItemTypeGroupData.id = 833; categoryId = 6 }
        | 834 -> Some { ItemTypeGroupData.id = 834; categoryId = 6 }
        | 883 -> Some { ItemTypeGroupData.id = 883; categoryId = 6 }
        | 893 -> Some { ItemTypeGroupData.id = 893; categoryId = 6 }
        | 894 -> Some { ItemTypeGroupData.id = 894; categoryId = 6 }
        | 898 -> Some { ItemTypeGroupData.id = 898; categoryId = 6 }
        | 900 -> Some { ItemTypeGroupData.id = 900; categoryId = 6 }
        | 902 -> Some { ItemTypeGroupData.id = 902; categoryId = 6 }
        | 906 -> Some { ItemTypeGroupData.id = 906; categoryId = 6 }
        | 941 -> Some { ItemTypeGroupData.id = 941; categoryId = 6 }
        | 963 -> Some { ItemTypeGroupData.id = 963; categoryId = 6 }
        | 1022 -> Some { ItemTypeGroupData.id = 1022; categoryId = 6 }
        | 1201 -> Some { ItemTypeGroupData.id = 1201; categoryId = 6 }
        | 1202 -> Some { ItemTypeGroupData.id = 1202; categoryId = 6 }
        | 1283 -> Some { ItemTypeGroupData.id = 1283; categoryId = 6 }
        | 1305 -> Some { ItemTypeGroupData.id = 1305; categoryId = 6 }
        | 1527 -> Some { ItemTypeGroupData.id = 1527; categoryId = 6 }
        | 1534 -> Some { ItemTypeGroupData.id = 1534; categoryId = 6 }
        | 1538 -> Some { ItemTypeGroupData.id = 1538; categoryId = 6 }
        | 1972 -> Some { ItemTypeGroupData.id = 1972; categoryId = 6 }
        | 2001 -> Some { ItemTypeGroupData.id = 2001; categoryId = 6 }
        | 38 -> Some { ItemTypeGroupData.id = 38; categoryId = 7 }
        | 39 -> Some { ItemTypeGroupData.id = 39; categoryId = 7 }
        | 40 -> Some { ItemTypeGroupData.id = 40; categoryId = 7 }
        | 41 -> Some { ItemTypeGroupData.id = 41; categoryId = 7 }
        | 43 -> Some { ItemTypeGroupData.id = 43; categoryId = 7 }
        | 46 -> Some { ItemTypeGroupData.id = 46; categoryId = 7 }
        | 47 -> Some { ItemTypeGroupData.id = 47; categoryId = 7 }
        | 48 -> Some { ItemTypeGroupData.id = 48; categoryId = 7 }
        | 49 -> Some { ItemTypeGroupData.id = 49; categoryId = 7 }
        | 52 -> Some { ItemTypeGroupData.id = 52; categoryId = 7 }
        | 53 -> Some { ItemTypeGroupData.id = 53; categoryId = 7 }
        | 54 -> Some { ItemTypeGroupData.id = 54; categoryId = 7 }
        | 55 -> Some { ItemTypeGroupData.id = 55; categoryId = 7 }
        | 56 -> Some { ItemTypeGroupData.id = 56; categoryId = 7 }
        | 57 -> Some { ItemTypeGroupData.id = 57; categoryId = 7 }
        | 59 -> Some { ItemTypeGroupData.id = 59; categoryId = 7 }
        | 60 -> Some { ItemTypeGroupData.id = 60; categoryId = 7 }
        | 61 -> Some { ItemTypeGroupData.id = 61; categoryId = 7 }
        | 62 -> Some { ItemTypeGroupData.id = 62; categoryId = 7 }
        | 63 -> Some { ItemTypeGroupData.id = 63; categoryId = 7 }
        | 65 -> Some { ItemTypeGroupData.id = 65; categoryId = 7 }
        | 67 -> Some { ItemTypeGroupData.id = 67; categoryId = 7 }
        | 68 -> Some { ItemTypeGroupData.id = 68; categoryId = 7 }
        | 71 -> Some { ItemTypeGroupData.id = 71; categoryId = 7 }
        | 72 -> Some { ItemTypeGroupData.id = 72; categoryId = 7 }
        | 74 -> Some { ItemTypeGroupData.id = 74; categoryId = 7 }
        | 76 -> Some { ItemTypeGroupData.id = 76; categoryId = 7 }
        | 77 -> Some { ItemTypeGroupData.id = 77; categoryId = 7 }
        | 78 -> Some { ItemTypeGroupData.id = 78; categoryId = 7 }
        | 80 -> Some { ItemTypeGroupData.id = 80; categoryId = 7 }
        | 82 -> Some { ItemTypeGroupData.id = 82; categoryId = 7 }
        | 96 -> Some { ItemTypeGroupData.id = 96; categoryId = 7 }
        | 98 -> Some { ItemTypeGroupData.id = 98; categoryId = 7 }
        | 201 -> Some { ItemTypeGroupData.id = 201; categoryId = 7 }
        | 202 -> Some { ItemTypeGroupData.id = 202; categoryId = 7 }
        | 203 -> Some { ItemTypeGroupData.id = 203; categoryId = 7 }
        | 205 -> Some { ItemTypeGroupData.id = 205; categoryId = 7 }
        | 208 -> Some { ItemTypeGroupData.id = 208; categoryId = 7 }
        | 209 -> Some { ItemTypeGroupData.id = 209; categoryId = 7 }
        | 210 -> Some { ItemTypeGroupData.id = 210; categoryId = 7 }
        | 211 -> Some { ItemTypeGroupData.id = 211; categoryId = 7 }
        | 212 -> Some { ItemTypeGroupData.id = 212; categoryId = 7 }
        | 213 -> Some { ItemTypeGroupData.id = 213; categoryId = 7 }
        | 225 -> Some { ItemTypeGroupData.id = 225; categoryId = 7 }
        | 285 -> Some { ItemTypeGroupData.id = 285; categoryId = 7 }
        | 289 -> Some { ItemTypeGroupData.id = 289; categoryId = 7 }
        | 290 -> Some { ItemTypeGroupData.id = 290; categoryId = 7 }
        | 291 -> Some { ItemTypeGroupData.id = 291; categoryId = 7 }
        | 295 -> Some { ItemTypeGroupData.id = 295; categoryId = 7 }
        | 302 -> Some { ItemTypeGroupData.id = 302; categoryId = 7 }
        | 308 -> Some { ItemTypeGroupData.id = 308; categoryId = 7 }
        | 309 -> Some { ItemTypeGroupData.id = 309; categoryId = 7 }
        | 315 -> Some { ItemTypeGroupData.id = 315; categoryId = 7 }
        | 316 -> Some { ItemTypeGroupData.id = 316; categoryId = 7 }
        | 317 -> Some { ItemTypeGroupData.id = 317; categoryId = 7 }
        | 321 -> Some { ItemTypeGroupData.id = 321; categoryId = 7 }
        | 325 -> Some { ItemTypeGroupData.id = 325; categoryId = 7 }
        | 326 -> Some { ItemTypeGroupData.id = 326; categoryId = 7 }
        | 328 -> Some { ItemTypeGroupData.id = 328; categoryId = 7 }
        | 329 -> Some { ItemTypeGroupData.id = 329; categoryId = 7 }
        | 330 -> Some { ItemTypeGroupData.id = 330; categoryId = 7 }
        | 338 -> Some { ItemTypeGroupData.id = 338; categoryId = 7 }
        | 339 -> Some { ItemTypeGroupData.id = 339; categoryId = 7 }
        | 341 -> Some { ItemTypeGroupData.id = 341; categoryId = 7 }
        | 353 -> Some { ItemTypeGroupData.id = 353; categoryId = 7 }
        | 357 -> Some { ItemTypeGroupData.id = 357; categoryId = 7 }
        | 367 -> Some { ItemTypeGroupData.id = 367; categoryId = 7 }
        | 378 -> Some { ItemTypeGroupData.id = 378; categoryId = 7 }
        | 379 -> Some { ItemTypeGroupData.id = 379; categoryId = 7 }
        | 405 -> Some { ItemTypeGroupData.id = 405; categoryId = 7 }
        | 406 -> Some { ItemTypeGroupData.id = 406; categoryId = 7 }
        | 407 -> Some { ItemTypeGroupData.id = 407; categoryId = 7 }
        | 464 -> Some { ItemTypeGroupData.id = 464; categoryId = 7 }
        | 472 -> Some { ItemTypeGroupData.id = 472; categoryId = 7 }
        | 475 -> Some { ItemTypeGroupData.id = 475; categoryId = 7 }
        | 481 -> Some { ItemTypeGroupData.id = 481; categoryId = 7 }
        | 483 -> Some { ItemTypeGroupData.id = 483; categoryId = 7 }
        | 499 -> Some { ItemTypeGroupData.id = 499; categoryId = 7 }
        | 501 -> Some { ItemTypeGroupData.id = 501; categoryId = 7 }
        | 506 -> Some { ItemTypeGroupData.id = 506; categoryId = 7 }
        | 507 -> Some { ItemTypeGroupData.id = 507; categoryId = 7 }
        | 508 -> Some { ItemTypeGroupData.id = 508; categoryId = 7 }
        | 509 -> Some { ItemTypeGroupData.id = 509; categoryId = 7 }
        | 510 -> Some { ItemTypeGroupData.id = 510; categoryId = 7 }
        | 511 -> Some { ItemTypeGroupData.id = 511; categoryId = 7 }
        | 512 -> Some { ItemTypeGroupData.id = 512; categoryId = 7 }
        | 514 -> Some { ItemTypeGroupData.id = 514; categoryId = 7 }
        | 515 -> Some { ItemTypeGroupData.id = 515; categoryId = 7 }
        | 518 -> Some { ItemTypeGroupData.id = 518; categoryId = 7 }
        | 524 -> Some { ItemTypeGroupData.id = 524; categoryId = 7 }
        | 538 -> Some { ItemTypeGroupData.id = 538; categoryId = 7 }
        | 546 -> Some { ItemTypeGroupData.id = 546; categoryId = 7 }
        | 585 -> Some { ItemTypeGroupData.id = 585; categoryId = 7 }
        | 586 -> Some { ItemTypeGroupData.id = 586; categoryId = 7 }
        | 588 -> Some { ItemTypeGroupData.id = 588; categoryId = 7 }
        | 589 -> Some { ItemTypeGroupData.id = 589; categoryId = 7 }
        | 590 -> Some { ItemTypeGroupData.id = 590; categoryId = 7 }
        | 638 -> Some { ItemTypeGroupData.id = 638; categoryId = 7 }
        | 642 -> Some { ItemTypeGroupData.id = 642; categoryId = 7 }
        | 644 -> Some { ItemTypeGroupData.id = 644; categoryId = 7 }
        | 645 -> Some { ItemTypeGroupData.id = 645; categoryId = 7 }
        | 646 -> Some { ItemTypeGroupData.id = 646; categoryId = 7 }
        | 647 -> Some { ItemTypeGroupData.id = 647; categoryId = 7 }
        | 650 -> Some { ItemTypeGroupData.id = 650; categoryId = 7 }
        | 658 -> Some { ItemTypeGroupData.id = 658; categoryId = 7 }
        | 660 -> Some { ItemTypeGroupData.id = 660; categoryId = 7 }
        | 737 -> Some { ItemTypeGroupData.id = 737; categoryId = 7 }
        | 753 -> Some { ItemTypeGroupData.id = 753; categoryId = 7 }
        | 762 -> Some { ItemTypeGroupData.id = 762; categoryId = 7 }
        | 763 -> Some { ItemTypeGroupData.id = 763; categoryId = 7 }
        | 764 -> Some { ItemTypeGroupData.id = 764; categoryId = 7 }
        | 765 -> Some { ItemTypeGroupData.id = 765; categoryId = 7 }
        | 766 -> Some { ItemTypeGroupData.id = 766; categoryId = 7 }
        | 767 -> Some { ItemTypeGroupData.id = 767; categoryId = 7 }
        | 768 -> Some { ItemTypeGroupData.id = 768; categoryId = 7 }
        | 769 -> Some { ItemTypeGroupData.id = 769; categoryId = 7 }
        | 770 -> Some { ItemTypeGroupData.id = 770; categoryId = 7 }
        | 771 -> Some { ItemTypeGroupData.id = 771; categoryId = 7 }
        | 773 -> Some { ItemTypeGroupData.id = 773; categoryId = 7 }
        | 774 -> Some { ItemTypeGroupData.id = 774; categoryId = 7 }
        | 775 -> Some { ItemTypeGroupData.id = 775; categoryId = 7 }
        | 776 -> Some { ItemTypeGroupData.id = 776; categoryId = 7 }
        | 777 -> Some { ItemTypeGroupData.id = 777; categoryId = 7 }
        | 778 -> Some { ItemTypeGroupData.id = 778; categoryId = 7 }
        | 779 -> Some { ItemTypeGroupData.id = 779; categoryId = 7 }
        | 781 -> Some { ItemTypeGroupData.id = 781; categoryId = 7 }
        | 782 -> Some { ItemTypeGroupData.id = 782; categoryId = 7 }
        | 786 -> Some { ItemTypeGroupData.id = 786; categoryId = 7 }
        | 815 -> Some { ItemTypeGroupData.id = 815; categoryId = 7 }
        | 842 -> Some { ItemTypeGroupData.id = 842; categoryId = 7 }
        | 862 -> Some { ItemTypeGroupData.id = 862; categoryId = 7 }
        | 878 -> Some { ItemTypeGroupData.id = 878; categoryId = 7 }
        | 896 -> Some { ItemTypeGroupData.id = 896; categoryId = 7 }
        | 899 -> Some { ItemTypeGroupData.id = 899; categoryId = 7 }
        | 901 -> Some { ItemTypeGroupData.id = 901; categoryId = 7 }
        | 904 -> Some { ItemTypeGroupData.id = 904; categoryId = 7 }
        | 905 -> Some { ItemTypeGroupData.id = 905; categoryId = 7 }
        | 1122 -> Some { ItemTypeGroupData.id = 1122; categoryId = 7 }
        | 1150 -> Some { ItemTypeGroupData.id = 1150; categoryId = 7 }
        | 1154 -> Some { ItemTypeGroupData.id = 1154; categoryId = 7 }
        | 1156 -> Some { ItemTypeGroupData.id = 1156; categoryId = 7 }
        | 1189 -> Some { ItemTypeGroupData.id = 1189; categoryId = 7 }
        | 1199 -> Some { ItemTypeGroupData.id = 1199; categoryId = 7 }
        | 1223 -> Some { ItemTypeGroupData.id = 1223; categoryId = 7 }
        | 1226 -> Some { ItemTypeGroupData.id = 1226; categoryId = 7 }
        | 1232 -> Some { ItemTypeGroupData.id = 1232; categoryId = 7 }
        | 1233 -> Some { ItemTypeGroupData.id = 1233; categoryId = 7 }
        | 1234 -> Some { ItemTypeGroupData.id = 1234; categoryId = 7 }
        | 1238 -> Some { ItemTypeGroupData.id = 1238; categoryId = 7 }
        | 1245 -> Some { ItemTypeGroupData.id = 1245; categoryId = 7 }
        | 1289 -> Some { ItemTypeGroupData.id = 1289; categoryId = 7 }
        | 1292 -> Some { ItemTypeGroupData.id = 1292; categoryId = 7 }
        | 1299 -> Some { ItemTypeGroupData.id = 1299; categoryId = 7 }
        | 1306 -> Some { ItemTypeGroupData.id = 1306; categoryId = 7 }
        | 1308 -> Some { ItemTypeGroupData.id = 1308; categoryId = 7 }
        | 1313 -> Some { ItemTypeGroupData.id = 1313; categoryId = 7 }
        | 1395 -> Some { ItemTypeGroupData.id = 1395; categoryId = 7 }
        | 1396 -> Some { ItemTypeGroupData.id = 1396; categoryId = 7 }
        | 1533 -> Some { ItemTypeGroupData.id = 1533; categoryId = 7 }
        | 1672 -> Some { ItemTypeGroupData.id = 1672; categoryId = 7 }
        | 1673 -> Some { ItemTypeGroupData.id = 1673; categoryId = 7 }
        | 1674 -> Some { ItemTypeGroupData.id = 1674; categoryId = 7 }
        | 1697 -> Some { ItemTypeGroupData.id = 1697; categoryId = 7 }
        | 1698 -> Some { ItemTypeGroupData.id = 1698; categoryId = 7 }
        | 1699 -> Some { ItemTypeGroupData.id = 1699; categoryId = 7 }
        | 1700 -> Some { ItemTypeGroupData.id = 1700; categoryId = 7 }
        | 1706 -> Some { ItemTypeGroupData.id = 1706; categoryId = 7 }
        | 1770 -> Some { ItemTypeGroupData.id = 1770; categoryId = 7 }
        | 1815 -> Some { ItemTypeGroupData.id = 1815; categoryId = 7 }
        | 1894 -> Some { ItemTypeGroupData.id = 1894; categoryId = 7 }
        | 1969 -> Some { ItemTypeGroupData.id = 1969; categoryId = 7 }
        | 1986 -> Some { ItemTypeGroupData.id = 1986; categoryId = 7 }
        | 1988 -> Some { ItemTypeGroupData.id = 1988; categoryId = 7 }
        | 2003 -> Some { ItemTypeGroupData.id = 2003; categoryId = 7 }
        | 2004 -> Some { ItemTypeGroupData.id = 2004; categoryId = 7 }
        | 2008 -> Some { ItemTypeGroupData.id = 2008; categoryId = 7 }
        | 2013 -> Some { ItemTypeGroupData.id = 2013; categoryId = 7 }
        | 83 -> Some { ItemTypeGroupData.id = 83; categoryId = 8 }
        | 85 -> Some { ItemTypeGroupData.id = 85; categoryId = 8 }
        | 86 -> Some { ItemTypeGroupData.id = 86; categoryId = 8 }
        | 87 -> Some { ItemTypeGroupData.id = 87; categoryId = 8 }
        | 88 -> Some { ItemTypeGroupData.id = 88; categoryId = 8 }
        | 89 -> Some { ItemTypeGroupData.id = 89; categoryId = 8 }
        | 90 -> Some { ItemTypeGroupData.id = 90; categoryId = 8 }
        | 92 -> Some { ItemTypeGroupData.id = 92; categoryId = 8 }
        | 372 -> Some { ItemTypeGroupData.id = 372; categoryId = 8 }
        | 373 -> Some { ItemTypeGroupData.id = 373; categoryId = 8 }
        | 374 -> Some { ItemTypeGroupData.id = 374; categoryId = 8 }
        | 375 -> Some { ItemTypeGroupData.id = 375; categoryId = 8 }
        | 376 -> Some { ItemTypeGroupData.id = 376; categoryId = 8 }
        | 377 -> Some { ItemTypeGroupData.id = 377; categoryId = 8 }
        | 384 -> Some { ItemTypeGroupData.id = 384; categoryId = 8 }
        | 385 -> Some { ItemTypeGroupData.id = 385; categoryId = 8 }
        | 386 -> Some { ItemTypeGroupData.id = 386; categoryId = 8 }
        | 387 -> Some { ItemTypeGroupData.id = 387; categoryId = 8 }
        | 394 -> Some { ItemTypeGroupData.id = 394; categoryId = 8 }
        | 395 -> Some { ItemTypeGroupData.id = 395; categoryId = 8 }
        | 396 -> Some { ItemTypeGroupData.id = 396; categoryId = 8 }
        | 425 -> Some { ItemTypeGroupData.id = 425; categoryId = 8 }
        | 476 -> Some { ItemTypeGroupData.id = 476; categoryId = 8 }
        | 479 -> Some { ItemTypeGroupData.id = 479; categoryId = 8 }
        | 482 -> Some { ItemTypeGroupData.id = 482; categoryId = 8 }
        | 492 -> Some { ItemTypeGroupData.id = 492; categoryId = 8 }
        | 497 -> Some { ItemTypeGroupData.id = 497; categoryId = 8 }
        | 498 -> Some { ItemTypeGroupData.id = 498; categoryId = 8 }
        | 500 -> Some { ItemTypeGroupData.id = 500; categoryId = 8 }
        | 548 -> Some { ItemTypeGroupData.id = 548; categoryId = 8 }
        | 648 -> Some { ItemTypeGroupData.id = 648; categoryId = 8 }
        | 653 -> Some { ItemTypeGroupData.id = 653; categoryId = 8 }
        | 654 -> Some { ItemTypeGroupData.id = 654; categoryId = 8 }
        | 655 -> Some { ItemTypeGroupData.id = 655; categoryId = 8 }
        | 656 -> Some { ItemTypeGroupData.id = 656; categoryId = 8 }
        | 657 -> Some { ItemTypeGroupData.id = 657; categoryId = 8 }
        | 663 -> Some { ItemTypeGroupData.id = 663; categoryId = 8 }
        | 772 -> Some { ItemTypeGroupData.id = 772; categoryId = 8 }
        | 863 -> Some { ItemTypeGroupData.id = 863; categoryId = 8 }
        | 864 -> Some { ItemTypeGroupData.id = 864; categoryId = 8 }
        | 892 -> Some { ItemTypeGroupData.id = 892; categoryId = 8 }
        | 907 -> Some { ItemTypeGroupData.id = 907; categoryId = 8 }
        | 908 -> Some { ItemTypeGroupData.id = 908; categoryId = 8 }
        | 909 -> Some { ItemTypeGroupData.id = 909; categoryId = 8 }
        | 910 -> Some { ItemTypeGroupData.id = 910; categoryId = 8 }
        | 911 -> Some { ItemTypeGroupData.id = 911; categoryId = 8 }
        | 916 -> Some { ItemTypeGroupData.id = 916; categoryId = 8 }
        | 972 -> Some { ItemTypeGroupData.id = 972; categoryId = 8 }
        | 1010 -> Some { ItemTypeGroupData.id = 1010; categoryId = 8 }
        | 1019 -> Some { ItemTypeGroupData.id = 1019; categoryId = 8 }
        | 1153 -> Some { ItemTypeGroupData.id = 1153; categoryId = 8 }
        | 1158 -> Some { ItemTypeGroupData.id = 1158; categoryId = 8 }
        | 1400 -> Some { ItemTypeGroupData.id = 1400; categoryId = 8 }
        | 1546 -> Some { ItemTypeGroupData.id = 1546; categoryId = 8 }
        | 1547 -> Some { ItemTypeGroupData.id = 1547; categoryId = 8 }
        | 1548 -> Some { ItemTypeGroupData.id = 1548; categoryId = 8 }
        | 1549 -> Some { ItemTypeGroupData.id = 1549; categoryId = 8 }
        | 1550 -> Some { ItemTypeGroupData.id = 1550; categoryId = 8 }
        | 1551 -> Some { ItemTypeGroupData.id = 1551; categoryId = 8 }
        | 1559 -> Some { ItemTypeGroupData.id = 1559; categoryId = 8 }
        | 1569 -> Some { ItemTypeGroupData.id = 1569; categoryId = 8 }
        | 1677 -> Some { ItemTypeGroupData.id = 1677; categoryId = 8 }
        | 1678 -> Some { ItemTypeGroupData.id = 1678; categoryId = 8 }
        | 1701 -> Some { ItemTypeGroupData.id = 1701; categoryId = 8 }
        | 1702 -> Some { ItemTypeGroupData.id = 1702; categoryId = 8 }
        | 1769 -> Some { ItemTypeGroupData.id = 1769; categoryId = 8 }
        | 1771 -> Some { ItemTypeGroupData.id = 1771; categoryId = 8 }
        | 1772 -> Some { ItemTypeGroupData.id = 1772; categoryId = 8 }
        | 1773 -> Some { ItemTypeGroupData.id = 1773; categoryId = 8 }
        | 1774 -> Some { ItemTypeGroupData.id = 1774; categoryId = 8 }
        | 1976 -> Some { ItemTypeGroupData.id = 1976; categoryId = 8 }
        | 1987 -> Some { ItemTypeGroupData.id = 1987; categoryId = 8 }
        | 1989 -> Some { ItemTypeGroupData.id = 1989; categoryId = 8 }
        | 104 -> Some { ItemTypeGroupData.id = 104; categoryId = 9 }
        | 105 -> Some { ItemTypeGroupData.id = 105; categoryId = 9 }
        | 106 -> Some { ItemTypeGroupData.id = 106; categoryId = 9 }
        | 107 -> Some { ItemTypeGroupData.id = 107; categoryId = 9 }
        | 108 -> Some { ItemTypeGroupData.id = 108; categoryId = 9 }
        | 109 -> Some { ItemTypeGroupData.id = 109; categoryId = 9 }
        | 110 -> Some { ItemTypeGroupData.id = 110; categoryId = 9 }
        | 111 -> Some { ItemTypeGroupData.id = 111; categoryId = 9 }
        | 118 -> Some { ItemTypeGroupData.id = 118; categoryId = 9 }
        | 119 -> Some { ItemTypeGroupData.id = 119; categoryId = 9 }
        | 120 -> Some { ItemTypeGroupData.id = 120; categoryId = 9 }
        | 121 -> Some { ItemTypeGroupData.id = 121; categoryId = 9 }
        | 123 -> Some { ItemTypeGroupData.id = 123; categoryId = 9 }
        | 126 -> Some { ItemTypeGroupData.id = 126; categoryId = 9 }
        | 127 -> Some { ItemTypeGroupData.id = 127; categoryId = 9 }
        | 128 -> Some { ItemTypeGroupData.id = 128; categoryId = 9 }
        | 129 -> Some { ItemTypeGroupData.id = 129; categoryId = 9 }
        | 130 -> Some { ItemTypeGroupData.id = 130; categoryId = 9 }
        | 131 -> Some { ItemTypeGroupData.id = 131; categoryId = 9 }
        | 132 -> Some { ItemTypeGroupData.id = 132; categoryId = 9 }
        | 133 -> Some { ItemTypeGroupData.id = 133; categoryId = 9 }
        | 134 -> Some { ItemTypeGroupData.id = 134; categoryId = 9 }
        | 135 -> Some { ItemTypeGroupData.id = 135; categoryId = 9 }
        | 136 -> Some { ItemTypeGroupData.id = 136; categoryId = 9 }
        | 137 -> Some { ItemTypeGroupData.id = 137; categoryId = 9 }
        | 139 -> Some { ItemTypeGroupData.id = 139; categoryId = 9 }
        | 140 -> Some { ItemTypeGroupData.id = 140; categoryId = 9 }
        | 141 -> Some { ItemTypeGroupData.id = 141; categoryId = 9 }
        | 142 -> Some { ItemTypeGroupData.id = 142; categoryId = 9 }
        | 143 -> Some { ItemTypeGroupData.id = 143; categoryId = 9 }
        | 145 -> Some { ItemTypeGroupData.id = 145; categoryId = 9 }
        | 147 -> Some { ItemTypeGroupData.id = 147; categoryId = 9 }
        | 148 -> Some { ItemTypeGroupData.id = 148; categoryId = 9 }
        | 151 -> Some { ItemTypeGroupData.id = 151; categoryId = 9 }
        | 152 -> Some { ItemTypeGroupData.id = 152; categoryId = 9 }
        | 154 -> Some { ItemTypeGroupData.id = 154; categoryId = 9 }
        | 156 -> Some { ItemTypeGroupData.id = 156; categoryId = 9 }
        | 157 -> Some { ItemTypeGroupData.id = 157; categoryId = 9 }
        | 158 -> Some { ItemTypeGroupData.id = 158; categoryId = 9 }
        | 160 -> Some { ItemTypeGroupData.id = 160; categoryId = 9 }
        | 161 -> Some { ItemTypeGroupData.id = 161; categoryId = 9 }
        | 162 -> Some { ItemTypeGroupData.id = 162; categoryId = 9 }
        | 163 -> Some { ItemTypeGroupData.id = 163; categoryId = 9 }
        | 165 -> Some { ItemTypeGroupData.id = 165; categoryId = 9 }
        | 166 -> Some { ItemTypeGroupData.id = 166; categoryId = 9 }
        | 167 -> Some { ItemTypeGroupData.id = 167; categoryId = 9 }
        | 168 -> Some { ItemTypeGroupData.id = 168; categoryId = 9 }
        | 169 -> Some { ItemTypeGroupData.id = 169; categoryId = 9 }
        | 170 -> Some { ItemTypeGroupData.id = 170; categoryId = 9 }
        | 172 -> Some { ItemTypeGroupData.id = 172; categoryId = 9 }
        | 174 -> Some { ItemTypeGroupData.id = 174; categoryId = 9 }
        | 175 -> Some { ItemTypeGroupData.id = 175; categoryId = 9 }
        | 176 -> Some { ItemTypeGroupData.id = 176; categoryId = 9 }
        | 177 -> Some { ItemTypeGroupData.id = 177; categoryId = 9 }
        | 178 -> Some { ItemTypeGroupData.id = 178; categoryId = 9 }
        | 218 -> Some { ItemTypeGroupData.id = 218; categoryId = 9 }
        | 223 -> Some { ItemTypeGroupData.id = 223; categoryId = 9 }
        | 224 -> Some { ItemTypeGroupData.id = 224; categoryId = 9 }
        | 296 -> Some { ItemTypeGroupData.id = 296; categoryId = 9 }
        | 342 -> Some { ItemTypeGroupData.id = 342; categoryId = 9 }
        | 343 -> Some { ItemTypeGroupData.id = 343; categoryId = 9 }
        | 344 -> Some { ItemTypeGroupData.id = 344; categoryId = 9 }
        | 345 -> Some { ItemTypeGroupData.id = 345; categoryId = 9 }
        | 346 -> Some { ItemTypeGroupData.id = 346; categoryId = 9 }
        | 347 -> Some { ItemTypeGroupData.id = 347; categoryId = 9 }
        | 348 -> Some { ItemTypeGroupData.id = 348; categoryId = 9 }
        | 349 -> Some { ItemTypeGroupData.id = 349; categoryId = 9 }
        | 350 -> Some { ItemTypeGroupData.id = 350; categoryId = 9 }
        | 352 -> Some { ItemTypeGroupData.id = 352; categoryId = 9 }
        | 356 -> Some { ItemTypeGroupData.id = 356; categoryId = 9 }
        | 360 -> Some { ItemTypeGroupData.id = 360; categoryId = 9 }
        | 371 -> Some { ItemTypeGroupData.id = 371; categoryId = 9 }
        | 400 -> Some { ItemTypeGroupData.id = 400; categoryId = 9 }
        | 401 -> Some { ItemTypeGroupData.id = 401; categoryId = 9 }
        | 408 -> Some { ItemTypeGroupData.id = 408; categoryId = 9 }
        | 410 -> Some { ItemTypeGroupData.id = 410; categoryId = 9 }
        | 447 -> Some { ItemTypeGroupData.id = 447; categoryId = 9 }
        | 477 -> Some { ItemTypeGroupData.id = 477; categoryId = 9 }
        | 478 -> Some { ItemTypeGroupData.id = 478; categoryId = 9 }
        | 486 -> Some { ItemTypeGroupData.id = 486; categoryId = 9 }
        | 487 -> Some { ItemTypeGroupData.id = 487; categoryId = 9 }
        | 489 -> Some { ItemTypeGroupData.id = 489; categoryId = 9 }
        | 490 -> Some { ItemTypeGroupData.id = 490; categoryId = 9 }
        | 503 -> Some { ItemTypeGroupData.id = 503; categoryId = 9 }
        | 504 -> Some { ItemTypeGroupData.id = 504; categoryId = 9 }
        | 516 -> Some { ItemTypeGroupData.id = 516; categoryId = 9 }
        | 525 -> Some { ItemTypeGroupData.id = 525; categoryId = 9 }
        | 532 -> Some { ItemTypeGroupData.id = 532; categoryId = 9 }
        | 535 -> Some { ItemTypeGroupData.id = 535; categoryId = 9 }
        | 537 -> Some { ItemTypeGroupData.id = 537; categoryId = 9 }
        | 643 -> Some { ItemTypeGroupData.id = 643; categoryId = 9 }
        | 651 -> Some { ItemTypeGroupData.id = 651; categoryId = 9 }
        | 718 -> Some { ItemTypeGroupData.id = 718; categoryId = 9 }
        | 722 -> Some { ItemTypeGroupData.id = 722; categoryId = 9 }
        | 723 -> Some { ItemTypeGroupData.id = 723; categoryId = 9 }
        | 724 -> Some { ItemTypeGroupData.id = 724; categoryId = 9 }
        | 725 -> Some { ItemTypeGroupData.id = 725; categoryId = 9 }
        | 726 -> Some { ItemTypeGroupData.id = 726; categoryId = 9 }
        | 727 -> Some { ItemTypeGroupData.id = 727; categoryId = 9 }
        | 787 -> Some { ItemTypeGroupData.id = 787; categoryId = 9 }
        | 841 -> Some { ItemTypeGroupData.id = 841; categoryId = 9 }
        | 853 -> Some { ItemTypeGroupData.id = 853; categoryId = 9 }
        | 854 -> Some { ItemTypeGroupData.id = 854; categoryId = 9 }
        | 855 -> Some { ItemTypeGroupData.id = 855; categoryId = 9 }
        | 856 -> Some { ItemTypeGroupData.id = 856; categoryId = 9 }
        | 857 -> Some { ItemTypeGroupData.id = 857; categoryId = 9 }
        | 858 -> Some { ItemTypeGroupData.id = 858; categoryId = 9 }
        | 859 -> Some { ItemTypeGroupData.id = 859; categoryId = 9 }
        | 860 -> Some { ItemTypeGroupData.id = 860; categoryId = 9 }
        | 870 -> Some { ItemTypeGroupData.id = 870; categoryId = 9 }
        | 871 -> Some { ItemTypeGroupData.id = 871; categoryId = 9 }
        | 888 -> Some { ItemTypeGroupData.id = 888; categoryId = 9 }
        | 889 -> Some { ItemTypeGroupData.id = 889; categoryId = 9 }
        | 890 -> Some { ItemTypeGroupData.id = 890; categoryId = 9 }
        | 891 -> Some { ItemTypeGroupData.id = 891; categoryId = 9 }
        | 912 -> Some { ItemTypeGroupData.id = 912; categoryId = 9 }
        | 914 -> Some { ItemTypeGroupData.id = 914; categoryId = 9 }
        | 915 -> Some { ItemTypeGroupData.id = 915; categoryId = 9 }
        | 917 -> Some { ItemTypeGroupData.id = 917; categoryId = 9 }
        | 918 -> Some { ItemTypeGroupData.id = 918; categoryId = 9 }
        | 944 -> Some { ItemTypeGroupData.id = 944; categoryId = 9 }
        | 945 -> Some { ItemTypeGroupData.id = 945; categoryId = 9 }
        | 965 -> Some { ItemTypeGroupData.id = 965; categoryId = 9 }
        | 973 -> Some { ItemTypeGroupData.id = 973; categoryId = 9 }
        | 996 -> Some { ItemTypeGroupData.id = 996; categoryId = 9 }
        | 1013 -> Some { ItemTypeGroupData.id = 1013; categoryId = 9 }
        | 1045 -> Some { ItemTypeGroupData.id = 1045; categoryId = 9 }
        | 1046 -> Some { ItemTypeGroupData.id = 1046; categoryId = 9 }
        | 1048 -> Some { ItemTypeGroupData.id = 1048; categoryId = 9 }
        | 1123 -> Some { ItemTypeGroupData.id = 1123; categoryId = 9 }
        | 1137 -> Some { ItemTypeGroupData.id = 1137; categoryId = 9 }
        | 1139 -> Some { ItemTypeGroupData.id = 1139; categoryId = 9 }
        | 1142 -> Some { ItemTypeGroupData.id = 1142; categoryId = 9 }
        | 1143 -> Some { ItemTypeGroupData.id = 1143; categoryId = 9 }
        | 1144 -> Some { ItemTypeGroupData.id = 1144; categoryId = 9 }
        | 1145 -> Some { ItemTypeGroupData.id = 1145; categoryId = 9 }
        | 1146 -> Some { ItemTypeGroupData.id = 1146; categoryId = 9 }
        | 1147 -> Some { ItemTypeGroupData.id = 1147; categoryId = 9 }
        | 1151 -> Some { ItemTypeGroupData.id = 1151; categoryId = 9 }
        | 1152 -> Some { ItemTypeGroupData.id = 1152; categoryId = 9 }
        | 1155 -> Some { ItemTypeGroupData.id = 1155; categoryId = 9 }
        | 1157 -> Some { ItemTypeGroupData.id = 1157; categoryId = 9 }
        | 1160 -> Some { ItemTypeGroupData.id = 1160; categoryId = 9 }
        | 1162 -> Some { ItemTypeGroupData.id = 1162; categoryId = 9 }
        | 1190 -> Some { ItemTypeGroupData.id = 1190; categoryId = 9 }
        | 1191 -> Some { ItemTypeGroupData.id = 1191; categoryId = 9 }
        | 1197 -> Some { ItemTypeGroupData.id = 1197; categoryId = 9 }
        | 1200 -> Some { ItemTypeGroupData.id = 1200; categoryId = 9 }
        | 1222 -> Some { ItemTypeGroupData.id = 1222; categoryId = 9 }
        | 1224 -> Some { ItemTypeGroupData.id = 1224; categoryId = 9 }
        | 1227 -> Some { ItemTypeGroupData.id = 1227; categoryId = 9 }
        | 1239 -> Some { ItemTypeGroupData.id = 1239; categoryId = 9 }
        | 1267 -> Some { ItemTypeGroupData.id = 1267; categoryId = 9 }
        | 1268 -> Some { ItemTypeGroupData.id = 1268; categoryId = 9 }
        | 1269 -> Some { ItemTypeGroupData.id = 1269; categoryId = 9 }
        | 1270 -> Some { ItemTypeGroupData.id = 1270; categoryId = 9 }
        | 1277 -> Some { ItemTypeGroupData.id = 1277; categoryId = 9 }
        | 1293 -> Some { ItemTypeGroupData.id = 1293; categoryId = 9 }
        | 1294 -> Some { ItemTypeGroupData.id = 1294; categoryId = 9 }
        | 1295 -> Some { ItemTypeGroupData.id = 1295; categoryId = 9 }
        | 1309 -> Some { ItemTypeGroupData.id = 1309; categoryId = 9 }
        | 1317 -> Some { ItemTypeGroupData.id = 1317; categoryId = 9 }
        | 1318 -> Some { ItemTypeGroupData.id = 1318; categoryId = 9 }
        | 1397 -> Some { ItemTypeGroupData.id = 1397; categoryId = 9 }
        | 1399 -> Some { ItemTypeGroupData.id = 1399; categoryId = 9 }
        | 1461 -> Some { ItemTypeGroupData.id = 1461; categoryId = 9 }
        | 1462 -> Some { ItemTypeGroupData.id = 1462; categoryId = 9 }
        | 1542 -> Some { ItemTypeGroupData.id = 1542; categoryId = 9 }
        | 1543 -> Some { ItemTypeGroupData.id = 1543; categoryId = 9 }
        | 1679 -> Some { ItemTypeGroupData.id = 1679; categoryId = 9 }
        | 1703 -> Some { ItemTypeGroupData.id = 1703; categoryId = 9 }
        | 1707 -> Some { ItemTypeGroupData.id = 1707; categoryId = 9 }
        | 1708 -> Some { ItemTypeGroupData.id = 1708; categoryId = 9 }
        | 1709 -> Some { ItemTypeGroupData.id = 1709; categoryId = 9 }
        | 1718 -> Some { ItemTypeGroupData.id = 1718; categoryId = 9 }
        | 1723 -> Some { ItemTypeGroupData.id = 1723; categoryId = 9 }
        | 1810 -> Some { ItemTypeGroupData.id = 1810; categoryId = 9 }
        | 1812 -> Some { ItemTypeGroupData.id = 1812; categoryId = 9 }
        | 1888 -> Some { ItemTypeGroupData.id = 1888; categoryId = 9 }
        | 1889 -> Some { ItemTypeGroupData.id = 1889; categoryId = 9 }
        | 1890 -> Some { ItemTypeGroupData.id = 1890; categoryId = 9 }
        | 1891 -> Some { ItemTypeGroupData.id = 1891; categoryId = 9 }
        | 1948 -> Some { ItemTypeGroupData.id = 1948; categoryId = 9 }
        | 1990 -> Some { ItemTypeGroupData.id = 1990; categoryId = 9 }
        | 1992 -> Some { ItemTypeGroupData.id = 1992; categoryId = 9 }
        | 1993 -> Some { ItemTypeGroupData.id = 1993; categoryId = 9 }
        | 1994 -> Some { ItemTypeGroupData.id = 1994; categoryId = 9 }
        | 2010 -> Some { ItemTypeGroupData.id = 2010; categoryId = 9 }
        | 94 -> Some { ItemTypeGroupData.id = 94; categoryId = 10 }
        | 95 -> Some { ItemTypeGroupData.id = 95; categoryId = 10 }
        | 99 -> Some { ItemTypeGroupData.id = 99; categoryId = 11 }
        | 180 -> Some { ItemTypeGroupData.id = 180; categoryId = 11 }
        | 182 -> Some { ItemTypeGroupData.id = 182; categoryId = 11 }
        | 185 -> Some { ItemTypeGroupData.id = 185; categoryId = 11 }
        | 279 -> Some { ItemTypeGroupData.id = 279; categoryId = 11 }
        | 286 -> Some { ItemTypeGroupData.id = 286; categoryId = 11 }
        | 287 -> Some { ItemTypeGroupData.id = 287; categoryId = 11 }
        | 288 -> Some { ItemTypeGroupData.id = 288; categoryId = 11 }
        | 297 -> Some { ItemTypeGroupData.id = 297; categoryId = 11 }
        | 298 -> Some { ItemTypeGroupData.id = 298; categoryId = 11 }
        | 301 -> Some { ItemTypeGroupData.id = 301; categoryId = 11 }
        | 306 -> Some { ItemTypeGroupData.id = 306; categoryId = 11 }
        | 319 -> Some { ItemTypeGroupData.id = 319; categoryId = 11 }
        | 323 -> Some { ItemTypeGroupData.id = 323; categoryId = 11 }
        | 335 -> Some { ItemTypeGroupData.id = 335; categoryId = 11 }
        | 337 -> Some { ItemTypeGroupData.id = 337; categoryId = 11 }
        | 383 -> Some { ItemTypeGroupData.id = 383; categoryId = 11 }
        | 435 -> Some { ItemTypeGroupData.id = 435; categoryId = 11 }
        | 446 -> Some { ItemTypeGroupData.id = 446; categoryId = 11 }
        | 494 -> Some { ItemTypeGroupData.id = 494; categoryId = 11 }
        | 495 -> Some { ItemTypeGroupData.id = 495; categoryId = 11 }
        | 496 -> Some { ItemTypeGroupData.id = 496; categoryId = 11 }
        | 520 -> Some { ItemTypeGroupData.id = 520; categoryId = 11 }
        | 522 -> Some { ItemTypeGroupData.id = 522; categoryId = 11 }
        | 523 -> Some { ItemTypeGroupData.id = 523; categoryId = 11 }
        | 527 -> Some { ItemTypeGroupData.id = 527; categoryId = 11 }
        | 533 -> Some { ItemTypeGroupData.id = 533; categoryId = 11 }
        | 534 -> Some { ItemTypeGroupData.id = 534; categoryId = 11 }
        | 550 -> Some { ItemTypeGroupData.id = 550; categoryId = 11 }
        | 551 -> Some { ItemTypeGroupData.id = 551; categoryId = 11 }
        | 552 -> Some { ItemTypeGroupData.id = 552; categoryId = 11 }
        | 553 -> Some { ItemTypeGroupData.id = 553; categoryId = 11 }
        | 554 -> Some { ItemTypeGroupData.id = 554; categoryId = 11 }
        | 555 -> Some { ItemTypeGroupData.id = 555; categoryId = 11 }
        | 556 -> Some { ItemTypeGroupData.id = 556; categoryId = 11 }
        | 557 -> Some { ItemTypeGroupData.id = 557; categoryId = 11 }
        | 558 -> Some { ItemTypeGroupData.id = 558; categoryId = 11 }
        | 559 -> Some { ItemTypeGroupData.id = 559; categoryId = 11 }
        | 560 -> Some { ItemTypeGroupData.id = 560; categoryId = 11 }
        | 561 -> Some { ItemTypeGroupData.id = 561; categoryId = 11 }
        | 562 -> Some { ItemTypeGroupData.id = 562; categoryId = 11 }
        | 563 -> Some { ItemTypeGroupData.id = 563; categoryId = 11 }
        | 564 -> Some { ItemTypeGroupData.id = 564; categoryId = 11 }
        | 565 -> Some { ItemTypeGroupData.id = 565; categoryId = 11 }
        | 566 -> Some { ItemTypeGroupData.id = 566; categoryId = 11 }
        | 567 -> Some { ItemTypeGroupData.id = 567; categoryId = 11 }
        | 568 -> Some { ItemTypeGroupData.id = 568; categoryId = 11 }
        | 569 -> Some { ItemTypeGroupData.id = 569; categoryId = 11 }
        | 570 -> Some { ItemTypeGroupData.id = 570; categoryId = 11 }
        | 571 -> Some { ItemTypeGroupData.id = 571; categoryId = 11 }
        | 572 -> Some { ItemTypeGroupData.id = 572; categoryId = 11 }
        | 573 -> Some { ItemTypeGroupData.id = 573; categoryId = 11 }
        | 574 -> Some { ItemTypeGroupData.id = 574; categoryId = 11 }
        | 575 -> Some { ItemTypeGroupData.id = 575; categoryId = 11 }
        | 576 -> Some { ItemTypeGroupData.id = 576; categoryId = 11 }
        | 577 -> Some { ItemTypeGroupData.id = 577; categoryId = 11 }
        | 578 -> Some { ItemTypeGroupData.id = 578; categoryId = 11 }
        | 579 -> Some { ItemTypeGroupData.id = 579; categoryId = 11 }
        | 580 -> Some { ItemTypeGroupData.id = 580; categoryId = 11 }
        | 581 -> Some { ItemTypeGroupData.id = 581; categoryId = 11 }
        | 582 -> Some { ItemTypeGroupData.id = 582; categoryId = 11 }
        | 583 -> Some { ItemTypeGroupData.id = 583; categoryId = 11 }
        | 584 -> Some { ItemTypeGroupData.id = 584; categoryId = 11 }
        | 593 -> Some { ItemTypeGroupData.id = 593; categoryId = 11 }
        | 594 -> Some { ItemTypeGroupData.id = 594; categoryId = 11 }
        | 595 -> Some { ItemTypeGroupData.id = 595; categoryId = 11 }
        | 596 -> Some { ItemTypeGroupData.id = 596; categoryId = 11 }
        | 597 -> Some { ItemTypeGroupData.id = 597; categoryId = 11 }
        | 602 -> Some { ItemTypeGroupData.id = 602; categoryId = 11 }
        | 603 -> Some { ItemTypeGroupData.id = 603; categoryId = 11 }
        | 604 -> Some { ItemTypeGroupData.id = 604; categoryId = 11 }
        | 605 -> Some { ItemTypeGroupData.id = 605; categoryId = 11 }
        | 606 -> Some { ItemTypeGroupData.id = 606; categoryId = 11 }
        | 611 -> Some { ItemTypeGroupData.id = 611; categoryId = 11 }
        | 612 -> Some { ItemTypeGroupData.id = 612; categoryId = 11 }
        | 613 -> Some { ItemTypeGroupData.id = 613; categoryId = 11 }
        | 614 -> Some { ItemTypeGroupData.id = 614; categoryId = 11 }
        | 615 -> Some { ItemTypeGroupData.id = 615; categoryId = 11 }
        | 620 -> Some { ItemTypeGroupData.id = 620; categoryId = 11 }
        | 621 -> Some { ItemTypeGroupData.id = 621; categoryId = 11 }
        | 622 -> Some { ItemTypeGroupData.id = 622; categoryId = 11 }
        | 623 -> Some { ItemTypeGroupData.id = 623; categoryId = 11 }
        | 624 -> Some { ItemTypeGroupData.id = 624; categoryId = 11 }
        | 629 -> Some { ItemTypeGroupData.id = 629; categoryId = 11 }
        | 630 -> Some { ItemTypeGroupData.id = 630; categoryId = 11 }
        | 631 -> Some { ItemTypeGroupData.id = 631; categoryId = 11 }
        | 632 -> Some { ItemTypeGroupData.id = 632; categoryId = 11 }
        | 633 -> Some { ItemTypeGroupData.id = 633; categoryId = 11 }
        | 665 -> Some { ItemTypeGroupData.id = 665; categoryId = 11 }
        | 666 -> Some { ItemTypeGroupData.id = 666; categoryId = 11 }
        | 667 -> Some { ItemTypeGroupData.id = 667; categoryId = 11 }
        | 668 -> Some { ItemTypeGroupData.id = 668; categoryId = 11 }
        | 669 -> Some { ItemTypeGroupData.id = 669; categoryId = 11 }
        | 670 -> Some { ItemTypeGroupData.id = 670; categoryId = 11 }
        | 671 -> Some { ItemTypeGroupData.id = 671; categoryId = 11 }
        | 672 -> Some { ItemTypeGroupData.id = 672; categoryId = 11 }
        | 673 -> Some { ItemTypeGroupData.id = 673; categoryId = 11 }
        | 674 -> Some { ItemTypeGroupData.id = 674; categoryId = 11 }
        | 675 -> Some { ItemTypeGroupData.id = 675; categoryId = 11 }
        | 676 -> Some { ItemTypeGroupData.id = 676; categoryId = 11 }
        | 677 -> Some { ItemTypeGroupData.id = 677; categoryId = 11 }
        | 678 -> Some { ItemTypeGroupData.id = 678; categoryId = 11 }
        | 679 -> Some { ItemTypeGroupData.id = 679; categoryId = 11 }
        | 680 -> Some { ItemTypeGroupData.id = 680; categoryId = 11 }
        | 681 -> Some { ItemTypeGroupData.id = 681; categoryId = 11 }
        | 682 -> Some { ItemTypeGroupData.id = 682; categoryId = 11 }
        | 683 -> Some { ItemTypeGroupData.id = 683; categoryId = 11 }
        | 684 -> Some { ItemTypeGroupData.id = 684; categoryId = 11 }
        | 685 -> Some { ItemTypeGroupData.id = 685; categoryId = 11 }
        | 686 -> Some { ItemTypeGroupData.id = 686; categoryId = 11 }
        | 687 -> Some { ItemTypeGroupData.id = 687; categoryId = 11 }
        | 688 -> Some { ItemTypeGroupData.id = 688; categoryId = 11 }
        | 689 -> Some { ItemTypeGroupData.id = 689; categoryId = 11 }
        | 690 -> Some { ItemTypeGroupData.id = 690; categoryId = 11 }
        | 691 -> Some { ItemTypeGroupData.id = 691; categoryId = 11 }
        | 692 -> Some { ItemTypeGroupData.id = 692; categoryId = 11 }
        | 693 -> Some { ItemTypeGroupData.id = 693; categoryId = 11 }
        | 694 -> Some { ItemTypeGroupData.id = 694; categoryId = 11 }
        | 695 -> Some { ItemTypeGroupData.id = 695; categoryId = 11 }
        | 696 -> Some { ItemTypeGroupData.id = 696; categoryId = 11 }
        | 697 -> Some { ItemTypeGroupData.id = 697; categoryId = 11 }
        | 698 -> Some { ItemTypeGroupData.id = 698; categoryId = 11 }
        | 699 -> Some { ItemTypeGroupData.id = 699; categoryId = 11 }
        | 700 -> Some { ItemTypeGroupData.id = 700; categoryId = 11 }
        | 701 -> Some { ItemTypeGroupData.id = 701; categoryId = 11 }
        | 702 -> Some { ItemTypeGroupData.id = 702; categoryId = 11 }
        | 703 -> Some { ItemTypeGroupData.id = 703; categoryId = 11 }
        | 704 -> Some { ItemTypeGroupData.id = 704; categoryId = 11 }
        | 705 -> Some { ItemTypeGroupData.id = 705; categoryId = 11 }
        | 706 -> Some { ItemTypeGroupData.id = 706; categoryId = 11 }
        | 715 -> Some { ItemTypeGroupData.id = 715; categoryId = 11 }
        | 755 -> Some { ItemTypeGroupData.id = 755; categoryId = 11 }
        | 756 -> Some { ItemTypeGroupData.id = 756; categoryId = 11 }
        | 757 -> Some { ItemTypeGroupData.id = 757; categoryId = 11 }
        | 758 -> Some { ItemTypeGroupData.id = 758; categoryId = 11 }
        | 759 -> Some { ItemTypeGroupData.id = 759; categoryId = 11 }
        | 760 -> Some { ItemTypeGroupData.id = 760; categoryId = 11 }
        | 761 -> Some { ItemTypeGroupData.id = 761; categoryId = 11 }
        | 784 -> Some { ItemTypeGroupData.id = 784; categoryId = 11 }
        | 789 -> Some { ItemTypeGroupData.id = 789; categoryId = 11 }
        | 790 -> Some { ItemTypeGroupData.id = 790; categoryId = 11 }
        | 791 -> Some { ItemTypeGroupData.id = 791; categoryId = 11 }
        | 792 -> Some { ItemTypeGroupData.id = 792; categoryId = 11 }
        | 793 -> Some { ItemTypeGroupData.id = 793; categoryId = 11 }
        | 794 -> Some { ItemTypeGroupData.id = 794; categoryId = 11 }
        | 795 -> Some { ItemTypeGroupData.id = 795; categoryId = 11 }
        | 796 -> Some { ItemTypeGroupData.id = 796; categoryId = 11 }
        | 797 -> Some { ItemTypeGroupData.id = 797; categoryId = 11 }
        | 798 -> Some { ItemTypeGroupData.id = 798; categoryId = 11 }
        | 799 -> Some { ItemTypeGroupData.id = 799; categoryId = 11 }
        | 800 -> Some { ItemTypeGroupData.id = 800; categoryId = 11 }
        | 801 -> Some { ItemTypeGroupData.id = 801; categoryId = 11 }
        | 802 -> Some { ItemTypeGroupData.id = 802; categoryId = 11 }
        | 803 -> Some { ItemTypeGroupData.id = 803; categoryId = 11 }
        | 804 -> Some { ItemTypeGroupData.id = 804; categoryId = 11 }
        | 805 -> Some { ItemTypeGroupData.id = 805; categoryId = 11 }
        | 806 -> Some { ItemTypeGroupData.id = 806; categoryId = 11 }
        | 807 -> Some { ItemTypeGroupData.id = 807; categoryId = 11 }
        | 808 -> Some { ItemTypeGroupData.id = 808; categoryId = 11 }
        | 809 -> Some { ItemTypeGroupData.id = 809; categoryId = 11 }
        | 810 -> Some { ItemTypeGroupData.id = 810; categoryId = 11 }
        | 811 -> Some { ItemTypeGroupData.id = 811; categoryId = 11 }
        | 812 -> Some { ItemTypeGroupData.id = 812; categoryId = 11 }
        | 813 -> Some { ItemTypeGroupData.id = 813; categoryId = 11 }
        | 814 -> Some { ItemTypeGroupData.id = 814; categoryId = 11 }
        | 816 -> Some { ItemTypeGroupData.id = 816; categoryId = 11 }
        | 817 -> Some { ItemTypeGroupData.id = 817; categoryId = 11 }
        | 818 -> Some { ItemTypeGroupData.id = 818; categoryId = 11 }
        | 819 -> Some { ItemTypeGroupData.id = 819; categoryId = 11 }
        | 820 -> Some { ItemTypeGroupData.id = 820; categoryId = 11 }
        | 821 -> Some { ItemTypeGroupData.id = 821; categoryId = 11 }
        | 822 -> Some { ItemTypeGroupData.id = 822; categoryId = 11 }
        | 823 -> Some { ItemTypeGroupData.id = 823; categoryId = 11 }
        | 824 -> Some { ItemTypeGroupData.id = 824; categoryId = 11 }
        | 825 -> Some { ItemTypeGroupData.id = 825; categoryId = 11 }
        | 826 -> Some { ItemTypeGroupData.id = 826; categoryId = 11 }
        | 827 -> Some { ItemTypeGroupData.id = 827; categoryId = 11 }
        | 828 -> Some { ItemTypeGroupData.id = 828; categoryId = 11 }
        | 829 -> Some { ItemTypeGroupData.id = 829; categoryId = 11 }
        | 843 -> Some { ItemTypeGroupData.id = 843; categoryId = 11 }
        | 844 -> Some { ItemTypeGroupData.id = 844; categoryId = 11 }
        | 845 -> Some { ItemTypeGroupData.id = 845; categoryId = 11 }
        | 846 -> Some { ItemTypeGroupData.id = 846; categoryId = 11 }
        | 847 -> Some { ItemTypeGroupData.id = 847; categoryId = 11 }
        | 848 -> Some { ItemTypeGroupData.id = 848; categoryId = 11 }
        | 849 -> Some { ItemTypeGroupData.id = 849; categoryId = 11 }
        | 850 -> Some { ItemTypeGroupData.id = 850; categoryId = 11 }
        | 851 -> Some { ItemTypeGroupData.id = 851; categoryId = 11 }
        | 852 -> Some { ItemTypeGroupData.id = 852; categoryId = 11 }
        | 861 -> Some { ItemTypeGroupData.id = 861; categoryId = 11 }
        | 865 -> Some { ItemTypeGroupData.id = 865; categoryId = 11 }
        | 866 -> Some { ItemTypeGroupData.id = 866; categoryId = 11 }
        | 867 -> Some { ItemTypeGroupData.id = 867; categoryId = 11 }
        | 868 -> Some { ItemTypeGroupData.id = 868; categoryId = 11 }
        | 875 -> Some { ItemTypeGroupData.id = 875; categoryId = 11 }
        | 922 -> Some { ItemTypeGroupData.id = 922; categoryId = 11 }
        | 924 -> Some { ItemTypeGroupData.id = 924; categoryId = 11 }
        | 925 -> Some { ItemTypeGroupData.id = 925; categoryId = 11 }
        | 927 -> Some { ItemTypeGroupData.id = 927; categoryId = 11 }
        | 934 -> Some { ItemTypeGroupData.id = 934; categoryId = 11 }
        | 952 -> Some { ItemTypeGroupData.id = 952; categoryId = 11 }
        | 959 -> Some { ItemTypeGroupData.id = 959; categoryId = 11 }
        | 960 -> Some { ItemTypeGroupData.id = 960; categoryId = 11 }
        | 961 -> Some { ItemTypeGroupData.id = 961; categoryId = 11 }
        | 982 -> Some { ItemTypeGroupData.id = 982; categoryId = 11 }
        | 983 -> Some { ItemTypeGroupData.id = 983; categoryId = 11 }
        | 984 -> Some { ItemTypeGroupData.id = 984; categoryId = 11 }
        | 985 -> Some { ItemTypeGroupData.id = 985; categoryId = 11 }
        | 986 -> Some { ItemTypeGroupData.id = 986; categoryId = 11 }
        | 987 -> Some { ItemTypeGroupData.id = 987; categoryId = 11 }
        | 1006 -> Some { ItemTypeGroupData.id = 1006; categoryId = 11 }
        | 1007 -> Some { ItemTypeGroupData.id = 1007; categoryId = 11 }
        | 1051 -> Some { ItemTypeGroupData.id = 1051; categoryId = 11 }
        | 1052 -> Some { ItemTypeGroupData.id = 1052; categoryId = 11 }
        | 1053 -> Some { ItemTypeGroupData.id = 1053; categoryId = 11 }
        | 1054 -> Some { ItemTypeGroupData.id = 1054; categoryId = 11 }
        | 1056 -> Some { ItemTypeGroupData.id = 1056; categoryId = 11 }
        | 1166 -> Some { ItemTypeGroupData.id = 1166; categoryId = 11 }
        | 1167 -> Some { ItemTypeGroupData.id = 1167; categoryId = 11 }
        | 1168 -> Some { ItemTypeGroupData.id = 1168; categoryId = 11 }
        | 1169 -> Some { ItemTypeGroupData.id = 1169; categoryId = 11 }
        | 1174 -> Some { ItemTypeGroupData.id = 1174; categoryId = 11 }
        | 1175 -> Some { ItemTypeGroupData.id = 1175; categoryId = 11 }
        | 1176 -> Some { ItemTypeGroupData.id = 1176; categoryId = 11 }
        | 1177 -> Some { ItemTypeGroupData.id = 1177; categoryId = 11 }
        | 1178 -> Some { ItemTypeGroupData.id = 1178; categoryId = 11 }
        | 1179 -> Some { ItemTypeGroupData.id = 1179; categoryId = 11 }
        | 1180 -> Some { ItemTypeGroupData.id = 1180; categoryId = 11 }
        | 1181 -> Some { ItemTypeGroupData.id = 1181; categoryId = 11 }
        | 1182 -> Some { ItemTypeGroupData.id = 1182; categoryId = 11 }
        | 1183 -> Some { ItemTypeGroupData.id = 1183; categoryId = 11 }
        | 1184 -> Some { ItemTypeGroupData.id = 1184; categoryId = 11 }
        | 1185 -> Some { ItemTypeGroupData.id = 1185; categoryId = 11 }
        | 1186 -> Some { ItemTypeGroupData.id = 1186; categoryId = 11 }
        | 1207 -> Some { ItemTypeGroupData.id = 1207; categoryId = 11 }
        | 1252 -> Some { ItemTypeGroupData.id = 1252; categoryId = 11 }
        | 1255 -> Some { ItemTypeGroupData.id = 1255; categoryId = 11 }
        | 1259 -> Some { ItemTypeGroupData.id = 1259; categoryId = 11 }
        | 1262 -> Some { ItemTypeGroupData.id = 1262; categoryId = 11 }
        | 1265 -> Some { ItemTypeGroupData.id = 1265; categoryId = 11 }
        | 1285 -> Some { ItemTypeGroupData.id = 1285; categoryId = 11 }
        | 1286 -> Some { ItemTypeGroupData.id = 1286; categoryId = 11 }
        | 1287 -> Some { ItemTypeGroupData.id = 1287; categoryId = 11 }
        | 1288 -> Some { ItemTypeGroupData.id = 1288; categoryId = 11 }
        | 1307 -> Some { ItemTypeGroupData.id = 1307; categoryId = 11 }
        | 1310 -> Some { ItemTypeGroupData.id = 1310; categoryId = 11 }
        | 1402 -> Some { ItemTypeGroupData.id = 1402; categoryId = 11 }
        | 1411 -> Some { ItemTypeGroupData.id = 1411; categoryId = 11 }
        | 1412 -> Some { ItemTypeGroupData.id = 1412; categoryId = 11 }
        | 1413 -> Some { ItemTypeGroupData.id = 1413; categoryId = 11 }
        | 1414 -> Some { ItemTypeGroupData.id = 1414; categoryId = 11 }
        | 1452 -> Some { ItemTypeGroupData.id = 1452; categoryId = 11 }
        | 1453 -> Some { ItemTypeGroupData.id = 1453; categoryId = 11 }
        | 1454 -> Some { ItemTypeGroupData.id = 1454; categoryId = 11 }
        | 1455 -> Some { ItemTypeGroupData.id = 1455; categoryId = 11 }
        | 1465 -> Some { ItemTypeGroupData.id = 1465; categoryId = 11 }
        | 1529 -> Some { ItemTypeGroupData.id = 1529; categoryId = 11 }
        | 1530 -> Some { ItemTypeGroupData.id = 1530; categoryId = 11 }
        | 1566 -> Some { ItemTypeGroupData.id = 1566; categoryId = 11 }
        | 1567 -> Some { ItemTypeGroupData.id = 1567; categoryId = 11 }
        | 1568 -> Some { ItemTypeGroupData.id = 1568; categoryId = 11 }
        | 1664 -> Some { ItemTypeGroupData.id = 1664; categoryId = 11 }
        | 1665 -> Some { ItemTypeGroupData.id = 1665; categoryId = 11 }
        | 1666 -> Some { ItemTypeGroupData.id = 1666; categoryId = 11 }
        | 1667 -> Some { ItemTypeGroupData.id = 1667; categoryId = 11 }
        | 1681 -> Some { ItemTypeGroupData.id = 1681; categoryId = 11 }
        | 1682 -> Some { ItemTypeGroupData.id = 1682; categoryId = 11 }
        | 1683 -> Some { ItemTypeGroupData.id = 1683; categoryId = 11 }
        | 1684 -> Some { ItemTypeGroupData.id = 1684; categoryId = 11 }
        | 1685 -> Some { ItemTypeGroupData.id = 1685; categoryId = 11 }
        | 1686 -> Some { ItemTypeGroupData.id = 1686; categoryId = 11 }
        | 1687 -> Some { ItemTypeGroupData.id = 1687; categoryId = 11 }
        | 1688 -> Some { ItemTypeGroupData.id = 1688; categoryId = 11 }
        | 1689 -> Some { ItemTypeGroupData.id = 1689; categoryId = 11 }
        | 1690 -> Some { ItemTypeGroupData.id = 1690; categoryId = 11 }
        | 1691 -> Some { ItemTypeGroupData.id = 1691; categoryId = 11 }
        | 1692 -> Some { ItemTypeGroupData.id = 1692; categoryId = 11 }
        | 1720 -> Some { ItemTypeGroupData.id = 1720; categoryId = 11 }
        | 1721 -> Some { ItemTypeGroupData.id = 1721; categoryId = 11 }
        | 1722 -> Some { ItemTypeGroupData.id = 1722; categoryId = 11 }
        | 1724 -> Some { ItemTypeGroupData.id = 1724; categoryId = 11 }
        | 1725 -> Some { ItemTypeGroupData.id = 1725; categoryId = 11 }
        | 1726 -> Some { ItemTypeGroupData.id = 1726; categoryId = 11 }
        | 1727 -> Some { ItemTypeGroupData.id = 1727; categoryId = 11 }
        | 1728 -> Some { ItemTypeGroupData.id = 1728; categoryId = 11 }
        | 1729 -> Some { ItemTypeGroupData.id = 1729; categoryId = 11 }
        | 1731 -> Some { ItemTypeGroupData.id = 1731; categoryId = 11 }
        | 1734 -> Some { ItemTypeGroupData.id = 1734; categoryId = 11 }
        | 1735 -> Some { ItemTypeGroupData.id = 1735; categoryId = 11 }
        | 1736 -> Some { ItemTypeGroupData.id = 1736; categoryId = 11 }
        | 1737 -> Some { ItemTypeGroupData.id = 1737; categoryId = 11 }
        | 1759 -> Some { ItemTypeGroupData.id = 1759; categoryId = 11 }
        | 1761 -> Some { ItemTypeGroupData.id = 1761; categoryId = 11 }
        | 1762 -> Some { ItemTypeGroupData.id = 1762; categoryId = 11 }
        | 1764 -> Some { ItemTypeGroupData.id = 1764; categoryId = 11 }
        | 1765 -> Some { ItemTypeGroupData.id = 1765; categoryId = 11 }
        | 1766 -> Some { ItemTypeGroupData.id = 1766; categoryId = 11 }
        | 1767 -> Some { ItemTypeGroupData.id = 1767; categoryId = 11 }
        | 1768 -> Some { ItemTypeGroupData.id = 1768; categoryId = 11 }
        | 1788 -> Some { ItemTypeGroupData.id = 1788; categoryId = 11 }
        | 1789 -> Some { ItemTypeGroupData.id = 1789; categoryId = 11 }
        | 1790 -> Some { ItemTypeGroupData.id = 1790; categoryId = 11 }
        | 1791 -> Some { ItemTypeGroupData.id = 1791; categoryId = 11 }
        | 1792 -> Some { ItemTypeGroupData.id = 1792; categoryId = 11 }
        | 1793 -> Some { ItemTypeGroupData.id = 1793; categoryId = 11 }
        | 1794 -> Some { ItemTypeGroupData.id = 1794; categoryId = 11 }
        | 1795 -> Some { ItemTypeGroupData.id = 1795; categoryId = 11 }
        | 1796 -> Some { ItemTypeGroupData.id = 1796; categoryId = 11 }
        | 1797 -> Some { ItemTypeGroupData.id = 1797; categoryId = 11 }
        | 1798 -> Some { ItemTypeGroupData.id = 1798; categoryId = 11 }
        | 1799 -> Some { ItemTypeGroupData.id = 1799; categoryId = 11 }
        | 1800 -> Some { ItemTypeGroupData.id = 1800; categoryId = 11 }
        | 1803 -> Some { ItemTypeGroupData.id = 1803; categoryId = 11 }
        | 1804 -> Some { ItemTypeGroupData.id = 1804; categoryId = 11 }
        | 1805 -> Some { ItemTypeGroupData.id = 1805; categoryId = 11 }
        | 1806 -> Some { ItemTypeGroupData.id = 1806; categoryId = 11 }
        | 1807 -> Some { ItemTypeGroupData.id = 1807; categoryId = 11 }
        | 1813 -> Some { ItemTypeGroupData.id = 1813; categoryId = 11 }
        | 1814 -> Some { ItemTypeGroupData.id = 1814; categoryId = 11 }
        | 1872 -> Some { ItemTypeGroupData.id = 1872; categoryId = 11 }
        | 1878 -> Some { ItemTypeGroupData.id = 1878; categoryId = 11 }
        | 1879 -> Some { ItemTypeGroupData.id = 1879; categoryId = 11 }
        | 1880 -> Some { ItemTypeGroupData.id = 1880; categoryId = 11 }
        | 1895 -> Some { ItemTypeGroupData.id = 1895; categoryId = 11 }
        | 1896 -> Some { ItemTypeGroupData.id = 1896; categoryId = 11 }
        | 1909 -> Some { ItemTypeGroupData.id = 1909; categoryId = 11 }
        | 1925 -> Some { ItemTypeGroupData.id = 1925; categoryId = 11 }
        | 1926 -> Some { ItemTypeGroupData.id = 1926; categoryId = 11 }
        | 1927 -> Some { ItemTypeGroupData.id = 1927; categoryId = 11 }
        | 1928 -> Some { ItemTypeGroupData.id = 1928; categoryId = 11 }
        | 1929 -> Some { ItemTypeGroupData.id = 1929; categoryId = 11 }
        | 1956 -> Some { ItemTypeGroupData.id = 1956; categoryId = 11 }
        | 1982 -> Some { ItemTypeGroupData.id = 1982; categoryId = 11 }
        | 1997 -> Some { ItemTypeGroupData.id = 1997; categoryId = 11 }
        | 2009 -> Some { ItemTypeGroupData.id = 2009; categoryId = 11 }
        | 190 -> Some { ItemTypeGroupData.id = 190; categoryId = 14 }
        | 191 -> Some { ItemTypeGroupData.id = 191; categoryId = 14 }
        | 192 -> Some { ItemTypeGroupData.id = 192; categoryId = 14 }
        | 193 -> Some { ItemTypeGroupData.id = 193; categoryId = 14 }
        | 194 -> Some { ItemTypeGroupData.id = 194; categoryId = 14 }
        | 195 -> Some { ItemTypeGroupData.id = 195; categoryId = 14 }
        | 196 -> Some { ItemTypeGroupData.id = 196; categoryId = 14 }
        | 197 -> Some { ItemTypeGroupData.id = 197; categoryId = 14 }
        | 198 -> Some { ItemTypeGroupData.id = 198; categoryId = 14 }
        | 199 -> Some { ItemTypeGroupData.id = 199; categoryId = 14 }
        | 255 -> Some { ItemTypeGroupData.id = 255; categoryId = 16 }
        | 256 -> Some { ItemTypeGroupData.id = 256; categoryId = 16 }
        | 257 -> Some { ItemTypeGroupData.id = 257; categoryId = 16 }
        | 258 -> Some { ItemTypeGroupData.id = 258; categoryId = 16 }
        | 266 -> Some { ItemTypeGroupData.id = 266; categoryId = 16 }
        | 268 -> Some { ItemTypeGroupData.id = 268; categoryId = 16 }
        | 269 -> Some { ItemTypeGroupData.id = 269; categoryId = 16 }
        | 270 -> Some { ItemTypeGroupData.id = 270; categoryId = 16 }
        | 272 -> Some { ItemTypeGroupData.id = 272; categoryId = 16 }
        | 273 -> Some { ItemTypeGroupData.id = 273; categoryId = 16 }
        | 274 -> Some { ItemTypeGroupData.id = 274; categoryId = 16 }
        | 275 -> Some { ItemTypeGroupData.id = 275; categoryId = 16 }
        | 278 -> Some { ItemTypeGroupData.id = 278; categoryId = 16 }
        | 505 -> Some { ItemTypeGroupData.id = 505; categoryId = 16 }
        | 1209 -> Some { ItemTypeGroupData.id = 1209; categoryId = 16 }
        | 1210 -> Some { ItemTypeGroupData.id = 1210; categoryId = 16 }
        | 1213 -> Some { ItemTypeGroupData.id = 1213; categoryId = 16 }
        | 1216 -> Some { ItemTypeGroupData.id = 1216; categoryId = 16 }
        | 1217 -> Some { ItemTypeGroupData.id = 1217; categoryId = 16 }
        | 1218 -> Some { ItemTypeGroupData.id = 1218; categoryId = 16 }
        | 1220 -> Some { ItemTypeGroupData.id = 1220; categoryId = 16 }
        | 1240 -> Some { ItemTypeGroupData.id = 1240; categoryId = 16 }
        | 1241 -> Some { ItemTypeGroupData.id = 1241; categoryId = 16 }
        | 1545 -> Some { ItemTypeGroupData.id = 1545; categoryId = 16 }
        | 267 -> Some { ItemTypeGroupData.id = 267; categoryId = 17 }
        | 280 -> Some { ItemTypeGroupData.id = 280; categoryId = 17 }
        | 281 -> Some { ItemTypeGroupData.id = 281; categoryId = 17 }
        | 282 -> Some { ItemTypeGroupData.id = 282; categoryId = 17 }
        | 283 -> Some { ItemTypeGroupData.id = 283; categoryId = 17 }
        | 284 -> Some { ItemTypeGroupData.id = 284; categoryId = 17 }
        | 313 -> Some { ItemTypeGroupData.id = 313; categoryId = 17 }
        | 314 -> Some { ItemTypeGroupData.id = 314; categoryId = 17 }
        | 332 -> Some { ItemTypeGroupData.id = 332; categoryId = 17 }
        | 333 -> Some { ItemTypeGroupData.id = 333; categoryId = 17 }
        | 334 -> Some { ItemTypeGroupData.id = 334; categoryId = 17 }
        | 355 -> Some { ItemTypeGroupData.id = 355; categoryId = 17 }
        | 369 -> Some { ItemTypeGroupData.id = 369; categoryId = 17 }
        | 370 -> Some { ItemTypeGroupData.id = 370; categoryId = 17 }
        | 409 -> Some { ItemTypeGroupData.id = 409; categoryId = 17 }
        | 474 -> Some { ItemTypeGroupData.id = 474; categoryId = 17 }
        | 493 -> Some { ItemTypeGroupData.id = 493; categoryId = 17 }
        | 521 -> Some { ItemTypeGroupData.id = 521; categoryId = 17 }
        | 526 -> Some { ItemTypeGroupData.id = 526; categoryId = 17 }
        | 528 -> Some { ItemTypeGroupData.id = 528; categoryId = 17 }
        | 530 -> Some { ItemTypeGroupData.id = 530; categoryId = 17 }
        | 536 -> Some { ItemTypeGroupData.id = 536; categoryId = 17 }
        | 652 -> Some { ItemTypeGroupData.id = 652; categoryId = 17 }
        | 716 -> Some { ItemTypeGroupData.id = 716; categoryId = 17 }
        | 732 -> Some { ItemTypeGroupData.id = 732; categoryId = 17 }
        | 733 -> Some { ItemTypeGroupData.id = 733; categoryId = 17 }
        | 734 -> Some { ItemTypeGroupData.id = 734; categoryId = 17 }
        | 735 -> Some { ItemTypeGroupData.id = 735; categoryId = 17 }
        | 873 -> Some { ItemTypeGroupData.id = 873; categoryId = 17 }
        | 879 -> Some { ItemTypeGroupData.id = 879; categoryId = 17 }
        | 880 -> Some { ItemTypeGroupData.id = 880; categoryId = 17 }
        | 884 -> Some { ItemTypeGroupData.id = 884; categoryId = 17 }
        | 913 -> Some { ItemTypeGroupData.id = 913; categoryId = 17 }
        | 955 -> Some { ItemTypeGroupData.id = 955; categoryId = 17 }
        | 964 -> Some { ItemTypeGroupData.id = 964; categoryId = 17 }
        | 1031 -> Some { ItemTypeGroupData.id = 1031; categoryId = 17 }
        | 1118 -> Some { ItemTypeGroupData.id = 1118; categoryId = 17 }
        | 1141 -> Some { ItemTypeGroupData.id = 1141; categoryId = 17 }
        | 1206 -> Some { ItemTypeGroupData.id = 1206; categoryId = 17 }
        | 1248 -> Some { ItemTypeGroupData.id = 1248; categoryId = 17 }
        | 1314 -> Some { ItemTypeGroupData.id = 1314; categoryId = 17 }
        | 1818 -> Some { ItemTypeGroupData.id = 1818; categoryId = 17 }
        | 1886 -> Some { ItemTypeGroupData.id = 1886; categoryId = 17 }
        | 1964 -> Some { ItemTypeGroupData.id = 1964; categoryId = 17 }
        | 1977 -> Some { ItemTypeGroupData.id = 1977; categoryId = 17 }
        | 1979 -> Some { ItemTypeGroupData.id = 1979; categoryId = 17 }
        | 1995 -> Some { ItemTypeGroupData.id = 1995; categoryId = 17 }
        | 2002 -> Some { ItemTypeGroupData.id = 2002; categoryId = 17 }
        | 97 -> Some { ItemTypeGroupData.id = 97; categoryId = 18 }
        | 100 -> Some { ItemTypeGroupData.id = 100; categoryId = 18 }
        | 101 -> Some { ItemTypeGroupData.id = 101; categoryId = 18 }
        | 299 -> Some { ItemTypeGroupData.id = 299; categoryId = 18 }
        | 470 -> Some { ItemTypeGroupData.id = 470; categoryId = 18 }
        | 544 -> Some { ItemTypeGroupData.id = 544; categoryId = 18 }
        | 545 -> Some { ItemTypeGroupData.id = 545; categoryId = 18 }
        | 549 -> Some { ItemTypeGroupData.id = 549; categoryId = 18 }
        | 639 -> Some { ItemTypeGroupData.id = 639; categoryId = 18 }
        | 640 -> Some { ItemTypeGroupData.id = 640; categoryId = 18 }
        | 641 -> Some { ItemTypeGroupData.id = 641; categoryId = 18 }
        | 1023 -> Some { ItemTypeGroupData.id = 1023; categoryId = 18 }
        | 1159 -> Some { ItemTypeGroupData.id = 1159; categoryId = 18 }
        | 300 -> Some { ItemTypeGroupData.id = 300; categoryId = 20 }
        | 303 -> Some { ItemTypeGroupData.id = 303; categoryId = 20 }
        | 304 -> Some { ItemTypeGroupData.id = 304; categoryId = 20 }
        | 721 -> Some { ItemTypeGroupData.id = 721; categoryId = 20 }
        | 738 -> Some { ItemTypeGroupData.id = 738; categoryId = 20 }
        | 739 -> Some { ItemTypeGroupData.id = 739; categoryId = 20 }
        | 740 -> Some { ItemTypeGroupData.id = 740; categoryId = 20 }
        | 741 -> Some { ItemTypeGroupData.id = 741; categoryId = 20 }
        | 742 -> Some { ItemTypeGroupData.id = 742; categoryId = 20 }
        | 743 -> Some { ItemTypeGroupData.id = 743; categoryId = 20 }
        | 744 -> Some { ItemTypeGroupData.id = 744; categoryId = 20 }
        | 745 -> Some { ItemTypeGroupData.id = 745; categoryId = 20 }
        | 746 -> Some { ItemTypeGroupData.id = 746; categoryId = 20 }
        | 747 -> Some { ItemTypeGroupData.id = 747; categoryId = 20 }
        | 748 -> Some { ItemTypeGroupData.id = 748; categoryId = 20 }
        | 749 -> Some { ItemTypeGroupData.id = 749; categoryId = 20 }
        | 750 -> Some { ItemTypeGroupData.id = 750; categoryId = 20 }
        | 751 -> Some { ItemTypeGroupData.id = 751; categoryId = 20 }
        | 783 -> Some { ItemTypeGroupData.id = 783; categoryId = 20 }
        | 1228 -> Some { ItemTypeGroupData.id = 1228; categoryId = 20 }
        | 1229 -> Some { ItemTypeGroupData.id = 1229; categoryId = 20 }
        | 1230 -> Some { ItemTypeGroupData.id = 1230; categoryId = 20 }
        | 1231 -> Some { ItemTypeGroupData.id = 1231; categoryId = 20 }
        | 1730 -> Some { ItemTypeGroupData.id = 1730; categoryId = 20 }
        | 361 -> Some { ItemTypeGroupData.id = 361; categoryId = 22 }
        | 1149 -> Some { ItemTypeGroupData.id = 1149; categoryId = 22 }
        | 1246 -> Some { ItemTypeGroupData.id = 1246; categoryId = 22 }
        | 1247 -> Some { ItemTypeGroupData.id = 1247; categoryId = 22 }
        | 1249 -> Some { ItemTypeGroupData.id = 1249; categoryId = 22 }
        | 1250 -> Some { ItemTypeGroupData.id = 1250; categoryId = 22 }
        | 1273 -> Some { ItemTypeGroupData.id = 1273; categoryId = 22 }
        | 1274 -> Some { ItemTypeGroupData.id = 1274; categoryId = 22 }
        | 1275 -> Some { ItemTypeGroupData.id = 1275; categoryId = 22 }
        | 1276 -> Some { ItemTypeGroupData.id = 1276; categoryId = 22 }
        | 1297 -> Some { ItemTypeGroupData.id = 1297; categoryId = 22 }
        | 1312 -> Some { ItemTypeGroupData.id = 1312; categoryId = 22 }
        | 2005 -> Some { ItemTypeGroupData.id = 2005; categoryId = 22 }
        | 311 -> Some { ItemTypeGroupData.id = 311; categoryId = 23 }
        | 363 -> Some { ItemTypeGroupData.id = 363; categoryId = 23 }
        | 364 -> Some { ItemTypeGroupData.id = 364; categoryId = 23 }
        | 365 -> Some { ItemTypeGroupData.id = 365; categoryId = 23 }
        | 397 -> Some { ItemTypeGroupData.id = 397; categoryId = 23 }
        | 404 -> Some { ItemTypeGroupData.id = 404; categoryId = 23 }
        | 413 -> Some { ItemTypeGroupData.id = 413; categoryId = 23 }
        | 414 -> Some { ItemTypeGroupData.id = 414; categoryId = 23 }
        | 416 -> Some { ItemTypeGroupData.id = 416; categoryId = 23 }
        | 417 -> Some { ItemTypeGroupData.id = 417; categoryId = 23 }
        | 418 -> Some { ItemTypeGroupData.id = 418; categoryId = 23 }
        | 426 -> Some { ItemTypeGroupData.id = 426; categoryId = 23 }
        | 430 -> Some { ItemTypeGroupData.id = 430; categoryId = 23 }
        | 438 -> Some { ItemTypeGroupData.id = 438; categoryId = 23 }
        | 439 -> Some { ItemTypeGroupData.id = 439; categoryId = 23 }
        | 440 -> Some { ItemTypeGroupData.id = 440; categoryId = 23 }
        | 441 -> Some { ItemTypeGroupData.id = 441; categoryId = 23 }
        | 443 -> Some { ItemTypeGroupData.id = 443; categoryId = 23 }
        | 444 -> Some { ItemTypeGroupData.id = 444; categoryId = 23 }
        | 445 -> Some { ItemTypeGroupData.id = 445; categoryId = 23 }
        | 449 -> Some { ItemTypeGroupData.id = 449; categoryId = 23 }
        | 471 -> Some { ItemTypeGroupData.id = 471; categoryId = 23 }
        | 473 -> Some { ItemTypeGroupData.id = 473; categoryId = 23 }
        | 480 -> Some { ItemTypeGroupData.id = 480; categoryId = 23 }
        | 707 -> Some { ItemTypeGroupData.id = 707; categoryId = 23 }
        | 709 -> Some { ItemTypeGroupData.id = 709; categoryId = 23 }
        | 710 -> Some { ItemTypeGroupData.id = 710; categoryId = 23 }
        | 837 -> Some { ItemTypeGroupData.id = 837; categoryId = 23 }
        | 838 -> Some { ItemTypeGroupData.id = 838; categoryId = 23 }
        | 839 -> Some { ItemTypeGroupData.id = 839; categoryId = 23 }
        | 840 -> Some { ItemTypeGroupData.id = 840; categoryId = 23 }
        | 877 -> Some { ItemTypeGroupData.id = 877; categoryId = 23 }
        | 1212 -> Some { ItemTypeGroupData.id = 1212; categoryId = 23 }
        | 1282 -> Some { ItemTypeGroupData.id = 1282; categoryId = 23 }
        | 436 -> Some { ItemTypeGroupData.id = 436; categoryId = 24 }
        | 484 -> Some { ItemTypeGroupData.id = 484; categoryId = 24 }
        | 661 -> Some { ItemTypeGroupData.id = 661; categoryId = 24 }
        | 662 -> Some { ItemTypeGroupData.id = 662; categoryId = 24 }
        | 881 -> Some { ItemTypeGroupData.id = 881; categoryId = 24 }
        | 882 -> Some { ItemTypeGroupData.id = 882; categoryId = 24 }
        | 977 -> Some { ItemTypeGroupData.id = 977; categoryId = 24 }
        | 450 -> Some { ItemTypeGroupData.id = 450; categoryId = 25 }
        | 451 -> Some { ItemTypeGroupData.id = 451; categoryId = 25 }
        | 452 -> Some { ItemTypeGroupData.id = 452; categoryId = 25 }
        | 453 -> Some { ItemTypeGroupData.id = 453; categoryId = 25 }
        | 454 -> Some { ItemTypeGroupData.id = 454; categoryId = 25 }
        | 455 -> Some { ItemTypeGroupData.id = 455; categoryId = 25 }
        | 456 -> Some { ItemTypeGroupData.id = 456; categoryId = 25 }
        | 457 -> Some { ItemTypeGroupData.id = 457; categoryId = 25 }
        | 458 -> Some { ItemTypeGroupData.id = 458; categoryId = 25 }
        | 459 -> Some { ItemTypeGroupData.id = 459; categoryId = 25 }
        | 460 -> Some { ItemTypeGroupData.id = 460; categoryId = 25 }
        | 461 -> Some { ItemTypeGroupData.id = 461; categoryId = 25 }
        | 462 -> Some { ItemTypeGroupData.id = 462; categoryId = 25 }
        | 465 -> Some { ItemTypeGroupData.id = 465; categoryId = 25 }
        | 467 -> Some { ItemTypeGroupData.id = 467; categoryId = 25 }
        | 468 -> Some { ItemTypeGroupData.id = 468; categoryId = 25 }
        | 469 -> Some { ItemTypeGroupData.id = 469; categoryId = 25 }
        | 519 -> Some { ItemTypeGroupData.id = 519; categoryId = 25 }
        | 903 -> Some { ItemTypeGroupData.id = 903; categoryId = 25 }
        | 1884 -> Some { ItemTypeGroupData.id = 1884; categoryId = 25 }
        | 1911 -> Some { ItemTypeGroupData.id = 1911; categoryId = 25 }
        | 1920 -> Some { ItemTypeGroupData.id = 1920; categoryId = 25 }
        | 1921 -> Some { ItemTypeGroupData.id = 1921; categoryId = 25 }
        | 1922 -> Some { ItemTypeGroupData.id = 1922; categoryId = 25 }
        | 1923 -> Some { ItemTypeGroupData.id = 1923; categoryId = 25 }
        | 2006 -> Some { ItemTypeGroupData.id = 2006; categoryId = 25 }
        | 935 -> Some { ItemTypeGroupData.id = 935; categoryId = 26 }
        | 1067 -> Some { ItemTypeGroupData.id = 1067; categoryId = 26 }
        | 1068 -> Some { ItemTypeGroupData.id = 1068; categoryId = 26 }
        | 937 -> Some { ItemTypeGroupData.id = 937; categoryId = 29 }
        | 1109 -> Some { ItemTypeGroupData.id = 1109; categoryId = 29 }
        | 1121 -> Some { ItemTypeGroupData.id = 1121; categoryId = 29 }
        | 1319 -> Some { ItemTypeGroupData.id = 1319; categoryId = 29 }
        | 1083 -> Some { ItemTypeGroupData.id = 1083; categoryId = 30 }
        | 1084 -> Some { ItemTypeGroupData.id = 1084; categoryId = 30 }
        | 1085 -> Some { ItemTypeGroupData.id = 1085; categoryId = 30 }
        | 1086 -> Some { ItemTypeGroupData.id = 1086; categoryId = 30 }
        | 1087 -> Some { ItemTypeGroupData.id = 1087; categoryId = 30 }
        | 1088 -> Some { ItemTypeGroupData.id = 1088; categoryId = 30 }
        | 1089 -> Some { ItemTypeGroupData.id = 1089; categoryId = 30 }
        | 1090 -> Some { ItemTypeGroupData.id = 1090; categoryId = 30 }
        | 1091 -> Some { ItemTypeGroupData.id = 1091; categoryId = 30 }
        | 1092 -> Some { ItemTypeGroupData.id = 1092; categoryId = 30 }
        | 1093 -> Some { ItemTypeGroupData.id = 1093; categoryId = 30 }
        | 1271 -> Some { ItemTypeGroupData.id = 1271; categoryId = 30 }
        | 1670 -> Some { ItemTypeGroupData.id = 1670; categoryId = 30 }
        | 954 -> Some { ItemTypeGroupData.id = 954; categoryId = 32 }
        | 956 -> Some { ItemTypeGroupData.id = 956; categoryId = 32 }
        | 957 -> Some { ItemTypeGroupData.id = 957; categoryId = 32 }
        | 958 -> Some { ItemTypeGroupData.id = 958; categoryId = 32 }
        | 971 -> Some { ItemTypeGroupData.id = 971; categoryId = 34 }
        | 990 -> Some { ItemTypeGroupData.id = 990; categoryId = 34 }
        | 991 -> Some { ItemTypeGroupData.id = 991; categoryId = 34 }
        | 992 -> Some { ItemTypeGroupData.id = 992; categoryId = 34 }
        | 993 -> Some { ItemTypeGroupData.id = 993; categoryId = 34 }
        | 997 -> Some { ItemTypeGroupData.id = 997; categoryId = 34 }
        | 728 -> Some { ItemTypeGroupData.id = 728; categoryId = 35 }
        | 729 -> Some { ItemTypeGroupData.id = 729; categoryId = 35 }
        | 730 -> Some { ItemTypeGroupData.id = 730; categoryId = 35 }
        | 731 -> Some { ItemTypeGroupData.id = 731; categoryId = 35 }
        | 979 -> Some { ItemTypeGroupData.id = 979; categoryId = 35 }
        | 1304 -> Some { ItemTypeGroupData.id = 1304; categoryId = 35 }
        | 1016 -> Some { ItemTypeGroupData.id = 1016; categoryId = 39 }
        | 1020 -> Some { ItemTypeGroupData.id = 1020; categoryId = 39 }
        | 1021 -> Some { ItemTypeGroupData.id = 1021; categoryId = 39 }
        | 1003 -> Some { ItemTypeGroupData.id = 1003; categoryId = 40 }
        | 1004 -> Some { ItemTypeGroupData.id = 1004; categoryId = 40 }
        | 1005 -> Some { ItemTypeGroupData.id = 1005; categoryId = 40 }
        | 1012 -> Some { ItemTypeGroupData.id = 1012; categoryId = 40 }
        | 1026 -> Some { ItemTypeGroupData.id = 1026; categoryId = 41 }
        | 1027 -> Some { ItemTypeGroupData.id = 1027; categoryId = 41 }
        | 1028 -> Some { ItemTypeGroupData.id = 1028; categoryId = 41 }
        | 1029 -> Some { ItemTypeGroupData.id = 1029; categoryId = 41 }
        | 1030 -> Some { ItemTypeGroupData.id = 1030; categoryId = 41 }
        | 1036 -> Some { ItemTypeGroupData.id = 1036; categoryId = 41 }
        | 1063 -> Some { ItemTypeGroupData.id = 1063; categoryId = 41 }
        | 1081 -> Some { ItemTypeGroupData.id = 1081; categoryId = 41 }
        | 1082 -> Some { ItemTypeGroupData.id = 1082; categoryId = 41 }
        | 1032 -> Some { ItemTypeGroupData.id = 1032; categoryId = 42 }
        | 1033 -> Some { ItemTypeGroupData.id = 1033; categoryId = 42 }
        | 1035 -> Some { ItemTypeGroupData.id = 1035; categoryId = 42 }
        | 1034 -> Some { ItemTypeGroupData.id = 1034; categoryId = 43 }
        | 1040 -> Some { ItemTypeGroupData.id = 1040; categoryId = 43 }
        | 1041 -> Some { ItemTypeGroupData.id = 1041; categoryId = 43 }
        | 1042 -> Some { ItemTypeGroupData.id = 1042; categoryId = 43 }
        | 1025 -> Some { ItemTypeGroupData.id = 1025; categoryId = 46 }
        | 1073 -> Some { ItemTypeGroupData.id = 1073; categoryId = 46 }
        | 1106 -> Some { ItemTypeGroupData.id = 1106; categoryId = 46 }
        | 940 -> Some { ItemTypeGroupData.id = 940; categoryId = 49 }
        | 1079 -> Some { ItemTypeGroupData.id = 1079; categoryId = 49 }
        | 1105 -> Some { ItemTypeGroupData.id = 1105; categoryId = 53 }
        | 1107 -> Some { ItemTypeGroupData.id = 1107; categoryId = 53 }
        | 1108 -> Some { ItemTypeGroupData.id = 1108; categoryId = 53 }
        | 1110 -> Some { ItemTypeGroupData.id = 1110; categoryId = 54 }
        | 1111 -> Some { ItemTypeGroupData.id = 1111; categoryId = 54 }
        | 1112 -> Some { ItemTypeGroupData.id = 1112; categoryId = 54 }
        | 1126 -> Some { ItemTypeGroupData.id = 1126; categoryId = 59 }
        | 976 -> Some { ItemTypeGroupData.id = 976; categoryId = 63 }
        | 1194 -> Some { ItemTypeGroupData.id = 1194; categoryId = 63 }
        | 1195 -> Some { ItemTypeGroupData.id = 1195; categoryId = 63 }
        | 1225 -> Some { ItemTypeGroupData.id = 1225; categoryId = 63 }
        | 1404 -> Some { ItemTypeGroupData.id = 1404; categoryId = 65 }
        | 1405 -> Some { ItemTypeGroupData.id = 1405; categoryId = 65 }
        | 1406 -> Some { ItemTypeGroupData.id = 1406; categoryId = 65 }
        | 1407 -> Some { ItemTypeGroupData.id = 1407; categoryId = 65 }
        | 1408 -> Some { ItemTypeGroupData.id = 1408; categoryId = 65 }
        | 1409 -> Some { ItemTypeGroupData.id = 1409; categoryId = 65 }
        | 1410 -> Some { ItemTypeGroupData.id = 1410; categoryId = 65 }
        | 1657 -> Some { ItemTypeGroupData.id = 1657; categoryId = 65 }
        | 1876 -> Some { ItemTypeGroupData.id = 1876; categoryId = 65 }
        | 1924 -> Some { ItemTypeGroupData.id = 1924; categoryId = 65 }
        | 2015 -> Some { ItemTypeGroupData.id = 2015; categoryId = 65 }
        | 2016 -> Some { ItemTypeGroupData.id = 2016; categoryId = 65 }
        | 2017 -> Some { ItemTypeGroupData.id = 2017; categoryId = 65 }
        | 1321 -> Some { ItemTypeGroupData.id = 1321; categoryId = 66 }
        | 1322 -> Some { ItemTypeGroupData.id = 1322; categoryId = 66 }
        | 1323 -> Some { ItemTypeGroupData.id = 1323; categoryId = 66 }
        | 1324 -> Some { ItemTypeGroupData.id = 1324; categoryId = 66 }
        | 1325 -> Some { ItemTypeGroupData.id = 1325; categoryId = 66 }
        | 1326 -> Some { ItemTypeGroupData.id = 1326; categoryId = 66 }
        | 1327 -> Some { ItemTypeGroupData.id = 1327; categoryId = 66 }
        | 1328 -> Some { ItemTypeGroupData.id = 1328; categoryId = 66 }
        | 1329 -> Some { ItemTypeGroupData.id = 1329; categoryId = 66 }
        | 1330 -> Some { ItemTypeGroupData.id = 1330; categoryId = 66 }
        | 1331 -> Some { ItemTypeGroupData.id = 1331; categoryId = 66 }
        | 1332 -> Some { ItemTypeGroupData.id = 1332; categoryId = 66 }
        | 1333 -> Some { ItemTypeGroupData.id = 1333; categoryId = 66 }
        | 1415 -> Some { ItemTypeGroupData.id = 1415; categoryId = 66 }
        | 1416 -> Some { ItemTypeGroupData.id = 1416; categoryId = 66 }
        | 1429 -> Some { ItemTypeGroupData.id = 1429; categoryId = 66 }
        | 1430 -> Some { ItemTypeGroupData.id = 1430; categoryId = 66 }
        | 1441 -> Some { ItemTypeGroupData.id = 1441; categoryId = 66 }
        | 1442 -> Some { ItemTypeGroupData.id = 1442; categoryId = 66 }
        | 1535 -> Some { ItemTypeGroupData.id = 1535; categoryId = 66 }
        | 1562 -> Some { ItemTypeGroupData.id = 1562; categoryId = 66 }
        | 1570 -> Some { ItemTypeGroupData.id = 1570; categoryId = 66 }
        | 1579 -> Some { ItemTypeGroupData.id = 1579; categoryId = 66 }
        | 1580 -> Some { ItemTypeGroupData.id = 1580; categoryId = 66 }
        | 1581 -> Some { ItemTypeGroupData.id = 1581; categoryId = 66 }
        | 1582 -> Some { ItemTypeGroupData.id = 1582; categoryId = 66 }
        | 1583 -> Some { ItemTypeGroupData.id = 1583; categoryId = 66 }
        | 1584 -> Some { ItemTypeGroupData.id = 1584; categoryId = 66 }
        | 1585 -> Some { ItemTypeGroupData.id = 1585; categoryId = 66 }
        | 1586 -> Some { ItemTypeGroupData.id = 1586; categoryId = 66 }
        | 1587 -> Some { ItemTypeGroupData.id = 1587; categoryId = 66 }
        | 1588 -> Some { ItemTypeGroupData.id = 1588; categoryId = 66 }
        | 1589 -> Some { ItemTypeGroupData.id = 1589; categoryId = 66 }
        | 1590 -> Some { ItemTypeGroupData.id = 1590; categoryId = 66 }
        | 1591 -> Some { ItemTypeGroupData.id = 1591; categoryId = 66 }
        | 1592 -> Some { ItemTypeGroupData.id = 1592; categoryId = 66 }
        | 1593 -> Some { ItemTypeGroupData.id = 1593; categoryId = 66 }
        | 1594 -> Some { ItemTypeGroupData.id = 1594; categoryId = 66 }
        | 1595 -> Some { ItemTypeGroupData.id = 1595; categoryId = 66 }
        | 1596 -> Some { ItemTypeGroupData.id = 1596; categoryId = 66 }
        | 1598 -> Some { ItemTypeGroupData.id = 1598; categoryId = 66 }
        | 1599 -> Some { ItemTypeGroupData.id = 1599; categoryId = 66 }
        | 1600 -> Some { ItemTypeGroupData.id = 1600; categoryId = 66 }
        | 1601 -> Some { ItemTypeGroupData.id = 1601; categoryId = 66 }
        | 1602 -> Some { ItemTypeGroupData.id = 1602; categoryId = 66 }
        | 1603 -> Some { ItemTypeGroupData.id = 1603; categoryId = 66 }
        | 1604 -> Some { ItemTypeGroupData.id = 1604; categoryId = 66 }
        | 1605 -> Some { ItemTypeGroupData.id = 1605; categoryId = 66 }
        | 1606 -> Some { ItemTypeGroupData.id = 1606; categoryId = 66 }
        | 1607 -> Some { ItemTypeGroupData.id = 1607; categoryId = 66 }
        | 1608 -> Some { ItemTypeGroupData.id = 1608; categoryId = 66 }
        | 1609 -> Some { ItemTypeGroupData.id = 1609; categoryId = 66 }
        | 1610 -> Some { ItemTypeGroupData.id = 1610; categoryId = 66 }
        | 1611 -> Some { ItemTypeGroupData.id = 1611; categoryId = 66 }
        | 1612 -> Some { ItemTypeGroupData.id = 1612; categoryId = 66 }
        | 1613 -> Some { ItemTypeGroupData.id = 1613; categoryId = 66 }
        | 1614 -> Some { ItemTypeGroupData.id = 1614; categoryId = 66 }
        | 1615 -> Some { ItemTypeGroupData.id = 1615; categoryId = 66 }
        | 1616 -> Some { ItemTypeGroupData.id = 1616; categoryId = 66 }
        | 1617 -> Some { ItemTypeGroupData.id = 1617; categoryId = 66 }
        | 1618 -> Some { ItemTypeGroupData.id = 1618; categoryId = 66 }
        | 1619 -> Some { ItemTypeGroupData.id = 1619; categoryId = 66 }
        | 1620 -> Some { ItemTypeGroupData.id = 1620; categoryId = 66 }
        | 1621 -> Some { ItemTypeGroupData.id = 1621; categoryId = 66 }
        | 1622 -> Some { ItemTypeGroupData.id = 1622; categoryId = 66 }
        | 1629 -> Some { ItemTypeGroupData.id = 1629; categoryId = 66 }
        | 1630 -> Some { ItemTypeGroupData.id = 1630; categoryId = 66 }
        | 1631 -> Some { ItemTypeGroupData.id = 1631; categoryId = 66 }
        | 1632 -> Some { ItemTypeGroupData.id = 1632; categoryId = 66 }
        | 1633 -> Some { ItemTypeGroupData.id = 1633; categoryId = 66 }
        | 1634 -> Some { ItemTypeGroupData.id = 1634; categoryId = 66 }
        | 1635 -> Some { ItemTypeGroupData.id = 1635; categoryId = 66 }
        | 1639 -> Some { ItemTypeGroupData.id = 1639; categoryId = 66 }
        | 1640 -> Some { ItemTypeGroupData.id = 1640; categoryId = 66 }
        | 1641 -> Some { ItemTypeGroupData.id = 1641; categoryId = 66 }
        | 1642 -> Some { ItemTypeGroupData.id = 1642; categoryId = 66 }
        | 1647 -> Some { ItemTypeGroupData.id = 1647; categoryId = 66 }
        | 1648 -> Some { ItemTypeGroupData.id = 1648; categoryId = 66 }
        | 1649 -> Some { ItemTypeGroupData.id = 1649; categoryId = 66 }
        | 1693 -> Some { ItemTypeGroupData.id = 1693; categoryId = 66 }
        | 1694 -> Some { ItemTypeGroupData.id = 1694; categoryId = 66 }
        | 1695 -> Some { ItemTypeGroupData.id = 1695; categoryId = 66 }
        | 1696 -> Some { ItemTypeGroupData.id = 1696; categoryId = 66 }
        | 1717 -> Some { ItemTypeGroupData.id = 1717; categoryId = 66 }
        | 1719 -> Some { ItemTypeGroupData.id = 1719; categoryId = 66 }
        | 1816 -> Some { ItemTypeGroupData.id = 1816; categoryId = 66 }
        | 1819 -> Some { ItemTypeGroupData.id = 1819; categoryId = 66 }
        | 1820 -> Some { ItemTypeGroupData.id = 1820; categoryId = 66 }
        | 1821 -> Some { ItemTypeGroupData.id = 1821; categoryId = 66 }
        | 1822 -> Some { ItemTypeGroupData.id = 1822; categoryId = 66 }
        | 1823 -> Some { ItemTypeGroupData.id = 1823; categoryId = 66 }
        | 1824 -> Some { ItemTypeGroupData.id = 1824; categoryId = 66 }
        | 1825 -> Some { ItemTypeGroupData.id = 1825; categoryId = 66 }
        | 1826 -> Some { ItemTypeGroupData.id = 1826; categoryId = 66 }
        | 1827 -> Some { ItemTypeGroupData.id = 1827; categoryId = 66 }
        | 1828 -> Some { ItemTypeGroupData.id = 1828; categoryId = 66 }
        | 1829 -> Some { ItemTypeGroupData.id = 1829; categoryId = 66 }
        | 1830 -> Some { ItemTypeGroupData.id = 1830; categoryId = 66 }
        | 1831 -> Some { ItemTypeGroupData.id = 1831; categoryId = 66 }
        | 1832 -> Some { ItemTypeGroupData.id = 1832; categoryId = 66 }
        | 1833 -> Some { ItemTypeGroupData.id = 1833; categoryId = 66 }
        | 1834 -> Some { ItemTypeGroupData.id = 1834; categoryId = 66 }
        | 1835 -> Some { ItemTypeGroupData.id = 1835; categoryId = 66 }
        | 1836 -> Some { ItemTypeGroupData.id = 1836; categoryId = 66 }
        | 1837 -> Some { ItemTypeGroupData.id = 1837; categoryId = 66 }
        | 1838 -> Some { ItemTypeGroupData.id = 1838; categoryId = 66 }
        | 1839 -> Some { ItemTypeGroupData.id = 1839; categoryId = 66 }
        | 1840 -> Some { ItemTypeGroupData.id = 1840; categoryId = 66 }
        | 1841 -> Some { ItemTypeGroupData.id = 1841; categoryId = 66 }
        | 1842 -> Some { ItemTypeGroupData.id = 1842; categoryId = 66 }
        | 1843 -> Some { ItemTypeGroupData.id = 1843; categoryId = 66 }
        | 1844 -> Some { ItemTypeGroupData.id = 1844; categoryId = 66 }
        | 1845 -> Some { ItemTypeGroupData.id = 1845; categoryId = 66 }
        | 1846 -> Some { ItemTypeGroupData.id = 1846; categoryId = 66 }
        | 1847 -> Some { ItemTypeGroupData.id = 1847; categoryId = 66 }
        | 1848 -> Some { ItemTypeGroupData.id = 1848; categoryId = 66 }
        | 1849 -> Some { ItemTypeGroupData.id = 1849; categoryId = 66 }
        | 1850 -> Some { ItemTypeGroupData.id = 1850; categoryId = 66 }
        | 1851 -> Some { ItemTypeGroupData.id = 1851; categoryId = 66 }
        | 1852 -> Some { ItemTypeGroupData.id = 1852; categoryId = 66 }
        | 1853 -> Some { ItemTypeGroupData.id = 1853; categoryId = 66 }
        | 1854 -> Some { ItemTypeGroupData.id = 1854; categoryId = 66 }
        | 1855 -> Some { ItemTypeGroupData.id = 1855; categoryId = 66 }
        | 1856 -> Some { ItemTypeGroupData.id = 1856; categoryId = 66 }
        | 1857 -> Some { ItemTypeGroupData.id = 1857; categoryId = 66 }
        | 1858 -> Some { ItemTypeGroupData.id = 1858; categoryId = 66 }
        | 1859 -> Some { ItemTypeGroupData.id = 1859; categoryId = 66 }
        | 1860 -> Some { ItemTypeGroupData.id = 1860; categoryId = 66 }
        | 1861 -> Some { ItemTypeGroupData.id = 1861; categoryId = 66 }
        | 1862 -> Some { ItemTypeGroupData.id = 1862; categoryId = 66 }
        | 1863 -> Some { ItemTypeGroupData.id = 1863; categoryId = 66 }
        | 1864 -> Some { ItemTypeGroupData.id = 1864; categoryId = 66 }
        | 1865 -> Some { ItemTypeGroupData.id = 1865; categoryId = 66 }
        | 1866 -> Some { ItemTypeGroupData.id = 1866; categoryId = 66 }
        | 1867 -> Some { ItemTypeGroupData.id = 1867; categoryId = 66 }
        | 1868 -> Some { ItemTypeGroupData.id = 1868; categoryId = 66 }
        | 1869 -> Some { ItemTypeGroupData.id = 1869; categoryId = 66 }
        | 1870 -> Some { ItemTypeGroupData.id = 1870; categoryId = 66 }
        | 1887 -> Some { ItemTypeGroupData.id = 1887; categoryId = 66 }
        | 1912 -> Some { ItemTypeGroupData.id = 1912; categoryId = 66 }
        | 1913 -> Some { ItemTypeGroupData.id = 1913; categoryId = 66 }
        | 1914 -> Some { ItemTypeGroupData.id = 1914; categoryId = 66 }
        | 1933 -> Some { ItemTypeGroupData.id = 1933; categoryId = 66 }
        | 1934 -> Some { ItemTypeGroupData.id = 1934; categoryId = 66 }
        | 1935 -> Some { ItemTypeGroupData.id = 1935; categoryId = 66 }
        | 1936 -> Some { ItemTypeGroupData.id = 1936; categoryId = 66 }
        | 1937 -> Some { ItemTypeGroupData.id = 1937; categoryId = 66 }
        | 1938 -> Some { ItemTypeGroupData.id = 1938; categoryId = 66 }
        | 1939 -> Some { ItemTypeGroupData.id = 1939; categoryId = 66 }
        | 1941 -> Some { ItemTypeGroupData.id = 1941; categoryId = 66 }
        | 1942 -> Some { ItemTypeGroupData.id = 1942; categoryId = 66 }
        | 1943 -> Some { ItemTypeGroupData.id = 1943; categoryId = 66 }
        | 1944 -> Some { ItemTypeGroupData.id = 1944; categoryId = 66 }
        | 1945 -> Some { ItemTypeGroupData.id = 1945; categoryId = 66 }
        | 1962 -> Some { ItemTypeGroupData.id = 1962; categoryId = 66 }
        | 1966 -> Some { ItemTypeGroupData.id = 1966; categoryId = 66 }
        | 1967 -> Some { ItemTypeGroupData.id = 1967; categoryId = 66 }
        | 1968 -> Some { ItemTypeGroupData.id = 1968; categoryId = 66 }
        | 1974 -> Some { ItemTypeGroupData.id = 1974; categoryId = 66 }
        | 1984 -> Some { ItemTypeGroupData.id = 1984; categoryId = 66 }
        | 1537 -> Some { ItemTypeGroupData.id = 1537; categoryId = 87 }
        | 1652 -> Some { ItemTypeGroupData.id = 1652; categoryId = 87 }
        | 1653 -> Some { ItemTypeGroupData.id = 1653; categoryId = 87 }
        | 1950 -> Some { ItemTypeGroupData.id = 1950; categoryId = 91 }
        | 1951 -> Some { ItemTypeGroupData.id = 1951; categoryId = 91 }
        | 1952 -> Some { ItemTypeGroupData.id = 1952; categoryId = 91 }
        | 1953 -> Some { ItemTypeGroupData.id = 1953; categoryId = 91 }
        | 1954 -> Some { ItemTypeGroupData.id = 1954; categoryId = 91 }
        | 1955 -> Some { ItemTypeGroupData.id = 1955; categoryId = 91 }
        | 350858 -> Some { ItemTypeGroupData.id = 350858; categoryId = 350001 }
        | 351064 -> Some { ItemTypeGroupData.id = 351064; categoryId = 350001 }
        | 351121 -> Some { ItemTypeGroupData.id = 351121; categoryId = 350001 }
        | 351210 -> Some { ItemTypeGroupData.id = 351210; categoryId = 350001 }
        | 351648 -> Some { ItemTypeGroupData.id = 351648; categoryId = 350001 }
        | 351844 -> Some { ItemTypeGroupData.id = 351844; categoryId = 350001 }
        | 354641 -> Some { ItemTypeGroupData.id = 354641; categoryId = 350001 }
        | 354753 -> Some { ItemTypeGroupData.id = 354753; categoryId = 350001 }
        | 364204 -> Some { ItemTypeGroupData.id = 364204; categoryId = 350001 }
        | 367487 -> Some { ItemTypeGroupData.id = 367487; categoryId = 350001 }
        | 367580 -> Some { ItemTypeGroupData.id = 367580; categoryId = 350001 }
        | 367594 -> Some { ItemTypeGroupData.id = 367594; categoryId = 350001 }
        | 367774 -> Some { ItemTypeGroupData.id = 367774; categoryId = 350001 }
        | 367776 -> Some { ItemTypeGroupData.id = 367776; categoryId = 350001 }
        | 368656 -> Some { ItemTypeGroupData.id = 368656; categoryId = 350001 }
        | 368666 -> Some { ItemTypeGroupData.id = 368666; categoryId = 350001 }
        | 368726 -> Some { ItemTypeGroupData.id = 368726; categoryId = 350001 }
        | _ -> None
    let groupsByCategory = function
        | 0 -> [| 0 |]
        | 1 -> [| 1;2;19;32 |]
        | 2 -> [| 3;4;5;6;7;8;9;10;11;12;13;14;186;226;227;305;307;310;312;318;336;340;366;368;382;411;448;502;517;649;711;835;836;874;885;897;920;988;995;1071;1165;1198;1316;1704;1882;1915;1940;1971;1973;1975;1978;1980;1981;1983;1991;1998 |]
        | 3 -> [| 15;16 |]
        | 4 -> [| 17;18;20;422;423;427;428;429;712;754;886;966;967;974;1136;1676;1996 |]
        | 5 -> [| 23;24;872;876;943;1301;1311;1739;1875 |]
        | 6 -> [| 25;26;27;28;29;30;31;237;324;358;380;381;419;420;463;485;513;540;541;543;547;659;830;831;832;833;834;883;893;894;898;900;902;906;941;963;1022;1201;1202;1283;1305;1527;1534;1538;1972;2001 |]
        | 7 -> [| 38;39;40;41;43;46;47;48;49;52;53;54;55;56;57;59;60;61;62;63;65;67;68;71;72;74;76;77;78;80;82;96;98;201;202;203;205;208;209;210;211;212;213;225;285;289;290;291;295;302;308;309;315;316;317;321;325;326;328;329;330;338;339;341;353;357;367;378;379;405;406;407;464;472;475;481;483;499;501;506;507;508;509;510;511;512;514;515;518;524;538;546;585;586;588;589;590;638;642;644;645;646;647;650;658;660;737;753;762;763;764;765;766;767;768;769;770;771;773;774;775;776;777;778;779;781;782;786;815;842;862;878;896;899;901;904;905;1122;1150;1154;1156;1189;1199;1223;1226;1232;1233;1234;1238;1245;1289;1292;1299;1306;1308;1313;1395;1396;1533;1672;1673;1674;1697;1698;1699;1700;1706;1770;1815;1894;1969;1986;1988;2003;2004;2008;2013 |]
        | 8 -> [| 83;85;86;87;88;89;90;92;372;373;374;375;376;377;384;385;386;387;394;395;396;425;476;479;482;492;497;498;500;548;648;653;654;655;656;657;663;772;863;864;892;907;908;909;910;911;916;972;1010;1019;1153;1158;1400;1546;1547;1548;1549;1550;1551;1559;1569;1677;1678;1701;1702;1769;1771;1772;1773;1774;1976;1987;1989 |]
        | 9 -> [| 104;105;106;107;108;109;110;111;118;119;120;121;123;126;127;128;129;130;131;132;133;134;135;136;137;139;140;141;142;143;145;147;148;151;152;154;156;157;158;160;161;162;163;165;166;167;168;169;170;172;174;175;176;177;178;218;223;224;296;342;343;344;345;346;347;348;349;350;352;356;360;371;400;401;408;410;447;477;478;486;487;489;490;503;504;516;525;532;535;537;643;651;718;722;723;724;725;726;727;787;841;853;854;855;856;857;858;859;860;870;871;888;889;890;891;912;914;915;917;918;944;945;965;973;996;1013;1045;1046;1048;1123;1137;1139;1142;1143;1144;1145;1146;1147;1151;1152;1155;1157;1160;1162;1190;1191;1197;1200;1222;1224;1227;1239;1267;1268;1269;1270;1277;1293;1294;1295;1309;1317;1318;1397;1399;1461;1462;1542;1543;1679;1703;1707;1708;1709;1718;1723;1810;1812;1888;1889;1890;1891;1948;1990;1992;1993;1994;2010 |]
        | 10 -> [| 94;95 |]
        | 11 -> [| 99;180;182;185;279;286;287;288;297;298;301;306;319;323;335;337;383;435;446;494;495;496;520;522;523;527;533;534;550;551;552;553;554;555;556;557;558;559;560;561;562;563;564;565;566;567;568;569;570;571;572;573;574;575;576;577;578;579;580;581;582;583;584;593;594;595;596;597;602;603;604;605;606;611;612;613;614;615;620;621;622;623;624;629;630;631;632;633;665;666;667;668;669;670;671;672;673;674;675;676;677;678;679;680;681;682;683;684;685;686;687;688;689;690;691;692;693;694;695;696;697;698;699;700;701;702;703;704;705;706;715;755;756;757;758;759;760;761;784;789;790;791;792;793;794;795;796;797;798;799;800;801;802;803;804;805;806;807;808;809;810;811;812;813;814;816;817;818;819;820;821;822;823;824;825;826;827;828;829;843;844;845;846;847;848;849;850;851;852;861;865;866;867;868;875;922;924;925;927;934;952;959;960;961;982;983;984;985;986;987;1006;1007;1051;1052;1053;1054;1056;1166;1167;1168;1169;1174;1175;1176;1177;1178;1179;1180;1181;1182;1183;1184;1185;1186;1207;1252;1255;1259;1262;1265;1285;1286;1287;1288;1307;1310;1402;1411;1412;1413;1414;1452;1453;1454;1455;1465;1529;1530;1566;1567;1568;1664;1665;1666;1667;1681;1682;1683;1684;1685;1686;1687;1688;1689;1690;1691;1692;1720;1721;1722;1724;1725;1726;1727;1728;1729;1731;1734;1735;1736;1737;1759;1761;1762;1764;1765;1766;1767;1768;1788;1789;1790;1791;1792;1793;1794;1795;1796;1797;1798;1799;1800;1803;1804;1805;1806;1807;1813;1814;1872;1878;1879;1880;1895;1896;1909;1925;1926;1927;1928;1929;1956;1982;1997;2009 |]
        | 14 -> [| 190;191;192;193;194;195;196;197;198;199 |]
        | 16 -> [| 255;256;257;258;266;268;269;270;272;273;274;275;278;505;1209;1210;1213;1216;1217;1218;1220;1240;1241;1545 |]
        | 17 -> [| 267;280;281;282;283;284;313;314;332;333;334;355;369;370;409;474;493;521;526;528;530;536;652;716;732;733;734;735;873;879;880;884;913;955;964;1031;1118;1141;1206;1248;1314;1818;1886;1964;1977;1979;1995;2002 |]
        | 18 -> [| 97;100;101;299;470;544;545;549;639;640;641;1023;1159 |]
        | 20 -> [| 300;303;304;721;738;739;740;741;742;743;744;745;746;747;748;749;750;751;783;1228;1229;1230;1231;1730 |]
        | 22 -> [| 361;1149;1246;1247;1249;1250;1273;1274;1275;1276;1297;1312;2005 |]
        | 23 -> [| 311;363;364;365;397;404;413;414;416;417;418;426;430;438;439;440;441;443;444;445;449;471;473;480;707;709;710;837;838;839;840;877;1212;1282 |]
        | 24 -> [| 436;484;661;662;881;882;977 |]
        | 25 -> [| 450;451;452;453;454;455;456;457;458;459;460;461;462;465;467;468;469;519;903;1884;1911;1920;1921;1922;1923;2006 |]
        | 26 -> [| 935;1067;1068 |]
        | 29 -> [| 937;1109;1121;1319 |]
        | 30 -> [| 1083;1084;1085;1086;1087;1088;1089;1090;1091;1092;1093;1271;1670 |]
        | 32 -> [| 954;956;957;958 |]
        | 34 -> [| 971;990;991;992;993;997 |]
        | 35 -> [| 728;729;730;731;979;1304 |]
        | 39 -> [| 1016;1020;1021 |]
        | 40 -> [| 1003;1004;1005;1012 |]
        | 41 -> [| 1026;1027;1028;1029;1030;1036;1063;1081;1082 |]
        | 42 -> [| 1032;1033;1035 |]
        | 43 -> [| 1034;1040;1041;1042 |]
        | 46 -> [| 1025;1073;1106 |]
        | 49 -> [| 940;1079 |]
        | 53 -> [| 1105;1107;1108 |]
        | 54 -> [| 1110;1111;1112 |]
        | 59 -> [| 1126 |]
        | 63 -> [| 976;1194;1195;1225 |]
        | 65 -> [| 1404;1405;1406;1407;1408;1409;1410;1657;1876;1924;2015;2016;2017 |]
        | 66 -> [| 1321;1322;1323;1324;1325;1326;1327;1328;1329;1330;1331;1332;1333;1415;1416;1429;1430;1441;1442;1535;1562;1570;1579;1580;1581;1582;1583;1584;1585;1586;1587;1588;1589;1590;1591;1592;1593;1594;1595;1596;1598;1599;1600;1601;1602;1603;1604;1605;1606;1607;1608;1609;1610;1611;1612;1613;1614;1615;1616;1617;1618;1619;1620;1621;1622;1629;1630;1631;1632;1633;1634;1635;1639;1640;1641;1642;1647;1648;1649;1693;1694;1695;1696;1717;1719;1816;1819;1820;1821;1822;1823;1824;1825;1826;1827;1828;1829;1830;1831;1832;1833;1834;1835;1836;1837;1838;1839;1840;1841;1842;1843;1844;1845;1846;1847;1848;1849;1850;1851;1852;1853;1854;1855;1856;1857;1858;1859;1860;1861;1862;1863;1864;1865;1866;1867;1868;1869;1870;1887;1912;1913;1914;1933;1934;1935;1936;1937;1938;1939;1941;1942;1943;1944;1945;1962;1966;1967;1968;1974;1984 |]
        | 87 -> [| 1537;1652;1653 |]
        | 91 -> [| 1950;1951;1952;1953;1954;1955 |]
        | 350001 -> [| 350858;351064;351121;351210;351648;351844;354641;354753;364204;367487;367580;367594;367774;367776;368656;368666;368726 |]
        | _ -> [||]
    let itemTypesByGroup = function
        | 0 -> [| 0;48464;48465 |]
        | 2 -> [| 2 |]
        | 3 -> [| 3 |]
        | 4 -> [| 4 |]
        | 5 -> [| 5 |]
        | 6 -> [| 6;7;8;9;10;3796;3797;3798;3799;3800;3801;3802;3803;34331;45030;45031;45032;45033;45034;45035;45036;45037;45038;45039;45040;45041;45042;45046;45047 |]
        | 7 -> [| 11;12;13;2014;2015;2016;2017;2063;30889 |]
        | 8 -> [| 14 |]
        | 9 -> [| 15;17774 |]
        | 10 -> [| 16;17;3873;3874;3875;3876;3877;12292;29624;29625;29626;29627;29628;29629;29630;29631;29632;29633;29634;29635 |]
        | 458 -> [| 18;17455;17456;28421;28422;28423;46685;46701 |]
        | 461 -> [| 19;17466;17467;28418;28419;28420;46688;46704 |]
        | 457 -> [| 20;17452;17453;28409;28410;28411;28620;46683;46699 |]
        | 454 -> [| 21;17440;17441;28400;28401;28402;46680;46696 |]
        | 450 -> [| 22;17425;17426;26852;28367;28385;28387;28625;46678;46691 |]
        | 12 -> [| 23;2263;3293;3296;3297;41567 |]
        | 13 -> [| 24 |]
        | 14 -> [| 25;29148 |]
        | 16 -> [| 26;27;28 |]
        | 17 -> [| 29 |]
        | 19 -> [| 30 |]
        | 18 -> [| 34;35;36;37;38;39;40;11399;27029;48927 |]
        | 280 -> [| 41;42;43;3643;3647;3673;3685;3687;3699;3812;3814;3922;4090;9826;9844;9850;9852;12865;32374;34874;34875;34876;34877;34878;34879;34880;34881;34882;34883;41023;41024;41025;41026;41027;41028;41029 |]
        | 1034 -> [| 44;2312;2317;2319;2321;2327;2328;2329;2463;3689;3691;3693;3695;3697;3725;3775;3828;9830;9832;9836;9838;9840;9842;15317 |]
        | 281 -> [| 45;3715;3717;3777;11855;21564;29470;29481;29482 |]
        | 24 -> [| 49;50;51;29247 |]
        | 94 -> [| 52 |]
        | 95 -> [| 53 |]
        | 15 -> [| 54;56;57;58;59;1529;1530;1531;1926;1927;1928;1929;1930;1931;1932;2071;2496;2497;2498;2499;2500;2501;2502;3864;3865;3866;3867;3868;3869;3870;3871;3872;4023;4024;9856;9857;9867;9868;9873;10795;12242;12294;12295;19757;21642;21644;21645;21646;22296;22297;22298;29323;29387;29388;29389;29390;34325;34326 |]
        | 1319 -> [| 60;34870 |]
        | 23 -> [| 164;165;166;9917;9919;9921;9923;9925;9927;9929;9931;9933;9935;9937;9939;16715;16718;23734;29138;29139;29140;29141;29142;29143 |]
        | 83 -> [| 178;179;180;181;182;183;184;185;186;187;188;189;190;191;192;193;194;195;196;197;198;199;200;201;17664;17666;17668;17670;17672;17674;17676;17678;19970;19972;19974;19976;19986;19988;19990;19992;19994;19996;19998;20000;20002;20004;20006;20008;20721;20723;20725;20727;20729;20731;20733;20735;20737;20739;20741;20743;20745;20747;20749;20751;20753;20755;20757;20759;20761;20763;20765;20767;20769;20771;20773;20775;20777;20779;20781;20783;20785;20787;20789;20791;20793;20795;20797;20799;20801;20803;20805;20807;20809;20811;20813;20815;21894;21896;21898;21900;21902;21904;21906;21908;21910;21912;21914;21916;21918;21920;21922;21924;21926;21928;21931;21933;21935;21937;21939;21941;28324;28326;28328;28330;28332;28334;28336;28338;32801 |]
        | 386 -> [| 202;203;204;205;2165;17908;27373;27377;27389;27391;27395;27399;27409;27423;27425;27427;27429;27431;27893;27894;30426 |]
        | 385 -> [| 206;207;208;209;2212;27433;27435;27437;27439;27441;27443;27445;27447;27449;27451;27453;27455;27889;27890;30428 |]
        | 384 -> [| 210;211;212;213;16025;27353;27361;27365;27367;27369;27371;27375;27379;27381;27383;27385;27387;27885;27886;30430;32463 |]
        | 85 -> [| 215;216;217;218;219;220;221;222;223;224;225;226;227;228;229;230;231;232;233;234;235;236;237;238;17648;17650;17652;17654;17656;17658;17660;17662;19962;19964;19966;19968;20034;20036;20038;20040;20043;20045;20047;20049;20051;20053;20055;20057;20913;20915;20917;20919;20921;20923;20925;20927;20929;20931;20933;20935;20937;20939;20941;20943;20945;20947;20949;20951;20953;20955;20957;20959;20961;20963;20965;20967;20969;20971;20973;20975;20977;20979;20981;20983;20985;20987;20989;20991;20993;20995;20997;20999;21001;21003;21005;21007;21320;21322;21324;21326;21328;21330;21332;21334;21336;21338;21340;21342;21344;21346;21348;21350;21352;21354;21356;21358;21360;21362;21364;21366;21368;21370;21372;21374;21376;21378;21380;21382;21384;21386;21388;21390;21392;21394;21396;21398;21400;21402;21404;21406;21408;21410;21412;21414;21416;21418;21420;21422;21424;21426;21428;21430;21432;21434;21436;21438;21440;21442;21444;21446;21740;22961;22963;22965;22967;22969;22971;22973;22975;22977;22979;22981;22983;22985;22987;22989;22991;22993;22995;22997;22999;23001;23003;23005;23007;23009;23011;23013;23015;23017;23019;23021;23023;23025;23027;23029;23031;23033;23035;23037;23039;23041;23043;23045;23047;23049;23051;23053;32803 |]
        | 86 -> [| 239;240;241;242;243;244;245;246;247;248;249;250;251;252;253;254;255;256;257;258;259;260;261;262;17680;17682;17684;17686;17688;17690;17692;17694;19978;19980;19982;19984;20010;20012;20014;20016;20018;20020;20022;20024;20026;20028;20030;20032;20128;20130;20132;20134;20817;20819;20821;20823;20825;20827;20829;20831;20833;20835;20837;20839;20841;20843;20845;20847;20849;20851;20853;20855;20857;20859;20861;20863;20865;20867;20869;20871;20873;20875;20877;20879;20881;20883;20885;20887;20889;20891;20893;20895;20897;20899;20901;20903;20905;20907;20909;20911;21194;21196;21198;21200;21202;21204;21206;21208;21210;21212;21214;21216;21218;21220;21222;21224;21226;21228;21230;21232;21234;21236;21238;21240;21242;21244;21246;21248;21250;21252;21254;21256;21258;21260;21262;21264;21266;21268;21270;21272;21274;21276;21278;21280;21282;21284;21286;21288;21290;21292;21294;21296;21298;21300;21302;21304;21306;21308;21310;21312;21314;21316;21318;21450;23071;23073;23075;23077;23079;23081;23083;23085;23089;23091;23093;23095;23097;23099;23101;23103;23105;23107;23109;23111;23113;23115;23117;23119;32799 |]
        | 87 -> [| 263;264;3552;3554;11283;11285;11287;11289;31982;31990;31998;32006;32014;33330;33332;33334;41489;41490 |]
        | 1158 -> [| 265 |]
        | 387 -> [| 266;2512;2514;2516;27313;27315;27317;27319;27321;27323;27325;27327;27329;27331;27333;27335;27883;27884 |]
        | 89 -> [| 267;2210;2506;2508;2510;27337;27339;27341;27343;27345;27347;27349;27351;27355;27357;27359;27363;27891;27892 |]
        | 394 -> [| 269;1810;1814;1816;27505;27507;27509;27511;27513;27515;27517;27519;27521;27523;27525;27527 |]
        | 92 -> [| 270;3733;3735;3737 |]
        | 38 -> [| 377;380;3829;3831;3839;3841;3849;3851;8387;8397;8401;8409;8419;8427;8433;8437;8465;8477;8481;8489;8505;8517;8521;8529;15408;16142;16144;16146;19489;20625;20627;20629;20631;28742;28744;28746;31922;31924;31926;31928;31930;31932;40354;40355;40356;40357;41459;41460;41461;41462;47800;47804;47808 |]
        | 39 -> [| 393;394;6485;6487;6489;6491;37805 |]
        | 40 -> [| 399;400;3542;6437;6439;6441;6443;10039;10836;10838;10840;10842;10850;10858;10866;10868;10870;10872;10874;10876;10878;10880;10882;10884;10886;10888;13947;13948;13949;13950;13951;13952;13953;13954;14597;14599;14601;14603;14700;14701;14702;14703;14704;14705;14706;14707;15897;15898;15899;15900;15901;15902;15903;15904;19169;19171;19173;19175;19177;19179;19181;19183;19185;19187;19189;19191;19193;19194;19195;19196;19197;19198;19199;19200;19201;19202;19203;19204;19205;19206;19207;19208;20617;20619;20621;20623;20703;41505;41506;41507;41508;41509;41510;47781;47785;47789;47793 |]
        | 41 -> [| 405;406;3544;3586;3588;3596;3598;3606;3608;3616;3618;8531;8533;8535;8537;8579;8581;8583;8585;8627;8629;8631;8633;8635;8637;8639;8641;8683;8685;8687;8689;19129;19131;19133;19135;19137;19139;19141;19143;19145;19147;19149;19151;32467;41469;41470;41471;41472;41473;41474 |]
        | 43 -> [| 421;1195;2032;4421;4423;4425;4427;4431;4433;4435;4437;14140;14142;15788;16599;16601;16603;16605;17526;21816;21817;21818;21819;23813;28530 |]
        | 46 -> [| 434;438;439;440;5945;5955;5971;5973;5975;6001;6003;6005;12052;12054;12056;12058;12066;12068;12076;12084;14102;14104;14106;14108;14110;14112;14114;14116;14118;14120;14122;14124;14484;14486;14488;14490;14492;14494;14496;14498;14500;14502;14504;14506;14508;14510;14512;14514;15747;15749;15751;15753;15755;15757;15759;15761;15764;15766;15768;15770;18658;18660;18662;18664;18666;18668;18670;18672;18674;18676;18680;18682;18684;18686;18688;18690;18692;18694;18696;18698;19313;19315;19317;19319;19321;19323;19325;19327;19329;19335;19337;19339;19341;19343;19345;19347;19349;19351;19353;19359;19491;21470;21472;21474;21476;21478;21480;21857;35656;35657;35658;35659;35660;35661;35662;41236;41237;41238;41239;41240;41241;41249;41250;41251;41252;41253;41254;41255;47408;47740;47745;47749;47753;47757 |]
        | 47 -> [| 442;2038;6129;6131;6133;6135 |]
        | 48 -> [| 443;1855;6525;6527;6529;6531;12604 |]
        | 49 -> [| 444;2333;6567;6569;6571;6573 |]
        | 52 -> [| 447;448;3242;3244;5399;5401;5403;5405;5439;5441;5443;5445;14242;14244;14246;14248;14250;14252;14254;14256;14258;14260;14656;14658;14660;14662;14664;14666;14668;14670;15431;15433;15887;15889;15891;15893;16140;21510;21512;22476;28516;28518;32459;40730;40731;40732;40733;40734;40736;40737;40750;40752;40754;40756;40758;40762;40764;41061;41062;47732;47736 |]
        | 53 -> [| 450;451;452;453;454;455;456;457;458;459;460;461;462;463;464;2985;2993;3001;3009;3017;3025;3033;3041;3049;3057;3065;3285;3512;3520;3559;3561;3634;3636;3638;3640;4044;4045;4049;4147;5175;5177;5179;5181;5215;5217;5219;5221;6631;6633;6635;6637;6671;6673;6675;6677;6715;6717;6719;6721;6757;6759;6761;6763;6805;6807;6809;6811;6859;6861;6863;6865;6919;6921;6923;6925;6959;6961;6963;6965;6999;7001;7003;7005;7043;7045;7047;7049;7083;7085;7087;7089;7123;7125;7127;7131;7167;7169;7171;7173;13791;13793;13795;13797;13799;13801;13803;13805;13807;13809;13811;13813;13815;13817;13819;13820;13821;13822;13823;13824;13825;13826;13827;13828;13829;13830;13831;13832;13833;13834;14417;14419;14421;14423;14425;14427;14429;14431;14433;14435;14437;14439;14441;14443;14445;14447;14449;14451;14453;14455;15399;15401;15403;15427;15429;15845;15846;15847;15848;15849;15850;15851;15852;15853;15854;15855;15856;15857;15858;15859;15860;15861;15862;15863;15864;15865;15866;15867;15868;15869;15870;15871;15872;15873;15874;16128;16129;16131;20444;20446;23834;23836;23838;23840;23842;23844;23846;23848;23850;34271;34272;34274;34276;34580;37290;37296;37297;37298;37299;41063;41064;41065;41066;41067;41099;41100;41101;41102;41103;41104;41114;41115;41116;41117;41118;41119;47446 |]
        | 54 -> [| 482;483;3651;5231;5233;5235;5237;5239;5241;5243;5245;12108;21841;22921;22923;28369;28748;28750;37450;37451;37452 |]
        | 55 -> [| 484;485;486;487;488;489;490;491;492;493;494;495;496;497;498;2865;2873;2881;2889;2897;2905;2913;2921;2929;2937;2945;2953;2961;2969;2977;3571;3573;8759;8785;8787;8789;8815;8817;8819;8821;8863;8865;8867;8869;8903;8905;8907;8909;9071;9073;9091;9093;9127;9129;9131;9133;9135;9137;9139;9141;9207;9209;9211;9213;9247;9249;9251;9253;9287;9289;9291;9293;9327;9329;9331;9333;9367;9369;9371;9373;9377;9411;9413;9415;9417;9419;9421;9451;9453;9455;9457;9491;9493;9495;9497;13773;13774;13775;13776;13777;13778;13779;13781;13782;13783;13784;13785;13786;13787;13788;14457;14459;14461;14463;14465;14467;14469;14471;14473;14475;15443;15445;16046;16047;16048;16049;16050;16051;16052;16053;16054;16055;16056;16057;16058;16059;16060;16148;16149;16150;20452;20454;21545;21547;21549;21551;21553;21555;21557;21559;21561;34284;34286;34288;37289;37304;37305;37306;37307;41080;41081;41082;41083;41150;41151;41152;41153;41154;41156;41157;41158;41159;41160 |]
        | 509 -> [| 499;2404;7993;8089;8091;8093;13925;13926;16068;16136;17491;20595;22565;32461 |]
        | 510 -> [| 501;2410;7997;8101;8103;8105;13921;13922;16064;16137;17487;20599;22567 |]
        | 508 -> [| 503;2420;8001;8113;8115;8117;13923;13924;14524;14525;14526;14527;14680;14681;14682;14683;16067;17490;20603;22569;28513;34294 |]
        | 767 -> [| 506;1445;1447;8171;8173;8175;8177;8203;8205;8207;8209;14144;14146;15080;15082;15084;15086;15088;15090;15092;15094;15437;17510;17528;23896;28532 |]
        | 770 -> [| 508;1254;1256;8291;8293;8295;8297;8323;8325;8327;8329;37825 |]
        | 768 -> [| 509;1246;1248;8131;8133;8135;8137;8163;8165;8167;8169;23894 |]
        | 59 -> [| 518;519;520;5913;5915;5917;5919;5929;5931;5933;5935;13939;14536;14538;14540;14542;15447;15806;21486;21488;44112;49730 |]
        | 60 -> [| 521;2046;2048;5829;5831;5833;5835;5837;5839;5841;5843;22893;23418;30839;40714;40715;40716;40717;40718;41200;41201;41202;41203;41204;41205;41206;41207;41208;41210;41211;47254;47255;47256;47257;47258 |]
        | 61 -> [| 522;1185;2018;2020;2022;3472;3480;3488;3496;3504;4745;4747;4749;4751;4785;4787;4789;4791;4869;4871;4873;4875;4909;4911;4913;4915;6073;6083;6097;6111;23801;23803;23805;41212;41213;41214;41215;41216;41217;41218;41219;41220;41484;41485;41486;41487;41488;48431;48435;48439 |]
        | 62 -> [| 523;1183;3528;3530;3534;3538;3540;4529;4531;4533;4535;4569;4571;4573;4575;4579;4609;4611;4613;4615;4621;13955;13956;13957;13958;13959;13960;13962;13963;13964;14067;14068;14069;14552;14554;14848;14849;14850;14851;14852;14853;14854;14855;15160;15161;15162;15163;15741;15742;15743;15744;15745;15746;17492;17493;17494;17546;17547;17548;18999;19001;19003;19005;19007;19009;19011;19013;19015;19017;19019;19021;19023;19025;19027;19029;19031;19033;19035;19036;19037;19038;19039;19040;19041;19042;19043;19044;19045;19046;20701;21853;22887;22889;22891;23795;23797;23799;28544;28549;28556;41498;41499;41500;41501;41502;47769;47773;47777 |]
        | 63 -> [| 524;2355;3653;3655;3663;3665;5683;5693;5697;5719;5721;5723;5743;5745;5747;5755;5757;5759;21504;21506;21508;41511;41512;41513;41514 |]
        | 65 -> [| 526;527;4025;4027;4029;4031;14262;14264;14266;14268;14270;14648;14650;14652;14654;15419;17500;17559;28514;30328;41038;47702 |]
        | 67 -> [| 529;1190;3575;5087;5089;5091;5093;12102;12217;12219;12221;12223;12225;16481;16483;16485;16487;16489;16491;16493;16495;19065;19067;19069;19071;19073;19075;19077;19079;19081;19083;19085;19087;23852;23854;23856;31946;31948;31950;41565;41566 |]
        | 68 -> [| 530;5135;5137;5139;5141;12257;12259;12261;12263;13001;14148;14150;14152;14154;14156;14158;14816;14818;14820;14822;14824;14826;14828;14830;15451;15875;15877;15879;15881;15883;15885;16497;16499;16501;16503;16505;16507;16509;16511;19101;19103;19105;19107;19109;19111;19113;19115;19117;19119;23821;23824;23829;40665;40666;40667;40668;40669;40670;48419;48423;48427 |]
        | 71 -> [| 533;4471;4473;4475;4477;12265;12267;12269;12271;13003;14160;14162;14164;14166;14168;14170;14832;14834;14836;14838;14840;14842;14844;14846;15794;15796;15798;15800;15802;15804;16465;16467;16469;16471;16473;16475;16477;16479;23815;23817;23819;37622;37623;37624;37625;37626;37627;37628;37629;37630;37631;40659;40660;40661;40662;40663;40664;47824;47828;47832 |]
        | 74 -> [| 561;562;563;564;565;566;567;568;569;570;571;572;573;574;575;3074;3082;3090;3098;3106;3114;3122;3130;3138;3146;3154;3162;3170;3178;3186;3546;3550;7247;7249;7251;7253;7287;7289;7291;7293;7327;7329;7331;7333;7367;7369;7371;7373;7407;7409;7411;7413;7447;7449;7451;7453;7487;7489;7491;7493;7535;7537;7539;7541;7579;7581;7583;7585;7619;7621;7623;7625;7663;7665;7667;7669;7703;7705;7707;7709;7743;7745;7747;7749;7783;7785;7787;7789;7827;7829;7831;7833;10678;10680;10688;10690;10692;10694;12344;12346;12354;12356;13864;13865;13866;13867;13868;13870;13872;13873;13874;13876;13878;13879;13880;13881;13882;13883;13884;13885;13886;13887;13888;13889;13890;13891;13892;13893;13894;14272;14274;14276;14278;14280;14282;14284;14286;14375;14377;14379;14381;14383;14385;14387;14389;14391;14393;14395;14397;14399;14401;14403;14405;14407;14409;14411;14413;14415;15421;15423;15814;15815;15816;15817;15818;15820;15821;15823;15824;15825;15826;15827;15828;15829;15830;15831;15832;15833;15834;15835;15836;15837;15838;15840;15841;15843;15844;16132;16133;16134;20448;20450;20587;20589;20591;22899;22901;22903;22905;22907;22909;22911;22913;22915;34278;34280;34282;37291;37300;37301;37302;37303;41076;41077;41078;41079;41126;41127;41128;41129;41130;41138;41139;41140;41141;41142 |]
        | 76 -> [| 577;2024;3556;3558;3566;3568;3576;3578;4829;4831;4833;4835;4955;4957;4959;4961;5007;5009;5011;5013;5017;5047;5049;5051;5053;14172;14174;14176;14178;14180;14182;14184;14186;15128;15130;15132;15134;15136;15138;15140;15142;15772;15774;15776;15778;15780;15782;15784;15786;20555;20557;20559;23807;23809;23811;41491;41492;41493;41494;41495 |]
        | 77 -> [| 578;2050;2281;2289;2291;2293;2295;2297;2299;2301;2303;4345;4346;4347;4348;4349;9608;9622;9632;9646;9660;13965;13966;13967;13968;13969;13994;13995;13996;13997;13998;14748;14749;14750;14751;14752;14753;14754;14755;14756;14757;14758;14759;14760;14761;14762;14763;14764;14765;14766;14767;15407;15418;17495;17496;17497;17498;17499;19257;19258;19259;19260;19261;19262;19263;19264;19265;19266;19267;19268;19269;19270;19271;19272;19273;19274;19275;19276;19277;19278;19279;19280;19281;19282;19283;19284;19285;19286;19287;19288;20633;20635;20637;20639;20641;30342;30420;30422;30424 |]
        | 80 -> [| 580;2117;5359;5361;5363;5365;20581;40690;40691;40692;40693;40694 |]
        | 82 -> [| 581;2341;5865;5867;5869;5871 |]
        | 25 -> [| 582;583;584;585;586;587;589;590;591;592;593;594;595;597;598;599;600;602;603;605;607;608;609;613;614;616;618;619;1896;1898;1900;1902;2161;3532;3751;3753;3766;3768;11019;11940;11942;17360;17619;17703;17705;17707;17812;17841;17924;17926;17928;17930;17932;29248;32880;32983;32985;32987;32989;33190;33468;33655;33657;33659;33661;33663;33665;33667;33669;33677;33816;34443;37453;37454;37455;37456;47269 |]
        | 237 -> [| 588;596;601;606;615;617;1233;9854;9858;9860;9862;33079;33081;33083 |]
        | 26 -> [| 620;621;622;623;624;625;626;627;628;629;630;631;632;633;634;635;1904;2006;11011;17634;17709;17713;17715;17718;17720;17722;17843;17922;25560;29336;29337;29340;29344;33470;33553;33639;33641;33643;33645;33647;33649;33651;33653;33818;34445;34475;34590;47270;49712 |]
        | 27 -> [| 638;639;640;641;642;643;644;645;1912;1914;1916;1918;4005;11936;11938;13202;17636;17726;17728;17732;17736;17738;17740;17918;17920;24688;24690;24692;24694;26840;26842;32305;32307;32309;32311;33472;33623;33625;33627;33629;33631;33633;33635;33637;33820;34118;34151;34213;34215;34217;34225;34227;34229;34237;34239;34247;34249;34251;34441;34457;34459;34461;34463;34465;34467;34469;34471;47271;47466 |]
        | 28 -> [| 648;649;650;651;652;653;654;655;656;657;1944;2863;2998;4363;4388;19744;32811;33689;33691;33693;33695 |]
        | 29 -> [| 670;33328 |]
        | 30 -> [| 671;3764;11567;23773;42126;42241;45649 |]
        | 31 -> [| 672;11129;11132;11134;21097;21628;27299;27301;27303;27305;29266;29328;29330;29332;29334;30842;33513;34496 |]
        | 104 -> [| 681;682 |]
        | 105 -> [| 683;684;685;689;690;691;935;936;937;938;939;940;941;943;944;945;946;947;948;949;950;952;953;954;955;956;960;961;962;963;964;965;966;2162;2835;3517;3533;3752;3754;3767;3769;11173;11175;11177;11179;11183;11185;11187;11189;11191;11193;11195;11197;11199;11201;11203;11366;11372;11374;11376;11378;11380;11382;11384;11388;11390;11394;11401;12031;12035;12037;12041;12043;12045;17620;17704;17706;17708;17813;17842;17925;17927;17929;17931;17933;29249;32208;32789;32881;32984;32986;32988;32990;33080;33082;33084;33191;33398;33469;33656;33658;33660;33662;33664;33666;33668;33670;33674;33678;33698;33817;34444;35780;39580;39581;39583;40301;40302;40315;40316;40317;40318;42525;45486;45533;47966;48638 |]
        | 106 -> [| 686;687;692;968;969;970;971;972;973;974;975;976;977;978;979;2007;2837;3519;11012;11958;11960;11962;11964;11966;11970;11972;11979;11986;11988;11990;11994;11996;12000;12004;12006;12012;12014;12016;12018;12020;12022;12024;17635;17710;17714;17716;17719;17721;17723;17844;17923;20126;29338;29339;29341;29345;32210;32791;33396;33471;33554;33640;33642;33644;33646;33648;33650;33652;33654;33676;33819;34446;34476;34478;34480;34591;35782;42524;45487;45532;45535;47967;48637;49716;49717 |]
        | 107 -> [| 688;693;994;995;996;997;998;999;4006;11937;11939;13203;17637;17727;17729;17733;17737;17739;17741;17919;17921;22429;22431;22437;22441;24689;24691;24693;24695;26843;28660;28662;28666;28711;32306;32308;32310;32312;33473;33624;33626;33628;33630;33632;33634;33636;33638;33821;34119;34153;34214;34216;34218;34220;34222;34224;34226;34228;34230;34232;34234;34236;34238;34240;34242;34244;34246;34248;34250;34252;34254;34256;34258;34442;34458;34460;34462;34464;34466;34468;34470;34472;45528;47716;47968 |]
        | 134 -> [| 784;785;12109;18069;22922;22924;25267;25541;25543;25813;26607;28749;28751;28789;38660;38661 |]
        | 136 -> [| 786;788;790;1876;1878;2405;2411;2421;3564;3570;4257;10630;10632;10643;13321;16063;16066;17486;17489;19740;20540;20594;20596;20598;20600;20602;20604;21543;22783;25716;26174;26759;27915;28376;28378;28380;28382;28384;28512;28566;32445;33447;33449;33451;33460;34291;34293;34295;41177;41178;41179;41183;41184;41185;41187;41190;41225;41226;41227;41228;41229;44103 |]
        | 166 -> [| 803;804;805;806;807;808;809;810;811;812;813;814;1216;1220;1221;1811;1815;1817;1819;1821;1823;1825;1827;1829;1831;1833;2179;2211;2213;2507;2509;2511;2513;2515;2517;2614;2622;2630;2638;2648;2656;2680;2802;2812;2818;17858;17860;17862;17864;21868;24472;24474;24476;24487;24489;24491;24496;24498;24500;24502;24504;24506;24508;24510;24512;24514;24516;24518;24520;24522;24524;24526;24528;24530;24532;24534;24536;24538;24540;24542;24543;24544;24604;24605;24614;24615;24616;24617;26760;26761;26762;32437;32439;32441;32443;37852;37853;37854;37855;37856;37857;37858;37859;37860;41278;41279;41280;41281;41282;41283;41284;41285;41288;41289;41292;41293;41296;41297;41300;41301 |]
        | 135 -> [| 819;820;821;822;823;824;825;826;827;828;829;830;831;832;833;2866;2874;2890;2898;2906;2914;2922;2938;2946;2954;2962;2970;2978;3572;3574;16029;16032;20453;20455;21546;21548;21550;21552;21554;21556;21558;21560;21562;34285;34287;34289;41092;41093;41094;41095;41096;41097;41098;41161;41162;41163;41165;41166;41167;41168;41169;41170;41171;41172;41173 |]
        | 133 -> [| 834;835;836;837;838;839;840;841;842;843;844;845;846;847;848;2986;2994;3002;3010;3018;3026;3034;3042;3050;3058;3066;3286;3513;3521;3560;3562;4148;20445;20447;23835;23837;23839;23841;23843;23845;23847;23849;23851;34273;34275;34277;41068;41069;41070;41071;41072;41073;41074;41075;41105;41106;41107;41108;41110;41111;41113;41120;41121;41122;41123;41124;41125;41186 |]
        | 165 -> [| 879;880;881;882;883;884;885;886;887;888;889;890;891;892;893;894;895;896;897;898;899;900;901;902;17665;17667;17669;17671;17673;17675;17677;17679;19995;20003;28325;28327;28329;28331;28333;28335;28337;28339;32802 |]
        | 111 -> [| 967;11130;11133;11135;21098;21629;27300;27302;27304;27306;29267;29329;29331;29333;29335;30843;33514;34497 |]
        | 108 -> [| 983;984;985;986;987;988;989;990;991;992;1945;2864;3039;4364;4389;19745;32812;33690;33692;33694;33696 |]
        | 110 -> [| 1002;3765;11568;23774;42138;45045;45648 |]
        | 118 -> [| 1010;1013;3830;3832;3840;3842;20626;20628;20630;20632;28743;28745;28747;31923;31925;31927;31929;31931;31933;41599;41600;41601;41602;41603;41604;41605;41606 |]
        | 119 -> [| 1026;1027 |]
        | 120 -> [| 1032;1033;3543;10040;10837;10839;10841;10843;10851;10859;12712;12714;12716;12718;20368;20618;20620;20622;20624;20704;22886;41632;41633;41634;41635;41636;41637 |]
        | 126 -> [| 1067;1071;1072;1073;12053;12055;12057;12059;12067;12069;12077;12085;15748;15750;15752;15754;15756;15758;15760;15762;15765;15767;15769;15771;21471;21473;21475;21477;21479;21481;21858;41242;41243;41244;41245;41246;41248;41256;41257;41258;41260;41261;41262;41313 |]
        | 127 -> [| 1074;2039 |]
        | 128 -> [| 1075;1856 |]
        | 129 -> [| 1076;2334 |]
        | 132 -> [| 1079;1080;3243;3245;4249;15888;15890;15892;15894;21511;21513;22477;28517;28519;28655;40740;40741;40742;40743;40744;40746;40747;40751;40753;40755;40757;40759;40763;40765 |]
        | 139 -> [| 1095;1096;9945;10191;15807;15896;21487;21489;22918;22920;44115;44116;44117 |]
        | 142 -> [| 1099;1184;3529;3531;3535;3539;3541;20702;21854;22888;22890;22892;23796;23798;23800;41614;41615;41616;41618;41619 |]
        | 143 -> [| 1100;2356;3654;3656;3664;3666;21505;21507;21509;41627;41628;41629;41630 |]
        | 145 -> [| 1102;1103;17501;17561;28515;30329;41221;41222 |]
        | 147 -> [| 1105;1191;3580;12103;12218;12220;12222;12224;12226;23853;23855;23857;31947;31949;31951;41697;41698 |]
        | 148 -> [| 1106;12258;12260;12262;12264;13002;15876;15878;15880;15882;15884;15886;23822;23825;23830;40684;40685;40686;40687;40688;40689 |]
        | 151 -> [| 1109;12266;12268;12270;12272;13004;15795;15797;15799;15801;15803;15805;23816;23818;23820;40672;40673;40674;40675;40676;40677 |]
        | 154 -> [| 1112;1113;1114;1115;1116;1117;1118;1119;1120;1121;1122;1123;1124;1125;1126;3075;3083;3091;3099;3107;3115;3123;3131;3139;3147;3155;3163;3171;3179;3187;3547;3557;10679;10681;12345;12347;12355;12357;15819;15822;15839;15842;20449;20451;20588;20590;20592;22900;22902;22904;22906;22908;22910;22912;22914;22916;24621;24623;34279;34281;34283;41085;41086;41087;41088;41089;41090;41091;41132;41133;41134;41135;41136;41137;41143;41144;41145;41146;41147;41148 |]
        | 156 -> [| 1128;2025;3567;3569;3577;3579;15773;15777;15779;15781;15783;15785;15787;20556;20558;20560;23808;23810;23812;41644;41645;41646;41647;41648 |]
        | 157 -> [| 1129;2282;2290;2292;2294;2296;2298;2300;2302;2304;20634;20636;20638;20640;20642;30343;30421;30423;30425;46011 |]
        | 167 -> [| 1130;1131;1132;1133;1134;1135;1136;1137;1138;1139;1140;1141;1142;1143;1144;1145;1146;1147;1148;1149;1150;1151;1152;1153;17649;17651;17653;17655;17657;17659;17661;17663;21335;32804 |]
        | 168 -> [| 1154;1155;1156;1157;1158;1159;1160;1161;1162;1163;1164;1165;1166;1167;1168;1169;1170;1171;1172;1173;1174;1175;1176;1177;17681;17683;17685;17687;17689;17691;17693;17695;23072;32800 |]
        | 169 -> [| 1178;1179;3553;3555;11284;11286;11288;11290;41598 |]
        | 96 -> [| 1182;1436;6041;6043;6045;6047 |]
        | 141 -> [| 1186;2019;2021;2023;3473;3489;3497;3505;23802;23804;23806;41639;41640;41641;41642;41643 |]
        | 764 -> [| 1192;1236;1244;5611;5613;5615;5617;5627;5629;5631;5633;14126;15812;21491 |]
        | 98 -> [| 1193;1197;1198;1262;1264;1266;1272;1274;1276;1282;1284;1286;1292;1294;1296;1302;1304;1306;13999;14001;14003;14005;14007;14009;14011;14013;14015;14017;14019;14021;14023;14025;14027;14049;14051;14053;14055;14057;14556;14560;14564;14568;14572;14576;14580;14584;14588;14592;14856;14858;14860;14862;14864;14866;14868;14870;14872;14874;14876;14878;14880;14882;14884;14886;14888;14890;14892;14894;14896;14898;14900;14902;14904;14906;14908;14910;14912;14914;14916;14918;14920;14922;14924;14926;14928;14930;14932;14934;15164;15166;15168;15170;15172;15174;15176;15178;15180;15182;15184;15186;15188;15190;15192;15194;15196;15198;15200;15202;15685;15687;15689;15691;15693;15695;15697;15699;15701;15703;16305;16307;16309;16311;16313;16315;16317;16319;16321;16323;16325;16327;16329;16331;16333;16335;16337;16339;16341;16343;16345;16347;16349;16351;17512;17514;17516;17518;17549;17551;17553;17555;17557;18700;18702;18704;18706;18708;18710;18712;18714;18716;18718;18720;18722;18724;18726;18728;18730;18740;18742;18744;18746;18748;18750;18752;18754;18756;18758;18760;18762;18764;18766;18768;18770;18772;18775;18777;18779;18781;18783;18785;18787;18789;18791;18793;18795;18797;28520;28547;28552;28554;28559;32809 |]
        | 99 -> [| 1194;3739;3740;3741;3742;3743 |]
        | 123 -> [| 1196;2033;15789;17527;23814;28531 |]
        | 100 -> [| 1201;2173;2175;2183;2185;2193;2195;2203;2205;2436;2444;2446;2454;2456;2464;2466;2476;2478;2486;2488;3549;15508;15510;16206;21638;21640;22780;23525;23559;23561;23563;23759;28209;28211;28213;28215;28262;28264;28266;28268;28270;28272;28274;28276;28278;28280;28282;28284;28286;28288;28290;28292;28294;28296;28298;28300;28302;28304;28306;28308;31864;31866;31868;31870;31872;31874;31876;31878;31880;31882;31884;31886;31888;31890;31892;31894;32465;33681;48744 |]
        | 101 -> [| 1202;3218;10246;10248;10250;10252;41030;43681;43694;43699;43700;43701 |]
        | 163 -> [| 1204;1205;1265;1267;1275;1277;1285;1287;1295;1297;1305;1307;11216;11218;11220;11226;11228;11230;11236;11238;11240;11246;11248;11250;11256;11258;11260;11266;11268;11270;15686;15688;15690;15692;15694;15696;15698;15700;15702;15704;15722;15724;15726;15728;15730;15732;15734;15736;15738;15740;17513;17515;17517;17519;17537;17539;17541;17543;17545;17550;17552;17554;17556;17558;22880;22882;22884;28521;28535;28537;28539;28541;28543;28548;28553;28555;28560;32810;46013 |]
        | 162 -> [| 1208;1437 |]
        | 160 -> [| 1210;2118;20582;26870 |]
        | 161 -> [| 1212;2342 |]
        | 176 -> [| 1214;2174;2176;2184;2186;2194;2196;2204;2206;2437;2445;2447;2455;2457;2465;2467;2477;2479;2487;2489;15509;15511;21639;21641;22781;23526;23560;23562;23564;23760;28210;28212;28214;28216;28263;28265;28267;28269;28271;28273;28275;28277;28279;28281;28283;28285;28287;28289;28291;28293;28295;28297;28299;28301;28303;28305;28307;28309;31865;31867;31869;31871;31873;31875;31877;31879;31881;31883;31885;31887;31889;31891;31893;31895;33682;48745 |]
        | 170 -> [| 1215;32783 |]
        | 174 -> [| 1217;3734;3736;3738 |]
        | 177 -> [| 1218;10247;10251;43911;43912;43913;43914;43915;43916;43934 |]
        | 451 -> [| 1223;17428;17429;28388;28389;28390;46676;46692 |]
        | 459 -> [| 1224;17459;17460;28424;28425;28426;28618;46686;46702 |]
        | 452 -> [| 1225;17432;17433;26851;28391;28392;28393;28624;46677;46693 |]
        | 456 -> [| 1226;17448;17449;26868;28406;28407;28408;28621;46682;46698 |]
        | 469 -> [| 1227;17867;17868;28415;28416;28417;28619;46684;46700 |]
        | 460 -> [| 1228;17463;17464;28427;28428;28429;46687;46703 |]
        | 467 -> [| 1229;17865;17866;26713;28397;28398;28399;28622;46679;46695 |]
        | 462 -> [| 1230;17470;17471;27028;28430;28431;28432;28617;46689;46705 |]
        | 455 -> [| 1231;17444;17445;28403;28404;28405;46681;46697 |]
        | 453 -> [| 1232;17436;17437;28394;28395;28396;28623;46675;46694 |]
        | 158 -> [| 1237;1245;1318;1320;1334;1336;1404;1406;2604;2606;21492;21494;21497;21499;21501;21856;33982;33984;33986;34123;34125;34127 |]
        | 78 -> [| 1240;1333;1335;5643;5645;5647;5649;5675;5677;5679;5681;21496;22537;34485;34487 |]
        | 763 -> [| 1242;2603;2605;5559;5561;5591;5593;5595;5597;5599;5601;14127;15813;21500 |]
        | 137 -> [| 1247;1249;1255;1257;1354;1356;1423;1446;1448;1540;1542;2332;17511;17523;17525;17529;22954;23895;23897;23899;28533;28777;31953 |]
        | 765 -> [| 1315;1317;1319;5479;5481;5483;5485;5487;5489;5491;5493;21493;21855;34489 |]
        | 769 -> [| 1351;1353;1355;8251;8253;8257;8259;8261;8263;8265;14128;14130;14132;15112;15114;15116;15118;15120;15122;15124;15126;15300;15302;15304;15306;17522;23898;28776 |]
        | 1 -> [| 1373;1374;1375;1376;1377;1378;1379;1380;1381;1382;1383;1384;1385;1386;34574 |]
        | 762 -> [| 1401;1403;1405;5519;5521;5523;5525;5527;5529;5531;5533;21498;34481;34483 |]
        | 57 -> [| 1419;1422;2331;8331;8333;8335;8337;8339;8341;8343;8345;37820 |]
        | 766 -> [| 1537;1539;1541;8211;8213;8215;8217;8219;8221;8223;8225;8255;14134;14136;14138;15096;15098;15100;15102;15104;15106;15108;15110;15292;15294;15296;15298;15439;17524;22953;28739;31952 |]
        | 72 -> [| 1547;1549;1551;1553;1557;1559;1563;1565;3897;3899;3901;3903;3907;3909;3913;3915;3937;3939;3941;3943;3947;3949;3953;3955;3977;3979;3981;3983;3987;3989;3993;3995;9668;9670;9678;9680;9702;9706;9728;9734;9744;9750;9762;9772;9784;9790;9800;9808;14188;14190;14192;14194;14196;14198;14200;14202;14204;14206;14208;14210;14212;14214;14218;14220;14222;14224;14226;14228;14544;14546;14548;14550;14692;14694;14696;14698;14784;14786;14788;14790;14792;14794;14796;14798;15152;15154;15156;15158;15405;15925;15927;15929;15931;15933;15935;15937;15939;15941;15943;15945;15947;15949;15951;15953;15955;15957;15959;15961;15963;21532;21534;21536;21538;23864;23866;23868;28545;28550;28557 |]
        | 152 -> [| 1548;1550;1552;1554;1558;1560;1564;1566;3938;3940;3942;3944;3948;3950;3954;3956;3978;3980;3982;3984;3988;3990;3994;3996;15926;15928;15930;15932;15936;15938;15940;15942;15946;15948;15950;15954;15956;15958;15960;15962;15964;21535;21537;21539;23865;23867;23869;28546;28551;28558 |]
        | 190 -> [| 1601;1602;1603;1604;1605;1606;1607;1608 |]
        | 191 -> [| 1611;1612;1613;1614;1615;1616;1617;1618;1619;1620;1621;1622;1623;1624;1625;1626;1627 |]
        | 193 -> [| 1628;1629;1630;1631;1632;1633;1634;1635 |]
        | 192 -> [| 1636;1639;1640;1641;1642;1643;1644 |]
        | 195 -> [| 1650;1651;1652;1653;1654;1655 |]
        | 196 -> [| 1657;1658;1659;1660;1661;1662 |]
        | 197 -> [| 1663;1664;1665;1666;1667;1668 |]
        | 198 -> [| 1669;1670;1671;1672;1673;1674 |]
        | 199 -> [| 1675;1676;1677;1678;1679;1680 |]
        | 295 -> [| 1798;1800;1802;1804;1808;2529;2531;2537;2539;2545;2547;2553;9556;9562;9566;9568;9570;9574;9580;9582;14029;14031;14033;14035;14037;14039;14041;14043;14606;14610;14614;14618;14622;14626;14630;14634;14716;14718;14720;14722;14724;14726;14728;14730;14732;14734;14736;14738;14740;14742;14744;14746;15909;15911;15913;15915;15917;15919;15921;15923;19209;19211;19213;19215;19217;19219;19221;19223;19225;19227;19229;19231;19233;19235;19237;19239;19241;19243;19245;19247;19249;19251;19253;19255;20605;20607;20609;20611 |]
        | 296 -> [| 1809;2530;2532;2538;2540;2546;2548;2554;15910;15912;15914;15916;15918;15920;15922;15924;20606;20608;20610;20612 |]
        | 395 -> [| 1818;1820;1822;1824;27481;27483;27485;27487;27489;27491;27493;27495;27497;27499;27501;27503 |]
        | 396 -> [| 1826;1828;1830;1832;27457;27459;27461;27463;27465;27467;27469;27471;27473;27475;27477;27479 |]
        | 511 -> [| 1875;1877;8007;8023;8025;8027;13919;13920;16061;17484;20597;22566 |]
        | 205 -> [| 1893;2363;2364;5845;5846;5849;5854;5855;5856;5857;5858;13941;13943;14800;14802;14804;14806;14808;14810;14812;14814;15397;15435;15808;15810;23900;23902;44111;49726 |]
        | 203 -> [| 1946;1982;1983;1984;1985;2579;2580;2583;2584;2587;2588;2591;2592;4013;4014;6193;6194;6195;6199;6202;6203;6207;6212;6216;6217;6218;6222;6225;6226;6230;6234;6238;6239;6241;6242;6243;6244;6251;6252;6257;6258;6259;6260;6267;6268;6275;6276;6283;6284;6285;6286;6289;6290;6291;6292;20238;20240;20242;20244;20246;20248;20250;20252;20254;20260;20262;20264;21521;21523;21525;21529 |]
        | 202 -> [| 1947;2002;2003;2004;2005;2258;2259;2260;2261;2262;7867;7869;7870;7887;7889;7892;7893;7895;7896;7914;7917;7918;7922;7926;7937;7948;7964;7965;7966;7970;20214;20216;20218;20220;20222;20224;20226;20228;20230;20232;20234;20236;22897 |]
        | 201 -> [| 1948;1955;1956;1957;1958;2559;2563;2567;2571;2575;9518;9519;9520;9521;9522;19923;19925;19927;19929;19931;19933;19935;19937;19939;19942;19944;19946;19948;19950;19952;20199;20201;20203;20205;20207;20573;20575;20577;20579;28729;28731;28733;28735;28737 |]
        | 210 -> [| 1949;1986;1987;6293;6294;6295;6296;6309;6310;6311;6312;21527;41196;41197 |]
        | 211 -> [| 1951;1998;1999;6321;6322;6323;6324;6325;6326;6327;6328;14100;14640;14642;14644;14646;15965 |]
        | 212 -> [| 1952;1973;6157;6158;6159;6160;14236;15276;15278;15280;15282;17520;22895;41191;41192;41193;41194;41195 |]
        | 289 -> [| 1959;1960;7217;7218;7219;7220 |]
        | 290 -> [| 1963;1964;5279;5280;5281;5282;22925;22939;22941;41198;41199 |]
        | 208 -> [| 1968;1969;5299;5300;5301;5302;22943;22945;32413 |]
        | 213 -> [| 1977;1978;6173;6174;6175;6176;14238;15284;15286;15288;15290;15792;22927;22929 |]
        | 1016 -> [| 2001;2008;2009;32422 |]
        | 286 -> [| 2010;2052;3548;30365;30366;30369;30379;30380;30381;32471;34579;34588;34589;43922;43923;43924 |]
        | 306 -> [| 2011;2127;2181;2218;2223;2232;2841;2850;2854;2860;2886;2891;2892;2895;2901;2911;2918;3261;3491;3498;3506;3624;3629;3792;3811;3835;3845;3846;3847;3848;10167;10231;10261;10262;10263;11072;11589;11590;11680;12028;12554;12555;12556;12602;16720;16721;16722;16723;16724;16725;19765;19794;21052;21099;21633;21662;21698;21699;21700;21701;21703;21704;21705;21706;21891;22032;22061;22068;22072;22084;22138;22150;22168;22223;22247;22318;22343;22728;22755;22791;22799;22849;23212;23213;23214;23215;23216;23217;23218;23219;23220;23359;23572;23595;23607;23701;23743;23904;24124;24237;24267;24269;24279;24280;24281;24301;24429;24447;24459;24577;24713;24721;24724;24750;24765;25255;25397;25468;25471;25523;25526;25537;25735;25841;25845;26605;26657;26658;26659;26660;26662;26663;26664;26665;26666;26667;26668;26669;26670;26671;26672;26673;26674;26675;26676;26677;26715;26719;26975;26976;26977;26978;27275;27288;27308;27802;27804;28138;28224;28259;28823;28841;28852;28859;28860;28861;28862;28885;28954;28963;28980;28981;29181;29182;29183;29184;29190;29212;29213;29214;29230;29289;29324;29438;29445;29532;29549;29608;29716;29717;29718;29719;29720;29721;29722;29723;29724;29725;29726;29727;29728;29729;29730;29731;29732;29733;29734;29735;29736;29737;29738;29739;29740;29741;29742;29743;29744;29745;29894;29895;29896;29897;29898;29899;29900;29901;29902;29903;30720;30758;30760;30775;30779;30781;30785;30813;30815;30956;30969;30976;30981;30982;30996;31961;32100;32205;32211;32217;32233;32240;32256;32276;32279;32281;32347;32353;32368;32370;32377;32378;32379;32382;32406;33530;33531;33532;33533;33534;33889;33987;34299;34300;34301;34305;34315;34330;34375;34378;34385;34403;34406;34438;34447;34453;34503;34504;34505;34506;34507;34508;34509;34510;34511;34512;34513;34514;34515;34516;34517;34518;34519;34520;34521;34522;34523;34524;34525;34526;34527;34528;34529;34530;34531;34532;42117;42118;42119;42638;42663;42664;42665;42666;42667;42668;42669;42670;42814;42862;42863;42864;42865;44279;46335;47449;48079;48084;48085;48133;48743;48779 |]
        | 597 -> [| 2012;16874;16876;16877;16878;16879;16882;16883;16885;16886;16887;16888;16890;16894;16895;16897;16901;16902;16903;16904;16905;16907;16908;16911;16913;16914;24033;24034;24035;24036;24037;24038;25823;32400 |]
        | 283 -> [| 2013;2093;2217;2226;2239;2240;2244;2662;2663;2665;2666;2668;2669;2670;2671;2672;2674;2675;2676;2677;2678;2681;2699;2700;2701;2702;2703;2704;2705;2706;2707;2708;2709;2725;2726;2727;2728;2919;2942;2958;2959;2975;2976;2983;2984;2999;3004;3006;3008;3032;3036;3483;3719;3721;3723;3804;3806;3808;3810;3923;4358;11701;11709;11742;12049;12110;12243;13267;13837;16194;16253;16593;16623;16630;17409;17754;17765;17767;17791;17796;20554;20715;21064;21066;21070;21466;21467;21502;21631;21672;21734;21743;21850;22067;22069;22085;22089;22139;22143;22173;22208;22209;22210;22321;22708;22752;22788;22792;22796;22801;22802;22803;22804;22847;23274;23327;23509;23558;23610;23699;24238;24251;24342;24441;24729;24731;24752;24755;24760;24766;25352;25373;25390;25847;25850;25869;25875;25885;25989;26115;26140;26225;26266;26271;26696;26708;26773;26775;26783;26788;26846;26901;26907;26908;26998;27203;28137;28832;28835;28842;28869;28886;28995;29191;29216;29219;29229;29253;29263;29269;29283;29294;29439;29447;29489;29614;30182;30716;30719;30757;30759;30761;30774;30804;30812;30814;30827;30968;30980;31960;32097;32193;32228;32270;32292;32372;32389;32398 |]
        | 1021 -> [| 2026;2027;2028;2029;2030;2031;2034;2035;2036;2037;2058;2059;2060;2061;2062 |]
        | 1020 -> [| 2040;2041;2042;2043;2044;2053;2054;2055;2056;2057 |]
        | 693 -> [| 2045;16105;16106;16107;16108;16109 |]
        | 140 -> [| 2047;2049;22894;23419;30840;40719;40720;40721;40722;40723;47259;47260 |]
        | 995 -> [| 2064;30574;30575;30576;30577;30669;30670 |]
        | 517 -> [| 2065;2066;2840;3625;20364;20369;20376;20377;20378;20379;20380;20381;20382;20383;20384;20385;20386;20387;20388;20389;20390;20391;20392;20393;20394;20520;20521;20529;20534;20535;20536;20537;20538;20643;20644;20645;20646;20647;20648;20649;20650;20651;20652;20653;20654;20655;20656;20657;20658;20659;20660;20661;20662;20663;20664;20665;20666;20667;20668;20669;20670;20671;20672;20673;20674;20675;20676;20677;20678;20679;20680;20681;20682;20683;20684;20685;20686;20687;20688;20689;20690;20691;20692;20693;20694;20695;20696;20697;20698;20699;21105;21106;21107;21108;21109;21110;21111;21112;21113;21114;21115;21116;21117;21118;21119;21120;21121;21122;21123;21124;21125;21132;21133;21134;21135;21136;21137;21138;21139;21140;21141;21142;21143;21144;21145;21146;21147;21148;21149;21150;21151;21152;21153;21154;21155;21156;21157;21158;21159;21160;21162;21163;21164;21165;21166;21167;21168;21169;21170;21171;21172;21173;21174;21175;21176;21177;21178;21179;21598;21843;21844;22081;22179;22180;22181;22185;22186;22187;22188;22189;22190;22191;22192;22193;22195;22196;22197;22221;22319;22390;22391;22625;22629;22630;22631;22632;22633;22635;22636;22637;22638;22639;22640;22641;22642;22643;22644;22645;22646;22647;22648;22649;22650;22651;22652;22653;22654;22655;22656;22657;22658;22677;22678;22679;22680;22681;22682;22683;22685;22686;22693;22694;22695;22696;22699;22700;22719;22726;22734;22735;22736;22737;22762;22763;22767;22768;22769;22770;22771;22772;22773;22774;22775;22844;22845;23063;23064;23065;23066;23067;23068;23070;23088;23122;23125;23126;23127;23232;23238;23239;23304;23311;23456;23540;23565;23603;23608;23613;23620;23625;23636;23637;23666;23697;23698;23746;23765;23768;23769;23770;23771;23772;23775;23776;23777;23778;23779;23780;23781;23782;23827;23831;23832;23881;23946;23947;24239;24240;24290;24291;24292;24293;24294;24295;24296;24309;24350;24463;24467;24664;24709;24710;24711;24712;24723;24732;24737;24738;24739;24740;24741;24742;24743;24746;24747;24748;24758;25403;25404;25405;25406;25415;25416;25417;25418;25419;25420;25421;25422;25423;25424;25425;25430;25431;25432;25433;25434;25435;25436;25437;25438;25439;25440;25449;25450;25455;25456;25457;25458;25459;25460;25461;25462;25463;25464;25465;25466;25518;25519;25520;25582;25583;25722;25740;25741;25742;25743;25744;25745;25746;25747;25748;25749;25750;25751;25752;25753;25754;25830;25831;25832;25833;25846;26176;26177;26178;26179;26180;26181;26182;26183;26184;26185;26186;26187;26188;26189;26190;26191;26192;26193;26194;26195;26196;26197;26198;26199;26200;26201;26202;26203;26204;26205;26206;26207;26208;26209;26210;26211;26213;26214;26215;26217;26218;26219;26220;26221;26222;26262;30821;30830;30838;30841;30887;30957;30992;31103;32098;32138;32139;32140;32195;32196;32243;32244;32278;32304;32395;32396;32397;32409;32410;32411 |]
        | 602 -> [| 2072;24000;24009;24010;24011;24012;24013;24181;24182;24183;24184;24185;24186 |]
        | 1035 -> [| 2073;2286;2287;2288;2305 |]
        | 314 -> [| 2074;2075;2100;2197;2198;2199;2200;2201;2202;2215;2216;2219;2220;2221;2250;2368;2369;2371;2373;2374;2375;2376;2377;2595;2596;2597;2598;2599;2601;2602;2608;2610;2615;2616;2617;2618;2619;2620;2623;2624;2626;2627;2628;2631;2632;2633;2635;2636;2639;2640;2641;2642;2644;2645;2646;2652;2653;2654;2657;2659;2660;2673;2682;2683;2684;2685;2686;2687;2688;2689;2690;2691;2692;2693;2694;2695;2696;2697;2698;2710;2712;2713;2714;2715;2716;2717;2718;2719;2720;2721;2722;2723;2724;2729;2730;2731;2732;2851;2853;2861;2862;2880;2888;2893;2899;2900;2904;2917;2930;2934;2943;2944;2951;2952;2955;2956;2957;2960;2963;2964;2965;2967;2968;2971;2972;2973;2974;2979;2980;2981;2982;2987;2988;2989;2990;2991;2992;2995;2996;2997;3000;3003;3005;3007;3011;3012;3013;3014;3015;3016;3019;3020;3021;3022;3023;3024;3027;3028;3029;3030;3031;3035;3037;3038;3501;3583;3584;3585;3627;3701;3837;3838;3843;3844;4089;4390;10646;11013;11066;11067;11068;11069;11070;11071;11508;11509;11510;11511;11512;11528;11585;11586;11587;11588;11602;11603;11604;11606;11607;11608;11635;11654;11702;11703;11707;11723;11856;11944;12250;12302;12303;12478;12994;12995;13067;13204;13205;13206;13210;13211;13212;13213;13214;13215;13288;13328;13918;14292;14293;14358;14483;15316;15318;15319;15353;15410;16041;16042;16043;16044;16045;16614;16686;16712;16713;16714;16832;17143;17391;17423;17424;17624;17640;17643;17646;17647;17755;17756;17757;17759;17761;17793;17794;17795;17814;17815;17816;17840;17848;17849;17850;17893;17894;17895;17897;18583;18655;19382;19399;19461;19462;19463;19493;19582;19730;20328;20362;20375;20541;20551;21624;22222;22730;22764;23863;23871;23882;23909;23945;23948;24717;25382;26270;26707;26774;26776;26778;26779;26781;26782;26784;26785;26786;26787;26790;26791;26792;26974;27803;28256;28257;28359;28360;28827;28828;28829;28830;28833;28834;28836;28843;28865;28866;28868;28870;28896;28897;28972;28973;28975;28996;29026;29137;29162;29202;29203;29205;29211;29268;29272;29278;29284;29321;29464;29471;29474;29475;29476;29477;29478;29480;29531;29607;29932;29933;29934;29935;29936;29937;29938;29939;29940;29941;29942;29943;29944;29945;29946;29947;29948;29949;29950;29951;29952;29953;29954;29955;30755;30756;30768;30776;30778;30780;30782;30784;30794;30809;30810;30811;30816;30907;30951;30952;30954;30955;30964;30967;32099;32106;32200;32201;32202;32204;32218;32220;32223;32225;32229;32234;32235;32237;32241;32252;32253;32257;32258;32259;32265;32266;32267;32272;32277;32280;32283;32284;32285;32286;32287;32288;32289;32290;32294;32350;32351;32352;32365;32366;32371;32375;32376;32383;32393;32403;32407;32408;32418;32885;32886;32887;32888;32889;32890;32891;32892;33070;33071;33072;33073;33117;33118;33119;33120;33121;33122;33123;33124;33125;33126;33127;33128;33129;33577;33618;33619;33620;34311;34312;34313;34314;34381;34382;34383;34400;34401;34402;34450;34451;34452;40456;40548;40549;40701;42683;45536;46278;47025;47026;47027;47041 |]
        | 474 -> [| 2076;4301;17826;17827;17828;17829;17830;17853;17854;17855;17856;17892;17904;17905;17906;17907;17910;17911;17916;17974;17983;17984;17985;17986;17987;17988;17989;17990;17991;17992;17995;17998;18566;18585;18644;19585;19586;19587;19621;19702;19705;19732;19954;20103;20104;20105;20164;20456;20457;20458;20517;21048;21839;21879;22157;22201;22295;23236;23907;23961;24264;24308;24352;24353;24462;24466;24482;24762;25281;25304;25353;25378;25386;25550;25551;25577;25579;25807;25864;26138;26216;26228;26241;26245;26278;26283;26455;28260;30975;32020;32189;32198;32242 |]
        | 952 -> [| 2077;2163;2187;2189;2214;2903;3054;3495;3502;3503;3508;30654;30762;30777;30783;30793;30805;30820;30899;30949;30953;30965;32127;32206;32224;32271;32273;32291;32299;32394;32404;34373;34374;34391;34398;34399;34449;34498;34499;34500;34501;34502;36903;36904;36905;36906;36907;40542;46279 |]
        | 1022 -> [| 2078 |]
        | 1730 -> [| 2082;2589;33329;33393;33394;33807;33808 |]
        | 481 -> [| 2083;4258;4260;17901;17938;18639;25771;26173;28756;28758 |]
        | 226 -> [| 2096;2097;2101;2102;2105;2106;2107;2110;2111;2112;2113;2114;2115;2116;2119;2120;2121;2122;2123;2124;2234;2252;2284;2285;2335;2407;2468;2573;2612;2734;2831;2832;2842;2852;2856;2858;2910;2926;2927;2928;3056;3059;3509;3510;3523;3592;3593;3594;3595;3600;3601;3602;3603;3604;3605;3610;3611;3612;3613;3614;3615;3620;3626;3630;3631;3632;3633;3635;3637;3639;3641;3642;3644;3646;3648;3649;3650;3652;3657;3658;3659;3660;3661;3662;3667;3668;3669;3670;3671;3672;3674;3675;3676;3677;3678;3679;3680;3681;3682;3684;3686;3688;3690;3704;3706;3708;3710;3712;3714;3716;3718;3720;3722;3724;3726;3728;3730;3757;3759;3760;3761;3762;3763;3770;3772;3774;3776;3778;3780;3781;3782;3783;3784;3785;3786;3787;3788;3789;3790;3791;3807;3880;3881;3920;3952;3957;3967;3970;3974;4007;4099;4100;4319;9875;9876;9877;9878;9879;9880;9881;9882;9883;9884;9885;9886;9887;9888;9889;9890;9891;9892;9893;9894;9895;9896;9897;9898;10041;10119;10120;10121;10122;10123;10124;10127;10135;10136;10137;10138;10139;10140;10141;10142;10143;10144;10234;10235;10236;10237;10238;10239;10240;10241;10242;10243;10256;10267;10269;10270;10305;10771;10772;10773;10774;10775;10778;10779;10780;10781;10782;10783;10784;10785;10786;10787;10788;11209;11210;11369;11678;13835;13836;14477;21608;21609;21659;21797;21798;21799;21807;21820;21821;21822;21823;21824;21825;21826;21827;21828;21829;21830;21831;21832;21833;21834;21835;21836;21837;21838;21883;22064;23223;23224;23225;23226;23227;23228;23229;23230;23231;23237;23535;23553;23615;23741;23742;23752;23753;23754;23755;23756;23761;23762;23763;23826;23833;23889;23968;24029;24032;24252;24457;24458;24480;24566;24589;24609;24643;25231;25232;25375;26229;26230;26231;26232;26233;26234;26235;26236;26237;26238;26239;26272;26739;26743;26746;26794;26860;26911;26968;28066;28070;28071;29157;29158;29159;29160;29161;29208;29250;29251;29279;29348;29349;29350;29351;29352;29353;29354;29355;29356;29357;29358;29359;29360;29361;29362;29363;29364;29382;29386;29452;29453;29454;29455;29456;29457;29458;29459;29460;29503;29505;29506;29507;29508;29509;29511;29546;29551;29552;29553;29554;29555;29556;29557;29558;29559;29561;29562;29563;29564;29565;29566;29567;29568;29569;29570;29571;29572;29573;29574;29575;29576;29577;29578;29579;29580;29581;29582;29583;29584;29585;29586;29589;29590;29591;29592;29593;29594;29595;29596;29597;29598;29599;29600;29601;29602;29603;29604;29606;30293;30294;30295;30298;30299;30300;30301;30302;30388;30412;30413;30414;30416;30419;30434;30435;30436;30439;30440;30444;30446;30447;30448;30449;30451;30452;30453;30454;30455;30456;30502;30503;30504;30505;30506;30513;30514;30515;30786;30789;30797;30798;30799;30800;30801;30802;30894;30895;30896;30897;30898;30900;30901;30902;30903;30904;30905;30991;32128;32129;32131;32132;32133;32134;32135;32136;32137;32216;32275;32386;32387;32399;32405;32419;32420;32421;32423;33481;33574;33622;33858;34190;34191;34192;34193;34194;34195;34196;34197;34302;34304;34310;34316;34332;34334;34335;34336;34352;34379;34384;34386;34387;34388;34389;34392;34404;34405;34448;34456;34494;34534;34535;34536;34537;34538;34539;34573;34717;34761;34762;34763;34764;34765;34766;34767;34784;34833;34834;34835;34836;34837;34838;34839;34840;35777;36459;36460;36461;36462;36463;36850;36851;36852;36917;36918;36919;36920;36921;36922;36923;36924;36925;36926;36927;36928;36929;36930;36931;36932;36933;36934;36935;36936;40466;40531;40532;40533;40550;40576;41573;42115;42515;42516;42517;42518;42519;42520;42521;42540;42601;42686;42687;42688;42689;42853;42854;42855;42856;42857;42858;42859;42860;42866;42867;42868;42869;42870;42871;42872;42873;45016;45053;45054;46263;46320;46541;46542;46543;46544;46545;46546;46583;46767;46770;47066;47067;47199;47200;47201;47202;47203;47206;47207;48266;48267;48268;48269;48466;49108;49109;49635 |]
        | 632 -> [| 2098;2128;23973;23994;23995;23996;23997;23998;24205;24206;24207;24208;24209;24210 |]
        | 209 -> [| 2103;2104;5339;5340;5341;5342;14240;15967;22935;22937 |]
        | 291 -> [| 2108;2109;5319;5320;5321;5322;22931;22933;32416;32417;37543;37544;37545;37546 |]
        | 633 -> [| 2126;16569;17035;17040;17041;17043;17113;17115;17116;17117;17118;17119;17120;17121;17122;17126;17128;17129;17130;17131;17132;17133;17134;17278;17279;17280;17281;24057;24058;24059;24060;24061;24062 |]
        | 1027 -> [| 2129;2130;2131;2132;2133;2134;2135;2136;2137;2138;2139;2140;2141;2142;2143;2144;2145;2146;2147;2148;2149;2150;2151;2152;2153;2154;2155;2156;2157;2158;2159;2160;2254;2524;2525;2533;2534;2549;2550;2551;2574;2576;2577;2578;2581;2582;2585;2586 |]
        | 1019 -> [| 2178;2180;2182;2188;32436;32438;32440;32442 |]
        | 1053 -> [| 2190;2907;2909;2939;2966;3259;3492;3524;3525;3526 |]
        | 1054 -> [| 2191;2207;2208;2209;2859;2931;2936;2950;3511;3527 |]
        | 1052 -> [| 2192;3071 |]
        | 673 -> [| 2222;11712;12394;15320;15349;16162;22800;25043;25045;25046;25048;25050;25052;25054;25056;25057;25058;25075;25076;25077;25078;25079;25080;25081;25082;29761;29762;29763;29764;29765;29766;29767;29768;29769;29770;29771;29772;30729;30730;30731;30732;30950;45463 |]
        | 1006 -> [| 2224;29235;29238;29241;29244;32457;32785 |]
        | 1025 -> [| 2233;3964;4318 |]
        | 1030 -> [| 2256;2542;2543;2544;2552;2555;2556;2557 |]
        | 1029 -> [| 2257;2535;2536;2541;2558;2560;2561;2562 |]
        | 1032 -> [| 2267;2270;2272;2306;2307 |]
        | 1033 -> [| 2268;2308;2309;2310;2311 |]
        | 1036 -> [| 2280 |]
        | 1040 -> [| 2344;2345;2346;2348;2349;2351;2352;2354;2358;2360;2361;2366;2367;9834;9846;9848;12836;17136;17392;17898;28974 |]
        | 572 -> [| 2370;2379;10283;10284;10285;10286;11045;11046;11047;11048;13049;13050;13051;13052;23429;23430;23431;23432;23434;23435;24361;24362;24363;24364;24365;24366;24367;24368 |]
        | 550 -> [| 2372;10013;10014;10015;10016;10019;11021;11022;11023;11024;13032;13033;13035;13036;16561;16562;22005;22006;22007;22008;22009;22010;22011;22012;22013;22014;22818;22819;22834;22835;22836;22837 |]
        | 675 -> [| 2378;29233 |]
        | 571 -> [| 2381;10287;11049;11050;11917;11918;11919;11920;23436;23437;23444;23445;23446;23447;23448;23449;23655;23656;23657;23658;33137;33146;33164;33185;33352 |]
        | 562 -> [| 2382;2383;2384;2385;2386;10266;11027;11028;11029;11030;13041;13042;13043;13044;21974;21975;21976;21977;21978;21979;21980;21981;21982;21983;23330;23331;23332;23333;23334;23335;25806 |]
        | 561 -> [| 2387;10265;11031;11036;11928;11929;11930;11931;21984;21985;21986;21987;23305;23306;23307;23308;23309;23310;23319;23320;23647;23648;23649;23650;33134;33145;33174;33189 |]
        | 1042 -> [| 2389;2390;2392;2393;2395;2396;2397;2398;2399;2400;2401;3645;3683;3779;9828 |]
        | 1241 -> [| 2403;2406;2495;2505;13279 |]
        | 1026 -> [| 2409;2412;2413;2414;2415;2416;2417;2418;2419;2422;2423;2424;2425;2426;2427;2428;2429;2430;2431;2432;2433;2434;2435;2438;2439;2440;2441;2442;2443;2448;2449;2450;2451;2452;2453;2458;2459;2460;2461;2462 |]
        | 1028 -> [| 2469;2470;2471;2472;2473;2474;2475;2480;2481;2482;2483;2484;2485;2490;2491;2492;2493;2494 |]
        | 353 -> [| 2528;4360;4371;4372;4373;4374;4375;4376;4377;4380;11744;17617;18642;20197;26869;30223;33375;33762;37136;37137;42240;44278;44281;46690 |]
        | 667 -> [| 2594;12388;14356;15328;15329;15335;15336;15411;20330;24976;24977;24978;24979;24982;24983;24985;24988;24991;24992;28167;28168;29665;29667;29671;29673;29674;29675;29676;29677;29678;32268 |]
        | 653 -> [| 2613;2647;24495;24497;24499;24501;24503;24505 |]
        | 656 -> [| 2621;2637;24531;24533;24535;24537;24539;24541 |]
        | 655 -> [| 2629;2655;24507;24509;24511;24513;24515;24517 |]
        | 654 -> [| 2679;13856;24486;24488;24490;24492;24493;24494 |]
        | 313 -> [| 2711;3703;3705;3707;3709;3711;3713;3818;3820;3822;3824;3826;26780 |]
        | 937 -> [| 2733;29495;29496;29497;29530 |]
        | 1045 -> [| 2735;2737;2738 |]
        | 857 -> [| 2736;2740;27867;27868;27869;27870 |]
        | 912 -> [| 2739;4408;29000;29002;29004;29006;29008;29010;29012;29014;29016;35796;35797;37833;37834;37835;37836;37837;37838;37839;37840;40336;40337;41230;41590;41591;41592;41593;41594;41595;41596;41597;45011;47337 |]
        | 858 -> [| 2741;27871;27872 |]
        | 1048 -> [| 2742;2743;2744;2745;2746;2747;2748;2749;2750;2751;2752;2753;2754;2755;2756;2757;2758;2759;2760;2761;2762;2763;2764;2765;2766;2767;2768;2769;2770;2771;2772;2773;2786;2787;2788;2789;2790;2791;2793;2795;2797;2800;3963;33150;33868 |]
        | 841 -> [| 2774;2775;2776;2777;2778;2779;2780;2781;2782;2783;2784;2785;27677;27680;27681;27682;27684;27685;27688;27689;27690;27694;27695;27696;27697;27698;27699;27703;27704;27705;27706;27707;27708;27712;27713;27714;27781;27783;27785;27787;27789;27791 |]
        | 856 -> [| 2792;2794;2796;2798;27859;27860;27861;27862;27863;27864;27865;27866 |]
        | 860 -> [| 2799;27875;27876;27877;27878 |]
        | 657 -> [| 2801;2811;24519;24521;24523;24525;24527;24529 |]
        | 855 -> [| 2803;2804;2806;2808;2813;2815;27843;27844;27845;27846;27847;27848;27849;27850;27851;27852;27853;27854 |]
        | 854 -> [| 2805;2807;2810;2814;2816;2819;27831;27832;27833;27834;27835;27836;27837;27838;27839;27840;27841;27842 |]
        | 648 -> [| 2817;13119;24471;24473;24475;24477;24478;24479 |]
        | 891 -> [| 2820;2821;28605 |]
        | 871 -> [| 2822;2823;2824;27944;27945;27946;27947;27948;27949 |]
        | 853 -> [| 2825;2826;2827;2828;2829;2830;27807;27808;27809;27810;27811;27812;27813;27814;27815;27816;27817;27818;27819;27820;27821;27822;27823;27824;27825;27826;27827;27828;27829;27830 |]
        | 943 -> [| 2833;29668;32792;32793;44204 |]
        | 324 -> [| 2834;3516;11365;11371;11373;11375;11379;11381;11383;11389;11393;11400;12036;12042;12044;32207;32788 |]
        | 358 -> [| 2836;3518;11993;11999;12003;12005;12011;12015;12019;12023;32209;34477;34479 |]
        | 303 -> [| 2838;3898;9947;9950;10151;10152;10155;10156;10164;10165;10166;15457;15458;15459;15460;15461;15462;15463;15464;15465;15466;15477;15478;15479;15480;25349;28670;28672;28674;28676;28678;28680;28682;28684;32248;33087;33111;36908;36909;36910;36911;36912;36946;36948;42120;42121;42122;42123;42232;42233;42234;42531;42541;44217;45634;45733;45998;45999;46000;46001;46002;46003;46004;46005;46006;46007;46008;46009;47016;47265;47266;47267;47395;47396;47397;47481;47705;47706;47707;47708;48113;48114;48115;48116;48117;48118;48150;48151;48152;48153;48582;48599;48600;48601;48602;48603;48604;48605;48606;48607;48608;48609;48610;48611;48612;48613;48614;48615;48616;49538;49539;49540;49541;49701;49702;49749 |]
        | 718 -> [| 2839;25303;25307;25308;25309;25310;25311;25314;25322;25323;25327;25328;25329;25503;25504;25505;25506;25507;25508;25509;25510;25511;25512;25513;25539;28671;28673;28675;28677;28679;28681;28683;28685;33088;33112;48923;48924;48925;48926;48945;48946;48947;48948 |]
        | 1056 -> [| 2845;2855;2932;2933;2935;3484;3485;3486;3487;3490 |]
        | 820 -> [| 2846;2847;3882;3884;3889;3890;3891;17165;17166;17284;17615;17616;17823;17824;18584;18641;24582;24584;25306;25877;25990;26117;26130;26678;26682;26686;26690;26691;26756;26758;26763;26764;26765;26766;26768 |]
        | 1063 -> [| 2848;3060;3061;3062;3063;3064;3067;3068 |]
        | 1041 -> [| 2867;2868;2869;2870;2871;2872;2875;2876 |]
        | 875 -> [| 2877;2879;2882;3070;28160;28161;28162;28163;30970;32230;32448;32449 |]
        | 927 -> [| 2878;2883;2884;2885;11714;16160;29144;29145;29146;29147;29290;29291;29292;29293;29466;30948;32348;32388;32446;32447;32455 |]
        | 526 -> [| 2887;2912;3507;3836;3925;3926;11610;15331;20434;20713;21043;21044;21046;21053;21054;21067;21091;21126;21180;21449;21453;21454;21460;21461;21462;21463;21464;21465;21468;21469;21514;21516;21517;21520;21531;21544;21565;21566;21567;21601;21602;21607;21612;21613;21614;21615;21616;21619;21620;21623;21625;21632;21634;21637;21661;21663;21664;21665;21669;21671;21676;21677;21736;21739;21742;21783;21784;21793;21800;21801;21804;21851;21852;21877;21878;21880;21885;21892;21893;21930;21971;21973;22030;22033;22035;22036;22037;22038;22044;22045;22046;22049;22054;22055;22056;22060;22062;22063;22073;22074;22077;22078;22080;22083;22087;22096;22099;22100;22101;22102;22103;22140;22141;22142;22144;22146;22149;22151;22152;22155;22159;22162;22163;22164;22165;22166;22167;22174;22205;22206;22207;22211;22214;22217;22218;22219;22220;22231;22234;22248;22249;22254;22277;22288;22315;22317;22494;22701;22705;22707;22738;22740;22741;22751;22754;22756;22793;22795;23234;23272;23273;23303;23420;23421;23508;23515;23516;23517;23518;23519;23521;23538;23539;23541;23542;23543;23544;23545;23546;23547;23548;23549;23550;23551;23552;23554;23555;23556;23573;23597;23602;23604;23605;23621;23622;23626;23629;23630;23632;23633;23634;23635;23673;23675;23676;23677;23678;23679;23680;23681;23682;23683;23684;23690;23692;23700;23737;23738;23739;23740;23744;23745;23748;23749;23764;23766;23874;23876;23877;23880;23883;23890;23891;23892;23893;23925;23926;23929;23930;23931;23932;23933;23934;23935;23936;23937;24030;24031;24123;24244;24246;24247;24248;24249;24250;24253;24254;24255;24263;24276;24277;24278;24287;24288;24289;24300;24304;24315;24316;24317;24354;24355;24357;24446;24465;24564;24576;24580;24581;24707;24708;24714;24715;24719;24720;24722;24725;24726;24727;24728;24730;24733;24734;24735;24736;24744;24745;24756;24763;25364;25367;25369;25383;25387;25391;25393;25394;25398;25401;25408;25467;25514;25515;25516;25517;25522;25575;25844;25878;25879;25988;26120;26122;26123;26124;26125;26126;26127;26129;26131;26132;26167;26458;26459;26460;26461;26462;26463;26464;26465;26466;26710;26789;26902;26903;26904;26905;26906;27038;27274;27294;28190;28837;28838;29030;29185;29186;29187;29188;29206;29217;29226;29246;29285;29472;29473;29479;29483;29484;29485;30497;30826;30906;30966;32126;33539;33988;43680;44243;44244;44245;44246;44247;44248;44249;44250;44251;44252;47450;49756 |]
        | 227 -> [| 2894;3073;10065;10066;10067;10068;10069;10128;10129;10130;10131;10132;10232;10233;10753;10754;10755;10756;10757;10758;10759;10760;10761;10762;10763;10764;10765;19713;19746;19747;19748;19749;19750;19751;19752;19753;19754;19755;19756;23767;24578;26467;33014;34333;35645;41581;42116;42536;42697;42901;43549;43917;43918;44066;44105;45017;45729;45730;45731;45993;45994;45995;46064;46065;46082;46083;46084;46085;46086;46088;46565;46566;46567;46568;46569;46570;46571;46572;46573;46574;47152;47329;47398;47399;47400;47861;48933;49126;49696;49697;49698;49700 |]
        | 319 -> [| 2896;2902;2915;3499;3500;3591;3858;4011;4357;11076;11077;11079;11080;11081;11167;11168;11169;11170;11171;12989;13034;13106;13200;16215;16726;16727;16728;16729;16730;16731;16732;16733;16734;16735;16736;16737;16738;16748;16749;16750;16751;16752;16753;16754;16755;16756;16757;16758;16759;16760;16761;16762;16763;16764;16765;16766;16767;16768;16769;16770;16771;16772;16773;16774;16775;16776;16777;16778;16779;16780;16781;16782;16784;16785;16786;16787;16788;16789;16790;16791;16792;16793;16794;16796;16797;16798;16799;16800;16801;16802;16803;16804;16805;16806;16807;16808;16809;16810;16811;16812;16813;16814;16815;16816;16817;16818;16819;16820;16821;16822;16823;16824;16825;16826;16827;16828;16829;16830;16831;16836;16837;16838;16839;16840;16841;16842;16843;16844;16845;16846;16847;16848;16849;16850;16851;16852;16853;16854;16855;16856;16857;16858;16859;16860;16861;16862;16864;16865;16866;17138;17140;17380;17381;17382;17393;17394;17395;17396;17397;17398;17399;17400;17401;17626;17627;17628;17629;17644;17763;17775;17776;17777;17778;17779;17780;17781;17782;17783;17784;17785;17786;17787;17788;17789;17790;18012;18013;18014;18015;18016;18017;18018;18019;18020;18021;18567;18568;18569;19505;19533;19593;19671;19672;19673;19711;19712;19729;19743;20165;20177;20182;22711;22712;22718;22742;22743;22744;22758;23222;23571;23663;23858;23859;23860;23906;23963;24245;24310;24452;24453;24456;24565;24587;24588;24685;24716;24768;24769;24770;25355;25356;25357;25358;25359;25363;25552;25725;25815;25819;25826;25828;25859;25991;25992;25993;25994;26121;26240;26704;26706;26720;26721;26722;26723;26724;26725;26726;26727;26728;26729;26732;26734;26737;26740;26751;26853;26854;26855;26894;26895;26896;26897;26898;26899;26900;27063;27290;27879;27880;27881;27882;28065;28227;28228;28234;28235;28246;28247;28248;28249;28250;28251;28252;28254;28258;28340;28582;28608;28616;28839;28854;29031;29149;29165;29166;29167;29168;29169;29170;29171;29172;29173;29174;29175;29176;29177;29178;29179;29180;29189;29209;29262;29301;29325;29346;29391;29437;29446;29461;29467;29468;29469;30273;30274;30275;30276;30277;30278;30279;30280;30507;30508;30509;30510;30511;30512;30806;30807;30927;32194;32219;32221;32238;32239;32264;32349;32412;33480;34303;35764;37870;42538;42690;47401;48652;48961;48962 |]
        | 706 -> [| 2916;12389;15327;15341;20333;20459;20460;20461;24867;24868;24869;24870;24875;24876;24883;24884;24886;24888;28181;28182;29698;29700;29701;29702;29703;29704;29705;29706;29707;32293 |]
        | 1010 -> [| 2947;32357;32359;32361;32363 |]
        | 1653 -> [| 2948;32325;32340;32342;32344;40362;40363;40364;40365;40560;40561;40562;40563;40564;40565;40566;40567;45673;45675;47038;47039;47116;47117;47118;47119;47120;47121;47122;47123;47124;47125;47126;47127;47128;47129;47130 |]
        | 1145 -> [| 2949;32326;32341;32343;32345;41351;41352;41353;41354;41355;41356;41361;41362;41363;41364;41365;41366;45674;45676;47232;47233;47234;47235;47236;47237;47238;47239;47240;47241;47242;47243;47244;47245;47246;47247;47248 |]
        | 920 -> [| 3069;3072;3076;3493;3494;29193;30391;30844;30845;30846;30847;30848;30849;30850;30851;30852;30853;30854;30860;30861;30862;30863;30864;30865;30866;30867;30868;30869;30870;30871;30872;30873;30874;30875;30876;30877;30878;30879;30880;30881;30882;30883;30884;35799;35800;35801;35802;35803;35804;37542 |]
        | 749 -> [| 3077;3078;3079;3080;3081;3084;3085;3086;3087;3088;3089;3092;10228;13253;13262;13263;16245;16246;16247;16248;27104;27105;27106;27107;32255 |]
        | 747 -> [| 3093;3094;3095;3096;3097;3100;3101;3102;3103;3104;3105;3108;3109;3110;3111;3112;3113;3116;3117;3118;3119;3120;3121;3124;13237;13238;13239;13240;13241;13242;13243;16003;16004;16005;16006;16008;16009;19500;24663;24669;27097;27098;27099;27100;27101;27110;27111;27112;27113;27114;27115;33486;33512 |]
        | 746 -> [| 3125;3126;3127;3128;3129;3132;3133;3134;3135;3136;3137;3140;3141;3142;3143;3144;3145;3148;3149;3150;3151;3152;3153;3156;3157;3158;3159;3160;3161;3164;3165;3166;3167;3168;3169;3172;3173;3174;3175;3176;3177;3180;3181;3182;3183;13226;13227;13228;13229;13230;13231;13247;13248;13249;13250;20371;24632;24636;24637;24638;24639;24640;24641;24642;27091;27092;27093;27094;27095;27096;27108;27109;27204;27205;27206;27243;27244;27245;27246;27247;27249;27250;27251;27252;27253;27254;27255;27256;27257;27258;27259 |]
        | 257 -> [| 3184;3327;3328;3329;3330;3331;3332;3333;3334;3335;3336;3337;3338;3339;3340;3341;3342;3343;3344;3345;3346;3347;3755;3758;9955;10264;11075;11078;12092;12093;12095;12096;12097;12098;12099;16591;17940;19430;19719;20342;20524;20525;20526;20527;20528;20530;20531;20532;20533;22551;22761;23950;24311;24312;24313;24314;28374;28609;28615;28656;28667;29029;29637;30650;30651;30652;30653;32918;33091;33092;33093;33094;33095;33096;33097;33098;33856;34327;34390;34533;35680;35685;37615;40328;40535;40536;40537;40538;47445;47867;47868;47869;49742;49743 |]
        | 742 -> [| 3185;3188;3189;3190;3191;3192;3193;3194;3195;3196;3197;3198;3199;3200;3201;3202;3203;3204;3205;3206;3207;3208;3209;3210;3211;3212;3213;3214;3215;3216;3217;3220;3221;3222;3223;3224;3225;3226;3227;3228;3229;3230;3231;3232;3233;3234;3235;3236;9957;10204;13166;13217;13218;13219;13220;13221;13222;13223;13224;13225;13244;13245;13246;13252;16249;19686;19687;19688;19689;19690;19691;19692;19693;19694;19695;19696;19697;19698;19699;19700;20443;25867;25868;27075;27076;27077;27078;27079;27080;27081;27082;27083;27084;27085;27086;27087;27088;27089;27090 |]
        | 741 -> [| 3237;3238;3239;3240;3241;3246;3247;3248;3249;3250;3251;3252;3253;3254;3255;3256;3257;3258;3262;3263;3264;3265;3266;3267;13216;13251;13254;13255;13259;13260;13261;13265;27116;27117;27118;27119;27120;27121;27122;27123;27124;27125;27126;27127;27128;27129;27142;27143;27223 |]
        | 186 -> [| 3260;26468;26469;26470;26472;26473;26474;26475;26476;26477;26478;26479;26480;26481;26482;26483;26484;26485;26486;26487;26488;26489;26490;26491;26492;26494;26495;26496;26497;26498;26499;26500;26501;26502;26503;26504;26505;26506;26507;26508;26509;26510;26511;26512;26513;26514;26516;26517;26518;26519;26520;26521;26522;26523;26524;26525;26526;26527;26528;26529;26530;26531;26532;26533;26534;26535;26536;26538;26539;26540;26541;26542;26543;26544;26545;26546;26547;26548;26549;26550;26551;26552;26553;26554;26555;26556;26557;26558;26559;26560;26561;26562;26563;26564;26565;26566;26567;26568;26569;26570;26571;26572;26573;26574;26575;26576;26577;26578;26579;26580;26581;26582;26583;26584;26585;26586;26587;26588;26589;26590;26591;26592;26593;26594;26595;26596;26699;26700;26701;26702;26703;26918;26919;26920;26933;26934;26935;26939;26940;26941;26972;27041;27042;27043;27044;27045;27046;27047;27048;27049;27050;27051;27052;27053;27054;27055;27056;27057;27058;27060;27061;27062;27202;27286;27926;27927;27928;27929;28221;28222;28223;28255;28603;29033;29034;29035;29036;29347;29365;29639;30457;30458;30459;30484;30485;30492;30493;30494;30495;30496;30822;30823;30824;30825;33489;33490;33538;33765;33766;33907;33908;33909;34395;34440;34584;34768;34884;37531;37596;37861;37862;40639;40640;40641;40642;40644;40645;40646;40647;40702;40703;40704;40705;40706;40707;41688;41689;41690;41691;41692;41693;41694;41695;41696;41699;41700;42662;44273;44275;44276;44277;46338;46339;46341;46342;46604;46605;46606;47517;47518;47519;47520;47521;47560;47758;47795;47977;47978;48120;48372;48373;48742;48970;49117;49119;49121;49123;49125;49627;49628;49629;49630;49631;49632;49664;49665;49666;49692;49693 |]
        | 1228 -> [| 3268;3269;3270;3274;3275;3276;10244;13233;27130;27131;27227;27229 |]
        | 740 -> [| 3271;3272;3273;3277;3278;3279;3280;3281;3282;3283;3284;3287;3288;3289;3290;13232;13234;13235;13236;27224;27225;27226;27230;27231;27232;27233;27234;27235;27236;27237;47261;47262;47263 |]
        | 738 -> [| 3291;3292;3299;3414;3415;3470;3471;3474;3475;3476;3477;3478;3479;3481;3482;13256;13257;13258;17871;19547;19548;19549;19550;19684;19685;20358;21606;27070;27071;27072;27073;27074;32254 |]
        | 255 -> [| 3300;3301;3302;3303;3304;3305;3306;3307;3308;3309;3310;3311;3312;3315;3316;3317;11082;11083;11084;12201;12202;12203;12204;12205;12206;12207;12208;12209;12210;12211;12212;12213;12214;12215;20327;21666;21667;22043;24563;32856;41403;41404;41405;41406;41407;41408;41537;47870;47871;47872;47873;47874;47875 |]
        | 1216 -> [| 3318;3413;3417;3418;3421;3423;3424;3426;3432;11204;11207;24572;28164;28879;28880;32797 |]
        | 256 -> [| 3319;3320;3321;3322;3323;3324;3325;3326;12441;12442;20209;20210;20211;20212;20213;20312;20314;20315;21071;21668;25718;25719;28073;32435;41409;41410 |]
        | 258 -> [| 3348;3349;3350;3351;3352;3354;11569;11572;11574;20494;20495;22536;22552;24764;43728 |]
        | 278 -> [| 3355;3356;3357;3358;3359;3361;3362;3893;3894;3895 |]
        | 266 -> [| 3363;3364;3365;3366;3367;3368;3369;3370;3371;3372;3731;3732;12241 |]
        | 1545 -> [| 3373;11584;37796;37797;37798;37799 |]
        | 267 -> [| 3374;3375;3376;3377;3378;3379;3404;12376;12383;12385;12386;12387;16546;16547;16548;16549;16550;16551;16552 |]
        | 268 -> [| 3380;3381;3382;3383;3384;3387;3388;3391;3395;3396;3397;3398;3400;22242;24268;24625;26224 |]
        | 1218 -> [| 3385;3386;3389;3390;3410;11395;12180;12181;12182;12183;12184;12185;12186;12187;12188;12189;12190;12191;12192;12193;12194;12195;12196;16281;18025;22578;25544;25863;28373;28585;45746;45748;45749;45750;46152;46153;46154;46155;46156 |]
        | 1210 -> [| 3392;3393;3394;16069;21803;22806;22807;22808;22809;24568;27902;27936;33078 |]
        | 270 -> [| 3402;3403;3406;3408;3409;11433;11441;11442;11443;11444;11445;11446;11447;11448;11449;11450;11451;11452;11453;11454;11455;11487;11529;11858;12179;20433;21789;21790;21791;23087;23121;23123;23124;24270;24624;30324;30325;30326;30327;30788 |]
        | 1220 -> [| 3405;3411;24242;24606;25530;25538;33399;33407 |]
        | 1217 -> [| 3412;3551;13278;21718;25739;25810;25811 |]
        | 1209 -> [| 3416;3419;3420;3422;3425;11206;11566;12365;12366;12367;21059;21802;24571;44067 |]
        | 272 -> [| 3427;3433;3434;3435;4411;11208;11579;12368;19759;19760;19761;19766;19767;19921;19922;27906;27911;28604;28631 |]
        | 1213 -> [| 3428;3429;3430;3431;32999;33000;33001;33002 |]
        | 273 -> [| 3436;3437;3438;3439;3440;3441;3442;12305;12484;12485;12486;12487;22172;22541;23069;23566;23594;23599;23606;23618;24241;24613;32339;33699;40572;40573;43702;43703 |]
        | 274 -> [| 3443;3444;3445;3446;3447;3448;11015;12834;13069;13070;13071;13072;13073;13074;13075;16594;16595;16596;16597;16598;16622;18580;25233;25235;28261;33467 |]
        | 275 -> [| 3449;3450;3451;3452;3453;3454;3455;3456;4385;21603;21610;21611;24562 |]
        | 279 -> [| 3457 |]
        | 340 -> [| 3465;3466;3467;11488;11489;11490 |]
        | 649 -> [| 3468;24445;33003;33005;33007;33009;33011 |]
        | 285 -> [| 3469;3887;3888;8743;8744;8745;8746;8747;8748;8749;8750;14230;14232;14768;14770;14772;14774;15308;15310;15312;15314;15425;15675;15677;20567;20569;28561 |]
        | 659 -> [| 3514;3628;22852;23913;23917;23919;42125 |]
        | 1013 -> [| 3515;22853;23914;23918;23920;42137 |]
        | 1073 -> [| 3522 |]
        | 325 -> [| 3536;11355;11357;11359;16433;16435;16437;16439;16441;16443;16445;16447;16449;16451;16453;16455;18981;18983;18985;18987;18989;18991;19047;19049;19051;19053;19055;19057;22947;22949;22951;23414;23416;24569;26912;26913;26914;32469;41463;41464;41465;41466;41467;41468 |]
        | 350 -> [| 3537;11356;11358;11360;22948;22950;22952;23415;23417;24570;26915;26916;26917;41621;41622;41623;41624;41625;41626;41653;41654;41655;41656 |]
        | 121 -> [| 3545;3587;3589;3597;3599;3607;3609;3617;3619;41649;41650;41651;41652;41666;41667;41668;41669;41670;41671 |]
        | 1674 -> [| 3563;32444;37295;41174;41175;41176 |]
        | 524 -> [| 3565;20539;37294;41180;41181;41182 |]
        | 538 -> [| 3581;3793;22175;22177;22325;22327;22329;22331;22333;22335;22337;22339;27014;27019;30832;30834;41533;41534 |]
        | 917 -> [| 3582;3590;3794;22176;22178;22326;22328;22330;22332;27015;27020;30833;30835;41535;41536 |]
        | 282 -> [| 3727;3729;17475 |]
        | 805 -> [| 3744;3748;3749;3750;16210;16211;18070;18071;18072;18079;18080;18085;18086;18087;18088;18564;22284;22285;23481;23482;23483;23484;23485;23486;27293 |]
        | 803 -> [| 3745;3746;18076;18077;18078;18082;18083;18084;22148;22280;22281;22282;22283;22729;23487;23488;23491;23492;23493;23494;23495;23496;23686;23687;23921;23922;23923;23924;26269;45636 |]
        | 801 -> [| 3747;18073;18074;18075;23489;23490;45637 |]
        | 419 -> [| 3756;16227;16229;16231;16233;24696;24698;24700;24702;33151;33153;33155;33157;33869;33871;33873;33875;34473;49711 |]
        | 284 -> [| 3771;3773;4091;19398;20510;26777;29504 |]
        | 495 -> [| 3795;3805;3809;17993;18630;18631;19703;19707;19955;19961;25472;25524;25528;25559;25805;25809;25866;26275;28508;28510;28998;29020;29021;29022;29023 |]
        | 821 -> [| 3821;3823;3825;3827;15396;15413;15414;15415;17141;17142;17162;17412;17413;17744;17745;17746;17749;17900;17973;18565;19423;19424;19592;19620;19701;19704;19731;20078;20079;20080;20173;20174;22716;22759;25374;25407;25549;25578;25581;25808;25818;25848;25865;25870;25873;25881;25884;25886;25995;26118;26119;26264;26679;26683;26689;26692;26694;26714;26716;26745;26749;26757;26769;26770;26771;26772;26793;26796;26797;26798;26799;26800;26801;26802;26803;26807;26810;26812;26818;26832;26833;26844;26881;28506;28507;28509;28863;28864 |]
        | 1109 -> [| 3859 |]
        | 301 -> [| 3863;3885;10037;10038;11125;11128 |]
        | 288 -> [| 3883;3886;9997;9998;9999;10000;10001;10003;10046;10047;10048;10050;10052;10053;10054;10056;10057;10058;10060;10076;10077;10078;10079;10080;10082;10083;10084;10085;10086;10089;10090;10091;10092;10095;10106;10107;10108;10109;10111;10112;10113;10125;10126;10133;10134;10650;10651;10652;10653;10654;10655;10656;10657;10658;10663;10664;10669;10670;10676;10677;11127;11137;11138;11139;11140;24265 |]
        | 940 -> [| 3910;3911;3914;3916;3919;3930;3931;3932;3933;3934;32617;32619;32620;32621;32622;32627;32630;32640;32641;32650;32654;32665;32684;32697;32711;32712;32713;32714;32715;32716;32717;32739;32740;32741;32742 |]
        | 818 -> [| 3921;3959;3960;3961;11593;11594;11595;11596;11598;11600;11651;11652;11656;11672;11673;11679;11681;11685;11705;13163;13772;13895;13898;13901;13904;13914;13915;13916;13917;14294;15354;15392;15412;16010;16087;16088;16089;16090;16091;16092;16190;16191;16192;16193;16195;16196;16197;16208;16287;16288;16553;16554;16557;16558;16570;16571;16576;16577;16578;16579;16582;16583;16586;16587;16607;16608;16610;16618;16619;16627;16628;16698;16699;16700;16701;16702;16870;17622;17625;17742;17846;17917;18574;18575;18576;20324;24718;24757;24759;27287;29019;29904;29909;29914;29915;29920;29921;29924;29927;34141;34142;34143;34144;34145;34154;34155;34182;34183;34184;34185;34186;34187;35646;35689;40574 |]
        | 914 -> [| 3927;3928;29040;29042;29044;29046;29048;29050;29052;29054;29056;29058;29060;29062;29064;29066;29068;29070;29072;29074;29076;29078;29080;29082;29084;29086;29088;29090;29092;29094;29096;29098;29100;29102;29104;29106;29108;29110 |]
        | 1083 -> [| 3958;4009;4037;4038;4039;4042;4043;4046;4048;4050;4052;32853;33992;33993;40344;41575;41576;42905;42906;45736;45745 |]
        | 1106 -> [| 3962 |]
        | 1091 -> [| 3966;4001;4002;4003;4004;4008;4116;4117;4118;4119;4120;4121;4122;4123;4124;4125;4126;4127;4128;4129;4130;4131;4132;4133;4134;4135;4172;4173;4174;4175;4176;4177;4178;4179;33064;33714;33716;33717;33718;33719;33720;33721;33722;33723;33724;33725;33771;33772;33773;33774;33775;33776;33777;33778;33779;33780;34079;34080;34081;34082;34083;34084;34085;34086;34087;34088;34089;34360;34361;34362;34363;34364;34365;36505;36506;36507;36508;36509;36510;36511;36512;36513;36514;36515;36516 |]
        | 1088 -> [| 3975;4054;4097;4098;4136;4137;4138;4139;4140;4141;4142;4143;4144;4145;4146;4149;4150;4151;4152;4153;4154;4233;4234;4235;4236;4237;4238;4239;4244;4245;33715;33726;33727;33728;33729;33730;33731;33732;33733;33734;33735;33736;33737;33738;33739;33740;33741;33742;33743;33791;33792;33793;33794;33795;33796;33797;33798;33799;33800;33803;33804;34090;34091;34092;34093;34094;34095;34096;34097;34098;34099;34100;34156;34157;34158;34159;34160;34161;34162;34163;34164;34165;34166;34167;34168;34169;34170;34171;34172;34173;34174;34175;34176;34177;34178;34179;34180;34181;34347;34348;34349;34350;34351;34353;34393;34394;37600;37601;37602;37603;37806;37807;37810;37811;37815;37816;37817;37818;37863;37864;40457;40458;40459;40460;40461;40462;40463;40464;40522;40523;42702;42703;42705;42706;45514;45515;45516;45517;45518;45519;45520;45521;45522;45523;45524;45525;45526;45527;45735;45737;45738;45741;45742;45744;46038;46039;46273;46274;46658;46659;46660;46661;46662;46663;46664;46665;46666;46667;46668;46669;46671;46672;46673;46674;47031;47032;47286;47287;47475;47476;48081;48082;48380;48381;48382;48383;48384;48385;48386;48387 |]
        | 585 -> [| 3986;4296;4299;27904;27930;27932;27934;41475 |]
        | 870 -> [| 3991;4298;4300;27905;27931;27933;27935;41631 |]
        | 1090 -> [| 3992;3997;3998;3999;4016;4017;4018;4019;4020;4021;4022;4026;4028;4030;4032;4033;4034;4035;4036;4069;4070;4071;4072;4073;4074;4075;4076;4078;4085;4101;4102;4103;4104;4105;4106;4107;4108;4109;4110;4111;4112;4113;4114;4115;4165;4166;4167;4168;4169;4170;4171;33744;33745;33746;33747;33748;33749;33750;33751;33752;33753;33754;33755;33756;33757;33758;33759;33760;33761;33781;33782;33783;33784;33785;33786;33787;33788;33789;33790;33989;34045;34046;34047;34048;34049;34050;34051;34052;34053;34054;34055;34101;34102;34103;34104;34105;34106;34107;34108;34109;34110;34111;34354;34355;34356;34357;34358;34359;36493;36494;36495;36496;36497;36498;36499;36500;36501;36502;36503;36504;40524;40525;42701;44121;44124;48083 |]
        | 819 -> [| 4010;4012;4015;4354;4355;4356;17283;17285;17800;17890;17903;17997;18004;18024;26142;26661;26680;26684;26687;26688;26753;26862;26863;26864;26865;26866 |]
        | 1136 -> [| 4051;4246;4247;4312;36945 |]
        | 1089 -> [| 4057;4058;4059;4060;4061;4062;4063;4064;4065;4066;4067;4068;4155;4156;4157;4158;4159;4160;4161;4162;4163;4164;4180;4181;4182;4183;4184;4185;4186;4187;4188;4189;4190;4191;4192;4193;4194;4195;4196;4197;4198;4199;4200;4201;4202;4203;4204;4205;4206;4207;4208;4209;4210;4211;4212;4213;4214;4215;4216;4217;4218;4219;4220;4221;4222;4223;4224;4225;4226;4227;4228;4229;4230;4231;4232;4240;4241;4242;4243;4365;4366;4367;4368;33062;33063;33107;33109;33487;33488;33578;33579;33767;33768;33769;33770;33812;33813;34210;34211;34824;34825;35681;35682;36480;36481;36482;36483;36484;36485;36486;36487;36488;36489;36490;36491;37808;37809;37865;37866;40526;40527;42700;42704;42707;44120;44123;45734;45743;47182;47183;47184;47185;47186;47187;47188;47189;47190;47192;47479;47480 |]
        | 366 -> [| 4077;12273;17831;23828;24706;28074;35776;42902;47685;47686;48964;49563 |]
        | 1092 -> [| 4086;4088;4096;34056;34057;34058;34059;34060;34061;34062;34063;34064;34065;34066;34067;34068;34069;34070;34071;34072;34073;34074;34075;34076;34077;34078;42698;42699;42708;42709;42710;42711;42712;42713;42714;42715;42716;42717;42718;42719;42720;42721;42722;42723;42724;42725;42726;42727;42728;42729;42730;42731;42732;42733;42734;42735;42736;42737;42738;42739;42740;42741;42742;42743;42744;42745;44122;44125;45739;45740;47191;47193;47477;47478 |]
        | 1118 -> [| 4093 |]
        | 899 -> [| 4248;28654;37608;37610;37611;37612;37613 |]
        | 650 -> [| 4250;4252;24348;24620;24622;24644 |]
        | 723 -> [| 4251;4253;24349;24645 |]
        | 339 -> [| 4254;11563;16537;16539;16541;16543;28740;31936 |]
        | 352 -> [| 4255;11564;28741 |]
        | 862 -> [| 4256;27914 |]
        | 918 -> [| 4259;4261;17902;17939;18640;25772;28613;28757;28759 |]
        | 316 -> [| 4262;4264;4266;4268;4270;4272;4274;4276;4278;4280;4282;4284;4286;4288;4290;11014;11017;11052;20069;20070;20124;20405;20406;20408;20409;20514;22227;22228;22553;22555;22557 |]
        | 532 -> [| 4263;4265;4267;4269;4271;4273;4275;4277;4279;4281;4283;4285;4287;4289;4291;21095;21604;22299;22300;22301;22302;22303;22304;22305;22306;22307;22308;22309;22310;22311;22554;22556;22558;23736;28647;28651 |]
        | 515 -> [| 4292;4294;20280;27951;28583;33400;42890 |]
        | 516 -> [| 4293;4295;20281;23954;27952;28584;28653;33401;42891 |]
        | 1201 -> [| 4302;4306;4308;4310 |]
        | 1141 -> [| 4303;4304;4320;4321;4322;4323;4324;4325;4326;4327;4328;4329;4330;4331;4332;4333;4334;4335;4336;4337;4338;47017;47018;47019;47020;47021;47022;47023;47024 |]
        | 489 -> [| 4305;4307;4309;4311;16228;16230;16232;16234;22443;22445;22447;22449;22467;22469;22471;22475;24697;24699;24701;24703;33152;33154;33156;33158;33327;33870;33872;33874;33876;34474;49715 |]
        | 1137 -> [| 4313;4314;4315;4316 |]
        | 707 -> [| 4359;27897 |]
        | 365 -> [| 4361;12235;12236;16213;16214;16286;20059;20060;20061;20062;20063;20064;20065;20066;27530;27532;27533;27535;27536;27538;27539;27540;27589;27591;27592;27594;27595;27597;27598;27600;27601;27603;27604;27606;27607;27609;27610;27612;27780;27782;27784;27786;27788;27790 |]
        | 786 -> [| 4369;25928;26096;26106;26108;26110;26112;26344;26352;26354;26356;26360;26366;26960;26962;31250;31252;31254;31256;31258;31260;31262;31264;31266;31268;31270;31272;31286;31288;31290;31292;31294;31296;31298;31300;31302;31304;31306;31308;31334;31336;31338;31340;31342;31344;31346;31348;31350;31352;31354;31356 |]
        | 787 -> [| 4370;4396;4398;4400;4402;25737;25889;25891;25893;25895;25897;25899;25901;25903;25907;25909;25911;25913;25915;25917;25919;25921;25923;25925;25929;25931;25933;25935;25937;25949;25951;25953;25955;25957;25969;25971;25973;25975;25977;25979;25981;25997;25999;26001;26003;26005;26007;26009;26017;26019;26021;26023;26025;26027;26029;26031;26039;26041;26043;26047;26049;26057;26059;26061;26063;26065;26067;26069;26071;26073;26077;26079;26081;26083;26085;26087;26089;26091;26097;26101;26103;26105;26107;26109;26111;26113;26287;26289;26291;26293;26295;26297;26299;26301;26303;26305;26307;26309;26311;26313;26315;26319;26321;26323;26325;26327;26329;26331;26333;26335;26337;26339;26341;26343;26345;26347;26349;26351;26353;26355;26357;26359;26361;26363;26365;26367;26369;26371;26373;26375;26377;26379;26381;26383;26385;26387;26389;26391;26393;26395;26397;26399;26401;26403;26405;26407;26409;26411;26413;26415;26417;26419;26421;26423;26425;26427;26429;26431;26433;26435;26437;26439;26441;26443;26445;26447;26449;26451;26453;26926;26928;26930;26932;26961;26963;26965;26967;27065;27067;27069;28889;28891;28893;28895;30988;30994;30998;31000;31002;31004;31006;31008;31010;31012;31014;31016;31018;31020;31022;31024;31026;31028;31030;31032;31034;31036;31038;31040;31042;31044;31046;31048;31050;31052;31054;31056;31058;31060;31062;31064;31066;31068;31070;31072;31074;31076;31078;31080;31082;31084;31086;31088;31090;31092;31094;31106;31108;31110;31112;31114;31116;31118;31120;31122;31124;31126;31128;31130;31132;31134;31136;31138;31140;31142;31144;31146;31148;31150;31152;31154;31156;31158;31160;31162;31164;31166;31168;31170;31172;31174;31176;31178;31180;31182;31184;31186;31188;31190;31192;31194;31196;31198;31200;31202;31204;31206;31208;31210;31212;31214;31216;31218;31221;31223;31225;31227;31229;31231;31233;31235;31237;31239;31241;31243;31245;31247;31249;31251;31253;31255;31257;31259;31261;31263;31265;31267;31269;31271;31273;31275;31277;31279;31281;31283;31285;31287;31289;31291;31293;31295;31297;31299;31301;31303;31305;31307;31309;31311;31313;31315;31317;31319;31321;31323;31325;31327;31329;31331;31333;31335;31337;31339;31341;31343;31345;31347;31349;31351;31353;31355;31357;31359;31361;31363;31365;31367;31369;31371;31373;31375;31377;31379;31381;31383;31385;31387;31389;31391;31393;31395;31397;31399;31401;31403;31405;31407;31409;31411;31413;31415;31417;31419;31421;31423;31425;31427;31429;31431;31433;31435;31437;31439;31441;31443;31445;31447;31449;31451;31453;31455;31457;31459;31461;31463;31465;31467;31469;31471;31473;31475;31477;31479;31481;31483;31485;31487;31489;31491;31493;31495;31497;31499;31501;31503;31505;31507;31509;31511;31513;31515;31517;31519;31521;31523;31525;31527;31529;31531;31533;31535;31537;31539;31541;31543;31545;31547;31549;31551;31553;31555;31557;31559;31561;31563;31565;31567;31569;31571;31573;31575;31577;31579;31581;31583;31585;31587;31589;31591;31593;31595;31597;31599;31601;31603;31605;31607;31609;31611;31613;31615;31617;31619;31621;31623;31625;31627;31629;31631;31633;31635;31637;31639;31641;31643;31645;31647;31649;31651;31653;31655;31657;31659;31661;31663;31665;31667;31669;31671;31673;31675;31677;31679;31681;31683;31685;31687;31689;31691;31693;31695;31697;31699;31701;31703;31705;31707;31709;31711;31713;31715;31717;31719;31721;31723;31725;31727;31729;31731;31733;31735;31737;31739;31741;31743;31745;31747;31749;31751;31753;31755;31757;31759;31761;31763;31765;31767;31769;31771;31773;31775;31777;31779;31781;31783;31785;31787;31789;31791;31793;31795;31797;31799;31801;31803;31805;31811;31813;31815;31817;31819;31821;31823;31825;31827;32026;32028;32030;32032;32034;32036;32038;32040;32042;32044;32046;32048;32050;32052;32054;32056;32058;32060;32062;32064;32066;32068;32070;32072;32074;32076;32078;32080;32082;32084;32086;32088;32090;32092;32094;32096;32818;32820;33278;33280;33282;33284;33286;33288;33290;33292;33294;33296;33299;33300;33302;33304;33306;33308;33310;33312;33314;33891;33893;33895;33897;33899;33901;33903;33905;34267;34269;34307;34309;43902;43904;43906;43908 |]
        | 1189 -> [| 4383;33915 |]
        | 1191 -> [| 4384;33916 |]
        | 1149 -> [| 4386 |]
        | 371 -> [| 4387;12297;12300;12301;26850;26889;26891;26893;28771;28773;28775 |]
        | 1156 -> [| 4391;32772;32774;32780;41504;47836;47838;47840 |]
        | 1157 -> [| 4392;32773;32775;32781;41638 |]
        | 645 -> [| 4393;4405;32919;32921;32923;32925;33842;33844;33846;33848;41034 |]
        | 1152 -> [| 4394;4406 |]
        | 781 -> [| 4395;4397;4399;4401;25934;25948;25950;25952;25954;25956;26348;26368;26370;26372;26374;26376;26929;26931;31226;31228;31230;31232;31234;31236;31358;31360;31362;31364;31366;31368;31370;31372;31374;31376;31378;31380;31382;31384;31386;31388;31390;31392;31394;31396;31398;31400;31402;31404;31406;31408;31410;31412;31414;31416;33303;33305;43894;43896;43898;43900 |]
        | 1150 -> [| 4403 |]
        | 1151 -> [| 4404;41657;41658;41659;41660 |]
        | 1153 -> [| 4407 |]
        | 1154 -> [| 4409 |]
        | 1155 -> [| 4410 |]
        | 298 -> [| 9869;10999;11000;11001;11002 |]
        | 299 -> [| 9871 |]
        | 745 -> [| 9899;9941;9942;9943;9956;10208;10209;10210;10211;10212;10213;10214;10215;10216;10217;10218;10219;10221;10222;10223;10224;10225;10226;10227;13283;13284;13285;13286;13287;14295;14296;14297;14298;14299 |]
        | 302 -> [| 9944;10188;10190;11101;11103;11105;11107;11109;11111;11113;11115;13945;15144;15146;15148;15150;15416;15895;22917;22919;44113;44114;49722 |]
        | 182 -> [| 9959;9960;9962;9965;9970;9971;9977;9978;9983;9984;9987;9988;9989;9991;10035;10036;10097;10099;10100;10102;10104;10105;10660;10674;11126;11515;11516;11517;11518;11519;11520;11521;32380;32381 |]
        | 551 -> [| 10017;10018;11025;11026;11894;11895;11896;11897;22820;22821;22828;22829;22830;22831;22832;22833;23638;23639;23640;23641;33132;33143;33173;33175 |]
        | 567 -> [| 10025;10026;10027;10028;10273;11032;11033;11034;11035;13045;13046;13047;13048;23360;23361;23362;23363;23364;23365 |]
        | 566 -> [| 10030;10274;11037;11038;11909;11910;11911;11912;23366;23367;23368;23369;23370;23371;23381;23382;23651;23652;23653;23654;33136;33142;33163;33183 |]
        | 297 -> [| 10043;10044;10045;10114;10115;10116;10117;10118;10823;10824;10825;10826;10827;10828;10829;10830;10831;10832;10833;10834;20716;20717;20718;20719 |]
        | 305 -> [| 10071;10073;25236;25244;25245;25246;25247;25248;25249;25250 |]
        | 826 -> [| 10110;23955;23958;23959 |]
        | 307 -> [| 10257;10258;10260;19758 |]
        | 557 -> [| 10275;10276;10277;10278;10279;10280;11039;11040;11041;11042;13037;13038;13039;13040;23259;23260;23261;23262;23263;23264;24385;24386;24387;24388;24389;24407 |]
        | 555 -> [| 10281;10282;11043;11044;11901;11902;11903;11904;23257;23258;23281;23282;23283;23284;23285;23286;23643;23644;23645;23646;24630;33135;33144;33172;33182 |]
        | 802 -> [| 10299;21814;23497;23498;23499;23500;23501;23502;23503;23504;23505;25379;28136;45638 |]
        | 507 -> [| 10629;10631;13931;13933;16065;16521;16523;16525;16527;17488;20593;21542;22564;28511;34290 |]
        | 308 -> [| 10642 |]
        | 310 -> [| 10645;19706;21094;23733;25354;29296;29297;29298;29299;29300;32798;33621;33857;34112;36465;42131;47374 |]
        | 336 -> [| 10648;10665;10666;10667;10668;10766;10767;10768;10769;10770;11580 |]
        | 287 -> [| 10649;13323;16693 |]
        | 312 -> [| 10809;10810;10811;10812;10813;10814;10815;10816;10817;10818;10819;10820;10821;10822 |]
        | 806 -> [| 10986;10987;10988;10989;10990;10991;10992;10993;10994;10995;18113;18114 |]
        | 315 -> [| 10998;11640;16297;16299;16301;16303;22875;22877 |]
        | 724 -> [| 11074;33536;33543;33545;33546;33547;33548;33556;33558;33560;33562;33564;33566 |]
        | 323 -> [| 11136;41339;41340;41341 |]
        | 830 -> [| 11172;11182;11188;11192;33397;42246;44993;48636 |]
        | 893 -> [| 11174;11190;11194;11387 |]
        | 831 -> [| 11176;11178;11184;11186;11196;11198;11200;11202;33673;35779 |]
        | 326 -> [| 11215;11217;11219;11225;11227;11229;11235;11237;11239;11245;11247;11249;11255;11257;11259;11265;11267;11269;14070;14072;14074;14076;14078;14080;14082;14084;14086;14088;14090;14092;14094;14096;14098;14936;14938;14940;14942;14944;14946;14948;14950;14952;14954;14956;14958;14960;14962;14964;14966;14968;14970;14972;14974;14976;14978;14980;14982;14984;14986;14988;14990;14992;14994;14996;14998;15000;15002;15004;15006;15008;15010;15012;15014;15204;15206;15208;15210;15212;15214;15216;15218;15220;15222;15224;15226;15228;15230;15232;15234;15236;15238;15240;15242;15453;15455;15721;15723;15725;15727;15729;15731;15733;15735;15737;15739;16385;16387;16389;16391;16393;16395;16397;16399;16401;16403;16405;16407;16409;16411;16413;16415;16417;16419;16421;16423;16425;16427;16429;16431;17536;17538;17540;17542;17544;18799;18801;18803;18805;18807;18809;18811;18813;18815;18817;18819;18821;18823;18825;18827;18829;18831;18833;18835;18837;18839;18841;18843;18845;18847;18849;18851;18853;18855;18857;18859;18861;18863;18865;18867;18869;18871;18873;18875;18877;18879;18881;18883;19361;19363;22879;22881;22883;28534;28536;28538;28540;28542 |]
        | 328 -> [| 11277;11301;11303;11305;11642;11644;11646;11648;13970;13972;13974;13976;13978;13980;13982;13984;13986;13988;13990;13992;14059;14061;14063;14065;15016;15018;15020;15022;15024;15026;15028;15030;15032;15034;15036;15038;15040;15042;15044;15046;15048;15050;15052;15054;15056;15058;15060;15062;15064;15066;15068;15070;15072;15074;15076;15078;15244;15246;15248;15250;15252;15254;15256;15258;15260;15262;15264;15266;15268;15270;15272;15274;15705;15707;15709;15711;15713;15715;15717;15719;16151;16153;16155;16157;16353;16355;16357;16359;16361;16363;16365;16367;16369;16371;16373;16375;16377;16379;16381;16383;17502;17504;17506;17508;17832;17834;17836;17838;18885;18887;18889;18891;18893;18895;18897;18899;18901;18903;18905;18907;18909;18911;18913;18915;18917;18919;18921;18923;18925;18927;18929;18931;18933;18935;18937;18939;18941;18943;18945;18947;18949;18951;18953;18955;18957;18959;18961;18963;18965;18967;18969;18971;18973;18975;18977;18979;28522;28524;28526;28528 |]
        | 348 -> [| 11278;11302;11304;11306;11643;11645;11647;11649;15706;15708;15710;15712;15714;15716;15718;15720;17503;17505;17507;17509;17833;17835;17837;17839;28523;28525;28527;28529 |]
        | 329 -> [| 11279;11291;11293;11295;11297;11299;11307;11309;11311;11313;11315;11317;11319;11321;11323;11325;11327;11329;11331;11333;11335;11337;11339;11341;11343;11345;11347;11349;11351;11353;20343;20345;20347;20349;20351;20353;23783;23785;23787;23789;23791;23793;28778;28780;28782;28784;28786;31896;31898;31900;31902;31904;31906;31908;31910;31916;31918;40348;40349;40350;40351;41456;41457;41458;47812;47817;47820 |]
        | 349 -> [| 11280;11292;11294;11296;11298;11300;20344;20346;20348;20350;20352;20354;23784;23786;23788;23790;23792;23794;28779;28781;28783;28785;28787;31897;31899;31901;31903;31905;31907;31909;31911;31917;31919;41607;41608;41609;41610;41611;41612;41613 |]
        | 318 -> [| 11367 |]
        | 330 -> [| 11370;11577;11578;14234;14776;14778;14780;14782;15790;16126;20561;20563;20565;32260 |]
        | 834 -> [| 11377;12032;12034;12038;45530 |]
        | 468 -> [| 11396;17869;17870;28412;28413;28414;28626 |]
        | 332 -> [| 11457;11458;11459;11460;11461;11462;11463;11464;11465;11466;11467;11468;11469;11470;11471;11472;11473;11474;11475;11476;11477;11478;11479;11480;11481;11482;11483;11484;11485;11486;11513;11514;11653;11746;20422;24468;27021;27023 |]
        | 333 -> [| 11491;11492;11493;11496;11498;11499;11504;11506;12867;20113;20114;20115;20116;20117;20171;20172;20410;20411;20412;20413;20414;20415;20416;20417;20418;20419;20420;20421;20423;20424;20425;25887;27025;27059 |]
        | 334 -> [| 11530;11531;11532;11533;11534;11535;11536;11537;11538;11539;11540;11541;11542;11543;11544;11545;11547;11548;11549;11550;11551;11552;11553;11554;11555;11556;11557;11558;11688;11689;11690;11691;11692;11693;11694;11695;33195 |]
        | 335 -> [| 11546;25816;25860 |]
        | 338 -> [| 11561;14045;14047;14636;14638;14708;14710;14712;14714;15905;15907;16529;16531;16533;16535;19289;19293;19295;19297;19299;19301;19303;19311;20613;24443 |]
        | 360 -> [| 11562;15906;15908;20614;24444 |]
        | 817 -> [| 11597;11650;11655;11668;11669;11670;11671;11675;11676;11677;11683;11684;11699;11704;11708;11721;11722;12197;12244;12251;12252;12253;12254;12255;12835;12892;12996;13201;13268;13513;13670;13671;13672;13673;13771;13896;13897;13899;13900;13902;13903;13905;13906;15333;15334;15390;15391;15582;15583;15584;15585;15586;16093;16094;16095;16096;16097;16198;16199;16209;16250;16251;16254;16256;16545;16555;16556;16559;16560;16572;16573;16574;16575;16580;16581;16584;16585;16588;16590;16609;16611;16612;16620;16626;16873;18573;18577;18578;18579;18656;19589;19662;19676;19681;19768;19769;20279;20363;20547;20714;24454;24455;28826;29024;29905;29908;29912;29913;29918;29919;29923;29926;30819;34592;34783;34785 |]
        | 613 -> [| 11601;11718;14344;16169;16980;16982;16991;16995;16998;17000;17003;17004;17007;17009;17016;17017;17020;17021;17024;17025;17028;17029;24087;24088;24089;24090;24091;24092;24093;24094;24095;24096;24097;24098 |]
        | 218 -> [| 11612;11795;15809;15811;23901;23903;44118 |]
        | 342 -> [| 11613;11641;22876;22878 |]
        | 343 -> [| 11614;11844;22932;22934;40338;40339 |]
        | 344 -> [| 11616;11848;15966 |]
        | 345 -> [| 11617;11851;15968;22936;22938 |]
        | 346 -> [| 11619;11747;15676;15678;20568;20570;28562 |]
        | 223 -> [| 11620;11798;11799;11803;11804;11808;17521;22896;22926;22940;22942;22944;22946;41412 |]
        | 224 -> [| 11621;11840;15793;22928;22930 |]
        | 131 -> [| 11622;11623;11624;11625;11626;11750;11754;11758;11762;11766;11770;11771;20219;20225;20231;20237;22898;48949 |]
        | 130 -> [| 11628;11629;11630;11631;11632;11775;11779;11783;11787;11791;20574;20576;20578;20580;28730;28732;28734;28736;28738 |]
        | 347 -> [| 11634;11812;11820;11821;11824;11825;11828;11829;11832;11833;11836;11837;20239;20241;20243;20245;20247;20249;20251;20253;20255;20261;20263;20265;21522;21524;21526;21528;21530 |]
        | 705 -> [| 11636;11660;11710;12438;15324;15343;16163;22789;24821;24823;24824;24826;24828;24830;24832;24834;24835;24836;24859;24860;24861;24862;24863;24864;24865;24866;25883;29787;29788;29789;29790;29791;29792;29793;29794;29795;29796;29797;29798;30739;30740;30741;30742;32190;45469 |]
        | 683 -> [| 11639;11665;11745;13105;14354;14360;14480;15342;15581;15973;15974;15975;15976;20163;24777;24779;24781;24784;24785;24786;24787;24790;24791;24793;24811;24812;24813;24814;24815;24816;24817;24818;24819;24820;29876;29878;29879;29881;29882;29883;29884;29885;29886;29887;29888;29889;29891;29892;29893;45467 |]
        | 665 -> [| 11657;11658;11662;11663;14351;14352;14362;14363;14364;14479;14482;15344;15347;15577;15578;15977;15978;15982;15983;15984;15985;15986;15987;16244;24891;24892;24893;24894;24895;24896;24897;24898;24899;24900;24901;24902;24903;24904;24905;24906;24907;24908;24909;24910;24923;24924;24925;24926;24927;24928;24929;24930;24931;24932;29804;29805;29806;29807;29808;29809;29810;29811;29812;29813;29814;29815;30763;30764;30765;30766;30818;45050 |]
        | 671 -> [| 11659;11664;13104;14355;14359;14478;15346;15579;15969;15970;15971;15972;24997;24999;25001;25004;25007;25008;25011;25012;25013;25015;25033;25034;25035;25036;25037;25038;25039;25040;25041;25042;29816;29817;29818;29819;29820;29821;29822;29823;29824;29825;29826;29827;29828;29829;29830;30769;30770;30771;30772;30773;32384;32392;45461 |]
        | 678 -> [| 11661;12440;15325;24271;25147;25149;25150;25152;25154;25156;25158;25160;25161;25162;25179;25180;25181;25182;25183;25184;25185;25186;25820;29775;29776;29777;29778;29779;29780;29781;29782;29783;29784;29785;29786;30725;30726;30727;30728;45466 |]
        | 677 -> [| 11666;13112;14353;14361;14481;15345;15580;15988;15989;15990;15991;21840;22706;25103;25105;25106;25107;25110;25112;25116;25117;25118;25120;25124;25137;25138;25139;25140;25141;25142;25143;25144;25145;25146;29831;29859;29863;29864;29865;29866;29867;29868;29869;29870;29871;29872;29873;29874;29875;45464 |]
        | 668 -> [| 11711;11713;12046;12048;12439;12999;13107;14349;15322;15323;15350;15352;16161;16164;24933;24935;24938;24940;24941;24942;24944;24947;24949;24952;24968;24969;24970;24971;24972;24973;24974;24975;26969;26970;29746;29747;29748;29749;29753;29754;29755;29756;29757;29758;29759;29760;30733;30734;30735;30736;32269;45057 |]
        | 604 -> [| 11716;14346;16166;16927;16928;16929;16930;16931;16944;16948;16949;16956;16957;16958;16959;16960;16961;16962;16971;16975;16976;24099;24100;24101;24102;24103;24104;24105;24106;24107;24108;24109;24110;26712;26755;26971 |]
        | 622 -> [| 11717;14348;16167;17057;17062;17065;17070;17073;17075;17080;17083;17084;17087;17089;17093;17094;17098;17100;17104;17105;17109;24075;24076;24077;24078;24079;24080;24081;24082;24083;24084;24085;24086;26750 |]
        | 595 -> [| 11719;14345;16165;16875;16880;16881;16884;16889;16891;16896;16898;16906;16909;16910;16912;16915;16916;16917;16918;16919;16920;24111;24112;24113;24114;24115;24116;24117;24118;24119;24120;24121;24122;26752;30743;32401 |]
        | 631 -> [| 11720;14347;16168;17033;17039;17042;17044;17045;17046;17047;17048;17055;17056;17110;17111;17112;17114;17123;17124;17125;17127;24063;24064;24065;24066;24067;24068;24069;24070;24071;24072;24073;24074;32192 |]
        | 355 -> [| 11724;11725;11732;11733;11734;11735;11736;11737;11738;11739;11740;11741 |]
        | 356 -> [| 11857;11859;11860;11861;11862;11863;11864;11865;11866;11867;11868;11869;11870;11871;11872;11873;11874;11876;11877;11878;11879;11880;11881;11882;11883;11884;11885;11886;11887;11888;11889;11890;11891;11892;20108;21055;23888;24469;25584;25585;25586;25587;25852;25854;25856;25858;26598;26600;26602;26604;27022;27024;27027;27039;29227;30387 |]
        | 552 -> [| 11898;11899;11900;11927;22838;22839;22840;22841;22842;22843 |]
        | 556 -> [| 11905;11906;11907;11908;23265;23266;23267;23268;23269;23270 |]
        | 565 -> [| 11913;11914;11915;11916;23372;23373;23374;23375;23376;23377 |]
        | 570 -> [| 11921;11922;11923;11924;23450;23451;23452;23453;23454;23455 |]
        | 560 -> [| 11932;11933;11934;11935;23337;23338;23339;23340;23341;23342 |]
        | 687 -> [| 11947;12029;16171;16172;16178;16212;29200;29201 |]
        | 689 -> [| 11948;12047;16173;16174;16175 |]
        | 833 -> [| 11957;11963;11965;11969;33395;33675;44995;45531;48635 |]
        | 906 -> [| 11959;11961;11971;20125 |]
        | 832 -> [| 11978;11985;11987;11989;32790;42245;49713 |]
        | 894 -> [| 11995;12013;12017;12021;35781 |]
        | 401 -> [| 12104;12105;13000;15791;20562;20564;20566 |]
        | 361 -> [| 12198;12199;12200;26849;26888;26890;26892;28770;28772;28774 |]
        | 363 -> [| 12237;24646 |]
        | 311 -> [| 12238;19470 |]
        | 1282 -> [| 12239 |]
        | 364 -> [| 12240;16219 |]
        | 185 -> [| 12245;12246;12248;12249;21845;21846;21847;21848;21849;22053;25215;27801 |]
        | 816 -> [| 12256;12464;13514;13908;13909;13910;13911;14350;15393;15394;16098;16099;16100;16101;16200;16201;16202;16203;16226;16252;16613;16621;16871;17851;18678;19674;19677;19679;19683;20359;20370;20373;20435;20438;20439;20440;20441;20442;20545;21860;22086;22324;25400;29906;29907;29910;29911;29916;29917;29922;29925;46027;46275 |]
        | 367 -> [| 12274;13935;13937;14528;14530;14532;14534;14684;14686;14688;14690;15681;15683;16457;16459;16461;16463;21482;21484;22291;28563;46270;47447;47448;49738 |]
        | 400 -> [| 12275;15682;15684;21483;21485;22292;28564 |]
        | 368 -> [| 12293 |]
        | 370 -> [| 12304;12528;12529;12530;12531;12532;12533;12534;12535;12536;12537;12538;12539;12540;12541;12542;12543;12544;12545;12546;12547;12548;12549;12550;12551;17190;17192;17194;17196;17199;17200;17201;17202;17203;17204;17205;17206;17207;17208;17209;17210;17211;17212;17213;17214;17215;17216;17217;17218;17219;17220;17221;17222;17223;17224;17225;17226;17227;17229;17230;17231;17232;17233;17234;17235;17236;17237;17238;17239;17240;17241;17242;17243;17244;17245;17247;17248;17249;17250;17251;17252;17253;17254;17255;17256;17257;17258;17259;17260;17261;17262;17263;17264;17266;17267;17268;17269;17270;17271;17272;17287;17288;17289;17290;17291;17292;17293;17294;17295;17296;17297;17298;17299;17300;17301;17302;17303;17304;17305;17306;17623;17630;17642;17743;17847;17852;18679;19663;20550;21062;21104;21626;23668;23669;24285;25239;25849;26128 |]
        | 369 -> [| 12306;12339;12340;12341;12342;12343;12369;12370;12371;12372;12373;12374;12375;12377;12378;12379;12380;12381;12382;12384;12444;12445;12446;12447;12448;12449;12450;12451;12452;12453;12454;12455;12456;12457;12460;12461;12462;12463;12465;12466;12467;12468;12469;12474;12475;12476;12477;12479;12480;12481;12597;12598;12599;12600;12601;29150 |]
        | 680 -> [| 12390;15330;15337;15351;15355;20335;25187;25188;25189;25190;25193;25194;25196;25198;25201;25202;28177;28178;29689;29690;29691;29692;29693;29694;29695;29696;29697 |]
        | 674 -> [| 12391;15326;15338;20334;25083;25084;25085;25086;25089;25090;25092;25094;25097;25098;25389;25814;28171;28174;29679;29680;29681;29682;29683;29684;29685;29686;29687;30790;30791;30792;32296;32297 |]
        | 691 -> [| 12392;16170;16176;16177;22753 |]
        | 374 -> [| 12552;12557;12559;12822;12824;12826;12828;12830;12832;41334;41336 |]
        | 726 -> [| 12553;12558;12560;12562;12564;12566;12811;12813;12815;12817;12819;12821;12823;12825;12827;12829;12831;12833;41331;41333;41335;41337 |]
        | 375 -> [| 12561;12563;12565;12810;12812;12814;12816;12818;12820;41330;41332 |]
        | 372 -> [| 12608;12625;12627;12773;12775;12777;12779;12781;12783;41314;41316 |]
        | 725 -> [| 12609;12626;12628;12630;12632;12634;12762;12764;12766;12768;12770;12772;12774;12776;12778;12780;12782;12784;41315;41317;41319;41321 |]
        | 377 -> [| 12610;12612;12614;12785;12787;12789;12791;12793;12795;41322;41324 |]
        | 722 -> [| 12611;12613;12615;12617;12619;12621;12786;12788;12790;12792;12794;12796;12798;12800;12802;12804;12806;12808;41323;41325;41327;41329 |]
        | 373 -> [| 12616;12618;12620;12797;12799;12801;12803;12805;12807;41326;41328 |]
        | 376 -> [| 12629;12631;12633;12761;12763;12765;12767;12769;12771;41318;41320 |]
        | 379 -> [| 12709;19806;19808;19810;19812;19814;21540;31944;32414 |]
        | 504 -> [| 12710;19807;19809;19811;19813;19815;21541;31945;32415 |]
        | 341 -> [| 12711;12713;12715;12717;20367;22885 |]
        | 1202 -> [| 12729;12733;12735;12743 |]
        | 503 -> [| 12730;12732;12734;12736;12744;12746;12748;12754 |]
        | 380 -> [| 12731;12745;12747;12753 |]
        | 382 -> [| 12847;12850;12851;12852;12853;12854;12856 |]
        | 383 -> [| 13068;13113;13114;13115;13116;16739;16740;16741;16742;16743;16744;16745;16746;16747;17144;17145;17146;17147;17148;17149;17150;17151;17152;17153;17154;17155;17156;17157;17158;17159;17160;17161;17163;17164;17568;17569;17570;17571;17572;17573;17574;17575;17576;17577;17578;17579;17580;17581;17582;17583;17584;17585;17586;17587;17588;17589;17590;17591;17592;17593;17594;17595;17596;17597;17598;17599;17600;17601;17602;17603;17605;17606;17607;17608;17609;17610;17611;17612;17638;17875;17876;17877;17878;17879;17880;18000;18001;18023;18026;18027;18028;18031;18032;18033;18034;18035;19664;19665;19666;19667;19668;19669;19670;21744;21745;21746;21747;21748;21749;22848;24767;24772;25385;25626;25706;25817;25827;25840;26709;26747;26856;26857;26858;27280;27281;27282;27283;27284;27285;27668;27669;27670;27765;27792;27793;27794;27795;27796;27797;27798;27799;27800;27953;27954;27955;27956;28139;28140;28141;28142;28143;28144;28145;28146;28147;28148;28149;28150;28151;28152;28153;28571;28572;28573;28574;28575;30460;30461;30462;34437;34454;34455;34873;35663;47488;48594 |]
        | 744 -> [| 13209;21888;21889;21890;22559;33403;33404;33405;33406;43775 |]
        | 506 -> [| 13320;13927;13929;14516;14518;14520;14522;14672;14674;14676;14678;15449;16062;16138;16513;16515;16517;16519;17485;19739;20601;22568 |]
        | 789 -> [| 13515;13516;13517;13518;13519;13521;13522;13525;13527;13528;22015;22016;22017;22018;22019;22020;22021;22022;22023;22024;26973 |]
        | 790 -> [| 13520;13523;13524;13526;13529;13530;13531;13532;13533;13534 |]
        | 848 -> [| 13535;13537;13539;13540;13542;13543;22871;22872;22873;22874 |]
        | 553 -> [| 13536;13538;13541;13544 |]
        | 792 -> [| 13545;13546;13554;13555;13558;13566;13567;13568;13571;13574;24390;24391;24392;24393;24394;24408 |]
        | 791 -> [| 13547;13548;13549;13550;13551;13552;13553;13565;13569;13570 |]
        | 849 -> [| 13556;13559;13560;13562;13563;13572;23299;23300;23301;23302 |]
        | 559 -> [| 13557;13561;13564;13573 |]
        | 798 -> [| 13575;13577;13586;13587;13591;13592;13595;13596;13599;13600;21998;21999;22000;23939;26871 |]
        | 800 -> [| 13576;13581;13582;13585;13590;13593;13594;13597;13598;13604;21988;21989;21990;21991;21992;21993;21994;21995;21996;21997 |]
        | 850 -> [| 13578;13579;13583;13588;13601;13602;23355;23356;23357;23358 |]
        | 564 -> [| 13580;13584;13589;13603 |]
        | 808 -> [| 13605;13611;13613;13618;13619;13624;13626;13630;13631;13636 |]
        | 851 -> [| 13606;13614;13620;13621;13633;13634;23400;23401;23402;23403 |]
        | 569 -> [| 13609;13615;13622;13635 |]
        | 810 -> [| 13610;13612;13616;13617;13623;13625;13627;13628;13629;13632 |]
        | 812 -> [| 13637;13638;13639;13641;13651;13656;13663;13664;13668;13669 |]
        | 814 -> [| 13640;13642;13643;13644;13645;13646;13647;13648;13649;13650;24369;24370;24371;24372;24373;24374;24375;24376 |]
        | 852 -> [| 13652;13653;13658;13660;13665;13666;23469;23470;23471;23472 |]
        | 574 -> [| 13654;13659;13661;13667 |]
        | 554 -> [| 13678;13679;13680;13681;13682;13683;13684;13685;13686;13687;13688;13689;22025;22026;22027;22028;35679 |]
        | 558 -> [| 13690;13691;13692;13693;13694;13695;13696;13697;13698;13699;13700;13701;24381;24382;24383;24384 |]
        | 573 -> [| 13702;13703;13704;13705;13706;13707;13708;13709;13710;13711;13712;13713;24377;24378;24379;24380 |]
        | 563 -> [| 13714;13715;13716;13717;13718;13719;13720;13721;13722;13723;13724;13725;22001;22002;22003;22004;22029 |]
        | 568 -> [| 13726;13727;13728;13729;13730;13731;13732;13733;13734;13735;13736;13737 |]
        | 397 -> [| 13780;16220;24574;24575;24653;24654;24655;24656;24657;24658;24659;24660;25305;29613;30389;33867 |]
        | 404 -> [| 14343;17764;17982;25270;25271;25280;25821;28314;28315;28316;28317;28884;30655 |]
        | 337 -> [| 15395;16102;16104;24754 |]
        | 409 -> [| 15587;15588;15589;15590;15591;15592;15593;15594;15596;15597;15598;15599;15600;15601;15602;15604;15605;15607;15608;15609;15610;15611;15612;15613;15614;15615;15617;15618;15619;15620;15621;15622;15623;15625;15626;15627;15628;15629;15630;15631;15632;15634;15635;15636;15637;15638;15639;15640;15641;15642;15643;15644;15645;15646;15647;15648;15649;15650;15651;15652;15653;15654;15655;15656;15657;15658;15659;15660;15661;15662;15663;15664;15666;15667;15668;15669;15670;15671;15672;15673;15674;15979;15980;15981;15992;15993;15994;15996;15997;15998;15999;16000;16001;16002;16118;16119;16120;16121;16122;16123;16124;16125;16179;16180;16181;16182;16183;16184;16185;16186;16187;16188;16189;16617;17639;17801;17802;17803;17817;17999;18581;18654;18657;19675;19678;19680;20372;20374;20546;20548;21057;21862;23624;25230;25366;25372;28231;28236;28237;28238 |]
        | 699 -> [| 16019;16020;16021;16022;16023;16024;16040;16703 |]
        | 701 -> [| 16027;16028;16030;16031;16033;16038;32456 |]
        | 703 -> [| 16034;16035;16036;16037;16039 |]
        | 411 -> [| 16103 |]
        | 695 -> [| 16110;16111;16112;16114;16115;33805 |]
        | 697 -> [| 16116;16117;16615;16616;29228;33806 |]
        | 32 -> [| 16159 |]
        | 413 -> [| 16216;24567;28351;32245 |]
        | 414 -> [| 16217;17172;17173 |]
        | 416 -> [| 16221 |]
        | 417 -> [| 16222;16695;16696;16697;17773;27560;27562;27638;27640;27641;27643 |]
        | 418 -> [| 16223 |]
        | 420 -> [| 16236;16238;16240;16242;32840;32842;32844;32846;32848;32872;32874;32876;32878;33099;33877;33879;33881;33883;42685;49710 |]
        | 487 -> [| 16237;16239;16241;16243;22453;22457;22461;22465;32841;32843;32845;32847;32849;32873;32875;32877;32879;33878;33880;33882;33884;44106;49714 |]
        | 422 -> [| 16258;16259;16260;16261;25411;25412;25413;25414 |]
        | 465 -> [| 16262;16263;16264;16265;16266;16267;16268;16269;17975;17976;17977;17978;28433;28434;28435;28436;28437;28438;28439;28440;28441;28442;28443;28444;28627;28628 |]
        | 423 -> [| 16272;16273;16274;16275;17887;17888;17889 |]
        | 464 -> [| 16278;17482;22229;28752;28754 |]
        | 490 -> [| 16279;17483;17913;22230;24306;28753;28755 |]
        | 425 -> [| 16282 |]
        | 606 -> [| 16563;16564;16932;16933;16935;16936;16937;16939;16940;16942;16943;16945;16946;16947;16950;16951;16953;16954;16955;16963;16964;16966;16972;16973;16974;16977;16979;24039;24040;24041;24042;24043;24044 |]
        | 615 -> [| 16565;16566;16981;16983;16985;16986;16987;16989;16990;16993;16994;16996;16997;16999;17001;17002;17006;17008;17012;17013;17015;17019;17022;17023;17026;17027;17032;24045;24046;24047;24048;24049;24050;25825;32391 |]
        | 624 -> [| 16567;16568;17059;17060;17061;17063;17064;17067;17068;17069;17072;17074;17076;17077;17078;17079;17081;17086;17088;17091;17092;17097;17099;17101;17102;17103;17106;24051;24052;24053;24054;24055;24056;24607 |]
        | 426 -> [| 16631;16688;16689;17770;17771;17772;27554;27556;27557;27559;27644;27646;27647;27649;27650;27652;27653;27655 |]
        | 427 -> [| 16633;16634;16635;16636;16637;16638;16639;16640;16641;16642;16643;16644;16646;16647;16648;16649;16650;16651;16652;16653 |]
        | 428 -> [| 16654;16655;16656;16657;16658;16659;16660;16661;16662;16663;16664;16665;16666;16667;16668;16669;17769;17959;17960;20431;29659;29660;29661;29662;29663;29664;32821;32822;32823;32824;32825;32826;32827;32828;32829;33336;33337;33338;33339 |]
        | 429 -> [| 16670;16671;16672;16673;16678;16679;16680;16681;16682;16683;17317;33359;33360;33361;33362 |]
        | 449 -> [| 16690;16691;16692;17402;17403;17404;27542;27544;27545;27547;27613;27615;27616;27618;27619;27621;27622;27624 |]
        | 430 -> [| 16694;16867;17167;17168;17406;17407;17408;27548;27550;27551;27553;27625;27627;27628;27630;27631;27633;27634;27636;27766;27767;27768;27769;27770;27771;27772;27773;27774;27775;27776;27777 |]
        | 661 -> [| 16868;25243;25251;25284;25285;25286;25287;25288;28702;28703;28704;28705;28706;28707;28708;28709 |]
        | 438 -> [| 16869;20175;20176;22634;24684;28318;28319;30656 |]
        | 594 -> [| 16892;16893;16899;16900;16921;16922;16923;16924;16925;16926;17641;24125;24126;24127;24128;24129;24130;24131;24132;24133;24134;25822;32298;32402 |]
        | 603 -> [| 16934;16938;16941;16952;16965;16967;16968;16969;16970;16978;24135;24136;24137;24138;24139;24140;24141;24142;24143;24144;26754 |]
        | 612 -> [| 16984;16988;16992;17005;17010;17011;17014;17018;17030;17031;24145;24146;24147;24148;24149;24150;24151;24152;24153;24154;25824;32385 |]
        | 630 -> [| 17034;17036;17037;17038;17049;17050;17051;17052;17053;17054;24165;24166;24167;24168;24169;24170;24171;24172;24173;24174 |]
        | 621 -> [| 17058;17066;17071;17082;17085;17090;17095;17096;17107;17108;19737;24155;24156;24157;24158;24159;24160;24161;24162;24163;24164 |]
        | 494 -> [| 17135;17179;17273;17275;17388;17390;17422;17563;17613;17614;17631;17632;17633;17645;17747;17748;17799;17818;17820;17821;17822;17891;17979;17994;18632;18633;18634;18645;19426;19427;19487;19501;19502;19504;19557;19558;19559;19560;19561;19562;19565;19588;19590;19622;19653;19708;19714;19715;19716;19738;19742;19795;19957;20102;20162;20166;20196;20282;20283;20284;20285;20325;20326;20329;20523;20542;21459;21519;21600;21617;21622;21627;21635;21861;21884;22031;22039;22047;22059;22098;22145;22156;22158;22161;22182;22184;22232;22241;22289;22320;22704;22709;22710;22725;22739;22750;22757;22794;23240;23413;23514;23520;23522;23567;23593;23600;23617;23642;23688;23689;23691;23695;23696;23908;23960;23964;24243;24256;24257;24262;24351;24356;24579;24670;24671;24751;24761;24771;25360;25377;25384;25388;25402;25717;25734;26168;26247;26248;26249;26250;26251;26606;26731;26733;26735;26736;26738;27279;27292;33910;41589 |]
        | 439 -> [| 17174;17175;17176;17177;27574;27576;27577;27579;27580;27582;27583;27585 |]
        | 441 -> [| 17178;27570;27573 |]
        | 440 -> [| 17180;27778;27779 |]
        | 443 -> [| 17181;17182;27563;27565;27567;27569 |]
        | 444 -> [| 17184;17185;17186;17187 |]
        | 445 -> [| 17188 |]
        | 496 -> [| 17274;17276;17277;17798;17996;18582;18628;18629;19373;19425;19591;19960;20077 |]
        | 446 -> [| 17286;19365;19366;19367;19368;19369;19370;19371;19372;19383;19384;19385;19386;19387;19388;19563;19564 |]
        | 447 -> [| 17322;17323;17324;17325;17326;17327;17328;17329;17330;17331;17332;17333;17334;17335;17336;17337;17338;17339;17340;17341;17342;17344;17345;17346;17347;17348;17349;17350;17351;17352;17353;17354;17355;17356;17357;17359;21948;21950;21952;21954;21956;21958;21960;21962;21964;21966;21968;21970;33196;36953;36954;36955;49721 |]
        | 448 -> [| 17363;17364;17365;17366;17367;17368 |]
        | 463 -> [| 17476;17478;17480 |]
        | 477 -> [| 17477;17479;17481;22545;22547;22549;33684 |]
        | 470 -> [| 17565 |]
        | 471 -> [| 17621;24652 |]
        | 472 -> [| 17696;17873;17884;21047 |]
        | 473 -> [| 17701 |]
        | 476 -> [| 17857;17859;17861;17863;29616;29618;29620;29622 |]
        | 478 -> [| 17874;17885 |]
        | 480 -> [| 17899;18586 |]
        | 483 -> [| 17912;18068;24305 |]
        | 436 -> [| 17941;17942;17943;17944;17945;17946;17947;17948;17949;17950;17951;17952;17953;17954;17955;17956;17957;17958;17961;20432;29640;29641;29642;29643;29644;29645;32830;32831;32832;32833;32834;32835;32836;32837;32838;33340;33341;33342;33343 |]
        | 484 -> [| 17962;17963;17964;17965;17966;17967;17968;17969;17970;17971;17972;33363;33364;33365;33366 |]
        | 879 -> [| 18029 |]
        | 482 -> [| 18036;18038;18040;18042;18044;18046;18048;18050;18052;18056;18058;18060;18062;18064;18066;18590;18592;18594;18596;18598;18600;18602;18604;18606;18610;18612;18614;18616;18618;18624;46355;46356;46365;46366;46367;46368;46369;46370;46371;46372 |]
        | 727 -> [| 18037;18039;18041;18043;18045;18047;18049;18051;18053;18055;18057;18059;18061;18063;18065;18067;18591;18593;18595;18597;18599;18601;18603;18605;18607;18609;18611;18613;18615;18617;18619;18625;46350;46351;46352;46353;46357;46358;46359;46360;46361;46362 |]
        | 663 -> [| 18054;18608 |]
        | 972 -> [| 18588;25797;28766;28768 |]
        | 492 -> [| 18626;18635;18637 |]
        | 493 -> [| 19400;19401;19402;19403;19404;19405;19406;19407;19408;19409;19410;19411;19412;19413;19414;19415;19416;19417;19418;19419;19420;19421;19422 |]
        | 498 -> [| 19459;19466;19468;19583;19594;22797 |]
        | 300 -> [| 19534;19535;19536;19537;19538;19539;19540;19551;19553;19554;19555;19556;20121;20157;20158;20159;20160;20161;20498;20499;20500;20501;20502;20503;20504;20505;20506;20507;20508;20509;22107;22108;22109;22110;22111;22112;22113;22114;22115;22116;22117;22118;22119;22120;22121;22122;22123;22124;22125;22126;22127;22128;22129;22130;22131;22133;22134;22135;22136;22137;24343;24344;24345;24346;24347;24485;28790;28791;28792;28793;28794;28795;28796;28797;28798;28799;28800;28801;28802;28803;28804;28805;28806;28807;28808;28809;28810;28811;28812;28813;28814;28815;28816;28817;28818;28819;31954;31955;31956;31957;31958;31959;31962;31963;31964;31965;31966;31967;31968;31969;31970;31971;31972;31973;31974;31975;31976;31977;31978;31979;32101;32102;32103;32104;32105;32107;32108;32109;32110;32111;32112;32113;32114;32115;32116;32117;32118;32119;32120;32121;32122;32123;32124;32125;33068;33516;33525;33526;33527;33528;33529;33555;33557;33559;33561;33563;33565;33917;33918;33919;33920;33921;33922;33923;33924;33925;33926;33927;33928;33929;33930;33931;33932;33933;33934;33935;33936;33937;33938;33939;33940;33941;33942;33943;33944;33945;33946;33947;33948;33949;33950;33951;33952;33953;33954;33955;33956;33957;33958;33959;33960;33961;33962;33963;33964;33965;33966;33967;33968;33969;33970;33971;33972;33973;33974;33975;33976;42145;42146;42200;42201;42202;42203;42204;42205;42206;42207;42208;42209;42210;42211;42212;42213;42214;42215 |]
        | 976 -> [| 19658;30222 |]
        | 501 -> [| 19660;44109 |]
        | 485 -> [| 19720;19722;19724;19726;34339;34341;34343;34345;42124;42243;45647 |]
        | 537 -> [| 19721;19723;19725;19727;34340;34342;34344;34346;42136;45044;45646 |]
        | 502 -> [| 19728;25880 |]
        | 530 -> [| 20110;21073;21075;21078;21081;21086;21089;21584;21585;21586;21587;21588;21589;21590;21591;21592;21593;21594;21595;21596;23138;23139;23140;23141;23142;23143;23144;23145;23146;23147;23158;23159;23160;23161;23162;23163;23164;23165;23166;23167;28867 |]
        | 505 -> [| 20127 |]
        | 771 -> [| 20138;25707;25709;25711;25713;25715;28375;28377;28379;28381;28383;28565;34292 |]
        | 513 -> [| 20183;20185;20187;20189;34328 |]
        | 525 -> [| 20184;20186;20188;20190;28845;28847;28849;28851;34329 |]
        | 772 -> [| 20306;20307;20308;21867;27393;27397;27401;27403;27405;27407;27411;27413;27415;27417;27419;27421;27887;27888 |]
        | 716 -> [| 20426;25553;25554;25555;25556;25851;25853;25855;25857;26597;26599;26601;26603;27026;30386 |]
        | 520 -> [| 20462;20463;20464;20465;20466;20467;20468;20469;20470;20471;20472;20473;20474;20475;21060;21130;21131;21767;21768;21769;21770;21771;21772;21773;21774;21775;21776;21779;21780;21781;21782;22255;22256;22257;22258;22259;22260;22261;22270;22661;22662;22663;22664;22665;22666;22673;23242;23243;23277;23280;23665;23671;23672;24683;26717;26718;32199;32222 |]
        | 521 -> [| 20476;20477;20478;20479;20480;20481;21808;21809;21810;21811;21812;21813;22095;22194;22203;22204;23878;27276 |]
        | 522 -> [| 20482;20483;20484;20485;20486;20487;20488;20489;21128;21129;21758;21759;21760;21762;21763;21764;21765;21766;21778;22262;22263;22264;22265;22272;22667;22668;22669;22670;22674;22676;23275;23276;23667;23670;23875;24286 |]
        | 523 -> [| 20490;20491;20492;20493;21058;21754;21755;21756;21757;21777;22266;22267;22268;22269;22271;22671;22672;22675;23221;23241;23278;23279;23664;23879;24682 |]
        | 533 -> [| 20549;20552;21049;21056;21061;21063;21065;21068;21090;21092;21101;21103;21515;21597;21630;21643;21647;21648;21649;21650;21651;21652;21670;21675;21786;21787;21859;21881;21882;21887;21972;22042;22052;22057;22058;22076;22082;22088;22091;22094;22104;22105;22160;22171;22233;22237;22239;22250;22253;22322;23233;23235;23422;23596;23598;23601;23609;23614;23628;23685;23951;23965;24261;24307;24661;25576;26741;26744;26748;26795;26859;26867;26878;26879;26880;26883 |]
        | 1229 -> [| 20700;22534;22535;22570;22571;27102;27103;27149;27150;27151;27169;27174;27175;27238;27239;27240 |]
        | 873 -> [| 21009;21011;21013;21017;21019;21021;21023;21025;21027;21029;21035;21037;21039;21041;24545;24547;24556;24558;24560 |]
        | 915 -> [| 21010;21012;21014;21018;21020;21022;21024;21026;21028;21030;21036;21038;21040;21042;24546;24548;24557;24559;24561 |]
        | 735 -> [| 21074;21077;21084;21085;21087 |]
        | 528 -> [| 21076;21079;21080;21082;21088;21719;21720;21721;21722;21723;21724;21725;21726;21727;21728;21729;21730;21731;21732;21733;23128;23129;23130;23131;23132;23133;23134;23135;23136;23137;23148;23149;23150;23151;23152;23153;23154;23155;23156;23157;42226 |]
        | 658 -> [| 21096;28646 |]
        | 534 -> [| 21127;21181;21448;21452;21735;21788;21792;21794;21795;21796;21886;22040;22041;22048;22075;22079;22097;22153;22154;22235;22238;22246;22273;22276;23271;23616;23623;23873;24260;24282;24583;24662;26139;26212;26227;26244;26246;26279;26284;26285;26454;26742;26806;26848;26882;26884;26885 |]
        | 715 -> [| 21161;23952;25351;25365;25368;25371;25392;25396;25409;25531;25532;25533;25534;25535;30908 |]
        | 527 -> [| 21490;21495;21503;21518;21563;21618;21621;21636;21653;21654;21655;21656;21657;21658;21660;22092;22093;22106;22236;22240;22316;23557;23612;23619;24258;24259;26767 |]
        | 732 -> [| 21568;21569;21570;21571;21572 |]
        | 731 -> [| 21573;21574;21575;21576;21577;33319;33322;33325 |]
        | 729 -> [| 21579;21580;21581;21582;21583;33318;33321;33324 |]
        | 1207 -> [| 21678;21679;21680;21681;21683;21684;21685;21686;21688;21689;21690;21691;21693;21694;21695;21696;21708;21709;21710;21711;21713;21714;21715;21716;22225;22226;22293;22294;23188;23189;23190;23191;23192;23193;23194;23195;23196;23197;23198;23199;23200;23201;23202;23203;23204;23205;23206;23207;23208;23209;23210;23211;24464;26135;26136;26137;26145;26146;26148;26149;26150;26151;26152;26153;26154;26155;26161;26162;26163;26164;26165;26166;26276;26277;27277;27278;28871;28872;28873;28874;28875;28876;28877;28878;28881;28882;28883;28902;28904;28905;28906;28907;28908;28909;28911;28912;28914;28915;28917;28918;28920;28921;28923;28924;28927;28928;28930;28931;28933;28934;28936;28937;28938;28939;28940;28941;28942;28943;28944;28945;28946;28948;28949;28951;28952;28955;28957;28958;28960;28961;28964;28966;28967;28969;28970;28976;28977;28978;28979;28982;28983;28984;28985;28986;28987;28988;28989;28990;28991;28992;28993;28994;30516;30517;30518;30519;30520;30521;30522;30523;30524;30525;30526;30527;30528;30529;30530;32282;32367;32369;33147;33186;33187;33188;33233;33234;33235;33236;33237;33238;33239;33240;33241;33242;33243;33244;33245;33246;33247;33248;33249;33251;33252;33253;33254;33255;33256;33257;33258;33259;33260;33261;33262;33263;33264;33265;33266;33267;33268;33269;33367;33368;34572;47457 |]
        | 886 -> [| 21815;28361;28362;28363;28364;28365;28366 |]
        | 535 -> [| 21943;21944;21945;21946;27657;27659;27661;27663;27665;27667;27938;27940;27942;27958;27960;27962;27964;27966;27968;27970;27972;27974;27976;27978;27980;27982;27984;27986;27988;27990;27992;27994;27996;27998;28000;28002;28004;28006;28008;28010;28012;28014;28016;28018;28020;28022;28024;28026;28028;28030;28032;28034;28036;28038;28040;28042;28044;28046;28048;28050;28052;28054;28056;28058;28060;28062;28064 |]
        | 536 -> [| 21947;21949;21951;21953;21955;21957;21959;21961;21963;21965;21967;21969;36956;36957;36958;49720 |]
        | 898 -> [| 22428;22430;22436;22440;44996 |]
        | 540 -> [| 22442;22444;22446;22448;22466;22468;22470;22474 |]
        | 541 -> [| 22452;22456;22460;22464 |]
        | 546 -> [| 22542;22576;22609;22611;22613;22615;22617;22619;22621;22623;28576;28578 |]
        | 1139 -> [| 22543;22577;28577;28579 |]
        | 543 -> [| 22544;22546;22548;33683 |]
        | 544 -> [| 22572;23659;23702 |]
        | 1142 -> [| 22573;23660;23703 |]
        | 545 -> [| 22574;22713 |]
        | 783 -> [| 22715;22760 |]
        | 640 -> [| 22765;23523;23709;23711;23717;23719;28197;28199;28201;28203;28205;28207;33671;33704;33706;33708;33710;33712 |]
        | 1144 -> [| 22766;23524;23710;23712;23718;23720;28198;28200;28202;28204;28206;28208;33672;33705;33707;33709;33711;33713 |]
        | 548 -> [| 22778;34260;41402 |]
        | 486 -> [| 22779;30014;30029 |]
        | 589 -> [| 22782 |]
        | 575 -> [| 22812;22813;22814;22815;22816;22817 |]
        | 576 -> [| 22822;22823;22824;22825;22826;22827 |]
        | 794 -> [| 22857;22858;22859;22860;22861;22862 |]
        | 793 -> [| 22865;22866;22867;22868;22869;22870 |]
        | 1652 -> [| 23055;23057;23059;23061;40358;40359;40360;40361;40552;40553;40554;40555;40556;40557;40558;40559;45669;45671;47035;47036;47138;47139;47140;47141;47142;47143;47144;47145;47146;47147;47148;47149;47150;47151 |]
        | 1146 -> [| 23056;23058;23060;23062;41375;41376;41377;41378;41379;41380;41381;41382;41383;41384;41385;41386;45670;45672;47208;47209;47210;47211;47212;47213;47214;47215;47216;47217;47218;47219;47220;47221;47222;47223 |]
        | 733 -> [| 23168;23169;23170;23171;23172 |]
        | 734 -> [| 23173;23174;23175;23176;23177 |]
        | 728 -> [| 23178;23179;23180;23181;23182;33315;33316;33317 |]
        | 730 -> [| 23183;23184;23185;23186;23187;33320;33323;33326 |]
        | 578 -> [| 23244;23252;23253;23254;23255;23256 |]
        | 577 -> [| 23245;23246;23247;23248;23249;23250 |]
        | 796 -> [| 23287;23288;23289;23290;23291;23292 |]
        | 795 -> [| 23293;23294;23295;23296;23297;23298 |]
        | 579 -> [| 23312;23313;23314;23315;23328;23329;23940;23941 |]
        | 580 -> [| 23321;23322;23323;23324;23325;23326 |]
        | 799 -> [| 23343;23344;23345;23346;23347;23348;23942;23943 |]
        | 797 -> [| 23349;23350;23351;23352;23353;23354 |]
        | 581 -> [| 23378;23379;23405;23406;23407;23408 |]
        | 582 -> [| 23383;23384;23385;23386;23387;23388 |]
        | 809 -> [| 23391;23392;23409;23410;23411;23412 |]
        | 807 -> [| 23394;23395;23396;23397;23398;23399 |]
        | 583 -> [| 23423;23424;23425;23426;23427;23428 |]
        | 584 -> [| 23438;23439;23440;23441;23442;23443 |]
        | 813 -> [| 23457;23458;23459;23460;23461;23462 |]
        | 811 -> [| 23463;23464;23465;23466;23467;23468 |]
        | 639 -> [| 23473;23506;23510;23512;23705;23707;23713;23715;23721;23723;23725;23727 |]
        | 1143 -> [| 23474;23507;23511;23513;23706;23708;23714;23716;23722;23724;23726;23728 |]
        | 804 -> [| 23475;23476;23477;23478;23479;23480;29215 |]
        | 647 -> [| 23527;24427;32262;32927;32929;32931;32933 |]
        | 408 -> [| 23528;23534;24284;24396;24418;24428;24439;31943;33823;33825;41413;41416;41418 |]
        | 646 -> [| 23533;24438;31942;32935;32937;32939;32941;33826;41031;41032 |]
        | 641 -> [| 23536;23729;23731 |]
        | 1147 -> [| 23537;23730;23732 |]
        | 588 -> [| 23674;24550;24552;24554;37474;40631;40632;40633;40634;41439;41440;41441;41442;41443;41444;42522 |]
        | 815 -> [| 23735 |]
        | 547 -> [| 23757;23911;23915;24483;42132 |]
        | 643 -> [| 23758;23912;23916;24484;42134 |]
        | 590 -> [| 23953;28652 |]
        | 824 -> [| 23956;23957 |]
        | 596 -> [| 23969;23974;23975;23976;23977;23978;24229;24230;24231;24232;24233;24234 |]
        | 605 -> [| 23970;23979;23980;23981;23982;23983;24223;24224;24225;24226;24227;24228 |]
        | 614 -> [| 23971;23984;23985;23986;23987;23988;24217;24218;24219;24220;24221;24222 |]
        | 623 -> [| 23972;23989;23990;23991;23992;23993;24211;24212;24213;24214;24215;24216 |]
        | 593 -> [| 23999;24004;24005;24006;24007;24008;24175;24176;24177;24178;24179;24180 |]
        | 611 -> [| 24001;24014;24015;24016;24017;24018;24187;24188;24189;24190;24191;24192 |]
        | 620 -> [| 24002;24019;24020;24021;24022;24023;24193;24194;24195;24196;24197;24198 |]
        | 629 -> [| 24003;24024;24025;24026;24027;24028;24199;24200;24201;24202;24203;24204 |]
        | 407 -> [| 24283;32951;32953;32955;32957;41414;41415;41417 |]
        | 644 -> [| 24395;24417;32943;32945;32947;32949;33850;33852 |]
        | 651 -> [| 24549;24551;24553;24555;41395;41438;41445;41446;41447;41448;41449;41450;41451;41452;41532;42889 |]
        | 652 -> [| 24592;24593;24594;24595;24596;24597 |]
        | 500 -> [| 24608;30221;32993;32994;32995;33569;33571;33572;33573;44110;44260;44261;44262;44263;44264;44265;44266;44267;44268;44269;44270;44271;44272;47264 |]
        | 684 -> [| 24797;24798;24799;24801;24805;24810;45468 |]
        | 685 -> [| 24843;24847;24848;24851;24855;24857;28179;28180 |]
        | 669 -> [| 24911;24912;24913;24915;24917;24919;27001;45051 |]
        | 666 -> [| 24956;24957;24958;24959;24960;24962;28169;28170;30737;30738 |]
        | 676 -> [| 25020;25021;25022;25024;25026;25028;45462 |]
        | 672 -> [| 25063;25064;25065;25066;25067;25069;28172;28173;32390 |]
        | 679 -> [| 25125;25126;25127;25129;25131;25133;45465 |]
        | 681 -> [| 25167;25168;25169;25170;25171;25173;28175;28176 |]
        | 712 -> [| 25237;25241;25242;25252;25283;25330;25331;25332;25333;25334;25335;25336;25337;25338;25339;25340;25341;25342;25343;25344;25345;25346;25347;25348;28686;28687;28688;28689;28690;28691;28692;28693 |]
        | 662 -> [| 25240;25282;25289;25290;25291;25292;25293;25294;25295;25296;25297;25298;25299;25300;25301;25302 |]
        | 737 -> [| 25266;25540;25542;25812;28788 |]
        | 711 -> [| 25268;25273;25274;25275;25276;25277;25278;25279;28629;28630;28694;28695;28696;28697;28698;28699;28700;28701;30370;30371;30372;30373;30374;30375;30376;30377;30378 |]
        | 1231 -> [| 25545;25546;25547;25548;27147;27148 |]
        | 670 -> [| 25557;30974 |]
        | 514 -> [| 25561;25563;25565;25567;25569;25571 |]
        | 1222 -> [| 25562;25564 |]
        | 754 -> [| 25588;25589;25590;25591;25592;25593;25594;25595;25596;25597;25598;25599;25600;25601;25602;25603;25604;25605;25606;25607;25608;25609;25610;25611;25612;25613;25614;25615;25616;25617;25618;25619;25620;25621;25622;25623;25624;25625 |]
        | 757 -> [| 25632;25635;25639;25643;25644;25646;25664;25677;25678;25680;25682;25683;25685;25688;25694;25695;25696;25703;25704;25705 |]
        | 761 -> [| 25633;25634;25637;25638;25649;25657;25659;25660;25663;25670;25701;25702 |]
        | 759 -> [| 25636;25641;25645;25656;25658;25667;25668;25674;25676;25679;25681;25684;25686;25687;25689;25690;25691;25692;25693;25698 |]
        | 755 -> [| 25640;25642;25654;25655;25673;25697 |]
        | 758 -> [| 25647;25661;25666;25669;25671;25672 |]
        | 756 -> [| 25648;25650;25651;25652;25653;25662;25665;25675;25699;25700 |]
        | 773 -> [| 25736;25888;25890;25892;25894;25896;25898;25900;26286;26288;26290;26292;26294;26296;26298;26302;27064;27066;27068;30987;30993;30997;30999;31001;31003;31005;31007;31009;31011;31013;31015;31017;31019;31021;31023;31025;31027;31029;31031;31033;31035;31037;31039;31041;31043;31045;31047;31049;31051;31053;31055;31057;31059;31061;31063;31065;31067;31069;31071;31073;31075;31077;31079;31081;33890;33892;33894;33896;33898;33900;33902;33904 |]
        | 784 -> [| 25829 |]
        | 1122 -> [| 25861;26983;30836 |]
        | 1123 -> [| 25862;26984;30837 |]
        | 1232 -> [| 25902;26300;31083;31085;31087;31089;31091;31093;32817;32819 |]
        | 774 -> [| 25906;26076;26078;26080;26082;26084;26086;26088;26090;26436;26438;26440;26442;26444;26446;26448;26450;26452;26964;26966;31716;31718;31720;31722;31724;31726;31728;31730;31732;31734;31736;31738;31740;31742;31744;31746;31748;31750;31752;31754;31756;31758;31760;31762;31764;31766;31768;31770;31772;31774;31776;31778;31780;31782;31784;31786;31788;31790;31792;31794;31796;31798;31800;31802;31804;31810;31812;31814;31816;31818;31820;31822;31824;31826 |]
        | 778 -> [| 25908;25910;25912;25914;25916;25918;25920;25922;25924;26324;26326;26328;26330;26332;26334;26336;26338;26340;26925;26927;32025;32027;32029;32031;32033;32035;32037;32039;32041;32043;32045;32047;32049;32051;32053;32055;32057;32059;32061;32063;32065;32067;32069;32071;32073;32075;32077;32079;32081;32083;32085;32087;32089;32091;32093;32095;33277;33279;33281;33283;33285;33287;33289;33291;33293;33295;33297;33298;33307;33309;33311;33313 |]
        | 1233 -> [| 25930;25932;25936;26104;26342;26346;26350;26362;31201;31203;31205;31207;31209;31211;31213;31215;31217;31220;31222;31224;31238;31240;31242;31244;31246;31248;31310;31312;31314;31316;31318;31320 |]
        | 775 -> [| 25968;25970;25972;25974;25976;25978;25980;26378;26380;26382;26384;26386;26388;26390;31418;31420;31422;31424;31426;31428;31430;31432;31434;31436;31438;31440;31442;31444;31446;31448;31450;31452;31454;31456;31458;31460;31462;31464;31466;31468;31470;31472;31474;31476;31478;31480;31482;31484;31486;31488;31490;31492;31494;31496;31498;31500 |]
        | 776 -> [| 25996;25998;26000;26002;26004;26006;26008;26392;26394;26396;26398;26400;26402;26404;31502;31504;31506;31508;31510;31512;31514;31516;31518;31520;31522;31524;31526;31528;31530;31532;31534;31536;31538;31540;31542;31544;31546;31548;31550;31552;31554;31556;31558;31560;31562;31564;31566;31568;31570;31572;31574;31576;31578;31580;31582;31584 |]
        | 779 -> [| 26016;26018;26020;26022;26024;26026;26028;26030;26406;26408;26410;26412;26414;26416;26418;26420;31586;31588;31590;31592;31594;31596;31598;31600;31602;31604;31606;31608;31610;31612;31614;31616;31618;31620;31622;31624;31626;31628;31630;31632;31634;31636;31638;31640;31642;31644;31646;31648;31650;31652;31654;33301 |]
        | 777 -> [| 26036;26038;26040;26042;26044;26046;26048;26422;26424;26426;26428;26430;26432;26434;31656;31658;31660;31662;31664;31666;31668;31670;31672;31674;31676;31678;31680;31682;31684;31686;31688;31690;31692;31694;31696;31698;31700;31702;31704;31706;31708;31710;31712;31714 |]
        | 782 -> [| 26056;26058;26060;26062;26064;26066;26068;26070;26072;26304;26306;26308;26310;26312;26314;26318;26320;26322;31105;31107;31109;31111;31113;31115;31117;31119;31121;31123;31125;31127;31129;31131;31133;31135;31137;31139;31141;31143;31145;31147;31149;31151;31153;31155;31157;31159;31161;31163;31165;31167;31169;31171;31173;31175;31177;31179;31181;31183;31185;31187;31189;31191;31193;31195;31197;31199 |]
        | 1234 -> [| 26100;26102;26358;26364;31274;31276;31278;31280;31282;31284;31322;31324;31326;31328;31330;31332 |]
        | 269 -> [| 26252;26253;26254;26255;26256;26257;26258;26259;26260;26261 |]
        | 828 -> [| 26959 |]
        | 750 -> [| 27152;27153;27154;27155;27156;27157;27158;27159;27160;27161;27162;27163;27164;27165;27166;27269;27270;27271;27272;27273 |]
        | 743 -> [| 27167;27170;27171 |]
        | 748 -> [| 27176;27177;27178;27179;27180;27181;27182;27184;27185;27264;27265;27267;27268 |]
        | 1230 -> [| 27186;27187;27188;27190;27191;27192;27193;27194;27195;27196;27197;27198;27260;47028 |]
        | 829 -> [| 27295;27296;27297;27298 |]
        | 1162 -> [| 27309;32858;32859;32860;32861;32862;32863;32864;32865;32866;32867;32868;32869;32870;32871;33004;33006;33008;33010;33012 |]
        | 835 -> [| 27656;27658;27660 |]
        | 836 -> [| 27662;27664;27666;27937;27939;27941;27957;27959;27961;27963;27965;27967;27969;27971;27973;27975;27977;27979;27981;27983;27985;27987;27989;27991;27993;27995;27997;27999;28001;28003;28005;28007;28009;28011;28013;28015;28017;28019;28021;28023;28025;28027;28029;28031;28033;28035;28037;28039;28041;28043;28045;28047;28049;28051;28053;28055;28057;28059;28061;28063 |]
        | 837 -> [| 27672;27855;27856;27857;27858 |]
        | 838 -> [| 27673 |]
        | 839 -> [| 27674 |]
        | 709 -> [| 27675 |]
        | 840 -> [| 27676 |]
        | 842 -> [| 27678;40635;40636;40696;40697;40698;40699;40700;41350 |]
        | 1703 -> [| 27679;41388;41389;41390;41391;41392;41393;41394 |]
        | 865 -> [| 27717 |]
        | 866 -> [| 27719 |]
        | 867 -> [| 27720 |]
        | 868 -> [| 27721 |]
        | 844 -> [| 27722;27723;27724;27725;27726;27727;27728;27729;27730;27731 |]
        | 843 -> [| 27732;27733;27734;27735;27736;27737 |]
        | 845 -> [| 27738;27739;27740;27741;27742;27743;27744;27745;27746;27747 |]
        | 846 -> [| 27748;27749;27750;27751;27752;27753 |]
        | 847 -> [| 27754;27755;27756;27757;27758;27759;27760;27761;27762;27763 |]
        | 859 -> [| 27873;27874 |]
        | 861 -> [| 27898;27899;27900;27901;29025;30995;36846;36847 |]
        | 90 -> [| 27912;27916;27918;27920;41548;41549;41550;41551 |]
        | 172 -> [| 27913;27917;27919;27921;27923;27925 |]
        | 863 -> [| 27922 |]
        | 864 -> [| 27924;34264 |]
        | 872 -> [| 28076;28077;28078;28079;28080;28081;28082;28083;28084;28085;28086;28087;28088;28089;28090;28091;28092;28093;28094;28095;28096;28097;28098;28099;28100;28101;28102;28103;28104;28105;28106;28107;28108;28109;28110;28111;28112;28113;28114;28115;28116;28117;28118;28119;28120;28121;28122;28123;28124;28125;28126;28127;28128;28129;28130;28131;28132;28133;28134;28135 |]
        | 874 -> [| 28155;28156;28157;28158;28159;28166 |]
        | 876 -> [| 28183;28184;28185 |]
        | 877 -> [| 28191 |]
        | 881 -> [| 28320 |]
        | 883 -> [| 28352;33687 |]
        | 944 -> [| 28353;33688 |]
        | 885 -> [| 28356 |]
        | 888 -> [| 28368;28386;28448;28449;28450;28451;28452;28453;28454;28455;28456;28457;28458;28459;28460;28461;28462;28463;28464;28465;28466;28467;28468;28469;28470;28471;28472;28473;28474;28475;28476;28477;28478;28479;28480;28481;28482;28483;28484;28485;28486;28487;28488;28489;28490;28491;28492;28493 |]
        | 890 -> [| 28494;28495;28496;28497;28498;28499;28500;28501;28502;28503;28504;28505 |]
        | 941 -> [| 28606;33685;42244 |]
        | 945 -> [| 28607;33686;43910 |]
        | 892 -> [| 28612 |]
        | 897 -> [| 28650 |]
        | 900 -> [| 28659;28661;28665;28710;34219;34221;34223;34231;34233;34235;34241;34243;34245;34253;34255;34257;47727;47728 |]
        | 916 -> [| 28668 |]
        | 1194 -> [| 28840;33015;33016;33017;33018;33019;33020;33021;33022;33023;33024;33025;33026;33027;33028;33029;33030;33058;33059;33060;33061;33065;33066;33213;33214;33215;33217;33218;33219;33220;33221;33575;33809;34417;34418;34419;34420;34421;34422;34423;34424;34425;34426;34427;34428;34429;34430;34431;34432;34433;34434;34435;34436;34769;34770;34771;34772;34773;34774;34775;34776;34777;34778;37874;37875;37877;37878;37879;37880;37881;37882;37883;37884;37885;37886;37887;37888;37889;37892;37893;37894;37895;37896;40656;41035;41496;42229;42230;42231;43640;43677;43678;43679;43930;43931;43932;43933;44128;44187;44188;44189;44190;44191;44192;44193;44194;44195;44197;44198;44199;44205;44206;44207;44208;44209;44210;44211;44212;44213;44214;44215;44216;45060;45061;45062;45996;46050;46151;46260;46266;46267;46268;46269;46756;46766;46825;47042;47043;47044;47045;47046;47047;47048;47053;47054;47055;47056;47057;47058;47059;47060;47062;47063;47064;47154;47253;47482;47961;47962;47963;48135;48136;48137;48138;48139;48140;48141;48142;48143;48144;48374;48375;48376;48377;48378;48379;48531;48532;48533;48534;48535;48536;48584;48585;48586;48587;48588;48589;48590;48591;48592;48593;48642;48643;48644;48645;48748;48749;48750;48751;48752;48753;48754;48755;48756;48757;48758;48759;48760;48928;48950;48951;48952;48953;48954;49419;49531;49532;49533;49619;49620;49621;49634;49641;49644;49645;49646;49647;49648;49649;49650;49651;49652;49653;49705;49706;49707;49708;49709;49718;49719;49746;49748 |]
        | 902 -> [| 28844;28846;28848;28850 |]
        | 904 -> [| 28888;28890;28892;28894 |]
        | 907 -> [| 28999;29001 |]
        | 908 -> [| 29003;45010 |]
        | 909 -> [| 29005;29007 |]
        | 910 -> [| 29009;29011;41155 |]
        | 911 -> [| 29013;29015 |]
        | 913 -> [| 29039;29041;29043;29045;29047;29049;29051;29053;29055;29057;29059;29061;29063;29065;29067;29069;29071;29073;29075;29077;29079;29081;29083;29085;29087;29089;29091;29093;29095;29097;29099;29101;29103;29105;29107;29109 |]
        | 903 -> [| 29113;29115;29117;29119;29121;29123;29125;29127;29129;29131;29133;29135 |]
        | 178 -> [| 29204 |]
        | 922 -> [| 29207;29310;29311;29312;29313;29314;29315;29316;29317;29318;29414;29415;29416;29418;29419;29420;29421;29422;29423 |]
        | 1007 -> [| 29234;29239;29242;29245;32786 |]
        | 924 -> [| 29236;29237;29240;29243;32784 |]
        | 925 -> [| 29286;29302;29303;29304 |]
        | 955 -> [| 29964;29965;29966;29967;29969;29970;29971;29972;29974;29975;29976;29977;29979;29980;29981;29982;30036;30038;30040;30042;30046;30048;30050;30052;30056;30058;30060;30062;30066;30068;30070;30072;30076;30078;30080;30082;30086;30088;30090;30092;30096;30098;30100;30102;30106;30108;30110;30112;30117;30118;30119;30120;30122;30123;30124;30125;30127;30128;30129;30130;30132;30133;30134;30135;30139;30141;30143;30145;30149;30151;30153;30155;30159;30161;30163;30165;30169;30171;30173;30175 |]
        | 963 -> [| 29984;29986;29988;29990 |]
        | 996 -> [| 29985;29987;29989;29991 |]
        | 964 -> [| 29992;29994;29996;30002;30008;30464;30466;30470;30474;30476;30478;34396;45652;45653;45654;45655 |]
        | 965 -> [| 29993;29995;29997;30003;30009;30465;30467;30471;30475;30477;30479;34397;45656;45657;45658;45659 |]
        | 967 -> [| 29998;30000;30016;30017;30020;30023;30025;30027;30247;30249;30250;30253;30255;30256;30257;30260;30261;30262;30263;30264;30265;30266;30267;30272;30312;30313;30314;30315;30316;30317;30318;30319;30320;30321;30322 |]
        | 479 -> [| 30013;30028;30486;30488;32246 |]
        | 966 -> [| 30018;30019;30021;30022;30024;30248;30251;30252;30254;30258;30259;30268;30269;30270;30271;45660;45661;45662;45663 |]
        | 1891 -> [| 30037;30039;30041;30043;30047;30049;30051;30053;30057;30059;30061;30063;30067;30069;30071;30073;30077;30079;30081;30083;30087;30089;30091;30093;30097;30099;30101;30103;30107;30109;30111;30113;30140;30142;30144;30146;30150;30152;30154;30156;30160;30162;30164;30166;30170;30172;30174;30176;30227;30228;30229;30230;30232;30233;30234;30235;30237;30238;30239;30240;30242;30243;30244;30245;30392;30393;30394;30395;30397;30398;30399;30400;30402;30403;30404;30405;30407;30408;30409;30410 |]
        | 971 -> [| 30187;30558;30562 |]
        | 983 -> [| 30188;30189;30190;30191 |]
        | 982 -> [| 30192;30193;30194;30195 |]
        | 959 -> [| 30196;30197;30198;30199 |]
        | 985 -> [| 30200;30201;30202 |]
        | 984 -> [| 30203;30204;30205 |]
        | 960 -> [| 30206;30207;30208 |]
        | 987 -> [| 30209;30210;30211 |]
        | 986 -> [| 30212;30213;30214 |]
        | 961 -> [| 30215;30216;30217;41338 |]
        | 974 -> [| 30303;30304;30305;30306;30307;30308;30309;30310;30311 |]
        | 977 -> [| 30344;30345;30346;30348;30349;30350;30351;30352;30368 |]
        | 882 -> [| 30347;30353;30354;30355;30356;30357;30358 |]
        | 979 -> [| 30382;30383;30384;30385 |]
        | 1240 -> [| 30532;30536;30537;30538;30539;30540;30541;30542;30543;30544;30545;30546;30547;30548;30549;30550;30551;30552;30553;30554 |]
        | 988 -> [| 30579;30583;30584;30642;30643;30644;30645;30646;30647;30648;30649;30657;30658;30659;30660;30661;30662;30663;30664;30665;30666;30667;30668;30671;30672;30673;30674;30675;30676;30677;30678;30679;30680;30681;30682;30683;30684;30685;30686;30687;30688;30689;30690;30691;30692;30693;30694;30695;30696;30697;30698;30699;30700;30701;30702;30703;30704;30705;30706;30707;30708;30709;30710;30711;30712;30713;30714;30715;30831;32894;32895;34134;34135;34136;34137;34138;34139;34140;34338;34366;34367;34368;34369;34370;34371;34372;34439;35650;35651;35652;35653;35654 |]
        | 992 -> [| 30582;30586;30588 |]
        | 990 -> [| 30599;30600;30605 |]
        | 993 -> [| 30614;30615;30618 |]
        | 991 -> [| 30628;30632;30633 |]
        | 880 -> [| 30744;30745;30746;30747 |]
        | 997 -> [| 30752;30753;30754;34412;34414;34416 |]
        | 1003 -> [| 32226;32300 |]
        | 1005 -> [| 32250;32302 |]
        | 1012 -> [| 32313;32458;48463 |]
        | 935 -> [| 32571;32574;32575;32576;32577;32578;32579;32580;32581;32643;32746;32748;32751;32752 |]
        | 1105 -> [| 32614;32642;32646;32658;32669;32670;32673;32674;32675;32678;32680;32681;32683;32685;32686;32687;32688;32689;32690;32691;32692;32693;32694;32695;32696;32701;32702;32703;32704;32705;32706;32707;32708;32709;32710;32719;32720;32721;32722;32723;32724;47430;47431;47432;47433;47434;47435;47760 |]
        | 1107 -> [| 32615;32623;32624;32628;32636;32637;32638;32644;32666;32667;32679;32725;32727;32728;32729;32730;32734;32735;32736;32737 |]
        | 1108 -> [| 32618;32738 |]
        | 1111 -> [| 32633 |]
        | 1110 -> [| 32634 |]
        | 1112 -> [| 32635 |]
        | 1079 -> [| 32652;32653 |]
        | 1121 -> [| 32682 |]
        | 1126 -> [| 32731 |]
        | 88 -> [| 32782 |]
        | 1159 -> [| 32787;44274 |]
        | 1160 -> [| 32839;32854;32855 |]
        | 1165 -> [| 32884 |]
        | 760 -> [| 32901;32902;32903;32904;32905;32906;32907;32908;32909;32910;32911;32912 |]
        | 1166 -> [| 32913 |]
        | 1167 -> [| 32914 |]
        | 1168 -> [| 32915 |]
        | 1169 -> [| 32916 |]
        | 1174 -> [| 32959;32960;32961;32962 |]
        | 1175 -> [| 32963 |]
        | 1176 -> [| 32964 |]
        | 1177 -> [| 32965 |]
        | 1178 -> [| 32966 |]
        | 1179 -> [| 32967 |]
        | 1180 -> [| 32968 |]
        | 1181 -> [| 32969 |]
        | 1182 -> [| 32970 |]
        | 1183 -> [| 32971 |]
        | 1184 -> [| 32972 |]
        | 1185 -> [| 32973 |]
        | 1186 -> [| 32974 |]
        | 1190 -> [| 32982 |]
        | 1195 -> [| 33031;33032;33033;33034;33035;33036;33037;33038;33039;33040;33041;33042;33043;33044;33045;33046;33047;33048;33049;33050;33051;33052;33053;33054;33055;33056;33057 |]
        | 1197 -> [| 33067 |]
        | 1198 -> [| 33069 |]
        | 1199 -> [| 33076;33101;33103;41503;47842;47844;47846 |]
        | 1200 -> [| 33077;33102;33104;41620 |]
        | 1206 -> [| 33138;33139;33140;33141 |]
        | 1212 -> [| 33149 |]
        | 1238 -> [| 33176;33197 |]
        | 1239 -> [| 33177;33198 |]
        | 1223 -> [| 33178;33180;33199;33201 |]
        | 1224 -> [| 33179;33181;33200;33202 |]
        | 1225 -> [| 33223;33224;33225;33226;33227;33228;33229;33230;33231;33232;33373;33374;33385;33386;33387;33388;33389;33390;33391;33392 |]
        | 1226 -> [| 33270;33272 |]
        | 1227 -> [| 33271;33273 |]
        | 1084 -> [| 33377;33378;33379;33380;33381;33382;33383;33384;33995;33996;33997;33998;33999;34000;34001;34002;34003;34004;34005;34006;34007;34008;34009;34010;34011;34012;34013;34014;34015;34016 |]
        | 1245 -> [| 33440;33441;33442;33446;33448;33450;33452;33453;33454;33455;33456;33457;33458;33459;33461;33462;33463;33464;33465;33466 |]
        | 1246 -> [| 33474;33520;33522 |]
        | 1250 -> [| 33475;33700;33702 |]
        | 1249 -> [| 33476 |]
        | 1247 -> [| 33477;33478;33479;33581;33583 |]
        | 1248 -> [| 33482;33483;33484;33485;33597;33598;33599;33600;33601;33602;33603;33604;33605;33606;33607;33612 |]
        | 1252 -> [| 33491;33492;33493;33494 |]
        | 1255 -> [| 33495;33496;33497;33498 |]
        | 1259 -> [| 33499;33500;33501;33502 |]
        | 1265 -> [| 33503;33504;33505;33506 |]
        | 1262 -> [| 33507;33508;33509;33510 |]
        | 1267 -> [| 33515;33582;33584 |]
        | 1269 -> [| 33517;33521;33523 |]
        | 1268 -> [| 33518;34121 |]
        | 1270 -> [| 33519;33701;33703 |]
        | 1271 -> [| 33549;33550;33551;33552;34017;34018;34019;34020;34021;34022;34023;34024;34025;34026;34027;34028;34029;34030;34031;34032;34033;34034;34035;34036;34037;34038;34039;34040;34041;34042;34043;34044 |]
        | 1273 -> [| 33585;33595;33608;33610 |]
        | 1277 -> [| 33586;33596;33609;33611 |]
        | 1274 -> [| 33587 |]
        | 1295 -> [| 33588 |]
        | 1275 -> [| 33589;36523 |]
        | 1293 -> [| 33590 |]
        | 1276 -> [| 33591;33990 |]
        | 1294 -> [| 33592 |]
        | 1283 -> [| 33697;37135 |]
        | 1292 -> [| 33822;33824;33828;33830;33832;33834;33836;33838;33840;41033 |]
        | 1285 -> [| 33864 |]
        | 1286 -> [| 33865 |]
        | 1287 -> [| 33866 |]
        | 1288 -> [| 33886;33887;33888 |]
        | 1289 -> [| 33981;33983;33985 |]
        | 1297 -> [| 34120 |]
        | 1299 -> [| 34122;34124;34126 |]
        | 1301 -> [| 34132;34133;40519 |]
        | 1304 -> [| 34201;34202;34203;34204;34205;34206;34207;34208 |]
        | 1308 -> [| 34266;34268;34306;34308 |]
        | 1305 -> [| 34317;34562;34828;35683 |]
        | 1309 -> [| 34318;34563;34829;35684 |]
        | 1306 -> [| 34319;34321;34323;34564;34566;34570;35676;35677;35678;35686;35687;35688 |]
        | 1307 -> [| 34337 |]
        | 1310 -> [| 34495;34561 |]
        | 1314 -> [| 34540;34541;34542;34543;34544;34545;34546;34547;34548;34549;34551;34552;34553;34554;34555;34556;34557;34558;34559;34560;34575;36902;40541;42640 |]
        | 1313 -> [| 34593;34595;34826;40307;40308;40309;40310 |]
        | 1318 -> [| 34594;34596;40311;40312;40313;40314 |]
        | 1950 -> [| 34599;34600;34601;34602;34603;34604;34605;34606;34607;34608;34609;34610;34611;34612;34613;34614;34615;34616;34617;34618;34619;34620;34621;34623;34624;34625;34626;34627;34628;34629;34630;34631;34632;34633;34634;34635;34636;34637;34638;34639;34640;34641;34642;34643;34645;34646;34647;34648;34649;34650;34651;34652;34653;34654;34655;34656;34657;34658;34659;34660;34661;34662;34663;34664;34665;34666;34667;34668;34669;34670;34671;34672;34673;34674;34675;34676;34677;34678;34679;34680;34681;34682;34683;34684;34685;34686;34687;34688;34689;34690;34691;34692;34693;34694;34695;34696;34697;34698;34699;34700;34701;34702;34703;34704;34705;34706;34707;34708;34709;34710;34711;34712;34713;34714;34715;34716;34718;34719;34720;34721;34722;34723;34724;34725;34726;34727;34728;34729;34730;34731;34732;34733;34734;34735;34736;34737;34738;34739;34740;34741;34742;34743;34744;34745;34746;34747;34748;34749;34750;34751;34752;34753;34754;34755;34756;34757;34758;34759;34760;34786;34787;34788;34789;34790;34791;34792;34795;34796;34797;34798;34799;34800;34801;34802;34805;34808;34809;34810;34811;34812;34813;34814;34815;34816;34817;34818;34819;34820;34821;34822;34823;35690;35695;35700;35705;36274;36275;36276;36277;36278;36279;36280;36281;36282;36283;36284;36285;36286;36287;36288;36289;36290;36291;36292;36293;36294;36295;36296;36297;36298;36299;36300;36301;36302;36303;36304;36305;36306;36307;36308;36309;36310;36311;36312;36313;36314;36315;36316;36317;36318;36319;36320;36321;36322;36323;36324;36325;36326;36327;36328;36329;36330;36331;36332;36333;36334;36335;36336;36337;36338;36339;36340;36341;36342;36343;36344;36345;36346;36347;36348;36349;36350;36351;36352;36353;36354;36355;36356;36357;36358;36359;36360;36361;36362;36363;36364;36365;36366;36367;36368;36369;36370;36371;36372;36373;36374;36375;36376;36377;36378;36379;36380;36381;36382;36383;36384;36385;36386;36387;36388;36389;36390;36391;36392;36393;36394;36395;36396;36397;36398;36399;36400;36401;36402;36403;36404;36405;36406;36407;36408;36409;36410;36411;36412;36413;36414;36415;36416;36417;36418;36419;36420;36421;36422;36423;36424;36425;36426;36427;36428;36429;36430;36431;36432;36433;36434;36435;36436;36437;36438;36439;36440;36441;36442;36443;36444;36445;36446;36447;36448;36449;36450;36451;36452;36453;36454;36455;36456;36457;36458;36517;36518;36519;36520;36522;36633;36634;36635;36636;36637;36638;36639;36640;36641;36642;36643;36644;36645;36646;36647;36648;36649;36650;36651;36652;36653;36654;36655;36656;36657;36658;36659;36660;36661;36662;36663;36664;36665;36666;36667;36668;36669;36670;36671;36672;36673;36674;36675;36676;36677;36678;36705;36706;36707;36708;36709;36710;36711;36712;36713;36714;36715;36716;36717;36718;36719;36720;36721;36722;36723;36724;36725;36726;36727;36728;36729;36730;36731;36732;36733;36734;36735;36736;36737;36738;36739;36740;36741;36742;36743;36744;36745;36746;36747;36748;36749;36750;36751;36752;36753;36754;36755;36756;36757;36758;36759;36760;36761;36762;36763;36764;36765;36766;36767;36768;36769;36770;36771;36772;36773;36774;36775;36776;36777;36778;36779;36780;36781;36782;36783;36784;36785;36786;36787;36788;36789;36790;36791;36792;36793;36794;36795;36796;36797;36798;36799;36800;36801;36802;36803;36804;36805;36806;36807;36808;36809;36810;36811;36812;36813;36814;36815;36816;36817;36818;36819;36820;36821;36822;36823;36824;36825;36826;36827;36828;36829;36830;36831;36832;36833;36834;36835;36836;36837;36838;36839;36840;36841;36842;36843;36844;36854;36913;36914;36915;36916;36951;36982;36983;36984;36985;36986;36987;36988;36989;36990;36991;36992;36993;36994;37055;37056;37057;37089;37090;37091;37092;37093;37094;37095;37096;37097;37098;37099;37100;37101;37102;37103;37104;37105;37106;37107;37108;37109;37110;37111;37112;37113;37114;37115;37116;37117;37118;37119;37120;37121;37122;37123;37124;37125;37126;37127;37128;37129;37130;37131;37132;37133;37134;37484;37485;37486;37487;37488;37489;37490;37491;37492;37493;37494;37495;37496;37497;37498;37499;37500;37501;37502;37503;37504;37505;37506;37507;37508;37509;37510;37511;37512;37513;37514;37515;37516;37517;37518;37519;37520;37521;37522;37523;37524;37525;37526;37527;37528;37529;37547;37548;37549;37550;37551;37552;37553;37554;37555;37556;37557;37558;37559;37560;37561;37562;37563;37564;37565;37566;37567;37568;37569;37570;37571;37572;37573;37574;37575;37576;37577;37578;37579;37580;37581;37582;37583;37584;37585;37586;37587;37588;37589;37590;37591;37592;37593;37594;37595;37632;37637;37642;37647;37652;37657;37662;37667;37672;37677;37682;37687;37692;37697;37702;37707;37712;37717;37722;37727;37732;37737;37742;37747;37752;37757;37762;37767;37772;37777;37782;37787;37867;37868;37869;37897;37898;37899;37900;37901;37902;37903;37904;37905;37907;37908;37909;37910;37911;37912;37913;37914;37915;37916;37917;37921;37922;37923;37928;37933;37938;37939;37940;37941;37942;37943;37944;37945;37947;37948;37949;37950;37951;37952;37953;37954;37955;37956;37957;37958;37959;37960;37961;37962;37965;37966;37967;37968;37969;37970;37971;37972;37973;37974;37979;37984;37989;37994;37999;38004;38009;38014;38019;38024;38029;38034;38039;38044;38049;38054;38059;38064;38069;38074;38079;38084;38089;38094;38099;38104;38109;38114;38119;38124;38129;38134;38139;38140;38146;38147;38148;38149;38150;38155;38160;38165;38170;38175;38180;38185;38190;38195;38200;38205;38210;38211;38212;38213;38214;38215;38216;38217;38218;38219;38220;38221;38222;38227;38232;38237;38242;38247;38252;38257;38262;38267;38272;38277;38282;38287;38292;38297;38302;38307;38312;38317;38322;38327;38332;38337;38342;38347;38352;38357;38362;38367;38372;38377;38382;38387;38392;38393;38394;38395;38396;38397;38398;38399;38400;38402;38403;38404;38409;38414;38419;38424;38429;38434;38439;38444;38449;38454;38459;38464;38469;38474;38479;38484;38489;38494;38499;38504;38509;38514;38519;38524;38529;38534;38539;38544;38549;38554;38559;38564;38569;38574;38579;38584;38589;38594;38599;38604;38609;38614;38619;38620;38621;38622;38623;38624;38625;38626;38627;38628;38629;38630;38632;38637;38642;38647;38652;38653;38654;38655;38656;38664;38669;38674;38679;38684;38689;38694;38699;38704;38709;38714;38719;38724;38729;38734;38739;38744;38749;38754;38759;38764;38769;38774;38779;38784;38789;38794;38799;38804;38809;38814;38819;38824;38829;38834;38839;38844;38849;38854;38859;38864;38869;38874;38879;38884;38889;38894;38899;38904;38909;38914;38919;38924;38929;38934;38939;38944;38949;38954;38959;38964;38969;38974;38979;38984;38989;38994;38999;39004;39009;39014;39019;39024;39029;39034;39039;39044;39049;39054;39059;39064;39069;39074;39079;39084;39089;39094;39099;39104;39109;39114;39119;39124;39129;39134;39139;39144;39149;39154;39159;39164;39169;39174;39179;39184;39189;39194;39199;39204;39209;39214;39219;39224;39229;39234;39239;39244;39249;39254;39259;39264;39269;39274;39279;39284;39289;39294;39299;39304;39309;39314;39319;39324;39329;39334;39339;39344;39349;39354;39359;39364;39369;39374;39379;39384;39389;39394;39399;39404;39409;39414;39419;39424;39429;39434;39439;39444;39449;39454;39459;39464;39469;39474;39479;39484;39489;39494;39499;39504;39509;39514;39519;39524;39529;39534;39539;39544;39549;39554;39559;39564;39569;39574;39584;39585;39586;39591;39596;39601;39606;39611;39616;39621;39626;39631;39636;39641;39646;39651;39656;39661;39666;39671;39676;39681;39686;39691;39696;39701;39706;39711;39716;39721;39726;39731;39736;39741;39746;39751;39756;39761;39766;39771;39776;39781;39786;39791;39796;39801;39806;39811;39816;39821;39826;39831;39836;39841;39846;39851;39856;39861;39866;39871;39876;39881;39886;39891;39896;39901;39906;39911;39916;39921;39926;39931;39936;39941;39946;39951;39956;39961;39966;39971;39976;39981;39986;39991;39996;40001;40006;40011;40016;40021;40026;40031;40036;40041;40046;40051;40056;40061;40066;40071;40076;40081;40086;40091;40096;40101;40106;40111;40116;40121;40126;40131;40136;40141;40146;40151;40156;40161;40166;40171;40176;40181;40186;40191;40196;40201;40206;40211;40216;40221;40226;40231;40236;40241;40246;40251;40256;40261;40266;40271;40276;40281;40286;40291;40296;40319;40320;40321;40322;40323;40324;40325;40326;40329;40330;40331;40332;40333;40366;40371;40376;40381;40386;40391;40396;40401;40406;40411;40416;40421;40426;40431;40436;40441;40446;40451;40467;40468;40469;40470;40471;40472;40473;40474;40475;40476;40477;40478;40479;40480;40481;40482;40484;40485;40486;40487;40488;40489;40490;40491;40492;40493;40495;40496;40497;40498;40499;40500;40501;40502;40503;40504;40505;40506;40507;40508;40509;40510;40511;40512;40513;40514;40515;40516;40517;40579;40580;40581;40582;40583;40584;40585;40586;40587;40588;40589;40590;40591;40592;40593;40594;40595;40596;40597;40598;40599;40600;40601;40602;40603;40604;40605;40606;40607;40608;40609;40610;40611;40612;40613;40614;40615;40616;40617;40618;40619;40620;40621;40622;40623;40624;40625;40626;40695;40770;40771;40772;40773;40774;40778;40783;40788;40793;40798;40803;40808;40813;40818;40823;40828;40833;40838;40843;40848;40853;40858;40863;40868;40873;40878;40883;40888;40893;40898;40903;40908;40913;40918;40923;40928;40933;40938;40943;40948;40953;40958;40963;40968;40973;40978;40983;40988;40993;40998;41003;41008;41013;41018;41419;41420;41421;41579;41580;41586;41587;41588;41680;41681;41682;41683;41684;41685;41686;41687;41770;41775;41780;41785;41790;41795;41800;41805;41810;41815;41820;41825;41830;41835;41840;41845;41850;41855;41860;41865;41870;41875;41880;41885;41890;41895;41900;41905;41910;41915;41920;41925;41930;41935;41940;41945;41950;41955;41960;41965;41970;41975;41980;41985;41990;41995;42000;42005;42010;42015;42020;42025;42030;42035;42040;42045;42050;42055;42060;42065;42070;42075;42080;42085;42090;42095;42100;42105;42110;42147;42148;42149;42150;42151;42152;42153;42154;42155;42156;42157;42158;42159;42160;42161;42162;42163;42164;42165;42166;42167;42168;42169;42170;42171;42172;42173;42174;42175;42176;42177;42178;42179;42180;42181;42182;42183;42184;42185;42186;42187;42188;42189;42190;42191;42192;42193;42194;42195;42196;42197;42198;42199;42216;42221;42247;42252;42257;42262;42267;42272;42277;42282;42287;42292;42297;42302;42307;42312;42317;42322;42327;42332;42337;42342;42347;42352;42357;42362;42367;42372;42377;42382;42387;42392;42397;42402;42407;42412;42417;42422;42427;42432;42437;42442;42447;42452;42457;42462;42467;42472;42477;42482;42487;42492;42497;42502;42507;42542;42543;42544;42545;42546;42547;42548;42549;42550;42551;42552;42553;42554;42555;42556;42557;42558;42559;42560;42561;42562;42563;42564;42565;42566;42567;42568;42569;42570;42571;42572;42573;42574;42575;42576;42577;42578;42579;42580;42581;42582;42583;42584;42585;42586;42587;42588;42589;42590;42591;42592;42593;42594;42595;42596;42597;42598;42599;42600;42614;42615;42616;42617;42618;42619;42620;42621;42622;42623;42624;42625;42641;42642;42643;42644;42645;42646;42647;42648;42649;42650;42651;42652;42653;42671;42672;42673;42674;42675;42676;42677;42678;42679;42680;42681;42682;42746;42747;42748;42749;42750;42751;42752;42753;42754;42755;42756;42757;42758;42759;42760;42761;42762;42763;42764;42765;42766;42767;42768;42769;42770;42771;42772;42773;42774;42775;42776;42777;42778;42779;42780;42781;42782;42783;42784;42785;42786;42787;42788;42789;42790;42791;42792;42793;42794;42795;42796;42797;42798;42799;42800;42907;42908;42909;42910;42915;42920;42925;42930;42935;42940;42945;42950;42955;42960;42965;42970;42975;42980;42985;42990;42995;43000;43005;43010;43015;43020;43025;43030;43035;43040;43045;43050;43055;43060;43065;43070;43075;43080;43085;43090;43095;43100;43105;43110;43115;43120;43125;43130;43135;43140;43145;43150;43155;43160;43165;43170;43175;43180;43185;43190;43195;43200;43205;43210;43215;43220;43225;43230;43235;43240;43245;43250;43255;43260;43265;43270;43275;43280;43285;43290;43295;43300;43305;43310;43315;43320;43325;43330;43335;43340;43345;43350;43355;43360;43365;43370;43375;43380;43385;43390;43395;43400;43405;43410;43482;43483;43484;43485;43486;43487;43488;43489;43490;43491;43492;43493;43494;43495;43496;43497;43498;43499;43500;43501;43502;43503;43504;43505;43506;43507;43508;43509;43510;43511;43512;43513;43514;43515;43516;43517;43518;43519;43520;43521;43522;43523;43524;43525;43526;43527;43528;43529;43530;43531;43532;43533;43534;43535;43536;43537;43538;43539;43666;43667;43668;43669;43670;43671;43672;43673;43674;43675;43676;43749;43750;43751;43752;43753;43754;43755;43756;43757;43758;43759;43760;43761;43762;43763;43764;43765;43766;43767;43768;43769;43770;43771;43772;43773;43774;43776;43777;43778;43779;43780;43781;43782;43783;43784;43785;43786;43787;43788;43789;43790;43791;43792;43793;43794;43795;43796;43797;43798;43799;43800;43801;43802;43803;43804;43805;43806;43807;43808;43809;43810;43811;43812;43813;43814;43815;43816;43817;43818;43819;43820;43821;43822;43823;43824;43825;43826;43827;43828;43829;43830;43831;43832;43833;43834;43835;43836;43837;43838;43839;43840;43841;43842;43843;43844;43845;43846;43847;43848;43849;43850;43851;43852;43853;43935;44068;44069;44070;44071;44072;44101;44127;44134;44135;44136;44137;44138;44139;44140;44141;44142;44143;44144;44145;44146;44147;44148;44149;44150;44151;44152;44153;44154;44155;44156;44157;44158;44159;44160;44161;44162;44163;44164;44165;44166;44167;44168;44169;44170;44171;44172;44173;44174;44175;44176;44177;44178;44179;44180;44181;44182;44183;44184;44185;44186;44200;44201;44202;44203;44218;44219;44220;44229;44230;44231;44232;44233;44234;44235;44236;44237;44238;44239;44240;44241;44242;44254;44255;44256;44257;44258;44259;44280;44282;44287;44292;44297;44302;44307;44312;44317;44322;44327;44332;44337;44342;44347;44352;44357;44362;44367;44372;44377;44382;44387;44392;44397;44402;44407;44412;44417;44422;44427;44432;44437;44442;44447;44452;44457;44462;44467;44472;44477;44482;44487;44492;44497;44502;44507;44512;44517;44522;44527;44532;44537;44542;44547;44552;44557;44562;44567;44572;44577;44582;44587;44592;44597;44602;44607;44612;44617;44622;44627;44632;44637;44642;44647;44652;44657;44662;44667;44672;44677;44682;44687;44692;44697;44702;44707;44712;44717;44722;44727;44732;44737;44742;44747;44752;44757;44762;44767;44772;44777;44782;44787;44792;44797;44802;44807;44812;44817;44822;44827;44832;44837;44842;44847;44852;44857;44862;44867;44872;44877;44882;44887;44888;44889;44890;44891;44892;44893;44894;44895;44896;44897;44898;44899;44900;44901;44902;44903;44904;44905;44906;44907;44908;44909;44910;44911;44912;44913;44914;44915;44916;44917;44918;44919;44920;44921;44922;44923;44924;44925;44926;44927;44928;44929;44930;44931;44932;44933;44934;44935;44936;44937;44938;44939;44940;44941;44942;44943;44944;44945;44946;44947;44948;44949;44950;44951;45012;45013;45014;45015;45018;45019;45020;45021;45022;45023;45024;45025;45026;45027;45029;45475;45480;45481;45482;45483;45484;45485;45505;45507;45508;45509;45552;45553;45554;45555;45556;45557;45558;45559;45560;45561;45562;45563;45564;45565;45566;45567;45568;45569;45570;45571;45572;45573;45574;45575;45576;45577;45578;45579;45580;45581;45582;45664;45665;45666;45667;45668;45751;45752;45753;45754;45755;45756;45757;45758;45759;45760;45761;45762;45763;45764;45765;45766;45767;45768;45769;45770;45771;45772;45773;45774;45775;45776;45777;45778;45779;45780;45781;45782;45783;45784;45785;45786;45787;45788;45789;45790;45791;45792;45793;45794;45795;45796;45797;45798;45799;45800;45801;45802;45803;45804;45805;45806;45807;45808;45809;45810;45811;45812;45813;45814;45815;45816;45817;45818;45819;45820;45821;45822;45823;45824;45825;45826;45827;45828;45829;45830;45831;45832;45833;45834;45835;45836;45837;45838;45839;45840;45841;45842;45843;45844;45845;45846;45847;45848;45849;45850;45851;45852;45853;45854;45855;45856;45857;45858;45859;45860;45861;45862;45863;45864;45865;45866;45867;45868;45869;45870;45871;45872;45873;45874;45875;45876;45877;45878;45879;45880;45881;45882;45883;45884;45885;45886;45887;45888;45889;45890;45891;45892;45893;45894;45895;45896;45897;45898;45899;45900;45901;45902;45903;45904;45905;45906;45907;45908;45909;45910;45911;45912;45913;45914;45915;45916;45917;45918;45919;45920;45921;45922;45923;45924;45925;45926;45927;45928;45929;45930;45931;45932;45933;45934;45935;45936;45937;45938;45939;45940;45941;45942;45943;45944;45945;45946;45947;45948;45949;45950;45951;45952;45953;45954;45955;45956;45957;45958;45959;45960;45961;45962;45963;45964;45965;45966;45967;45968;45969;45970;45971;45972;45973;45974;45975;45976;45977;45978;45979;45980;45981;45982;45983;45984;45985;45986;45987;45988;45989;45990;45991;45992;45997;46014;46015;46016;46017;46018;46019;46020;46021;46022;46024;46025;46026;46040;46041;46042;46043;46044;46045;46051;46089;46090;46091;46092;46093;46094;46095;46096;46097;46098;46099;46100;46101;46102;46103;46104;46105;46106;46107;46108;46109;46110;46111;46112;46113;46114;46115;46116;46117;46118;46119;46120;46121;46122;46123;46124;46125;46126;46127;46128;46129;46130;46131;46132;46133;46134;46135;46136;46137;46138;46139;46140;46141;46142;46143;46144;46145;46146;46147;46148;46149;46276;46277;46376;46377;46378;46379;46380;46383;46384;46385;46386;46387;46388;46389;46390;46391;46392;46393;46394;46395;46396;46397;46398;46399;46400;46401;46402;46403;46404;46405;46406;46407;46408;46409;46410;46411;46412;46413;46414;46415;46416;46417;46418;46419;46420;46421;46422;46423;46424;46425;46426;46427;46428;46429;46430;46431;46432;46433;46434;46435;46436;46437;46438;46439;46440;46441;46442;46443;46520;46521;46522;46525;46526;46527;46528;46529;46530;46531;46532;46533;46534;46535;46536;46537;46538;46539;46540;46547;46548;46549;46550;46551;46552;46553;46554;46555;46556;46557;46558;46559;46560;46561;46562;46563;46564;46582;46584;46707;46708;46709;46710;46711;46712;46713;46714;46715;46716;46717;46718;46719;46720;46721;46722;46723;46724;46725;46726;46727;46728;46729;46730;46731;46732;46733;46734;46735;46736;46737;46738;46739;46740;46741;46742;46743;46744;46745;46746;46747;46748;46749;46750;46751;46752;46753;46754;46755;46773;46774;46775;46776;46777;46778;46779;46780;46781;46782;46783;46784;46785;46786;46787;46788;46789;46790;46791;46792;46793;46794;46795;46796;46797;46798;46799;46800;46801;46802;46803;46804;46805;46806;46807;46808;46809;46810;46811;46812;46813;46814;46815;46816;46817;46818;46819;46820;46821;46822;46823;46824;46827;46828;46829;46830;46831;46832;46833;46834;46835;46836;46837;46838;46839;46840;46841;46842;46843;46844;46845;46846;46847;46848;46849;46850;46851;46852;46853;46854;46855;46856;46857;46858;46859;46860;46861;46862;46863;46864;46865;46866;46867;46868;46869;46870;46871;46872;46873;46874;46875;46876;46877;46878;46879;46880;46881;46882;46883;46884;46885;46886;46887;46888;46889;46890;46891;46892;46893;46894;46895;46896;46897;46898;46899;46900;46901;46902;46903;46904;46905;46906;46907;46908;46909;46910;46911;46912;46913;46914;46915;46916;46917;46918;46919;46920;46921;46922;46923;46924;46925;46926;46927;46928;46929;46930;46931;46932;46933;46934;46935;46936;46937;46938;46939;46940;46941;46942;46943;46944;46945;46946;46947;46948;46949;46950;46951;46952;46953;46954;46955;46956;46957;46958;46959;46960;46961;46962;46963;46964;46965;46966;46967;46968;46969;46970;46971;46972;46973;46974;46975;46976;46977;46978;46979;46980;46981;46982;46983;46984;46985;46986;46987;46988;46989;46990;46991;46992;46993;46994;46995;46996;46997;46998;46999;47000;47001;47002;47003;47004;47005;47006;47007;47008;47009;47010;47011;47012;47013;47014;47015;47029;47030;47049;47050;47051;47052;47075;47085;47090;47095;47101;47102;47103;47104;47105;47106;47158;47159;47160;47161;47162;47163;47164;47165;47166;47167;47168;47169;47170;47171;47172;47173;47174;47175;47176;47177;47178;47179;47249;47250;47251;47282;47289;47290;47291;47292;47293;47294;47295;47304;47305;47306;47307;47308;47309;47310;47311;47312;47313;47314;47315;47316;47317;47318;47319;47320;47321;47371;47372;47375;47376;47377;47493;47494;47495;47496;47497;47498;47499;47500;47501;47502;47503;47504;47505;47506;47507;47508;47509;47510;47511;47522;47523;47524;47526;47527;47528;47529;47530;47531;47532;47533;47534;47535;47536;47537;47538;47539;47540;47541;47544;47545;47546;47547;47548;47549;47550;47551;47552;47610;47611;47612;47613;47614;47615;47616;47617;47618;47619;47621;47622;47623;47624;47625;47626;47627;47628;47629;47630;47631;47632;47633;47634;47635;47636;47637;47638;47639;47640;47641;47642;47643;47644;47645;47646;47647;47648;47649;47650;47651;47652;47653;47654;47655;47680;47681;47682;47683;47684;47698;48146;48147;48155;48156;48157;48158;48159;48160;48161;48162;48163;48164;48165;48166;48167;48168;48169;48170;48171;48172;48173;48174;48175;48176;48177;48178;48179;48180;48181;48182;48183;48184;48185;48186;48187;48188;48189;48190;48191;48192;48193;48194;48195;48196;48197;48198;48199;48200;48201;48202;48203;48204;48205;48206;48207;48208;48209;48210;48211;48212;48213;48214;48215;48216;48217;48218;48219;48220;48221;48222;48223;48224;48225;48226;48227;48228;48229;48230;48231;48232;48233;48242;48243;48244;48365;48366;48367;48368;48369;48481;48482;48483;48484;48485;48486;48487;48488;48489;48490;48491;48492;48493;48494;48495;48496;48497;48498;48499;48500;48501;48502;48503;48504;48505;48506;48507;48508;48509;48510;48511;48512;48513;48514;48515;48516;48517;48518;48519;48520;48521;48522;48523;48524;48525;48526;48527;48528;48529;48530;48543;48544;48546;48547;48548;48549;48550;48551;48552;48553;48554;48555;48556;48557;48558;48559;48560;48561;48562;48563;48564;48565;48566;48576;48577;48578;48579;48580;48581;48649;48650;48651;48653;48654;48655;48656;48719;48720;48721;48722;48723;48724;48725;48726;48727;48728;48729;48730;48731;48732;48733;48734;48735;48816;48817;48819;48830;48831;48833;48834;48836;48837;48838;48839;48843;48844;48845;48846;48847;48848;48849;48850;48851;48852;48853;48854;48855;48856;48857;48858;48859;48860;48861;48893;48894;48895;48896;49141;49146;49147;49148;49149;49150;49151;49152;49153;49154;49155;49156;49157;49158;49163;49168;49173;49178;49183;49188;49193;49198;49203;49208;49213;49218;49223;49228;49233;49238;49243;49248;49253;49258;49263;49268;49273;49278;49283;49288;49293;49298;49303;49308;49313;49318;49323;49328;49333;49338;49343;49348;49353;49358;49363;49368;49373;49378;49383;49388;49393;49398;49403;49408;49413;49420;49421;49422;49423;49424;49425;49426;49427;49428;49429;49430;49431;49432;49433;49434;49435;49436;49441;49446;49451;49456;49461;49466;49471;49476;49481;49486;49491;49496;49501;49506;49511;49516;49521;49526;49750;49751;49752 |]
        | 1952 -> [| 34779;34885;34889;34893;34897;34901;34905;34909;34913;34917;34921;34925;34929;34933;34937;34941;34945;34949;34953;34957;34961;34965;34969;34973;34977;34981;34985;34989;34993;34997;35001;35005;35009;35013;35017;35021;35025;35029;35033;35037;35041;35045;35049;35053;35057;35061;35065;35069;35073;35077;35081;35085;35089;35093;35097;35101;35105;35109;35113;35117;35121;35125;35129;35133;35137;35141;35145;35149;35153;35157;35161;35165;35169;35173;35177;35181;35185;35189;35193;35197;35201;35205;35209;35213;35217;35221;35225;35229;35233;35237;35241;35245;35249;35253;35257;35261;35265;35269;35273;35277;35281;35285;35289;35293;35297;35301;35305;35309;35313;35317;35321;35325;35329;35333;35337;35341;35345;35349;35353;35357;35361;35365;35369;35373;35377;35381;35385;35389;35393;35397;35401;35405;35409;35413;35417;35421;35425;35429;35433;35437;35441;35445;35449;35453;35457;35461;35465;35469;35473;35477;35481;35485;35489;35493;35497;35501;35505;35509;35513;35517;35521;35525;35529;35533;35537;35541;35545;35549;35553;35557;35561;35565;35569;35573;35577;35581;35585;35589;35593;35597;35601;35605;35609;35613;35617;35621;35625;35629;35633;35637;35641;35691;35696;35701;35706;36869;36870;36871;36872;36886;36890;36894;36898;37633;37638;37643;37648;37653;37658;37663;37668;37673;37678;37683;37688;37693;37698;37703;37708;37713;37718;37723;37728;37733;37738;37743;37748;37753;37758;37763;37768;37773;37778;37783;37788;37924;37929;37934;37975;37980;37985;37990;37995;38000;38005;38010;38015;38020;38025;38030;38035;38040;38045;38050;38055;38060;38065;38070;38075;38080;38085;38090;38095;38100;38105;38110;38115;38120;38125;38130;38135;38151;38156;38161;38166;38171;38176;38181;38186;38191;38196;38201;38206;38223;38228;38233;38238;38243;38248;38253;38258;38263;38268;38273;38278;38283;38288;38293;38298;38303;38308;38313;38318;38323;38328;38333;38338;38343;38348;38353;38358;38363;38368;38373;38378;38383;38388;38405;38410;38415;38420;38425;38430;38435;38440;38445;38450;38455;38460;38465;38470;38475;38480;38485;38490;38495;38500;38505;38510;38515;38520;38525;38530;38535;38540;38545;38550;38555;38560;38565;38570;38575;38580;38585;38590;38595;38600;38605;38610;38615;38633;38638;38643;38648;38665;38670;38675;38680;38685;38690;38695;38700;38705;38710;38715;38720;38725;38730;38735;38740;38745;38750;38755;38760;38765;38770;38775;38780;38785;38790;38795;38800;38805;38810;38815;38820;38825;38830;38835;38840;38845;38850;38855;38860;38865;38870;38875;38880;38885;38890;38895;38900;38905;38910;38915;38920;38925;38930;38935;38940;38945;38950;38955;38960;38965;38970;38975;38980;38985;38990;38995;39000;39005;39010;39015;39020;39025;39030;39035;39040;39045;39050;39055;39060;39065;39070;39075;39080;39085;39090;39095;39100;39105;39110;39115;39120;39125;39130;39135;39140;39145;39150;39155;39160;39165;39170;39175;39180;39185;39190;39195;39200;39205;39210;39215;39220;39225;39230;39235;39240;39245;39250;39255;39260;39265;39270;39275;39280;39285;39290;39295;39300;39305;39310;39315;39320;39325;39330;39335;39340;39345;39350;39355;39360;39365;39370;39375;39380;39385;39390;39395;39400;39405;39410;39415;39420;39425;39430;39435;39440;39445;39450;39455;39460;39465;39470;39475;39480;39485;39490;39495;39500;39505;39510;39515;39520;39525;39530;39535;39540;39545;39550;39555;39560;39565;39570;39575;39587;39592;39597;39602;39607;39612;39617;39622;39627;39632;39637;39642;39647;39652;39657;39662;39667;39672;39677;39682;39687;39692;39697;39702;39707;39712;39717;39722;39727;39732;39737;39742;39747;39752;39757;39762;39767;39772;39777;39782;39787;39792;39797;39802;39807;39812;39817;39822;39827;39832;39837;39842;39847;39852;39857;39862;39867;39872;39877;39882;39887;39892;39897;39902;39907;39912;39917;39922;39927;39932;39937;39942;39947;39952;39957;39962;39967;39972;39977;39982;39987;39992;39997;40002;40007;40012;40017;40022;40027;40032;40037;40042;40047;40052;40057;40062;40067;40072;40077;40082;40087;40092;40097;40102;40107;40112;40117;40122;40127;40132;40137;40142;40147;40152;40157;40162;40167;40172;40177;40182;40187;40192;40197;40202;40207;40212;40217;40222;40227;40232;40237;40242;40247;40252;40257;40262;40267;40272;40277;40282;40287;40292;40297;40367;40372;40377;40382;40387;40392;40397;40402;40407;40412;40417;40422;40427;40432;40437;40442;40447;40452;40779;40784;40789;40794;40799;40804;40809;40814;40819;40824;40829;40834;40839;40844;40849;40854;40859;40864;40869;40874;40879;40884;40889;40894;40899;40904;40909;40914;40919;40924;40929;40934;40939;40944;40949;40954;40959;40964;40969;40974;40979;40984;40989;40994;40999;41004;41009;41014;41019;41771;41776;41781;41786;41791;41796;41801;41806;41811;41816;41821;41826;41831;41836;41841;41846;41851;41856;41861;41866;41871;41876;41881;41886;41891;41896;41901;41906;41911;41916;41921;41926;41931;41936;41941;41946;41951;41956;41961;41966;41971;41976;41981;41986;41991;41996;42001;42006;42011;42016;42021;42026;42031;42036;42041;42046;42051;42056;42061;42066;42071;42076;42081;42086;42091;42096;42101;42106;42111;42217;42222;42248;42253;42258;42263;42268;42273;42278;42283;42288;42293;42298;42303;42308;42313;42318;42323;42328;42333;42338;42343;42348;42353;42358;42363;42368;42373;42378;42383;42388;42393;42398;42403;42408;42413;42418;42423;42428;42433;42438;42443;42448;42453;42458;42463;42468;42473;42478;42483;42488;42493;42498;42503;42508;42911;42916;42921;42926;42931;42936;42941;42946;42951;42956;42961;42966;42971;42976;42981;42986;42991;42996;43001;43006;43011;43016;43021;43026;43031;43036;43041;43046;43051;43056;43061;43066;43071;43076;43081;43086;43091;43096;43101;43106;43111;43116;43121;43126;43131;43136;43141;43146;43151;43156;43161;43166;43171;43176;43181;43186;43191;43196;43201;43206;43211;43216;43221;43226;43231;43236;43241;43246;43251;43256;43261;43266;43271;43276;43281;43286;43291;43296;43301;43306;43311;43316;43321;43326;43331;43336;43341;43346;43351;43356;43361;43366;43371;43376;43381;43386;43391;43396;43401;43406;43411;44283;44288;44293;44298;44303;44308;44313;44318;44323;44328;44333;44338;44343;44348;44353;44358;44363;44368;44373;44378;44383;44388;44393;44398;44403;44408;44413;44418;44423;44428;44433;44438;44443;44448;44453;44458;44463;44468;44473;44478;44483;44488;44493;44498;44503;44508;44513;44518;44523;44528;44533;44538;44543;44548;44553;44558;44563;44568;44573;44578;44583;44588;44593;44598;44603;44608;44613;44618;44623;44628;44633;44638;44643;44648;44653;44658;44663;44668;44673;44678;44683;44688;44693;44698;44703;44708;44713;44718;44723;44728;44733;44738;44743;44748;44753;44758;44763;44768;44773;44778;44783;44788;44793;44798;44803;44808;44813;44818;44823;44828;44833;44838;44843;44848;44853;44858;44863;44868;44873;44878;44883;45476;47076;47086;47091;47096;47283;49142;49159;49164;49169;49174;49179;49184;49189;49194;49199;49204;49209;49214;49219;49224;49229;49234;49239;49244;49249;49254;49259;49264;49269;49274;49279;49284;49289;49294;49299;49304;49309;49314;49319;49324;49329;49334;49339;49344;49349;49354;49359;49364;49369;49374;49379;49384;49389;49394;49399;49404;49409;49414;49437;49442;49447;49452;49457;49462;49467;49472;49477;49482;49487;49492;49497;49502;49507;49512;49517;49522;49527 |]
        | 1953 -> [| 34780;34886;34890;34894;34898;34902;34906;34910;34914;34918;34922;34926;34930;34934;34938;34942;34946;34950;34954;34958;34962;34966;34970;34974;34978;34982;34986;34990;34994;34998;35002;35006;35010;35014;35018;35022;35026;35030;35034;35038;35042;35046;35050;35054;35058;35062;35066;35070;35074;35078;35082;35086;35090;35094;35098;35102;35106;35110;35114;35118;35122;35126;35130;35134;35138;35142;35146;35150;35154;35158;35162;35166;35170;35174;35178;35182;35186;35190;35194;35198;35202;35206;35210;35214;35218;35222;35226;35230;35234;35238;35242;35246;35250;35254;35258;35262;35266;35270;35274;35278;35282;35286;35290;35294;35298;35302;35306;35310;35314;35318;35322;35326;35330;35334;35338;35342;35346;35350;35354;35358;35362;35366;35370;35374;35378;35382;35386;35390;35394;35398;35402;35406;35410;35414;35418;35422;35426;35430;35434;35438;35442;35446;35450;35454;35458;35462;35466;35470;35474;35478;35482;35486;35490;35494;35498;35502;35506;35510;35514;35518;35522;35526;35530;35534;35538;35542;35546;35550;35554;35558;35562;35566;35570;35574;35578;35582;35586;35590;35594;35598;35602;35606;35610;35614;35618;35622;35626;35630;35634;35638;35642;35692;35697;35702;35707;36873;36874;36875;36876;36887;36891;36895;36899;37634;37639;37644;37649;37654;37659;37664;37669;37674;37679;37684;37689;37694;37699;37704;37709;37714;37719;37724;37729;37734;37739;37744;37749;37754;37759;37764;37769;37774;37779;37784;37789;37925;37930;37935;37976;37981;37986;37991;37996;38001;38006;38011;38016;38021;38026;38031;38036;38041;38046;38051;38056;38061;38066;38071;38076;38081;38086;38091;38096;38101;38106;38111;38116;38121;38126;38131;38136;38152;38157;38162;38167;38172;38177;38182;38187;38192;38197;38202;38207;38224;38229;38234;38239;38244;38249;38254;38259;38264;38269;38274;38279;38284;38289;38294;38299;38304;38309;38314;38319;38324;38329;38334;38339;38344;38349;38354;38359;38364;38369;38374;38379;38384;38389;38406;38411;38416;38421;38426;38431;38436;38441;38446;38451;38456;38461;38466;38471;38476;38481;38486;38491;38496;38501;38506;38511;38516;38521;38526;38531;38536;38541;38546;38551;38556;38561;38566;38571;38576;38581;38586;38591;38596;38601;38606;38611;38616;38634;38639;38644;38649;38666;38671;38676;38681;38686;38691;38696;38701;38706;38711;38716;38721;38726;38731;38736;38741;38746;38751;38756;38761;38766;38771;38776;38781;38786;38791;38796;38801;38806;38811;38816;38821;38826;38831;38836;38841;38846;38851;38856;38861;38866;38871;38876;38881;38886;38891;38896;38901;38906;38911;38916;38921;38926;38931;38936;38941;38946;38951;38956;38961;38966;38971;38976;38981;38986;38991;38996;39001;39006;39011;39016;39021;39026;39031;39036;39041;39046;39051;39056;39061;39066;39071;39076;39081;39086;39091;39096;39101;39106;39111;39116;39121;39126;39131;39136;39141;39146;39151;39156;39161;39166;39171;39176;39181;39186;39191;39196;39201;39206;39211;39216;39221;39226;39231;39236;39241;39246;39251;39256;39261;39266;39271;39276;39281;39286;39291;39296;39301;39306;39311;39316;39321;39326;39331;39336;39341;39346;39351;39356;39361;39366;39371;39376;39381;39386;39391;39396;39401;39406;39411;39416;39421;39426;39431;39436;39441;39446;39451;39456;39461;39466;39471;39476;39481;39486;39491;39496;39501;39506;39511;39516;39521;39526;39531;39536;39541;39546;39551;39556;39561;39566;39571;39576;39588;39593;39598;39603;39608;39613;39618;39623;39628;39633;39638;39643;39648;39653;39658;39663;39668;39673;39678;39683;39688;39693;39698;39703;39708;39713;39718;39723;39728;39733;39738;39743;39748;39753;39758;39763;39768;39773;39778;39783;39788;39793;39798;39803;39808;39813;39818;39823;39828;39833;39838;39843;39848;39853;39858;39863;39868;39873;39878;39883;39888;39893;39898;39903;39908;39913;39918;39923;39928;39933;39938;39943;39948;39953;39958;39963;39968;39973;39978;39983;39988;39993;39998;40003;40008;40013;40018;40023;40028;40033;40038;40043;40048;40053;40058;40063;40068;40073;40078;40083;40088;40093;40098;40103;40108;40113;40118;40123;40128;40133;40138;40143;40148;40153;40158;40163;40168;40173;40178;40183;40188;40193;40198;40203;40208;40213;40218;40223;40228;40233;40238;40243;40248;40253;40258;40263;40268;40273;40278;40283;40288;40293;40298;40368;40373;40378;40383;40388;40393;40398;40403;40408;40413;40418;40423;40428;40433;40438;40443;40448;40453;40780;40785;40790;40795;40800;40805;40810;40815;40820;40825;40830;40835;40840;40845;40850;40855;40860;40865;40870;40875;40880;40885;40890;40895;40900;40905;40910;40915;40920;40925;40930;40935;40940;40945;40950;40955;40960;40965;40970;40975;40980;40985;40990;40995;41000;41005;41010;41015;41020;41772;41777;41782;41787;41792;41797;41802;41807;41812;41817;41822;41827;41832;41837;41842;41847;41852;41857;41862;41867;41872;41877;41882;41887;41892;41897;41902;41907;41912;41917;41922;41927;41932;41937;41942;41947;41952;41957;41962;41967;41972;41977;41982;41987;41992;41997;42002;42007;42012;42017;42022;42027;42032;42037;42042;42047;42052;42057;42062;42067;42072;42077;42082;42087;42092;42097;42102;42107;42112;42218;42223;42249;42254;42259;42264;42269;42274;42279;42284;42289;42294;42299;42304;42309;42314;42319;42324;42329;42334;42339;42344;42349;42354;42359;42364;42369;42374;42379;42384;42389;42394;42399;42404;42409;42414;42419;42424;42429;42434;42439;42444;42449;42454;42459;42464;42469;42474;42479;42484;42489;42494;42499;42504;42509;42912;42917;42922;42927;42932;42937;42942;42947;42952;42957;42962;42967;42972;42977;42982;42987;42992;42997;43002;43007;43012;43017;43022;43027;43032;43037;43042;43047;43052;43057;43062;43067;43072;43077;43082;43087;43092;43097;43102;43107;43112;43117;43122;43127;43132;43137;43142;43147;43152;43157;43162;43167;43172;43177;43182;43187;43192;43197;43202;43207;43212;43217;43222;43227;43232;43237;43242;43247;43252;43257;43262;43267;43272;43277;43282;43287;43292;43297;43302;43307;43312;43317;43322;43327;43332;43337;43342;43347;43352;43357;43362;43367;43372;43377;43382;43387;43392;43397;43402;43407;43412;44284;44289;44294;44299;44304;44309;44314;44319;44324;44329;44334;44339;44344;44349;44354;44359;44364;44369;44374;44379;44384;44389;44394;44399;44404;44409;44414;44419;44424;44429;44434;44439;44444;44449;44454;44459;44464;44469;44474;44479;44484;44489;44494;44499;44504;44509;44514;44519;44524;44529;44534;44539;44544;44549;44554;44559;44564;44569;44574;44579;44584;44589;44594;44599;44604;44609;44614;44619;44624;44629;44634;44639;44644;44649;44654;44659;44664;44669;44674;44679;44684;44689;44694;44699;44704;44709;44714;44719;44724;44729;44734;44739;44744;44749;44754;44759;44764;44769;44774;44779;44784;44789;44794;44799;44804;44809;44814;44819;44824;44829;44834;44839;44844;44849;44854;44859;44864;44869;44874;44879;44884;45477;47077;47087;47092;47097;47284;49143;49160;49165;49170;49175;49180;49185;49190;49195;49200;49205;49210;49215;49220;49225;49230;49235;49240;49245;49250;49255;49260;49265;49270;49275;49280;49285;49290;49295;49300;49305;49310;49315;49320;49325;49330;49335;49340;49345;49350;49355;49360;49365;49370;49375;49380;49385;49390;49395;49400;49405;49410;49415;49438;49443;49448;49453;49458;49463;49468;49473;49478;49483;49488;49493;49498;49503;49508;49513;49518;49523;49528 |]
        | 1954 -> [| 34781;34887;34891;34895;34899;34903;34907;34911;34915;34919;34923;34927;34931;34935;34939;34943;34947;34951;34955;34959;34963;34967;34971;34975;34979;34983;34987;34991;34995;34999;35003;35007;35011;35015;35019;35023;35027;35031;35035;35039;35043;35047;35051;35055;35059;35063;35067;35071;35075;35079;35083;35087;35091;35095;35099;35103;35107;35111;35115;35119;35123;35127;35131;35135;35139;35143;35147;35151;35155;35159;35163;35167;35171;35175;35179;35183;35187;35191;35195;35199;35203;35207;35211;35215;35219;35223;35227;35231;35235;35239;35243;35247;35251;35255;35259;35263;35267;35271;35275;35279;35283;35287;35291;35295;35299;35303;35307;35311;35315;35319;35323;35327;35331;35335;35339;35343;35347;35351;35355;35359;35363;35367;35371;35375;35379;35383;35387;35391;35395;35399;35403;35407;35411;35415;35419;35423;35427;35431;35435;35439;35443;35447;35451;35455;35459;35463;35467;35471;35475;35479;35483;35487;35491;35495;35499;35503;35507;35511;35515;35519;35523;35527;35531;35535;35539;35543;35547;35551;35555;35559;35563;35567;35571;35575;35579;35583;35587;35591;35595;35599;35603;35607;35611;35615;35619;35623;35627;35631;35635;35639;35643;35693;35698;35703;35708;36877;36878;36879;36880;36888;36892;36896;36900;37635;37640;37645;37650;37655;37660;37665;37670;37675;37680;37685;37690;37695;37700;37705;37710;37715;37720;37725;37730;37735;37740;37745;37750;37755;37760;37765;37770;37775;37780;37785;37790;37926;37931;37936;37977;37982;37987;37992;37997;38002;38007;38012;38017;38022;38027;38032;38037;38042;38047;38052;38057;38062;38067;38072;38077;38082;38087;38092;38097;38102;38107;38112;38117;38122;38127;38132;38137;38153;38158;38163;38168;38173;38178;38183;38188;38193;38198;38203;38208;38225;38230;38235;38240;38245;38250;38255;38260;38265;38270;38275;38280;38285;38290;38295;38300;38305;38310;38315;38320;38325;38330;38335;38340;38345;38350;38355;38360;38365;38370;38375;38380;38385;38390;38407;38412;38417;38422;38427;38432;38437;38442;38447;38452;38457;38462;38467;38472;38477;38482;38487;38492;38497;38502;38507;38512;38517;38522;38527;38532;38537;38542;38547;38552;38557;38562;38567;38572;38577;38582;38587;38592;38597;38602;38607;38612;38617;38635;38640;38645;38650;38667;38672;38677;38682;38687;38692;38697;38702;38707;38712;38717;38722;38727;38732;38737;38742;38747;38752;38757;38762;38767;38772;38777;38782;38787;38792;38797;38802;38807;38812;38817;38822;38827;38832;38837;38842;38847;38852;38857;38862;38867;38872;38877;38882;38887;38892;38897;38902;38907;38912;38917;38922;38927;38932;38937;38942;38947;38952;38957;38962;38967;38972;38977;38982;38987;38992;38997;39002;39007;39012;39017;39022;39027;39032;39037;39042;39047;39052;39057;39062;39067;39072;39077;39082;39087;39092;39097;39102;39107;39112;39117;39122;39127;39132;39137;39142;39147;39152;39157;39162;39167;39172;39177;39182;39187;39192;39197;39202;39207;39212;39217;39222;39227;39232;39237;39242;39247;39252;39257;39262;39267;39272;39277;39282;39287;39292;39297;39302;39307;39312;39317;39322;39327;39332;39337;39342;39347;39352;39357;39362;39367;39372;39377;39382;39387;39392;39397;39402;39407;39412;39417;39422;39427;39432;39437;39442;39447;39452;39457;39462;39467;39472;39477;39482;39487;39492;39497;39502;39507;39512;39517;39522;39527;39532;39537;39542;39547;39552;39557;39562;39567;39572;39577;39589;39594;39599;39604;39609;39614;39619;39624;39629;39634;39639;39644;39649;39654;39659;39664;39669;39674;39679;39684;39689;39694;39699;39704;39709;39714;39719;39724;39729;39734;39739;39744;39749;39754;39759;39764;39769;39774;39779;39784;39789;39794;39799;39804;39809;39814;39819;39824;39829;39834;39839;39844;39849;39854;39859;39864;39869;39874;39879;39884;39889;39894;39899;39904;39909;39914;39919;39924;39929;39934;39939;39944;39949;39954;39959;39964;39969;39974;39979;39984;39989;39994;39999;40004;40009;40014;40019;40024;40029;40034;40039;40044;40049;40054;40059;40064;40069;40074;40079;40084;40089;40094;40099;40104;40109;40114;40119;40124;40129;40134;40139;40144;40149;40154;40159;40164;40169;40174;40179;40184;40189;40194;40199;40204;40209;40214;40219;40224;40229;40234;40239;40244;40249;40254;40259;40264;40269;40274;40279;40284;40289;40294;40299;40369;40374;40379;40384;40389;40394;40399;40404;40409;40414;40419;40424;40429;40434;40439;40444;40449;40454;40781;40786;40791;40796;40801;40806;40811;40816;40821;40826;40831;40836;40841;40846;40851;40856;40861;40866;40871;40876;40881;40886;40891;40896;40901;40906;40911;40916;40921;40926;40931;40936;40941;40946;40951;40956;40961;40966;40971;40976;40981;40986;40991;40996;41001;41006;41011;41016;41021;41773;41778;41783;41788;41793;41798;41803;41808;41813;41818;41823;41828;41833;41838;41843;41848;41853;41858;41863;41868;41873;41878;41883;41888;41893;41898;41903;41908;41913;41918;41923;41928;41933;41938;41943;41948;41953;41958;41963;41968;41973;41978;41983;41988;41993;41998;42003;42008;42013;42018;42023;42028;42033;42038;42043;42048;42053;42058;42063;42068;42073;42078;42083;42088;42093;42098;42103;42108;42113;42219;42224;42250;42255;42260;42265;42270;42275;42280;42285;42290;42295;42300;42305;42310;42315;42320;42325;42330;42335;42340;42345;42350;42355;42360;42365;42370;42375;42380;42385;42390;42395;42400;42405;42410;42415;42420;42425;42430;42435;42440;42445;42450;42455;42460;42465;42470;42475;42480;42485;42490;42495;42500;42505;42510;42913;42918;42923;42928;42933;42938;42943;42948;42953;42958;42963;42968;42973;42978;42983;42988;42993;42998;43003;43008;43013;43018;43023;43028;43033;43038;43043;43048;43053;43058;43063;43068;43073;43078;43083;43088;43093;43098;43103;43108;43113;43118;43123;43128;43133;43138;43143;43148;43153;43158;43163;43168;43173;43178;43183;43188;43193;43198;43203;43208;43213;43218;43223;43228;43233;43238;43243;43248;43253;43258;43263;43268;43273;43278;43283;43288;43293;43298;43303;43308;43313;43318;43323;43328;43333;43338;43343;43348;43353;43358;43363;43368;43373;43378;43383;43388;43393;43398;43403;43408;43413;44285;44290;44295;44300;44305;44310;44315;44320;44325;44330;44335;44340;44345;44350;44355;44360;44365;44370;44375;44380;44385;44390;44395;44400;44405;44410;44415;44420;44425;44430;44435;44440;44445;44450;44455;44460;44465;44470;44475;44480;44485;44490;44495;44500;44505;44510;44515;44520;44525;44530;44535;44540;44545;44550;44555;44560;44565;44570;44575;44580;44585;44590;44595;44600;44605;44610;44615;44620;44625;44630;44635;44640;44645;44650;44655;44660;44665;44670;44675;44680;44685;44690;44695;44700;44705;44710;44715;44720;44725;44730;44735;44740;44745;44750;44755;44760;44765;44770;44775;44780;44785;44790;44795;44800;44805;44810;44815;44820;44825;44830;44835;44840;44845;44850;44855;44860;44865;44870;44875;44880;44885;45478;47078;47088;47093;47098;47285;49144;49161;49166;49171;49176;49181;49186;49191;49196;49201;49206;49211;49216;49221;49226;49231;49236;49241;49246;49251;49256;49261;49266;49271;49276;49281;49286;49291;49296;49301;49306;49311;49316;49321;49326;49331;49336;49341;49346;49351;49356;49361;49366;49371;49376;49381;49386;49391;49396;49401;49406;49411;49416;49439;49444;49449;49454;49459;49464;49469;49474;49479;49484;49489;49494;49499;49504;49509;49514;49519;49524;49529 |]
        | 1955 -> [| 34782;34888;34892;34896;34900;34904;34908;34912;34916;34920;34924;34928;34932;34936;34940;34944;34948;34952;34956;34960;34964;34968;34972;34976;34980;34984;34988;34992;34996;35000;35004;35008;35012;35016;35020;35024;35028;35032;35036;35040;35044;35048;35052;35056;35060;35064;35068;35072;35076;35080;35084;35088;35092;35096;35100;35104;35108;35112;35116;35120;35124;35128;35132;35136;35140;35144;35148;35152;35156;35160;35164;35168;35172;35176;35180;35184;35188;35192;35196;35200;35204;35208;35212;35216;35220;35224;35228;35232;35236;35240;35244;35248;35252;35256;35260;35264;35268;35272;35276;35280;35284;35288;35292;35296;35300;35304;35308;35312;35316;35320;35324;35328;35332;35336;35340;35344;35348;35352;35356;35360;35364;35368;35372;35376;35380;35384;35388;35392;35396;35400;35404;35408;35412;35416;35420;35424;35428;35432;35436;35440;35444;35448;35452;35456;35460;35464;35468;35472;35476;35480;35484;35488;35492;35496;35500;35504;35508;35512;35516;35520;35524;35528;35532;35536;35540;35544;35548;35552;35556;35560;35564;35568;35572;35576;35580;35584;35588;35592;35596;35600;35604;35608;35612;35616;35620;35624;35628;35632;35636;35640;35644;35694;35699;35704;35709;36881;36882;36883;36884;36889;36893;36897;36901;37636;37641;37646;37651;37656;37661;37666;37671;37676;37681;37686;37691;37696;37701;37706;37711;37716;37721;37726;37731;37736;37741;37746;37751;37756;37761;37766;37771;37776;37781;37786;37791;37927;37932;37937;37978;37983;37988;37993;37998;38003;38008;38013;38018;38023;38028;38033;38038;38043;38048;38053;38058;38063;38068;38073;38078;38083;38088;38093;38098;38103;38108;38113;38118;38123;38128;38133;38138;38154;38159;38164;38169;38174;38179;38184;38189;38194;38199;38204;38209;38226;38231;38236;38241;38246;38251;38256;38261;38266;38271;38276;38281;38286;38291;38296;38301;38306;38311;38316;38321;38326;38331;38336;38341;38346;38351;38356;38361;38366;38371;38376;38381;38386;38391;38408;38413;38418;38423;38428;38433;38438;38443;38448;38453;38458;38463;38468;38473;38478;38483;38488;38493;38498;38503;38508;38513;38518;38523;38528;38533;38538;38543;38548;38553;38558;38563;38568;38573;38578;38583;38588;38593;38598;38603;38608;38613;38618;38636;38641;38646;38651;38668;38673;38678;38683;38688;38693;38698;38703;38708;38713;38718;38723;38728;38733;38738;38743;38748;38753;38758;38763;38768;38773;38778;38783;38788;38793;38798;38803;38808;38813;38818;38823;38828;38833;38838;38843;38848;38853;38858;38863;38868;38873;38878;38883;38888;38893;38898;38903;38908;38913;38918;38923;38928;38933;38938;38943;38948;38953;38958;38963;38968;38973;38978;38983;38988;38993;38998;39003;39008;39013;39018;39023;39028;39033;39038;39043;39048;39053;39058;39063;39068;39073;39078;39083;39088;39093;39098;39103;39108;39113;39118;39123;39128;39133;39138;39143;39148;39153;39158;39163;39168;39173;39178;39183;39188;39193;39198;39203;39208;39213;39218;39223;39228;39233;39238;39243;39248;39253;39258;39263;39268;39273;39278;39283;39288;39293;39298;39303;39308;39313;39318;39323;39328;39333;39338;39343;39348;39353;39358;39363;39368;39373;39378;39383;39388;39393;39398;39403;39408;39413;39418;39423;39428;39433;39438;39443;39448;39453;39458;39463;39468;39473;39478;39483;39488;39493;39498;39503;39508;39513;39518;39523;39528;39533;39538;39543;39548;39553;39558;39563;39568;39573;39578;39590;39595;39600;39605;39610;39615;39620;39625;39630;39635;39640;39645;39650;39655;39660;39665;39670;39675;39680;39685;39690;39695;39700;39705;39710;39715;39720;39725;39730;39735;39740;39745;39750;39755;39760;39765;39770;39775;39780;39785;39790;39795;39800;39805;39810;39815;39820;39825;39830;39835;39840;39845;39850;39855;39860;39865;39870;39875;39880;39885;39890;39895;39900;39905;39910;39915;39920;39925;39930;39935;39940;39945;39950;39955;39960;39965;39970;39975;39980;39985;39990;39995;40000;40005;40010;40015;40020;40025;40030;40035;40040;40045;40050;40055;40060;40065;40070;40075;40080;40085;40090;40095;40100;40105;40110;40115;40120;40125;40130;40135;40140;40145;40150;40155;40160;40165;40170;40175;40180;40185;40190;40195;40200;40205;40210;40215;40220;40225;40230;40235;40240;40245;40250;40255;40260;40265;40270;40275;40280;40285;40290;40295;40300;40370;40375;40380;40385;40390;40395;40400;40405;40410;40415;40420;40425;40430;40435;40440;40445;40450;40455;40782;40787;40792;40797;40802;40807;40812;40817;40822;40827;40832;40837;40842;40847;40852;40857;40862;40867;40872;40877;40882;40887;40892;40897;40902;40907;40912;40917;40922;40927;40932;40937;40942;40947;40952;40957;40962;40967;40972;40977;40982;40987;40992;40997;41002;41007;41012;41017;41022;41774;41779;41784;41789;41794;41799;41804;41809;41814;41819;41824;41829;41834;41839;41844;41849;41854;41859;41864;41869;41874;41879;41884;41889;41894;41899;41904;41909;41914;41919;41924;41929;41934;41939;41944;41949;41954;41959;41964;41969;41974;41979;41984;41989;41994;41999;42004;42009;42014;42019;42024;42029;42034;42039;42044;42049;42054;42059;42064;42069;42074;42079;42084;42089;42094;42099;42104;42109;42114;42220;42225;42251;42256;42261;42266;42271;42276;42281;42286;42291;42296;42301;42306;42311;42316;42321;42326;42331;42336;42341;42346;42351;42356;42361;42366;42371;42376;42381;42386;42391;42396;42401;42406;42411;42416;42421;42426;42431;42436;42441;42446;42451;42456;42461;42466;42471;42476;42481;42486;42491;42496;42501;42506;42511;42914;42919;42924;42929;42934;42939;42944;42949;42954;42959;42964;42969;42974;42979;42984;42989;42994;42999;43004;43009;43014;43019;43024;43029;43034;43039;43044;43049;43054;43059;43064;43069;43074;43079;43084;43089;43094;43099;43104;43109;43114;43119;43124;43129;43134;43139;43144;43149;43154;43159;43164;43169;43174;43179;43184;43189;43194;43199;43204;43209;43214;43219;43224;43229;43234;43239;43244;43249;43254;43259;43264;43269;43274;43279;43284;43289;43294;43299;43304;43309;43314;43319;43324;43329;43334;43339;43344;43349;43354;43359;43364;43369;43374;43379;43384;43389;43394;43399;43404;43409;43414;44286;44291;44296;44301;44306;44311;44316;44321;44326;44331;44336;44341;44346;44351;44356;44361;44366;44371;44376;44381;44386;44391;44396;44401;44406;44411;44416;44421;44426;44431;44436;44441;44446;44451;44456;44461;44466;44471;44476;44481;44486;44491;44496;44501;44506;44511;44516;44521;44526;44531;44536;44541;44546;44551;44556;44561;44566;44571;44576;44581;44586;44591;44596;44601;44606;44611;44616;44621;44626;44631;44636;44641;44646;44651;44656;44661;44666;44671;44676;44681;44686;44691;44696;44701;44706;44711;44716;44721;44726;44731;44736;44741;44746;44751;44756;44761;44766;44771;44776;44781;44786;44791;44796;44801;44806;44811;44816;44821;44826;44831;44836;44841;44846;44851;44856;44861;44866;44871;44876;44881;44886;45479;47079;47089;47094;47099;47281;49145;49162;49167;49172;49177;49182;49187;49192;49197;49202;49207;49212;49217;49222;49227;49232;49237;49242;49247;49252;49257;49262;49267;49272;49277;49282;49287;49292;49297;49302;49307;49312;49317;49322;49327;49332;49337;49342;49347;49352;49357;49362;49367;49372;49377;49382;49387;49392;49397;49402;49407;49412;49417;49440;49445;49450;49455;49460;49465;49470;49475;49480;49485;49490;49495;49500;49505;49510;49515;49520;49525;49530 |]
        | 1316 -> [| 34832 |]
        | 1317 -> [| 34841;34842;34843;34844;34845;34846;34847;34848;34849;34850;34851;34852;34853;34854;34855;34856;34857;34858;34859;34860;34861;34862;34863;34864;34865;34866;34867;34868;34869 |]
        | 1395 -> [| 35770;35771;35774 |]
        | 1397 -> [| 35772;35773 |]
        | 1396 -> [| 35788;35789;35790 |]
        | 1399 -> [| 35791;35792 |]
        | 1400 -> [| 35794;35795 |]
        | 1402 -> [| 35812;35816 |]
        | 1413 -> [| 35813 |]
        | 1411 -> [| 35814;35815 |]
        | 1412 -> [| 35819 |]
        | 1414 -> [| 35820 |]
        | 1404 -> [| 35825;35826;35827 |]
        | 1405 -> [| 35828;35829;35830 |]
        | 1657 -> [| 35832;35833;35834;40340;47512;47513;47514;47515;47516 |]
        | 1406 -> [| 35835;35836 |]
        | 1408 -> [| 35837;35841 |]
        | 1407 -> [| 35838;35839;37533 |]
        | 2017 -> [| 35840 |]
        | 1409 -> [| 35842;35843;35844 |]
        | 2015 -> [| 35845;49600;49601 |]
        | 1415 -> [| 35877;35878;35881;35886;35891;45550 |]
        | 1717 -> [| 35880;35893;35895;35896;35897;35898;35900;35901;35904;35927;35929;35930;35931;35932;35933;35934;35935;35936;35937;35938;35939;35950;35951;35952;35953;35954;35955;35957;35958;35961;35966;35967;37963 |]
        | 1416 -> [| 35888;35889;35890 |]
        | 1321 -> [| 35892;35894 |]
        | 1322 -> [| 35899;45537;45538;45539 |]
        | 1323 -> [| 35905;35906;35907;35908;35909;35910;35911 |]
        | 1324 -> [| 35912;35913;35914;35915 |]
        | 1325 -> [| 35916;35917;35918;35919;35920 |]
        | 1327 -> [| 35921;47323 |]
        | 1562 -> [| 35922;47298 |]
        | 1328 -> [| 35923;47325 |]
        | 1329 -> [| 35924;35925;46575;47330;47332 |]
        | 1330 -> [| 35926;47327 |]
        | 1333 -> [| 35928 |]
        | 1332 -> [| 35940;46577;47338 |]
        | 1719 -> [| 35941;35945;35947;47364;47366;47368 |]
        | 1441 -> [| 35943;47351 |]
        | 1331 -> [| 35944;47068;47069;47070;47071;47072;47073;47074;47252 |]
        | 1442 -> [| 35949;47334 |]
        | 1429 -> [| 35959;35962;47340;47342 |]
        | 1430 -> [| 35963;35965;47344;47347 |]
        | 1882 -> [| 36464;42532;47204;47205;47380;47383;47386;47389;47392;47451;47452;47453;47454;47455;47456;47949;47950 |]
        | 1465 -> [| 36848 |]
        | 1568 -> [| 36939;38659;40725;42127;42512;46344;47715;47717;48129;48904;48905;48906;48907;48940;48941;48942;48955;49534 |]
        | 1665 -> [| 36940;38658;40726;42128;42513;46343;46346;46347;47719;47720;47722;48130;48900;48901;48937;48938;48939;48956;49536 |]
        | 1666 -> [| 36941;38657;42129;42514;47721;48959;49537 |]
        | 1461 -> [| 36949 |]
        | 1462 -> [| 36960;36961;36962;36963;36964;36965;36966;36967;36968;36971;36972;36973;36974;36975;36976;36977;36978;36979;36980;36981;37537;37538;37539;37540;40521;49625;49626 |]
        | 1709 -> [| 36997;36999;37000;37001;37002;37003;37004;37005;37006;37007;37011;37012;37014;37015;37021;37024;37025;37026;37027;37031;37033;37037;37038;37039;37040;37042;37046;37049;37050;37051;37052;37053;37054;37058;37061;37062;37063;37064;37065;37067;37068;37069;37071;37072;37073;37074;37075;37076;37077;37078;37079;37084;37085;37138;37139;37140;37323;37324;37325;37326;37327;37336;37337;37340;37341;37386;37387;37388;37389;37398;37399;37400;37401;37402;37403;37404;37405;37406;37407;37408;37409;37415;37416;37425;37426;37427;37428;37429;37430;37433;37434;37441;37442;37443;37444;37445;37446;37447;37448;37964;41430;41431;41432;41433;41434;41435;41436;41437 |]
        | 1707 -> [| 37008;37020;37022;37023;37028;37029;37030;37032;37034;37041;37043;37044;37045;37047;37048;37060;37066;37080;37081;37083;37087;37541;43925;43926;43927;43928;43929;45540;45541;45542;45551;46576;46578;47107;47109;47110;47111;47112;47113;47114;47115;47322;47324;47326;47328;47331;47333;47335;47339;47341;47343;47345;47346;47349;47350;47354;47355;47357;47359;47361;47363;47365;47367;47369 |]
        | 1326 -> [| 37141;37142;37143 |]
        | 1826 -> [| 37146;37147 |]
        | 1823 -> [| 37148;37149 |]
        | 1821 -> [| 37150;37151 |]
        | 1828 -> [| 37152;43732 |]
        | 1827 -> [| 37153;43919 |]
        | 1824 -> [| 37154;37155 |]
        | 1822 -> [| 37156;37157 |]
        | 1820 -> [| 37158;37159 |]
        | 1819 -> [| 37160;37161 |]
        | 1825 -> [| 37162;37163 |]
        | 1851 -> [| 37164;37165 |]
        | 1855 -> [| 37166;37167 |]
        | 1858 -> [| 37168;37169 |]
        | 1850 -> [| 37170;37171 |]
        | 1859 -> [| 37172;37173 |]
        | 1860 -> [| 37174;37175;45641 |]
        | 1593 -> [| 37176;37177 |]
        | 1867 -> [| 37178;37179 |]
        | 1868 -> [| 37180;37181 |]
        | 1870 -> [| 37182;37183 |]
        | 1598 -> [| 37184;37185 |]
        | 1599 -> [| 37186;37187 |]
        | 1600 -> [| 37188;37475 |]
        | 1601 -> [| 37190;37191 |]
        | 1602 -> [| 37192;37193 |]
        | 1603 -> [| 37194;37195 |]
        | 1604 -> [| 37196;37197 |]
        | 1605 -> [| 37198;37199 |]
        | 1606 -> [| 37202;37203 |]
        | 1607 -> [| 37204;37205 |]
        | 1608 -> [| 37206;37207 |]
        | 1609 -> [| 37208;37209 |]
        | 1610 -> [| 37210;37211 |]
        | 1611 -> [| 37212;37213 |]
        | 1612 -> [| 37214;37215 |]
        | 1613 -> [| 37216;37217 |]
        | 1615 -> [| 37218;37219 |]
        | 1614 -> [| 37220;37221 |]
        | 1616 -> [| 37222;37223 |]
        | 1617 -> [| 37224;37225 |]
        | 1618 -> [| 37226;37227 |]
        | 1619 -> [| 37228;37229 |]
        | 1620 -> [| 37230;37231 |]
        | 1621 -> [| 37232;37233 |]
        | 1622 -> [| 37234;37235 |]
        | 1629 -> [| 37248;37249 |]
        | 1630 -> [| 37250;37251 |]
        | 1631 -> [| 37252;37253 |]
        | 1632 -> [| 37254;37255 |]
        | 1633 -> [| 37256;37257 |]
        | 1634 -> [| 37258;37259 |]
        | 1635 -> [| 37260;37261 |]
        | 1639 -> [| 37268;37269 |]
        | 1640 -> [| 37270;37271 |]
        | 1641 -> [| 37272;37273 |]
        | 1642 -> [| 37274;37275 |]
        | 1647 -> [| 37280;37281 |]
        | 1648 -> [| 37282;37283 |]
        | 1649 -> [| 37284;37285 |]
        | 1708 -> [| 37287;37309;37310;37311;37312;37314;37315;37316;37317;37318;37319;37320;37321;37322;37328;37329;37330;37331;37332;37333;37334;37335;37338;37339;37342;37343;37344;37345;37346;37347;37348;37349;37350;37351;37352;37353;37354;37355;37356;37357;37358;37359;37360;37361;37364;37365;37366;37367;37368;37369;37370;37371;37372;37373;37374;37375;37376;37377;37378;37379;37380;37381;37382;37383;37384;37385;37390;37391;37392;37393;37394;37395;37396;37397;37410;37411;37413;37414;37417;37418;37419;37420;37421;37422;37423;37424;37431;37432;37435;37436;37437;37438;37449;44002;44003;44004;44005;44006;44007;44008;44009;44010;44011;44012;44013;44014;44015;44016;44017;44018;44019;44020;44021;44022;44023;44024;44025;44026;44027;44028;44029;44030;44031;44032;44033;44034;44035;44036;44037;44038;44039;44040;44041;44042;44043;44044;44045;44046;44047;44048;44049;44050;44051;44052;44053;44054;44055;44056;44057;44058;44059;44060;44061;44062;44063;44064;44065;44074;44075;44076;44077;44078;44079;44080;44081;44082;44083;44084;44085;44086;44087;44088;44089;44090;44091;44092;44093;44094;44095;44096;44097;45545;45547;45549;45642;45643;46500;46501;46502;46503;46504;46505;46506;46507;46508;46509;46510;46511;46512;46513;46514;46515;46516;46517;46518;46519;46643;46644;46645;46646;46647;46648;46649;46650;46651;46652 |]
        | 1673 -> [| 37288;37292;37293;41223;41224 |]
        | 1527 -> [| 37457;37458;37459;37460 |]
        | 1681 -> [| 37461;41396 |]
        | 1682 -> [| 37462 |]
        | 1683 -> [| 37463;41397 |]
        | 1684 -> [| 37464 |]
        | 1685 -> [| 37465;41398 |]
        | 1686 -> [| 37466 |]
        | 1687 -> [| 37467;41399 |]
        | 1689 -> [| 37468;41400 |]
        | 1691 -> [| 37470;41401 |]
        | 1692 -> [| 37471 |]
        | 1529 -> [| 37472 |]
        | 1530 -> [| 37473 |]
        | 1533 -> [| 37479 |]
        | 1534 -> [| 37480;37481;37482;37483 |]
        | 1535 -> [| 37532;47348 |]
        | 2016 -> [| 37534 |]
        | 1410 -> [| 37535;37536 |]
        | 1537 -> [| 37599;40345;40346;40347;40568;40569;40570;40571;45651;47037;47131;47132;47133;47134;47135;47136;47137 |]
        | 1538 -> [| 37604;37605;37606;37607;42133;42242;45645 |]
        | 1542 -> [| 37617;37618;37619;37620 |]
        | 1543 -> [| 37621 |]
        | 1549 -> [| 37821;37822;37823;37824 |]
        | 1559 -> [| 37826;37827;37828;37829 |]
        | 1546 -> [| 37843;37844;37845 |]
        | 1547 -> [| 37846;37847;37848 |]
        | 1548 -> [| 37849;37850;37851 |]
        | 1569 -> [| 40334;40335 |]
        | 1739 -> [| 40520;42523;43630;45635;46375;49703;49704 |]
        | 1690 -> [| 40637 |]
        | 1688 -> [| 40671 |]
        | 1667 -> [| 40727;40728;42238;46348;46349;47275;47723;47724;48131;48799;48800;48801;48936;48957;49118;49120;49122;49124 |]
        | 1724 -> [| 40729 |]
        | 1670 -> [| 41036;41043;41044;41045;41046;41047;41048;41049;41050;41051;41052;41053;49668;49669;49670;49671;49672;49673;49674;49675;49676;49677;49678;49679;49680;49681;49682;49683;49684;49685 |]
        | 1672 -> [| 41040;41054;41055;41056;41057;41058;41059 |]
        | 1704 -> [| 41233;41235;41342;41343;41344;41345;41346;41347;41348;41349;41540 |]
        | 1676 -> [| 41263;41264;41265;41266;41267;41268;41269;41302;41303;41304;41305;41306;41307;41308;41309;41310;41311;41312 |]
        | 1677 -> [| 41270;41271;41272;41273;41274;41275;41276;41277 |]
        | 1678 -> [| 41286;41287;41290;41291;41294;41295;41298;41299 |]
        | 1679 -> [| 41367;41368;41369;41370;41371;41372;41373;41374;45650;47224;47225;47226;47227;47228;47229;47230;47231 |]
        | 1706 -> [| 41411 |]
        | 1693 -> [| 41422;41423 |]
        | 1694 -> [| 41424;41425 |]
        | 1695 -> [| 41426;41427 |]
        | 1696 -> [| 41428;41429 |]
        | 1698 -> [| 41476;41477;41478;41479 |]
        | 1697 -> [| 41480;41481;41482;41483 |]
        | 1699 -> [| 41515;41525;41526;41527 |]
        | 1700 -> [| 41516;41528;41529;41530;41531 |]
        | 1701 -> [| 41517;41518;41519;41520 |]
        | 1702 -> [| 41521;41522;41523;41524 |]
        | 1718 -> [| 41582;41583;41584;41585;42135;45043;45644 |]
        | 1723 -> [| 41661;41662;41663;41664;41665 |]
        | 1720 -> [| 42139 |]
        | 1721 -> [| 42140 |]
        | 1722 -> [| 42141 |]
        | 1727 -> [| 42142 |]
        | 1728 -> [| 42143 |]
        | 1729 -> [| 42144 |]
        | 1735 -> [| 42235 |]
        | 1734 -> [| 42236 |]
        | 1736 -> [| 42237 |]
        | 1737 -> [| 42239 |]
        | 1770 -> [| 42526;42527;42528;42529;42530;43551;43552;43554;43555;43556 |]
        | 1764 -> [| 42533 |]
        | 1765 -> [| 42534 |]
        | 1766 -> [| 42535 |]
        | 1767 -> [| 42654;42655;42656;42657;42658;42659;42660;42661;43612;43613 |]
        | 1768 -> [| 42692;42693;46261;47489;47490;47491;47492;47542;47543;48545;48567;48568;48569;48570;48571;48572;48573;48575;48640;48647 |]
        | 1769 -> [| 42694;42695;42696 |]
        | 1800 -> [| 42815 |]
        | 1788 -> [| 42816 |]
        | 1789 -> [| 42817 |]
        | 1790 -> [| 42818 |]
        | 1791 -> [| 42819 |]
        | 1792 -> [| 42820 |]
        | 1793 -> [| 42821 |]
        | 1794 -> [| 42822 |]
        | 1795 -> [| 42823 |]
        | 1796 -> [| 42824 |]
        | 1797 -> [| 42825 |]
        | 1798 -> [| 42826 |]
        | 1799 -> [| 42827 |]
        | 1771 -> [| 42829;42830;42831 |]
        | 1774 -> [| 42832;42833;42834 |]
        | 1773 -> [| 42835;42836;42837 |]
        | 1772 -> [| 42838;42839;42840 |]
        | 1803 -> [| 42841;42842;42843;42845;42846;43563;43564;43565;43566;43567;43574;43575;43576;43577;43578;43585;43586;43587;43588;43589;43596;43597;43598;43599;43600;43614;43615;43616;43617;43618;43633;43634;43635;43636;43638;43644;43645;43646;43647;43648;43653;43654;43655;44107;44108;44953;45680;46052;46053;46058;46061;46066;46070;46074;46078;46382;47194;47195;47196;47197 |]
        | 1804 -> [| 42844 |]
        | 1805 -> [| 42847 |]
        | 1806 -> [| 42848 |]
        | 1807 -> [| 42849 |]
        | 1810 -> [| 42874;42875;42876;42877;42878;42879;42880;42881;42882;42883;42884;42885;42886;42887;42888 |]
        | 1812 -> [| 43544;43545;43546;43547;43548;43607;43608;43609;43610;43611;43659;43661;43663;43665 |]
        | 1813 -> [| 43557;43558;43559;43560;43568;43569;43570;43571;43579;43580;43581;43582;43590;43591;43592;43593;43601;43602;43603;43604;43622;43623;43624;43625;43641;43642;43649;43656;46054;46056;46059;46062;46067;46071;46075;46079;46581;46760;48583 |]
        | 1814 -> [| 43561;43562;43572;43573;43583;43584;43594;43595;43605;43606;43626;43627;43643;43650;43657;45055;45056;46055;46057;46060;46063;46069;46073;46077;46081;46523;46524;47198 |]
        | 1815 -> [| 43658;43660;43662;43664 |]
        | 1818 -> [| 43682;43683;43684;43685;43686;43687;43688;43689;43690;43691;43692;43693;43695;43696;43697;43698;45677;45678;45679;46381;46444;46445;46446;46447;46448;46449;46450;46451;46452;46453;46454;46455;46456;46457;46458;46459;46460;46461;46462;46463;46464;46465;46466;46467;46468;46469;46470;46471;46472;46473;46474;46475;46476;46477;46478;46479;46480;46481;46482;46483;46579;46580;46601;46602;46603;46771;46772 |]
        | 1869 -> [| 43704;43705;45548 |]
        | 1856 -> [| 43707;43708 |]
        | 1857 -> [| 43709;43711 |]
        | 1852 -> [| 43712;43713 |]
        | 1853 -> [| 43714;43715 |]
        | 1854 -> [| 43716;43717 |]
        | 1861 -> [| 43718;43719;45546 |]
        | 1862 -> [| 43720;43721 |]
        | 1863 -> [| 43722;43723 |]
        | 1864 -> [| 43724;43725 |]
        | 1865 -> [| 43726;43727 |]
        | 1866 -> [| 43729;43730 |]
        | 1829 -> [| 43733;43734 |]
        | 1830 -> [| 43854;43855 |]
        | 1831 -> [| 43856;43857 |]
        | 1832 -> [| 43858;43859 |]
        | 1833 -> [| 43860;43861 |]
        | 1834 -> [| 43862;43863 |]
        | 1835 -> [| 43864;43865 |]
        | 1836 -> [| 43866;43867;45640 |]
        | 1837 -> [| 43868;43869 |]
        | 1839 -> [| 43870;43871;45544 |]
        | 1838 -> [| 43872;43873 |]
        | 1840 -> [| 43874;43875 |]
        | 1841 -> [| 43876;43877 |]
        | 1842 -> [| 43878;43879 |]
        | 1843 -> [| 43880;43881 |]
        | 1845 -> [| 43882;43883 |]
        | 1844 -> [| 43884;43885 |]
        | 1846 -> [| 43886;43887 |]
        | 1847 -> [| 43888;43889 |]
        | 1848 -> [| 43890;43891 |]
        | 1849 -> [| 43892;43893 |]
        | 1816 -> [| 43920;43921 |]
        | 512 -> [| 44102 |]
        | 1872 -> [| 44253 |]
        | 1875 -> [| 44992 |]
        | 1876 -> [| 45006 |]
        | 1940 -> [| 45008;46030;46031;46032 |]
        | 1887 -> [| 45009 |]
        | 1880 -> [| 45470;45474;46653;46654 |]
        | 1878 -> [| 45471;45472 |]
        | 1879 -> [| 45473 |]
        | 1884 -> [| 45490;45491;45492;45493;46280;46281;46282;46283;46284;46285;46286;46287 |]
        | 1920 -> [| 45494;45495;45496;45497;46288;46289;46290;46291;46292;46293;46294;46295 |]
        | 1921 -> [| 45498;45499;45500;45501;46296;46297;46298;46299;46300;46301;46302;46303 |]
        | 1922 -> [| 45502;45503;45504;45506;46304;46305;46306;46307;46308;46309;46310;46311 |]
        | 1923 -> [| 45510;45511;45512;45513;46312;46313;46314;46315;46316;46317;46318;46319 |]
        | 1972 -> [| 45534 |]
        | 1886 -> [| 45584;45585 |]
        | 954 -> [| 45586;45587;45588;45589;45590;45591;45592;45593;45594;45595;45596;45597 |]
        | 956 -> [| 45598;45599;45600;45601;45602;45603;45604;45605;45606;45607;45608;45609 |]
        | 957 -> [| 45610;45611;45612;45613;45614;45615;45616;45617;45618;45619;45620;45621 |]
        | 958 -> [| 45622;45623;45624;45625;45626;45627;45628;45629;45630;45631;45632;45633 |]
        | 973 -> [| 45681;45682;45683;45684;45685;45686;45687;45688;45689;45690;45691;45692;45693;45694;45695;45696;45697;45698;45699;45700;45701;45702;45703;45704;45705;45706;45707;45708;45709;45710;45711;45712;45713;45714;45715;45716;45717;45718;45719;45720;45721;45722;45723;45724;45725;45726;45727;45728 |]
        | 1888 -> [| 45732;46166;46167;46168;46169;46170;46171;46172;46173;46174;46175;46176;46177;46178;46179;46180;46181;46182;46183;46184;46185;46186;46187;46188;46189;46190;46191;46192;46193;46194;46195;46196;46197;46198;46199;46200;46201;46202;46203;46204;46205;46206;46207;46208;46209;46210;46211;46212;46213;46214;46215;46216;46217;46218 |]
        | 1894 -> [| 46010;46012 |]
        | 1896 -> [| 46046;46047;46048;46049;48134 |]
        | 1909 -> [| 46068;46072;46076;46080 |]
        | 1889 -> [| 46157;46158;46159;46160;46161;46162;46163;46164;46165 |]
        | 1890 -> [| 46219;46220;46221;46222;46223;46224;46225;46226;46227;46228;46229;46230;46231;46232;46233;46234;46235;46236;46237;46238;46240;46241;46242;46243;46244;46245;46246;46247;46248;46249;46250;46251 |]
        | 1911 -> [| 46252;46253;46254;46255;46256;46257;46258;46259 |]
        | 1912 -> [| 46323;46324 |]
        | 1913 -> [| 46325;46326 |]
        | 1914 -> [| 46327;46328 |]
        | 1915 -> [| 46329 |]
        | 1664 -> [| 46345;47718;48902;48903;48943;48958;49535 |]
        | 1924 -> [| 46363;46364 |]
        | 1933 -> [| 46484;46485 |]
        | 1934 -> [| 46486;46487 |]
        | 1935 -> [| 46488;46489 |]
        | 1936 -> [| 46490;46491 |]
        | 1937 -> [| 46492;46493 |]
        | 1938 -> [| 46494;46495 |]
        | 1939 -> [| 46496;46497 |]
        | 1951 -> [| 46585;46586;46587;46588;46589;46590;46591;46592;46593;46594;46595;46596;46597;46598;46599;46600 |]
        | 1941 -> [| 46633;46634 |]
        | 1942 -> [| 46635;46636 |]
        | 1943 -> [| 46637;46638 |]
        | 1944 -> [| 46639;46640 |]
        | 1945 -> [| 46641;46642 |]
        | 1948 -> [| 47040 |]
        | 1956 -> [| 47153;47459 |]
        | 1726 -> [| 47180;47181 |]
        | 1986 -> [| 47272;47273;47274;47912;47913;47914;47915;47916;47917;47918;47919;47920;47921;47922;47923 |]
        | 1454 -> [| 47276;47277 |]
        | 1962 -> [| 47288 |]
        | 1964 -> [| 47297;47299;47699;47700;47701;47729;47730;47731;47733;47734;47735;47737;47738;47739;47741;47742;47743;47744;47746;47747;47748;47750;47751;47752;47754;47755;47756;47766;47767;47768;47770;47771;47772;47774;47775;47776;47778;47779;47780;47782;47783;47784;47786;47787;47788;47790;47791;47792;47797;47798;47799;47801;47802;47803;47805;47806;47807;47809;47810;47811;47813;47814;47815;47816;47818;47819;47821;47822;47823;47825;47826;47827;47829;47830;47831;47835;47837;47839;47841;47843;47845;48416;48417;48418;48420;48421;48422;48424;48425;48426;48428;48429;48430;48432;48433;48434;48436;48437;48438;49723;49724;49725;49727;49728;49729;49731;49732;49733;49735;49736;49737;49739;49740;49741 |]
        | 1976 -> [| 47300;47301;47302 |]
        | 1974 -> [| 47303 |]
        | 1551 -> [| 47336 |]
        | 1966 -> [| 47352;47353 |]
        | 1967 -> [| 47356;47358 |]
        | 1968 -> [| 47360;47362 |]
        | 1975 -> [| 47378;47379;47381;47382;47384;47385;47387;47388;47390;47391;47393;47402;47403;47404;47405;47406;47407;47409;47410;47412;47413;47414;47415;47416;47417;47418;47419;47420;47421;47422;47423;47424;47425;47426;47427;47428;47671;47672;47673;47674;47675;47676;47677;47678;47679;47936;47937;47938;47939;47940;47941;47942;47943;47944;47945;47946;47947;47948;47964;47965;48920;48921;48922;48960;48963;48968;49104;49105;49106;49107;49110;49418;49557;49558;49559;49560;49561;49562;49615;49691;49757;49758 |]
        | 1971 -> [| 47436;47439;47440;47441;47465;47467;47468;47472;47473;47620 |]
        | 1981 -> [| 47437;47438;47442;47443;47444;47469;47470;48254 |]
        | 1991 -> [| 47458;47833;47834 |]
        | 1973 -> [| 47460;47461;47462;47463;47464;48093;48094 |]
        | 1977 -> [| 47558;47561;47562;47563;47564;47565;47566;47567;47568;47569;47570;47571;47572;47573;47574;47575;47576;47577;47578;47579;47580;47581;47582;47583;47584;47585;47586;47587;47588;47589;47590;47591;47592;47593;47594;47595;47596;47597;47598;47599;47600;47601;47602;47603;47604;47605;47606;47607;47608;47609;47688;47689;47690;47691;47692;47693;47694;47695;47696;47697;48761;48762;48763 |]
        | 1980 -> [| 47656;47657;47658;47659;47660;47661;47662;47663;47664;47665;47666;47667;47668;47669;47670;49616;49617;49618 |]
        | 1978 -> [| 47710;47712;47713 |]
        | 1979 -> [| 47711;47761;47762;47763;47764;47765;47888;47889;47890;47891;47892;47893;47894;47895;47896;47897;47898;47899;47900;47901;47902;47903;47904;47905;47906;47907 |]
        | 1997 -> [| 47847;47848;47849;47850;47851;47852;47853;47854;47855;47856;47857;47858;47859;47860;48253;48262;48263;48264;48265 |]
        | 1983 -> [| 47862;47863;47864;47865;47866 |]
        | 1982 -> [| 47876;47877;47878;47879;47880;47953;47954;47955;47956;47957;47958;47959;47960;48086;48087;48088;48089;48090;48091;48092;48122;48123;48124;48125;48126;48127;48234;48235;48236;48237;48238;48239;48240;48241;48245;48246;48247;48248;48249;48250;48251;48252;48255;48256;48257;48258;48259;48260;48261 |]
        | 1984 -> [| 47881;47882;47883;47884;47979;47980;47981;47982;47983;47984;47985;47986;47987;47988;47989;47990;47991;47992;47993;47994;47995;47996;47997;47998;47999;48000;48001;48002;48003;48004;48005;48006;48007;48008;48009;48010;48011;48012;48013;48014;48015;48016;48017;48018;48019;48020;48021;48022;48023;48024;48025;48026;48027;48028;48029;48030;48031;48032;48033;48034;48035;48036;48037;48038;48039;48040;48041;48042;48043;48044;48045;48046;48047;48048;48049;48050;48051;48052;48053;48054;48055;48056;48057;48058;48059;48060;48061;48062;48063;48064;48065;48066;48067;48068;48069;48070;48071;48072;48073;48074;48075;48076;48077;48078 |]
        | 1987 -> [| 47885;47886;47887;47924;47925;47928;47929;47932;47933 |]
        | 1988 -> [| 47908;47909;47911;49734 |]
        | 1989 -> [| 47926;47927;47930;47931;47934;47935 |]
        | 2009 -> [| 47951;49661;49662;49663;49689;49690 |]
        | 1990 -> [| 47969;47970;47971;47972;47973;47974;48469;48470;48471;48472;48473;48474 |]
        | 1996 -> [| 47975;48080;48112 |]
        | 1992 -> [| 48095;48096 |]
        | 1993 -> [| 48097;48098;48099;48102;48103;48104;48107;48108;48109 |]
        | 1994 -> [| 48100;48101;48105;48106;48110;48111 |]
        | 1895 -> [| 48119;48132;49694;49695 |]
        | 1995 -> [| 48121 |]
        | 1566 -> [| 48128 |]
        | 739 -> [| 48148;48149;48746;48747 |]
        | 1998 -> [| 48270;48271;48272;48273;48274;48275;48276;48277;48278;48279;48280;48281;48282;48283;48284;48285;48286;48287;48288;48289;48290;48291;48292;48293;48294;48295;48296;48297;48298;48299;48300;48301;48302;48303;48304;48305;48306;48307;48308;48309;48310;48311;48312;48313;48314;48315;48316;48317;48318;48319;48320;48321;48322;48323;48324;48325;48326;48327;48328;48329;48330;48331;48332;48333;48334;48335;48336;48337;48338;48339;48340;48341;48342;48343;48344;48345;48346;48347;48348;48349;48350;48351;48352;48353;48354;48355;48356;48357;48358;48359;48360;48361;48362;48363;48364 |]
        | 2001 -> [| 48648 |]
        | 2002 -> [| 48764;48765;48767;48768;48769;48770;48771;48772;48774;48775;48777;48778 |]
        | 2004 -> [| 48780 |]
        | 2003 -> [| 48781 |]
        | 2005 -> [| 48899 |]
        | 2006 -> [| 48916;48917;48918;48919 |]
        | 1452 -> [| 48929;48930;48931;48932 |]
        | 2013 -> [| 48944 |]
        | 1929 -> [| 48969 |]
        | 2008 -> [| 49099 |]
        | 2010 -> [| 49100 |]
        | 1927 -> [| 49699 |]
        | 350858 -> [| 350916;351063;351296;351297;351310;351311;351317;351320;351332;351336;351337;351706;351709;351855;352263;352304;352305;352313;352314;352472;352499;352508;352522;352526;352556;352602;352891;353032;353042;353106;353107;353108;353109;353110;353111;353112;353113;353114;353115;353116;353117;353118;353119;353120;353126;353127;353128;353129;353130;353131;353132;353133;353134;353135;353136;353137;353138;353139;353140;353143;353144;353145;353146;353147;353148;353149;353150;353151;353152;353153;353154;353155;353156;353161;353162;353163;353164;353165;353166;353167;353168;353169;353170;353171;353172;353173;353174;353175;353179;353180;353181;353182;353183;353184;353185;353186;353187;353188;353189;353190;353191;353192;353193;353196;353197;353198;353199;353200;353201;353202;353203;353204;353205;353206;353207;353208;353209;353258;353263;353264;353281;353289;353691;353692;353693;353694;353695;353696;353697;353698;353699;353701;353702;353705;353730;353731;353732;353733;353734;353735;353736;353737;353738;353741;353749;353772;353773;353774;353775;353783;353796;353797;353800;353801;353817;353818;353929;354583;354685;354928;354929;354930;354937;354956;354957;354959;354960;354961;354962;354963;354964;355010;355013;355015;355019;355027;355032;355038;355043;355050;355067;355069;355071;355081;355087;355098;355104;355107;355109;355139;355145;355151;355157;355159;355161;355254;355256;355257;355258;355259;355260;355261;355262;355263;355264;355265;355432;355434;355443;355476;355478;355483;355488;355495;355497;355498;355499;355514;355515;355594;355595;355596;355597;355598;355599;355600;355603;355604;355605;355615;355616;355617;355679;355685;355697;355740;355741;355742;355743;355744;355746;355747;355748;355749;355750;355751;355752;355753;355761;355762;355763;355764;355765;355766;355779;355781;355812;355813;355814;355815;355820;355821;355822;355823;355824;355825;355826;355827;355828;355829;355830;355831;355832;355833;355834;355835;355836;355837;355839;355840;355841;355842;355843;355844;355845;355846;355847;355848;355849;355850;355851;355852;355853;355854;355855;355856;355857;355858;355859;355860;355861;355862;355863;355864;355865;355866;355867;355868;355869;355870;355871;355872;355873;355874;355875;355876;355877;355878;355879;355880;355881;355882;355883;355949;355962;355964;355994;356042;356044;356046;356048;356050;356052;356115;356116;356214;356300;356331;356332;356333;356334;356393;356426;356514;356515;356516;356630;356632;356831;356833;356835;356837;356839;356847;356848;356849;356850;356851;356852;356853;356913;356914;356925;363069;363105;363106;363107;363309;363350;363351;363355;363356;363357;363358;363359;363394;363395;363396;363398;363406;363408;363491;363551;363570;363578;363592;363604;363770;363774;363775;363780;363781;363782;363783;363784;363785;363786;363787;363794;363796;363797;363798;363800;363801;363848;363849;363850;363851;363852;363857;363858;364102;364103;364200;364201;364331;364332;364333;364334;364559;364561;364563;364786;364787;364788;365409;365441;365442;365443;365444;365447;365448;365449;365450;365451;365452;365453;365454;365455;365456;365457;365458;365459;365460;365566;365567;365568;365569;365570;365572;365573;365574;365575;365576;365577;365578;365579;365580;365581;365623;365624;365625;365626;365627;365628;365629;365630;365631;365632;365633;365634;365635;365636;365650;365651;365652;365654;365655;365656;365657;365658;365659;365660;365661;365662;365663;365664;365665;365666;365667;365668;365669;365670;365671;365673;365674;365675;365676;365677;365678;365679;365680;365681;365682;365683;365684;365685;365686;365687;365688;365689;365690;365691;365692;365693;366009;366014;366015;366094;366095;366096;366097;366098;366099;366100;366101;366102;366103;366344;366345;366372;366373;366374;366375;366376;366377;366378;366379;366380;366381;366385;366386;366387;366388;366389;366390;366424;366425;366426;366427;366428;366429;366430;366431;366432;366433;366434;366452;366453;366454;366455;366456;366457;366458;366459;366460;366461;366462;366463;366464;366495;366496;366497;366498;366499;366500;366501;366502;366503;366504;366505;366506;366510;366511;366512;366513;366514;366515;366516;366517;366518;366519;366520;366521;367223;367226;367227;367228;367229;367230;367436;367437;367439;367440;367472;367477;367489;367500;367502;367511;367517;367519;367528;367541;367548;367549;367552;367586;367587;367589;367590;367591;367592;367621;367622;367623;367624;367625;367627;367628;367629;367630;367631;367632;367633;367813;367848;367992;367994;367996;368014;368015;368016;368245;368519;368540;368541;368542;368543;368544;368545;368556;368557;368558;368559;368560;368561;368562;368563;368564;368565;368566;368567;368568;368587;368588;368589;368590;368591;368592;368593;368595;368596;368597;368598;368599;368600;368601;368602;368603;368604;368605;368606;368607;368608;368609;368610;368611;368612;371027 |]
        | 351064 -> [| 351071;352415;352587;352588;352591;352592;352593;352594;352595;352596;352597;352598;352928;352934;352937;352938;352939;352940;352942;352944;353257;353759;353760;353763;353764;353766;353767;353768;353769;353959;353960;353961;353962;353963;353964;353965;353966;353967;353974;353975;353994;354003;354005;354007;354192;354234;354235;354237;354251;354252;354271;354272;354273;354274;354275;354277;354317;354934;354935;354941;355425;355426;355427;355430;355445;355516;355720;355767;355768;355771;356015;356020;356022;356023;356024;356031;356032;356034;356035;356037;356038;356040;356041;356053;356056;356058;356059;356065;356106;356107;356108;356109;356110;356111;356112;356113;356114;356401;356559;356569;356570;356571;356572;356617;356618;356619;356620;356621;356622;356623;356624;356625;356626;356627;356628;356827;356828;356829;356830;356840;363310;363349;363397;363934;363935;363936;363955;363956;363957;363982;363983;363984;364009;364010;364011;364018;364019;364020;364021;364022;364023;364024;364025;364026;364027;364028;364029;364030;364031;364032;364033;364034;364035;364036;364037;364038;364039;364040;364041;364043;364050;364095;364096;364097;364098;364099;364105;364178;364242;364243;364317;364319;364322;364565;364566;364567;364726;364732;364736;364738;364739;364740;364741;364742;364743;364744;364745;364746;364810;364811;364812;364813;364814;364815;364816;364817;364818;364819;364820;364821;364863;364872;364873;364874;364875;364876;364877;364878;364879;364880;364881;364882;364883;364884;364952;364955;364956;365262;365263;365289;365290;365291;365292;365293;365297;365298;365299;365300;365301;365302;365303;365304;365305;365306;365307;365308;365309;365310;365311;365312;365313;365314;365315;365316;365317;365318;365319;365320;365321;365322;365323;365324;365325;365326;365421;365694;365695;365696;365697;365698;365699;365700;365701;365702;365703;365704;365705;365706;365707;365708;365709;365710;365711;365712;365713;365714;365715;365716;365717;365718;365719;365720;365721;365722;365723;365724;365725;365726;365727;365728;365729;365928;365930;365932;365934;365936;365938;365940;365942;365971;365972;365973;365974;365975;365976;365993;365994;366336;366337;366338;366339;366340;366341;366342;366343;366346;366363;366364;366365;366366;366367;366368;366369;366370;366371;366412;366413;366414;366415;366416;366417;366418;366419;366420;366421;366422;366423;366443;366444;366445;366446;366447;366448;366449;366450;366451;366489;366490;366491;366492;366493;366494;366677;366678;366679;366680;366681;366682;366683;366684;366685;366686;366687;366688;366689;366690;366691;366695;366696;366697;366698;366699;366700;366710;366711;366712;366713;366714;366715;366716;366717;366718;366719;366720;366721;366722;366723;366724;366732;366733;366734;366735;366736;366737;367442;367443;367450;367451;367453;367455;367456;367457;367607;367634;367650;367651;367652;367653;367654;367655;367656;367657;367658;367716;367738;367742;367751;367760;367885;367895;367896;367897;367898;367899;367900;368061;368062;368064;368065;368066;368067;368069;368071;368524;368548;368549;368550;368551;368552;368553;368554;368555;368574;368576;368577;368579;368580;368581;368582;368583;368584;368585;368586;368594;368614;368615;368616;368617;368618;368619;368620;368631;368632;368633;368634;368635;368636;368638;368640;368647;368649;368650;368651;368908;368909;368910;368911;368912;368913;368914;368915;369408;369409;369410;369411;369412;369413;369414;369415;369416;369417;369418;369419;369420;369421;369422;369423;369424;369425;369426;369427;369438;369439;369440;369441;369442;369443;369451;369452;369453;369469;369470;369471;369472;369475;369476;369477;369478;369479;369480;369481;369482;369507;369508;369509;369510;369511;369512;369513;369514;369515;369516;369517;369518;369539;369540;369541;369542;369543;369544;369545;369546;369547;369548;369549;369550 |]
        | 351210 -> [| 351252;351253;351278;351321;351352;351354;351355;351824;353089;353486;353808;353832;353879;353881;353884;353886;353900;353904;354741;354742;354927;355249;355250;355374;355423;355424;355470;355471;355472;355473;355474;355475;355479;355772;356068;356069;356072;356073;356075;356077;356207;356211;356841;356842;356871;356872;356873;356874;356875;356876;356909;363354;364121;364171;364172;364246;364247;364344;364348;364355;364369;364378;364380;364490;365364;365420;365428;365943;365944;365945;366382;366383;366384;366507;366508;366509;368518;368531;368532;368533;368534;368537;368539;368546;368547;368880;368881;368882;368884;368885;368887;368888;368889;368890;368891 |]
        | 351121 -> [| 351610;351611;351614;351615;351620;351630;351631;351632;351633;351669;351670;351671;351673;351674;351675;351679;351680;351681;351684;351686;351687;351688;351689;351690;351696;351697;351698;351699;351700;351701;351732;351865;351905;351906;351907;351908;351909;351910;352017;352018;352019;352020;352021;352022;352032;352034;352035;352041;352042;352043;352045;352046;352047;352048;352049;352050;352051;352052;352057;352067;352068;352069;352070;352071;352072;352073;352074;352076;352077;352078;352079;352083;352089;352101;352108;352221;352274;352277;352279;352293;352536;352537;352538;352550;352604;352687;352929;353041;353283;353284;353285;353742;353743;353744;353907;353919;353931;353932;353933;353934;353935;353936;353980;353981;353982;353983;353984;353985;353986;353987;353988;353989;353990;353991;353992;354011;354012;354122;354123;354124;354125;354126;354127;354128;354129;354130;354131;354132;354133;354134;354135;354140;354141;354142;354147;354148;354149;354150;354151;354152;354153;354154;354155;354156;354158;354159;354160;354169;354170;354171;354172;354173;354174;354175;354176;354177;354178;354179;354180;354181;354182;354183;354184;354185;354186;354187;354188;354264;354265;354266;354267;354667;354669;354867;354869;354870;354903;354904;354905;354906;354907;354908;354912;354913;354914;354915;354916;354917;354918;354919;354921;354922;354923;354924;354926;355294;355297;355299;355308;355329;355331;355332;355375;355402;355403;355404;355405;355406;355407;355408;355409;355411;355412;355413;355414;355415;355416;355421;355422;355442;355517;355518;355519;355520;355521;355523;355526;355527;355528;355532;355533;355534;355535;355536;355537;355566;355567;355568;355569;355570;355571;355582;355583;355584;355585;355586;355587;355591;355607;355610;355611;355613;355614;355785;355786;355787;355788;355789;355790;355791;355792;355793;355798;355799;355800;355801;355802;355803;355804;355805;355807;355808;355809;355810;355811;355894;355895;355896;355897;355898;355903;355904;355905;355906;355908;355909;355910;355927;355928;355929;355930;355931;356416;356471;356473;356495;356496;356497;356498;356499;356500;356526;356562;356563;356564;356565;356566;356567;356590;356591;356593;356594;356629;356703;356704;356705;356707;356708;356711;356788;356789;356790;356791;356792;356793;356794;356795;356796;356797;356798;356799;356800;356801;356802;356803;356804;356805;356854;356855;356857;356858;356859;356860;356861;356862;356863;356864;356865;356866;356867;356868;356869;356870;363096;363388;363389;363390;363405;364173;364174;364175;364176;364177;364245;364248;364249;364250;364506;365200;365229;365230;365231;365233;365234;365235;365237;365238;365239;365240;365241;365242;365243;365252;365253;365254;365255;365256;365294;365295;365296;365351;365352;365353;365360;365361;365362;365424;365777;365778;365779;365783;365784;365785;365786;365787;365788;365902;365903;365904;365905;365906;365907;365908;365952;365956;366289;366290;366291;366292;366293;366294;366295;366296;366297;366298;366299;366300;366301;366302;366303;366304;366305;366306;366307;366308;366309;366310;366311;366312;366313;366314;366315;366316;366317;366318;366319;366320;366321;366322;366323;366324;366391;366392;366393;366394;366395;366396;366397;366398;366399;366400;366401;366402;366403;366404;366405;366406;366407;366408;366435;366436;366437;366438;366439;366440;366465;366466;366467;366468;366469;366470;366471;366472;366473;366474;366475;366476;366477;366478;366479;366480;366481;366482;366522;366523;366524;368777;368893;368894;368895;368898;368899;368900 |]
        | 351844 -> [| 351858;351915;351916;352493;353213;353214;353215;353216;353217;353218;353219;353220;353222;353223;353224;353225;353229;353230;353231;353232;353233;353234;353235;353236;353237;353238;353239;353240;353244;353245;353246;353247;353248;353249;353250;353251;353252;353253;353254;353255;353256;353748;354106;354107;354108;354626;354627;354664;354714;354884;355266;355267;355268;355269;355270;355271;355428;355435;355508;355577;356305;356306;356709;356710;356819;356843;356844;356845;356846;356877;356878;356882;356883;356900;356901;356918;357011;357018;363400;363409;363410;363411;363412;364408;364409;364410;364411;364412;364413;364414;364564;364781;364782;364783;364784;364785;364789;364790;364791;366004;366104;366105;366106;366107;366108;366409;366410;366411;366441;366442;366483;366484;366485;366486;366487;366488;366525;366526;366527;366528;366529;366530;366532;366534;366749;366750;366751;368242;368243;368244;369211;370658 |]
        | 351648 -> [| 352887;352888;352890;353317;353318;353322;353323;353326;353327;353330;353331;353335;353336;353352;353353;353357;353363;353365;353366;353368;353369;353370;353371;353372;353373;353375;353376;353377;353378;353379;353381;353382;353386;353387;353388;353389;353390;353391;353399;353405;353408;353413;353426;353427;353428;353435;353436;353437;353438;353440;353441;353443;353444;353445;353446;353447;353448;353449;353450;353451;353452;353453;353454;353455;353456;353457;353458;353459;353460;353461;353462;353463;353464;353465;353466;353467;353468;353469;353470;353471;353472;353473;353474;353475;353476;353477;353478;353479;353482;353484;353485;353685;353686;353687;355212;355213;355280;355932;356658;356701;356724;356725;356915;363360;363362;363788;363789;363861;363862;364519;364520;364521;364531;364532;364533;364534;364555;364556;364570;364571;364573;364575;364576;364578;364579;364580;364581;364594;364595;364596;364597;364598;364599;364600;364601;364602;364603;364604;364605;364606;364607;364608;364609;364610;364611;364612;364613;364614;364615;364616;364617;364618;364633;364639;364640;364641;364656;364658;364659;364661;364662;364663;364664;364665;364666;364667;364668;364669;364670;364671;364672;364673;364674;364675;364676;364677;364678;364679;364680;364681;364682;364683;364684;364685;364686;364687;364688;364689;364690;364691;364692;364693;364694;364695;364696;364697;364698;364699;364700;364701;364702;364703;364704;364705;364706;364707;364708;364709;364747;364748;364749;364750;364751;364761;364763;364769;364773;364775;364776;364777;364916;364918;364919;364920;364921;364922;364933;364935;364943;364945;365386;365388;365389;365391;365392;365393;365395;365396;365397;365399;365400;365401;365404;365405;365406;365407;365408;365832;365844;365845;365848;365850;365851;365853;365854;365855;365857;365859;365860;365861;365864;365865;365866;365868;365870;365872;365873;365875;365876;365877;365878;365879;365893;366228;366587;366589;366590;366591;366592;366595;366596;366597;366598;366599;366600;366760;367382 |]
        | 354641 -> [| 354643;354644;355210;355217;355218;355219;355558;355561;355976;355977;355978;355979;364094;364101;364471;364472;364477;364478;364479;365433;365434;365435;365446;365909;365912;365913;365914;365915;365916;365917;365918;365919;365920;365921;365922;365923;365924;365925;365926;366022;366023;366024;366025;366229;366230;366231;366232;366233;366234;366235;366236;366237;366238;366239;366240;366241;366242;366243;366244;366245;366246;366247;366248;366249;366250;366251;366252;369233 |]
        | 354753 -> [| 354764;354765;354767;354770;354772;354773;354789;354790;354791;354792;354793;354794;354796;354797;354824;354826;354827;354850;354851;354852;354856;354857;354858;354859;354894;354949;354958;355198;355199;355201;355325;355326;355327;355438;355439;355721;355722;355723;355724;356012;356322;356335;356336;356337;357007;357009 |]
        | 364204 -> [| 364205;364206;364207 |]
        | 368656 -> [| 366967;366968;366969;366970;366971 |]
        | 367487 -> [| 367499;367596;367597;367598;367843;367845 |]
        | 367580 -> [| 367578 |]
        | 367594 -> [| 367600;367677;367679;367681;367685;367687;367689;367691;367693;367695;367697;367699;367701;367703;367705;367707;367709;367711;367713;367715;367811;367854;367856;367863;367864;367948;367955;367959;367960;367963;367987;367988;367989;367998;367999;368000;368001;368003;368022;368023;368024;368025;368026 |]
        | 367774 -> [| 367765;367768 |]
        | 367776 -> [| 367770;367777;367778;367779 |]
        | 368666 -> [| 368497 |]
        | 368726 -> [| 368725;368755;368756;368776;368951;369091;369092;369093;369094;369102;369103;369104;369105;369106;369107;369108;369109;369113;369114;369115;369116;369158;369159;369160;369161;369162;369163;369164;369165;369166;369167;369168;369180;369200;369203;369204;369205;369206;369242;369243;369244;369245;369246;369247;369248;369249;369250;369251;369252;369253;369254;369255;369256;369257;369258;369259;369260;369261;369262;369263;369264;369265;369266;369267;369268;369269;369270;369271;369272;369273;369274;369275;369276;369277;369278;369279;369280;369281;369282;369290;369291;369292;369293;369294;369295;369296;369297;369302;369303;369304;369305;369434;369435;370308;370488 |]
        | _ -> [||]
