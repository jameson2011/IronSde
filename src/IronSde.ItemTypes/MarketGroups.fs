namespace IronSde.ItemTypes
open IronSde
open IronSde.Types
module internal MarketGroups=
    let private marketGroup2()= {MarketGroupData.id = 2; parentId = None; name = "Blueprints & Reactions"; }
    let private marketGroup4()= {MarketGroupData.id = 4; parentId = None; name = "Ships"; }
    let private marketGroup9()= {MarketGroupData.id = 9; parentId = None; name = "Ship Equipment"; }
    let private marketGroup10()= {MarketGroupData.id = 10; parentId = Some 9; name = "Turrets & Bays"; }
    let private marketGroup11()= {MarketGroupData.id = 11; parentId = None; name = "Ammunition & Charges"; }
    let private marketGroup14()= {MarketGroupData.id = 14; parentId = Some 9; name = "Hull & Armor"; }
    let private marketGroup19()= {MarketGroupData.id = 19; parentId = None; name = "Trade Goods"; }
    let private marketGroup24()= {MarketGroupData.id = 24; parentId = None; name = "Implants & Boosters"; }
    let private marketGroup27()= {MarketGroupData.id = 27; parentId = Some 24; name = "Implants"; }
    let private marketGroup52()= {MarketGroupData.id = 52; parentId = Some 9; name = "Propulsion"; }
    let private marketGroup54()= {MarketGroupData.id = 54; parentId = Some 1031; name = "Standard Ores"; }
    let private marketGroup86()= {MarketGroupData.id = 86; parentId = Some 10; name = "Hybrid Turrets"; }
    let private marketGroup87()= {MarketGroupData.id = 87; parentId = Some 10; name = "Projectile Turrets"; }
    let private marketGroup88()= {MarketGroupData.id = 88; parentId = Some 10; name = "Energy Turrets"; }
    let private marketGroup99()= {MarketGroupData.id = 99; parentId = Some 11; name = "Projectile Ammo"; }
    let private marketGroup100()= {MarketGroupData.id = 100; parentId = Some 11; name = "Hybrid Charges"; }
    let private marketGroup101()= {MarketGroupData.id = 101; parentId = Some 11; name = "Frequency Crystals"; }
    let private marketGroup114()= {MarketGroupData.id = 114; parentId = Some 11; name = "Missiles"; }
    let private marketGroup115()= {MarketGroupData.id = 115; parentId = Some 114; name = "Auto-Targeting"; }
    let private marketGroup117()= {MarketGroupData.id = 117; parentId = Some 114; name = "Light Missiles"; }
    let private marketGroup118()= {MarketGroupData.id = 118; parentId = Some 114; name = "Rockets"; }
    let private marketGroup128()= {MarketGroupData.id = 128; parentId = Some 554; name = "Remote Shield Boosters"; }
    let private marketGroup132()= {MarketGroupData.id = 132; parentId = Some 52; name = "Propulsion Upgrades"; }
    let private marketGroup134()= {MarketGroupData.id = 134; parentId = Some 14; name = "Armor Repairers"; }
    let private marketGroup140()= {MarketGroupData.id = 140; parentId = Some 10; name = "Missile Launchers"; }
    let private marketGroup141()= {MarketGroupData.id = 141; parentId = Some 9; name = "Smartbombs"; }
    let private marketGroup150()= {MarketGroupData.id = 150; parentId = None; name = "Skills"; }
    let private marketGroup157()= {MarketGroupData.id = 157; parentId = None; name = "Drones"; }
    let private marketGroup159()= {MarketGroupData.id = 159; parentId = Some 157; name = "Combat Drones"; }
    let private marketGroup204()= {MarketGroupData.id = 204; parentId = Some 2; name = "Ships"; }
    let private marketGroup205()= {MarketGroupData.id = 205; parentId = Some 204; name = "Frigates"; }
    let private marketGroup206()= {MarketGroupData.id = 206; parentId = Some 204; name = "Cruisers"; }
    let private marketGroup207()= {MarketGroupData.id = 207; parentId = Some 204; name = "Battleships"; }
    let private marketGroup208()= {MarketGroupData.id = 208; parentId = Some 204; name = "Industrial Ships"; }
    let private marketGroup209()= {MarketGroupData.id = 209; parentId = Some 2; name = "Ship Equipment"; }
    let private marketGroup210()= {MarketGroupData.id = 210; parentId = Some 209; name = "Turrets & Bays"; }
    let private marketGroup214()= {MarketGroupData.id = 214; parentId = Some 209; name = "Hull & Armor"; }
    let private marketGroup252()= {MarketGroupData.id = 252; parentId = Some 209; name = "Propulsion"; }
    let private marketGroup286()= {MarketGroupData.id = 286; parentId = Some 210; name = "Hybrid Turrets"; }
    let private marketGroup287()= {MarketGroupData.id = 287; parentId = Some 210; name = "Projectile Turrets"; }
    let private marketGroup288()= {MarketGroupData.id = 288; parentId = Some 210; name = "Energy Turrets"; }
    let private marketGroup299()= {MarketGroupData.id = 299; parentId = Some 211; name = "Projectile Ammo"; }
    let private marketGroup300()= {MarketGroupData.id = 300; parentId = Some 211; name = "Hybrid Charges"; }
    let private marketGroup301()= {MarketGroupData.id = 301; parentId = Some 211; name = "Frequency Crystals"; }
    let private marketGroup314()= {MarketGroupData.id = 314; parentId = Some 211; name = "Missiles"; }
    let private marketGroup387()= {MarketGroupData.id = 387; parentId = Some 114; name = "Torpedoes"; }
    let private marketGroup391()= {MarketGroupData.id = 391; parentId = Some 4; name = "Shuttles"; }
    let private marketGroup408()= {MarketGroupData.id = 408; parentId = Some 204; name = "Interceptors"; }
    let private marketGroup414()= {MarketGroupData.id = 414; parentId = Some 204; name = "Shuttles"; }
    let private marketGroup419()= {MarketGroupData.id = 419; parentId = Some 204; name = "Covert Ops"; }
    let private marketGroup442()= {MarketGroupData.id = 442; parentId = Some 204; name = "Logistics"; }
    let private marketGroup453()= {MarketGroupData.id = 453; parentId = Some 204; name = "Heavy Assault Cruisers"; }
    let private marketGroup458()= {MarketGroupData.id = 458; parentId = Some 204; name = "Assault Frigates"; }
    let private marketGroup475()= {MarketGroupData.id = 475; parentId = None; name = "Manufacture & Research"; }
    let private marketGroup496()= {MarketGroupData.id = 496; parentId = Some 204; name = "Mining Barges"; }
    let private marketGroup531()= {MarketGroupData.id = 531; parentId = Some 27; name = "Skill Hardwiring"; }
    let private marketGroup532()= {MarketGroupData.id = 532; parentId = Some 27; name = "Attribute Enhancers"; }
    let private marketGroup533()= {MarketGroupData.id = 533; parentId = Some 475; name = "Materials"; }
    let private marketGroup537()= {MarketGroupData.id = 537; parentId = Some 14; name = "Remote Armor Repairers"; }
    let private marketGroup538()= {MarketGroupData.id = 538; parentId = Some 14; name = "Hull Repairers"; }
    let private marketGroup551()= {MarketGroupData.id = 551; parentId = Some 554; name = "Shield Extenders"; }
    let private marketGroup552()= {MarketGroupData.id = 552; parentId = Some 554; name = "Shield Boosters"; }
    let private marketGroup554()= {MarketGroupData.id = 554; parentId = Some 9; name = "Shield"; }
    let private marketGroup555()= {MarketGroupData.id = 555; parentId = Some 86; name = "Railguns"; }
    let private marketGroup556()= {MarketGroupData.id = 556; parentId = Some 86; name = "Blasters"; }
    let private marketGroup557()= {MarketGroupData.id = 557; parentId = Some 88; name = "Beam Lasers"; }
    let private marketGroup558()= {MarketGroupData.id = 558; parentId = Some 88; name = "Pulse Lasers"; }
    let private marketGroup559()= {MarketGroupData.id = 559; parentId = Some 87; name = "Autocannons"; }
    let private marketGroup560()= {MarketGroupData.id = 560; parentId = Some 87; name = "Artillery Cannons"; }
    let private marketGroup580()= {MarketGroupData.id = 580; parentId = Some 114; name = "Cruise Missiles"; }
    let private marketGroup581()= {MarketGroupData.id = 581; parentId = Some 114; name = "Heavy Missiles"; }
    let private marketGroup582()= {MarketGroupData.id = 582; parentId = Some 204; name = "Destroyers"; }
    let private marketGroup588()= {MarketGroupData.id = 588; parentId = Some 204; name = "Battlecruisers"; }
    let private marketGroup614()= {MarketGroupData.id = 614; parentId = Some 19; name = "Criminal Evidence"; }
    let private marketGroup616()= {MarketGroupData.id = 616; parentId = Some 19; name = "Insignias"; }
    let private marketGroup634()= {MarketGroupData.id = 634; parentId = Some 204; name = "Transport Ships"; }
    let private marketGroup655()= {MarketGroupData.id = 655; parentId = Some 9; name = "Engineering Equipment"; }
    let private marketGroup656()= {MarketGroupData.id = 656; parentId = Some 9; name = "Electronics and Sensor Upgrades"; }
    let private marketGroup657()= {MarketGroupData.id = 657; parentId = Some 9; name = "Electronic Warfare"; }
    let private marketGroup662()= {MarketGroupData.id = 662; parentId = Some 655; name = "Energy Nosferatu"; }
    let private marketGroup663()= {MarketGroupData.id = 663; parentId = Some 655; name = "Remote Capacitor Transmitters"; }
    let private marketGroup664()= {MarketGroupData.id = 664; parentId = Some 655; name = "Capacitor Batteries"; }
    let private marketGroup668()= {MarketGroupData.id = 668; parentId = Some 655; name = "Capacitor Boosters"; }
    let private marketGroup677()= {MarketGroupData.id = 677; parentId = Some 657; name = "Electronic Counter Measures"; }
    let private marketGroup681()= {MarketGroupData.id = 681; parentId = Some 657; name = "Sensor Backup Arrays"; }
    let private marketGroup685()= {MarketGroupData.id = 685; parentId = Some 657; name = "ECCM"; }
    let private marketGroup739()= {MarketGroupData.id = 739; parentId = Some 19; name = "Criminal Dog Tags"; }
    let private marketGroup751()= {MarketGroupData.id = 751; parentId = Some 614; name = "Overseer's Personal Effects"; }
    let private marketGroup752()= {MarketGroupData.id = 752; parentId = Some 614; name = "Criminal DNA Patterns"; }
    let private marketGroup782()= {MarketGroupData.id = 782; parentId = Some 204; name = "Dreadnoughts"; }
    let private marketGroup787()= {MarketGroupData.id = 787; parentId = Some 204; name = "Freighters"; }
    let private marketGroup845()= {MarketGroupData.id = 845; parentId = Some 99; name = "Standard Ammo"; }
    let private marketGroup846()= {MarketGroupData.id = 846; parentId = Some 99; name = "Advanced Artillery Ammo"; }
    let private marketGroup847()= {MarketGroupData.id = 847; parentId = Some 99; name = "Advanced Autocannon Ammo"; }
    let private marketGroup848()= {MarketGroupData.id = 848; parentId = Some 100; name = "Standard Charges"; }
    let private marketGroup849()= {MarketGroupData.id = 849; parentId = Some 100; name = "Advanced Blaster Charges"; }
    let private marketGroup850()= {MarketGroupData.id = 850; parentId = Some 100; name = "Advanced Railgun Charges"; }
    let private marketGroup852()= {MarketGroupData.id = 852; parentId = Some 101; name = "Advanced Beam Laser Crystals"; }
    let private marketGroup853()= {MarketGroupData.id = 853; parentId = Some 101; name = "Advanced Pulse Laser Crystals"; }
    let private marketGroup878()= {MarketGroupData.id = 878; parentId = Some 204; name = "Titans"; }
    let private marketGroup879()= {MarketGroupData.id = 879; parentId = Some 204; name = "Carriers"; }
    let private marketGroup880()= {MarketGroupData.id = 880; parentId = Some 204; name = "Interdictors"; }
    let private marketGroup881()= {MarketGroupData.id = 881; parentId = Some 204; name = "Command Ships"; }
    let private marketGroup882()= {MarketGroupData.id = 882; parentId = Some 204; name = "Recon Ships"; }
    let private marketGroup943()= {MarketGroupData.id = 943; parentId = Some 2; name = "Ship Modifications"; }
    let private marketGroup968()= {MarketGroupData.id = 968; parentId = Some 114; name = "Heavy Assault Missiles"; }
    let private marketGroup986()= {MarketGroupData.id = 986; parentId = Some 99; name = "Faction Ammo"; }
    let private marketGroup1041()= {MarketGroupData.id = 1041; parentId = Some 2; name = "Manufacture & Research"; }
    let private marketGroup1018()= {MarketGroupData.id = 1018; parentId = Some 14; name = "Remote Hull Repairers"; }
    let private marketGroup990()= {MarketGroupData.id = 990; parentId = Some 100; name = "Faction Charges"; }
    let private marketGroup851()= {MarketGroupData.id = 851; parentId = Some 101; name = "Standard Crystals"; }
    let private marketGroup994()= {MarketGroupData.id = 994; parentId = Some 101; name = "Faction Crystals"; }
    let private marketGroup1031()= {MarketGroupData.id = 1031; parentId = Some 533; name = "Raw Materials"; }
    let private marketGroup1034()= {MarketGroupData.id = 1034; parentId = Some 533; name = "Reaction Materials"; }
    let private marketGroup1035()= {MarketGroupData.id = 1035; parentId = Some 475; name = "Components"; }
    let private marketGroup1021()= {MarketGroupData.id = 1021; parentId = Some 1035; name = "Outpost Components"; }
    let private marketGroup1111()= {MarketGroupData.id = 1111; parentId = Some 955; name = "Rigs"; }
    let private marketGroup505()= {MarketGroupData.id = 505; parentId = Some 114; name = "XL Torpedoes"; }
    let private marketGroup135()= {MarketGroupData.id = 135; parentId = Some 14; name = "Hull Upgrades"; }
    let private marketGroup120()= {MarketGroupData.id = 120; parentId = Some 11; name = "Probes"; }
    let private marketGroup944()= {MarketGroupData.id = 944; parentId = Some 943; name = "Armor Rigs"; }
    let private marketGroup956()= {MarketGroupData.id = 956; parentId = Some 1111; name = "Armor Rigs"; }
    let private marketGroup957()= {MarketGroupData.id = 957; parentId = Some 1111; name = "Astronautic Rigs"; }
    let private marketGroup958()= {MarketGroupData.id = 958; parentId = Some 1111; name = "Drone Rigs"; }
    let private marketGroup960()= {MarketGroupData.id = 960; parentId = Some 1111; name = "Electronics Superiority Rigs"; }
    let private marketGroup961()= {MarketGroupData.id = 961; parentId = Some 1111; name = "Engineering Rigs"; }
    let private marketGroup962()= {MarketGroupData.id = 962; parentId = Some 1111; name = "Energy Weapon Rigs"; }
    let private marketGroup963()= {MarketGroupData.id = 963; parentId = Some 1111; name = "Hybrid Weapon Rigs"; }
    let private marketGroup964()= {MarketGroupData.id = 964; parentId = Some 1111; name = "Missile Launcher Rigs"; }
    let private marketGroup965()= {MarketGroupData.id = 965; parentId = Some 1111; name = "Shield Rigs"; }
    let private marketGroup979()= {MarketGroupData.id = 979; parentId = Some 1111; name = "Projectile Weapon Rigs"; }
    let private marketGroup945()= {MarketGroupData.id = 945; parentId = Some 943; name = "Astronautic Rigs"; }
    let private marketGroup946()= {MarketGroupData.id = 946; parentId = Some 943; name = "Drone Rigs"; }
    let private marketGroup948()= {MarketGroupData.id = 948; parentId = Some 943; name = "Electronics Superiority Rigs"; }
    let private marketGroup949()= {MarketGroupData.id = 949; parentId = Some 943; name = "Engineering Rigs"; }
    let private marketGroup950()= {MarketGroupData.id = 950; parentId = Some 943; name = "Energy Weapon Rigs"; }
    let private marketGroup951()= {MarketGroupData.id = 951; parentId = Some 943; name = "Hybrid Weapon Rigs"; }
    let private marketGroup952()= {MarketGroupData.id = 952; parentId = Some 943; name = "Missile Launcher Rigs"; }
    let private marketGroup954()= {MarketGroupData.id = 954; parentId = Some 943; name = "Shield Rigs"; }
    let private marketGroup477()= {MarketGroupData.id = 477; parentId = None; name = "Structures"; }
    let private marketGroup1276()= {MarketGroupData.id = 1276; parentId = Some 1272; name = "Infrastructure Upgrades"; }
    let private marketGroup953()= {MarketGroupData.id = 953; parentId = Some 943; name = "Projectile Weapon Rigs"; }
    let private marketGroup1320()= {MarketGroupData.id = 1320; parentId = None; name = "Planetary Infrastructure"; }
    let private marketGroup5()= {MarketGroupData.id = 5; parentId = Some 1361; name = "Standard Frigates"; }
    let private marketGroup432()= {MarketGroupData.id = 432; parentId = Some 1364; name = "Assault Frigates"; }
    let private marketGroup1065()= {MarketGroupData.id = 1065; parentId = Some 1364; name = "Electronic Attack Frigates"; }
    let private marketGroup420()= {MarketGroupData.id = 420; parentId = Some 1364; name = "Covert Ops"; }
    let private marketGroup399()= {MarketGroupData.id = 399; parentId = Some 1364; name = "Interceptors"; }
    let private marketGroup6()= {MarketGroupData.id = 6; parentId = Some 1367; name = "Standard Cruisers"; }
    let private marketGroup1070()= {MarketGroupData.id = 1070; parentId = Some 1368; name = "Heavy Interdiction Cruisers"; }
    let private marketGroup824()= {MarketGroupData.id = 824; parentId = Some 1368; name = "Recon Ships"; }
    let private marketGroup448()= {MarketGroupData.id = 448; parentId = Some 1368; name = "Heavy Assault Cruisers"; }
    let private marketGroup437()= {MarketGroupData.id = 437; parentId = Some 1368; name = "Logistics"; }
    let private marketGroup464()= {MarketGroupData.id = 464; parentId = Some 1372; name = "Standard Destroyers"; }
    let private marketGroup469()= {MarketGroupData.id = 469; parentId = Some 1374; name = "Standard Battlecruisers"; }
    let private marketGroup822()= {MarketGroupData.id = 822; parentId = Some 1375; name = "Command Ships"; }
    let private marketGroup7()= {MarketGroupData.id = 7; parentId = Some 1376; name = "Standard Battleships"; }
    let private marketGroup1080()= {MarketGroupData.id = 1080; parentId = Some 1377; name = "Marauders"; }
    let private marketGroup1075()= {MarketGroupData.id = 1075; parentId = Some 1377; name = "Black Ops"; }
    let private marketGroup817()= {MarketGroupData.id = 817; parentId = Some 1381; name = "Carriers"; }
    let private marketGroup1089()= {MarketGroupData.id = 1089; parentId = Some 1381; name = "Jump Freighters"; }
    let private marketGroup812()= {MarketGroupData.id = 812; parentId = Some 1381; name = "Titans"; }
    let private marketGroup761()= {MarketGroupData.id = 761; parentId = Some 1381; name = "Dreadnoughts"; }
    let private marketGroup1047()= {MarketGroupData.id = 1047; parentId = Some 1381; name = "Capital Industrial Ships"; }
    let private marketGroup766()= {MarketGroupData.id = 766; parentId = Some 1381; name = "Freighters"; }
    let private marketGroup8()= {MarketGroupData.id = 8; parentId = Some 1382; name = "Standard Industrial Ships"; }
    let private marketGroup629()= {MarketGroupData.id = 629; parentId = Some 1385; name = "Transport Ships"; }
    let private marketGroup1332()= {MarketGroupData.id = 1332; parentId = Some 533; name = "Planetary Materials"; }
    let private marketGroup661()= {MarketGroupData.id = 661; parentId = Some 655; name = "Energy Neutralizers"; }
    let private marketGroup1396()= {MarketGroupData.id = 1396; parentId = None; name = "Apparel"; }
    let private marketGroup1397()= {MarketGroupData.id = 1397; parentId = Some 1396; name = "Men's Clothing"; }
    let private marketGroup1402()= {MarketGroupData.id = 1402; parentId = Some 1396; name = "Women's Clothing"; }
    let private marketGroup1407()= {MarketGroupData.id = 1407; parentId = Some 1396; name = "Accessories"; }
    let private marketGroup883()= {MarketGroupData.id = 883; parentId = Some 204; name = "Exhumers"; }
    let private marketGroup1045()= {MarketGroupData.id = 1045; parentId = Some 204; name = "Capital Industrial Ships"; }
    let private marketGroup1338()= {MarketGroupData.id = 1338; parentId = Some 2; name = "Structures"; }
    let private marketGroup1361()= {MarketGroupData.id = 1361; parentId = Some 4; name = "Frigates"; }
    let private marketGroup1362()= {MarketGroupData.id = 1362; parentId = Some 1361; name = "Faction Frigates"; }
    let private marketGroup1364()= {MarketGroupData.id = 1364; parentId = Some 1361; name = "Advanced Frigates"; }
    let private marketGroup1367()= {MarketGroupData.id = 1367; parentId = Some 4; name = "Cruisers"; }
    let private marketGroup1368()= {MarketGroupData.id = 1368; parentId = Some 1367; name = "Advanced Cruisers"; }
    let private marketGroup1138()= {MarketGroupData.id = 1138; parentId = Some 1368; name = "Strategic Cruisers"; }
    let private marketGroup1369()= {MarketGroupData.id = 1369; parentId = Some 1367; name = "Faction Cruisers"; }
    let private marketGroup1372()= {MarketGroupData.id = 1372; parentId = Some 4; name = "Destroyers"; }
    let private marketGroup1373()= {MarketGroupData.id = 1373; parentId = Some 1372; name = "Advanced Destroyers"; }
    let private marketGroup823()= {MarketGroupData.id = 823; parentId = Some 1373; name = "Interdictors"; }
    let private marketGroup1374()= {MarketGroupData.id = 1374; parentId = Some 4; name = "Battlecruisers"; }
    let private marketGroup1375()= {MarketGroupData.id = 1375; parentId = Some 1374; name = "Advanced Battlecruisers"; }
    let private marketGroup1376()= {MarketGroupData.id = 1376; parentId = Some 4; name = "Battleships"; }
    let private marketGroup1377()= {MarketGroupData.id = 1377; parentId = Some 1376; name = "Advanced Battleships"; }
    let private marketGroup1378()= {MarketGroupData.id = 1378; parentId = Some 1376; name = "Faction Battleships"; }
    let private marketGroup1381()= {MarketGroupData.id = 1381; parentId = Some 4; name = "Capital Ships"; }
    let private marketGroup1382()= {MarketGroupData.id = 1382; parentId = Some 4; name = "Industrial Ships"; }
    let private marketGroup1385()= {MarketGroupData.id = 1385; parentId = Some 1382; name = "Advanced Industrial Ships"; }
    let private marketGroup1384()= {MarketGroupData.id = 1384; parentId = Some 4; name = "Mining Barges"; }
    let private marketGroup1316()= {MarketGroupData.id = 1316; parentId = Some 114; name = "XL Cruise Missiles"; }
    let private marketGroup1285()= {MarketGroupData.id = 1285; parentId = Some 477; name = "Starbase Structures"; }
    let private marketGroup1272()= {MarketGroupData.id = 1272; parentId = Some 477; name = "Sovereignty Structures"; }
    let private marketGroup955()= {MarketGroupData.id = 955; parentId = None; name = "Ship Modifications"; }
    let private marketGroup1112()= {MarketGroupData.id = 1112; parentId = Some 955; name = "Subsystems"; }
    let private marketGroup1322()= {MarketGroupData.id = 1322; parentId = Some 1320; name = "Command Centers"; }
    let private marketGroup350001()= {MarketGroupData.id = 350001; parentId = None; name = "Infantry Gear"; }
    let private marketGroup353562()= {MarketGroupData.id = 353562; parentId = Some 350001; name = "Dropsuits and Gear"; }
    let private marketGroup353566()= {MarketGroupData.id = 353566; parentId = Some 350001; name = "Vehicles and Gear"; }
    let private marketGroup355449()= {MarketGroupData.id = 355449; parentId = Some 350001; name = "Militia Gear"; }
    let private marketGroup1427()= {MarketGroupData.id = 1427; parentId = Some 19; name = "Aurum Tokens"; }
    let private marketGroup1469()= {MarketGroupData.id = 1469; parentId = Some 531; name = "Armor Implants"; }
    let private marketGroup1470()= {MarketGroupData.id = 1470; parentId = Some 531; name = "Electronic Systems Implants"; }
    let private marketGroup1471()= {MarketGroupData.id = 1471; parentId = Some 531; name = "Engineering Implants"; }
    let private marketGroup1472()= {MarketGroupData.id = 1472; parentId = Some 531; name = "Faction Omega Implants"; }
    let private marketGroup1473()= {MarketGroupData.id = 1473; parentId = Some 531; name = "Gunnery Implants"; }
    let private marketGroup1474()= {MarketGroupData.id = 1474; parentId = Some 531; name = "Industry Implants"; }
    let private marketGroup1475()= {MarketGroupData.id = 1475; parentId = Some 531; name = "Fleet Support Implants"; }
    let private marketGroup1476()= {MarketGroupData.id = 1476; parentId = Some 531; name = "Missile Implants"; }
    let private marketGroup1477()= {MarketGroupData.id = 1477; parentId = Some 531; name = "Navigation Implants"; }
    let private marketGroup1478()= {MarketGroupData.id = 1478; parentId = Some 531; name = "Science Implants"; }
    let private marketGroup1479()= {MarketGroupData.id = 1479; parentId = Some 531; name = "Shield Implants"; }
    let private marketGroup1520()= {MarketGroupData.id = 1520; parentId = Some 211; name = "Probes"; }
    let private marketGroup357()= {MarketGroupData.id = 357; parentId = Some 2; name = "Drones"; }
    let private marketGroup800()= {MarketGroupData.id = 800; parentId = Some 1041; name = "Components"; }
    let private marketGroup1522()= {MarketGroupData.id = 1522; parentId = Some 1041; name = "Materials"; }
    let private marketGroup211()= {MarketGroupData.id = 211; parentId = Some 2; name = "Ammunition & Charges"; }
    let private marketGroup1530()= {MarketGroupData.id = 1530; parentId = Some 357; name = "Combat Drones"; }
    let private marketGroup480()= {MarketGroupData.id = 480; parentId = Some 1285; name = "Weapon Batteries"; }
    let private marketGroup1545()= {MarketGroupData.id = 1545; parentId = Some 209; name = "Shield"; }
    let private marketGroup1546()= {MarketGroupData.id = 1546; parentId = Some 209; name = "Engineering Equipment"; }
    let private marketGroup1566()= {MarketGroupData.id = 1566; parentId = Some 209; name = "Electronic Warfare"; }
    let private marketGroup1578()= {MarketGroupData.id = 1578; parentId = Some 209; name = "Electronics and Sensor Upgrades"; }
    let private marketGroup1097()= {MarketGroupData.id = 1097; parentId = Some 800; name = "Advanced Capital Ship Components"; }
    let private marketGroup1591()= {MarketGroupData.id = 1591; parentId = Some 800; name = "Advanced Components"; }
    let private marketGroup1610()= {MarketGroupData.id = 1610; parentId = Some 1112; name = "Amarr Subsystems"; }
    let private marketGroup1612()= {MarketGroupData.id = 1612; parentId = Some 4; name = "Special Edition Ships"; }
    let private marketGroup1625()= {MarketGroupData.id = 1625; parentId = Some 1112; name = "Caldari Subsystems"; }
    let private marketGroup1626()= {MarketGroupData.id = 1626; parentId = Some 1112; name = "Minmatar Subsystems"; }
    let private marketGroup1627()= {MarketGroupData.id = 1627; parentId = Some 1112; name = "Gallente Subsystems"; }
    let private marketGroup1122()= {MarketGroupData.id = 1122; parentId = Some 1610; name = "Amarr Core Subsystems"; }
    let private marketGroup1123()= {MarketGroupData.id = 1123; parentId = Some 1625; name = "Caldari Core Subsystems"; }
    let private marketGroup1124()= {MarketGroupData.id = 1124; parentId = Some 1627; name = "Gallente Core Subsystems"; }
    let private marketGroup1125()= {MarketGroupData.id = 1125; parentId = Some 1626; name = "Minmatar Core Subsystems"; }
    let private marketGroup1126()= {MarketGroupData.id = 1126; parentId = Some 1610; name = "Amarr Defensive Subsystems"; }
    let private marketGroup1127()= {MarketGroupData.id = 1127; parentId = Some 1625; name = "Caldari Defensive Subsystems"; }
    let private marketGroup1128()= {MarketGroupData.id = 1128; parentId = Some 1626; name = "Minmatar Defensive Subsystems"; }
    let private marketGroup1129()= {MarketGroupData.id = 1129; parentId = Some 1627; name = "Gallente Defensive Subsystems"; }
    let private marketGroup1130()= {MarketGroupData.id = 1130; parentId = Some 1610; name = "Amarr Offensive Subsystems"; }
    let private marketGroup1131()= {MarketGroupData.id = 1131; parentId = Some 1625; name = "Caldari Offensive Subsystems"; }
    let private marketGroup1132()= {MarketGroupData.id = 1132; parentId = Some 1627; name = "Gallente Offensive Subsystems"; }
    let private marketGroup1133()= {MarketGroupData.id = 1133; parentId = Some 1626; name = "Minmatar Offensive Subsystems"; }
    let private marketGroup1134()= {MarketGroupData.id = 1134; parentId = Some 1610; name = "Amarr Propulsion Subsystems"; }
    let private marketGroup1135()= {MarketGroupData.id = 1135; parentId = Some 1625; name = "Caldari Propulsion Subsystems"; }
    let private marketGroup1136()= {MarketGroupData.id = 1136; parentId = Some 1627; name = "Gallente Propulsion Subsystems"; }
    let private marketGroup1137()= {MarketGroupData.id = 1137; parentId = Some 1626; name = "Minmatar Propulsion Subsystems"; }
    let private marketGroup357120()= {MarketGroupData.id = 357120; parentId = Some 357121; name = "Armor Hardeners"; }
    let private marketGroup779()= {MarketGroupData.id = 779; parentId = Some 9; name = "Fleet Assistance Modules"; }
    let private marketGroup379()= {MarketGroupData.id = 379; parentId = Some 404; name = "Cargo Containers"; }
    let private marketGroup354461()= {MarketGroupData.id = 354461; parentId = Some 353591; name = "Boosts (Ground)"; }
    let private marketGroup354460()= {MarketGroupData.id = 354460; parentId = Some 353591; name = "Afterburners (Aerial)"; }
    let private marketGroup363304()= {MarketGroupData.id = 363304; parentId = Some 354444; name = "180mm Armor Plates"; }
    let private marketGroup363305()= {MarketGroupData.id = 363305; parentId = Some 354444; name = "120mm Armor Plates"; }
    let private marketGroup363306()= {MarketGroupData.id = 363306; parentId = Some 354444; name = "60mm Armor Plates"; }
    let private marketGroup363440()= {MarketGroupData.id = 363440; parentId = Some 354448; name = "Light"; }
    let private marketGroup363441()= {MarketGroupData.id = 363441; parentId = Some 354448; name = "Heavy"; }
    let private marketGroup363442()= {MarketGroupData.id = 363442; parentId = Some 353587; name = "Shield Extenders"; }
    let private marketGroup363448()= {MarketGroupData.id = 363448; parentId = Some 354471; name = "Light"; }
    let private marketGroup363449()= {MarketGroupData.id = 363449; parentId = Some 354471; name = "Heavy"; }
    let private marketGroup363452()= {MarketGroupData.id = 363452; parentId = Some 356597; name = "Shield Hardeners"; }
    let private marketGroup363456()= {MarketGroupData.id = 363456; parentId = Some 363442; name = "Heavy"; }
    let private marketGroup363457()= {MarketGroupData.id = 363457; parentId = Some 363442; name = "Light"; }
    let private marketGroup363464()= {MarketGroupData.id = 363464; parentId = Some 354338; name = "Standard"; }
    let private marketGroup363465()= {MarketGroupData.id = 363465; parentId = Some 354338; name = "Advanced"; }
    let private marketGroup363466()= {MarketGroupData.id = 363466; parentId = Some 354338; name = "Prototype"; }
    let private marketGroup363467()= {MarketGroupData.id = 363467; parentId = Some 354339; name = "Standard"; }
    let private marketGroup363468()= {MarketGroupData.id = 363468; parentId = Some 354339; name = "Advanced"; }
    let private marketGroup363469()= {MarketGroupData.id = 363469; parentId = Some 354339; name = "Prototype"; }
    let private marketGroup363470()= {MarketGroupData.id = 363470; parentId = Some 354340; name = "Standard"; }
    let private marketGroup363471()= {MarketGroupData.id = 363471; parentId = Some 354340; name = "Advanced"; }
    let private marketGroup363472()= {MarketGroupData.id = 363472; parentId = Some 354340; name = "Prototype"; }
    let private marketGroup356971()= {MarketGroupData.id = 356971; parentId = Some 354489; name = "Standard"; }
    let private marketGroup354331()= {MarketGroupData.id = 354331; parentId = Some 353569; name = "Standard"; }
    let private marketGroup354332()= {MarketGroupData.id = 354332; parentId = Some 353569; name = "Advanced"; }
    let private marketGroup354333()= {MarketGroupData.id = 354333; parentId = Some 353569; name = "Prototype"; }
    let private marketGroup354335()= {MarketGroupData.id = 354335; parentId = Some 353568; name = "Standard"; }
    let private marketGroup354336()= {MarketGroupData.id = 354336; parentId = Some 353568; name = "Advanced"; }
    let private marketGroup354337()= {MarketGroupData.id = 354337; parentId = Some 353568; name = "Prototype"; }
    let private marketGroup354338()= {MarketGroupData.id = 354338; parentId = Some 353557; name = "Locus Grenades"; }
    let private marketGroup354339()= {MarketGroupData.id = 354339; parentId = Some 353557; name = "Anti-Vehicle Grenades"; }
    let private marketGroup354340()= {MarketGroupData.id = 354340; parentId = Some 353557; name = "Flux Grenades"; }
    let private marketGroup354343()= {MarketGroupData.id = 354343; parentId = Some 353573; name = "Standard"; }
    let private marketGroup354344()= {MarketGroupData.id = 354344; parentId = Some 353573; name = "Advanced"; }
    let private marketGroup354345()= {MarketGroupData.id = 354345; parentId = Some 353573; name = "Prototype"; }
    let private marketGroup354347()= {MarketGroupData.id = 354347; parentId = Some 353570; name = "Standard"; }
    let private marketGroup354348()= {MarketGroupData.id = 354348; parentId = Some 353570; name = "Advanced"; }
    let private marketGroup354350()= {MarketGroupData.id = 354350; parentId = Some 353570; name = "Prototype"; }
    let private marketGroup354352()= {MarketGroupData.id = 354352; parentId = Some 353572; name = "Standard"; }
    let private marketGroup354353()= {MarketGroupData.id = 354353; parentId = Some 353572; name = "Advanced"; }
    let private marketGroup354354()= {MarketGroupData.id = 354354; parentId = Some 353572; name = "Prototype"; }
    let private marketGroup356916()= {MarketGroupData.id = 356916; parentId = Some 353589; name = "Scanners"; }
    let private marketGroup354364()= {MarketGroupData.id = 354364; parentId = Some 353571; name = "Standard"; }
    let private marketGroup354366()= {MarketGroupData.id = 354366; parentId = Some 353571; name = "Advanced"; }
    let private marketGroup354367()= {MarketGroupData.id = 354367; parentId = Some 353571; name = "Prototype"; }
    let private marketGroup356972()= {MarketGroupData.id = 356972; parentId = Some 354489; name = "Advanced"; }
    let private marketGroup354376()= {MarketGroupData.id = 354376; parentId = Some 353601; name = "Standard"; }
    let private marketGroup354377()= {MarketGroupData.id = 354377; parentId = Some 353601; name = "Advanced"; }
    let private marketGroup354378()= {MarketGroupData.id = 354378; parentId = Some 353601; name = "Prototype"; }
    let private marketGroup354380()= {MarketGroupData.id = 354380; parentId = Some 353604; name = "Standard"; }
    let private marketGroup354381()= {MarketGroupData.id = 354381; parentId = Some 353604; name = "Advanced"; }
    let private marketGroup354382()= {MarketGroupData.id = 354382; parentId = Some 353604; name = "Prototype"; }
    let private marketGroup354384()= {MarketGroupData.id = 354384; parentId = Some 353602; name = "Standard"; }
    let private marketGroup354385()= {MarketGroupData.id = 354385; parentId = Some 353602; name = "Advanced"; }
    let private marketGroup354386()= {MarketGroupData.id = 354386; parentId = Some 353602; name = "Prototype"; }
    let private marketGroup356435()= {MarketGroupData.id = 356435; parentId = Some 356433; name = "Advanced"; }
    let private marketGroup354388()= {MarketGroupData.id = 354388; parentId = Some 353600; name = "Standard"; }
    let private marketGroup354389()= {MarketGroupData.id = 354389; parentId = Some 353600; name = "Advanced"; }
    let private marketGroup354390()= {MarketGroupData.id = 354390; parentId = Some 353600; name = "Prototype"; }
    let private marketGroup356964()= {MarketGroupData.id = 356964; parentId = Some 354490; name = "Advanced"; }
    let private marketGroup356965()= {MarketGroupData.id = 356965; parentId = Some 354490; name = "Prototype"; }
    let private marketGroup356960()= {MarketGroupData.id = 356960; parentId = Some 354491; name = "Standard"; }
    let private marketGroup356961()= {MarketGroupData.id = 356961; parentId = Some 354491; name = "Advanced"; }
    let private marketGroup356962()= {MarketGroupData.id = 356962; parentId = Some 354491; name = "Prototype"; }
    let private marketGroup354403()= {MarketGroupData.id = 354403; parentId = Some 353575; name = "Standard"; }
    let private marketGroup354404()= {MarketGroupData.id = 354404; parentId = Some 353575; name = "Advanced"; }
    let private marketGroup354405()= {MarketGroupData.id = 354405; parentId = Some 353575; name = "Prototype"; }
    let private marketGroup356968()= {MarketGroupData.id = 356968; parentId = Some 354488; name = "Standard"; }
    let private marketGroup356969()= {MarketGroupData.id = 356969; parentId = Some 354488; name = "Advanced"; }
    let private marketGroup354410()= {MarketGroupData.id = 354410; parentId = Some 353574; name = "Standard"; }
    let private marketGroup354411()= {MarketGroupData.id = 354411; parentId = Some 353574; name = "Advanced"; }
    let private marketGroup354412()= {MarketGroupData.id = 354412; parentId = Some 353574; name = "Prototype"; }
    let private marketGroup356973()= {MarketGroupData.id = 356973; parentId = Some 354489; name = "Prototype"; }
    let private marketGroup354414()= {MarketGroupData.id = 354414; parentId = Some 353576; name = "Standard"; }
    let private marketGroup354415()= {MarketGroupData.id = 354415; parentId = Some 353576; name = "Advanced"; }
    let private marketGroup354416()= {MarketGroupData.id = 354416; parentId = Some 353576; name = "Prototype"; }
    let private marketGroup356977()= {MarketGroupData.id = 356977; parentId = Some 354483; name = "Advanced"; }
    let private marketGroup356978()= {MarketGroupData.id = 356978; parentId = Some 354483; name = "Prototype"; }
    let private marketGroup356979()= {MarketGroupData.id = 356979; parentId = Some 353613; name = "Standard"; }
    let private marketGroup356980()= {MarketGroupData.id = 356980; parentId = Some 353613; name = "Advanced"; }
    let private marketGroup356981()= {MarketGroupData.id = 356981; parentId = Some 353613; name = "Prototype"; }
    let private marketGroup354425()= {MarketGroupData.id = 354425; parentId = Some 353583; name = "Endurance Modifiers"; }
    let private marketGroup354427()= {MarketGroupData.id = 354427; parentId = Some 353583; name = "Speed Modifiers"; }
    let private marketGroup354429()= {MarketGroupData.id = 354429; parentId = Some 353583; name = "Melee Upgrades"; }
    let private marketGroup354430()= {MarketGroupData.id = 354430; parentId = Some 353584; name = "CPU Upgrades"; }
    let private marketGroup354431()= {MarketGroupData.id = 354431; parentId = Some 353585; name = "PG Upgrades"; }
    let private marketGroup354434()= {MarketGroupData.id = 354434; parentId = Some 353586; name = "Damage Amplifiers"; }
    let private marketGroup355461()= {MarketGroupData.id = 355461; parentId = Some 355449; name = "Vehicles"; }
    let private marketGroup355462()= {MarketGroupData.id = 355462; parentId = Some 355449; name = "Weapons"; }
    let private marketGroup355463()= {MarketGroupData.id = 355463; parentId = Some 355462; name = "Weapons & Grenades"; }
    let private marketGroup355457()= {MarketGroupData.id = 355457; parentId = Some 355449; name = "Dropsuits"; }
    let private marketGroup355465()= {MarketGroupData.id = 355465; parentId = Some 355460; name = "Turrets"; }
    let private marketGroup355466()= {MarketGroupData.id = 355466; parentId = Some 355459; name = "Dropsuit Modules"; }
    let private marketGroup355467()= {MarketGroupData.id = 355467; parentId = Some 355459; name = "Vehicle Modules"; }
    let private marketGroup354444()= {MarketGroupData.id = 354444; parentId = Some 353588; name = "Armor Plates"; }
    let private marketGroup355469()= {MarketGroupData.id = 355469; parentId = Some 355457; name = "Dropsuits"; }
    let private marketGroup354448()= {MarketGroupData.id = 354448; parentId = Some 353588; name = "Armor Repairers"; }
    let private marketGroup354453()= {MarketGroupData.id = 354453; parentId = Some 353589; name = "CPU Upgrades"; }
    let private marketGroup354454()= {MarketGroupData.id = 354454; parentId = Some 353590; name = "Damage Control Systems"; }
    let private marketGroup354455()= {MarketGroupData.id = 354455; parentId = Some 353590; name = "Mobile CRUs"; }
    let private marketGroup354458()= {MarketGroupData.id = 354458; parentId = Some 353590; name = "Power Grid Upgrades"; }
    let private marketGroup354459()= {MarketGroupData.id = 354459; parentId = Some 353590; name = "Power Diagnostic Systems"; }
    let private marketGroup356976()= {MarketGroupData.id = 356976; parentId = Some 354483; name = "Standard"; }
    let private marketGroup354469()= {MarketGroupData.id = 354469; parentId = Some 353592; name = "Damage Amplifiers"; }
    let private marketGroup354471()= {MarketGroupData.id = 354471; parentId = Some 353587; name = "Shield Boosters"; }
    let private marketGroup354478()= {MarketGroupData.id = 354478; parentId = Some 353565; name = "Blaster"; }
    let private marketGroup354483()= {MarketGroupData.id = 354483; parentId = Some 353605; name = "Large"; }
    let private marketGroup354488()= {MarketGroupData.id = 354488; parentId = Some 354478; name = "Small"; }
    let private marketGroup354489()= {MarketGroupData.id = 354489; parentId = Some 354478; name = "Large"; }
    let private marketGroup354490()= {MarketGroupData.id = 354490; parentId = Some 353608; name = "Small"; }
    let private marketGroup354491()= {MarketGroupData.id = 354491; parentId = Some 353608; name = "Large"; }
    let private marketGroup355189()= {MarketGroupData.id = 355189; parentId = Some 355181; name = "Prototype"; }
    let private marketGroup355193()= {MarketGroupData.id = 355193; parentId = Some 353563; name = "Nanite Injectors"; }
    let private marketGroup355187()= {MarketGroupData.id = 355187; parentId = Some 355181; name = "Standard"; }
    let private marketGroup356575()= {MarketGroupData.id = 356575; parentId = Some 354469; name = "Hybrid Damage Amplifiers"; }
    let private marketGroup356576()= {MarketGroupData.id = 356576; parentId = Some 354469; name = "Missile Damage Amplifiers"; }
    let private marketGroup355460()= {MarketGroupData.id = 355460; parentId = Some 355449; name = "Turrets"; }
    let private marketGroup356580()= {MarketGroupData.id = 356580; parentId = Some 356575; name = "Systemic Hybrid Damage"; }
    let private marketGroup356583()= {MarketGroupData.id = 356583; parentId = Some 356576; name = "Large Missile Damage"; }
    let private marketGroup354542()= {MarketGroupData.id = 354542; parentId = Some 354534; name = "Passive Boosters"; }
    let private marketGroup354543()= {MarketGroupData.id = 354543; parentId = Some 354534; name = "Active Boosters"; }
    let private marketGroup355572()= {MarketGroupData.id = 355572; parentId = Some 353584; name = "Data Miners"; }
    let private marketGroup356597()= {MarketGroupData.id = 356597; parentId = Some 353587; name = "Shield Hardeners"; }
    let private marketGroup355188()= {MarketGroupData.id = 355188; parentId = Some 355181; name = "Advanced"; }
    let private marketGroup354565()= {MarketGroupData.id = 354565; parentId = Some 354563; name = "Standard"; }
    let private marketGroup354566()= {MarketGroupData.id = 354566; parentId = Some 354563; name = "Advanced"; }
    let private marketGroup354567()= {MarketGroupData.id = 354567; parentId = Some 354563; name = "Prototype"; }
    let private marketGroup355458()= {MarketGroupData.id = 355458; parentId = Some 355449; name = "Equipment"; }
    let private marketGroup355459()= {MarketGroupData.id = 355459; parentId = Some 355449; name = "Modules"; }
    let private marketGroup353557()= {MarketGroupData.id = 353557; parentId = Some 353567; name = "Grenades"; }
    let private marketGroup353574()= {MarketGroupData.id = 353574; parentId = Some 353563; name = "Nanohives"; }
    let private marketGroup353575()= {MarketGroupData.id = 353575; parentId = Some 353563; name = "Drop Uplinks"; }
    let private marketGroup353576()= {MarketGroupData.id = 353576; parentId = Some 353563; name = "Repair Tools"; }
    let private marketGroup353581()= {MarketGroupData.id = 353581; parentId = Some 353579; name = "Shield"; }
    let private marketGroup353582()= {MarketGroupData.id = 353582; parentId = Some 353579; name = "Armor"; }
    let private marketGroup353583()= {MarketGroupData.id = 353583; parentId = Some 353579; name = "Biotics"; }
    let private marketGroup353584()= {MarketGroupData.id = 353584; parentId = Some 353579; name = "Electronics"; }
    let private marketGroup353585()= {MarketGroupData.id = 353585; parentId = Some 353579; name = "Engineering"; }
    let private marketGroup353586()= {MarketGroupData.id = 353586; parentId = Some 353579; name = "Weapon Upgrades"; }
    let private marketGroup353587()= {MarketGroupData.id = 353587; parentId = Some 353580; name = "Shield"; }
    let private marketGroup353588()= {MarketGroupData.id = 353588; parentId = Some 353580; name = "Armor"; }
    let private marketGroup353589()= {MarketGroupData.id = 353589; parentId = Some 353580; name = "Electronics"; }
    let private marketGroup353590()= {MarketGroupData.id = 353590; parentId = Some 353580; name = "Engineering"; }
    let private marketGroup353591()= {MarketGroupData.id = 353591; parentId = Some 353580; name = "Propulsion"; }
    let private marketGroup353592()= {MarketGroupData.id = 353592; parentId = Some 353580; name = "Turret Upgrades"; }
    let private marketGroup354618()= {MarketGroupData.id = 354618; parentId = Some 354616; name = "Standard"; }
    let private marketGroup354619()= {MarketGroupData.id = 354619; parentId = Some 354616; name = "Advanced"; }
    let private marketGroup354620()= {MarketGroupData.id = 354620; parentId = Some 354616; name = "Prototype"; }
    let private marketGroup353605()= {MarketGroupData.id = 353605; parentId = Some 353565; name = "Railgun"; }
    let private marketGroup353608()= {MarketGroupData.id = 353608; parentId = Some 353565; name = "Missile"; }
    let private marketGroup355468()= {MarketGroupData.id = 355468; parentId = Some 355458; name = "Equipment"; }
    let private marketGroup353613()= {MarketGroupData.id = 353613; parentId = Some 353605; name = "Small"; }
    let private marketGroup355464()= {MarketGroupData.id = 355464; parentId = Some 355461; name = "Vehicles"; }
    let private marketGroup356963()= {MarketGroupData.id = 356963; parentId = Some 354490; name = "Standard"; }
    let private marketGroup356582()= {MarketGroupData.id = 356582; parentId = Some 356576; name = "Systemic Missile Damage"; }
    let private marketGroup355181()= {MarketGroupData.id = 355181; parentId = Some 353563; name = "Remote Explosives"; }
    let private marketGroup354671()= {MarketGroupData.id = 354671; parentId = Some 353584; name = "Scan Enhancers"; }
    let private marketGroup353651()= {MarketGroupData.id = 353651; parentId = Some 353566; name = "Heavy Attack Vehicles"; }
    let private marketGroup353652()= {MarketGroupData.id = 353652; parentId = Some 353566; name = "Light Attack Vehicles"; }
    let private marketGroup353653()= {MarketGroupData.id = 353653; parentId = Some 353566; name = "Dropships"; }
    let private marketGroup356970()= {MarketGroupData.id = 356970; parentId = Some 354488; name = "Prototype"; }
    let private marketGroup357121()= {MarketGroupData.id = 357121; parentId = Some 353588; name = "Armor Hardeners"; }
    let private marketGroup353657()= {MarketGroupData.id = 353657; parentId = Some 353651; name = "Standard"; }
    let private marketGroup355194()= {MarketGroupData.id = 355194; parentId = Some 355193; name = "Standard"; }
    let private marketGroup355195()= {MarketGroupData.id = 355195; parentId = Some 355193; name = "Advanced"; }
    let private marketGroup355196()= {MarketGroupData.id = 355196; parentId = Some 355193; name = "Prototype"; }
    let private marketGroup353663()= {MarketGroupData.id = 353663; parentId = Some 353651; name = "Marauder"; }
    let private marketGroup353664()= {MarketGroupData.id = 353664; parentId = Some 353652; name = "Standard"; }
    let private marketGroup354690()= {MarketGroupData.id = 354690; parentId = Some 354686; name = "Standard"; }
    let private marketGroup354691()= {MarketGroupData.id = 354691; parentId = Some 354686; name = "Advanced"; }
    let private marketGroup354692()= {MarketGroupData.id = 354692; parentId = Some 354686; name = "Prototype"; }
    let private marketGroup353669()= {MarketGroupData.id = 353669; parentId = Some 353652; name = "Logistics"; }
    let private marketGroup353671()= {MarketGroupData.id = 353671; parentId = Some 353653; name = "Standard"; }
    let private marketGroup354696()= {MarketGroupData.id = 354696; parentId = Some 354693; name = "Standard"; }
    let private marketGroup354697()= {MarketGroupData.id = 354697; parentId = Some 354693; name = "Advanced"; }
    let private marketGroup354698()= {MarketGroupData.id = 354698; parentId = Some 354693; name = "Prototype"; }
    let private marketGroup353676()= {MarketGroupData.id = 353676; parentId = Some 353653; name = "Logistics"; }
    let private marketGroup353681()= {MarketGroupData.id = 353681; parentId = Some 353633; name = "Weaponry"; }
    let private marketGroup353684()= {MarketGroupData.id = 353684; parentId = Some 353681; name = "Weapons"; }
    let private marketGroup353706()= {MarketGroupData.id = 353706; parentId = Some 353633; name = "Dropsuit Command"; }
    let private marketGroup353707()= {MarketGroupData.id = 353707; parentId = Some 353706; name = "Dropsuit Command"; }
    let private marketGroup353710()= {MarketGroupData.id = 353710; parentId = Some 353633; name = "Vehicle Command"; }
    let private marketGroup353711()= {MarketGroupData.id = 353711; parentId = Some 353710; name = "Vehicle Command"; }
    let private marketGroup353713()= {MarketGroupData.id = 353713; parentId = Some 353633; name = "Turret Operation"; }
    let private marketGroup353715()= {MarketGroupData.id = 353715; parentId = Some 353713; name = "Turret Operation"; }
    let private marketGroup353716()= {MarketGroupData.id = 353716; parentId = Some 353713; name = "Turret Upgrades"; }
    let private marketGroup356434()= {MarketGroupData.id = 356434; parentId = Some 356433; name = "Standard"; }
    let private marketGroup356436()= {MarketGroupData.id = 356436; parentId = Some 356433; name = "Prototype"; }
    let private marketGroup363475()= {MarketGroupData.id = 363475; parentId = Some 353633; name = "Corporations"; }
    let private marketGroup363476()= {MarketGroupData.id = 363476; parentId = Some 363475; name = "Corporation Management"; }
    let private marketGroup1659()= {MarketGroupData.id = 1659; parentId = None; name = "Special Edition Assets"; }
    let private marketGroup540()= {MarketGroupData.id = 540; parentId = Some 14; name = "Resistance Plating"; }
    let private marketGroup1665()= {MarketGroupData.id = 1665; parentId = Some 540; name = "Thermal Resistance Plating"; }
    let private marketGroup1666()= {MarketGroupData.id = 1666; parentId = Some 540; name = "Kinetic Resistance Plating"; }
    let private marketGroup1667()= {MarketGroupData.id = 1667; parentId = Some 540; name = "Explosive Resistance Plating"; }
    let private marketGroup1668()= {MarketGroupData.id = 1668; parentId = Some 540; name = "EM Resistance Plating"; }
    let private marketGroup1670()= {MarketGroupData.id = 1670; parentId = Some 540; name = "Adaptive Resistance Plating"; }
    let private marketGroup133()= {MarketGroupData.id = 133; parentId = Some 14; name = "Armor Plates"; }
    let private marketGroup1678()= {MarketGroupData.id = 1678; parentId = Some 535; name = "Thermal Armor Hardeners"; }
    let private marketGroup1679()= {MarketGroupData.id = 1679; parentId = Some 535; name = "Kinetic Armor Hardeners"; }
    let private marketGroup1680()= {MarketGroupData.id = 1680; parentId = Some 535; name = "Explosive Armor Hardeners"; }
    let private marketGroup1681()= {MarketGroupData.id = 1681; parentId = Some 535; name = "EM Armor Hardeners"; }
    let private marketGroup535()= {MarketGroupData.id = 535; parentId = Some 14; name = "Armor Hardeners"; }
    let private marketGroup1682()= {MarketGroupData.id = 1682; parentId = Some 541; name = "Energized Explosive Plating"; }
    let private marketGroup1683()= {MarketGroupData.id = 1683; parentId = Some 541; name = "Energized Thermal Plating"; }
    let private marketGroup1684()= {MarketGroupData.id = 1684; parentId = Some 541; name = "Energized EM Plating"; }
    let private marketGroup1685()= {MarketGroupData.id = 1685; parentId = Some 541; name = "Energized Kinetic Plating"; }
    let private marketGroup541()= {MarketGroupData.id = 541; parentId = Some 14; name = "Energized Plating"; }
    let private marketGroup1686()= {MarketGroupData.id = 1686; parentId = Some 541; name = "Energized Adaptive Plating"; }
    let private marketGroup550()= {MarketGroupData.id = 550; parentId = Some 554; name = "Shield Resistance Amplifiers"; }
    let private marketGroup1688()= {MarketGroupData.id = 1688; parentId = Some 550; name = "Thermal Resistance Amplifiers"; }
    let private marketGroup1689()= {MarketGroupData.id = 1689; parentId = Some 550; name = "Kinetic Resistance Amplifiers"; }
    let private marketGroup1690()= {MarketGroupData.id = 1690; parentId = Some 550; name = "Explosive Resistance Amplifiers"; }
    let private marketGroup1691()= {MarketGroupData.id = 1691; parentId = Some 550; name = "EM Resistance Amplifiers"; }
    let private marketGroup553()= {MarketGroupData.id = 553; parentId = Some 554; name = "Shield Hardeners"; }
    let private marketGroup1692()= {MarketGroupData.id = 1692; parentId = Some 553; name = "Thermal Shield Hardeners"; }
    let private marketGroup1693()= {MarketGroupData.id = 1693; parentId = Some 553; name = "Kinetic Shield Hardeners"; }
    let private marketGroup1694()= {MarketGroupData.id = 1694; parentId = Some 553; name = "Explosive Shield Hardeners"; }
    let private marketGroup1695()= {MarketGroupData.id = 1695; parentId = Some 553; name = "EM Shield Hardeners"; }
    let private marketGroup1696()= {MarketGroupData.id = 1696; parentId = Some 553; name = "Adaptive Shield Hardeners"; }
    let private marketGroup363791()= {MarketGroupData.id = 363791; parentId = Some 363790; name = "Standard"; }
    let private marketGroup363792()= {MarketGroupData.id = 363792; parentId = Some 363790; name = "Advanced"; }
    let private marketGroup363793()= {MarketGroupData.id = 363793; parentId = Some 363790; name = "Prototype"; }
    let private marketGroup364044()= {MarketGroupData.id = 364044; parentId = Some 353562; name = "Light"; }
    let private marketGroup364045()= {MarketGroupData.id = 364045; parentId = Some 353562; name = "Medium"; }
    let private marketGroup364046()= {MarketGroupData.id = 364046; parentId = Some 353562; name = "Heavy"; }
    let private marketGroup364047()= {MarketGroupData.id = 364047; parentId = Some 353567; name = "Light"; }
    let private marketGroup364048()= {MarketGroupData.id = 364048; parentId = Some 353567; name = "Sidearm"; }
    let private marketGroup364049()= {MarketGroupData.id = 364049; parentId = Some 353567; name = "Heavy"; }
    let private marketGroup363790()= {MarketGroupData.id = 363790; parentId = Some 364048; name = "Flaylock Pistols"; }
    let private marketGroup354686()= {MarketGroupData.id = 354686; parentId = Some 364047; name = "Laser Rifles"; }
    let private marketGroup353571()= {MarketGroupData.id = 353571; parentId = Some 364047; name = "Swarm Launchers"; }
    let private marketGroup353570()= {MarketGroupData.id = 353570; parentId = Some 364047; name = "Sniper Rifles"; }
    let private marketGroup353569()= {MarketGroupData.id = 353569; parentId = Some 364047; name = "Assault Rifles"; }
    let private marketGroup354616()= {MarketGroupData.id = 354616; parentId = Some 364047; name = "Mass Drivers"; }
    let private marketGroup354693()= {MarketGroupData.id = 354693; parentId = Some 364047; name = "Shotguns"; }
    let private marketGroup353572()= {MarketGroupData.id = 353572; parentId = Some 364048; name = "Submachine Guns"; }
    let private marketGroup353573()= {MarketGroupData.id = 353573; parentId = Some 364048; name = "Scrambler Pistols"; }
    let private marketGroup356433()= {MarketGroupData.id = 356433; parentId = Some 364048; name = "Nova Knives"; }
    let private marketGroup353568()= {MarketGroupData.id = 353568; parentId = Some 364049; name = "Forge Guns"; }
    let private marketGroup354563()= {MarketGroupData.id = 354563; parentId = Some 364049; name = "Heavy Machine Guns"; }
    let private marketGroup353600()= {MarketGroupData.id = 353600; parentId = Some 364044; name = "Scout"; }
    let private marketGroup353601()= {MarketGroupData.id = 353601; parentId = Some 364045; name = "Assault"; }
    let private marketGroup353602()= {MarketGroupData.id = 353602; parentId = Some 364045; name = "Logistics"; }
    let private marketGroup353604()= {MarketGroupData.id = 353604; parentId = Some 364046; name = "Sentinel"; }
    let private marketGroup364051()= {MarketGroupData.id = 364051; parentId = Some 364047; name = "Scrambler Rifles"; }
    let private marketGroup364052()= {MarketGroupData.id = 364052; parentId = Some 364051; name = "Standard"; }
    let private marketGroup364053()= {MarketGroupData.id = 364053; parentId = Some 364051; name = "Advanced"; }
    let private marketGroup364054()= {MarketGroupData.id = 364054; parentId = Some 364051; name = "Prototype"; }
    let private marketGroup364055()= {MarketGroupData.id = 364055; parentId = Some 364047; name = "Plasma Cannons"; }
    let private marketGroup364056()= {MarketGroupData.id = 364056; parentId = Some 364055; name = "Standard"; }
    let private marketGroup364057()= {MarketGroupData.id = 364057; parentId = Some 364055; name = "Advanced"; }
    let private marketGroup364058()= {MarketGroupData.id = 364058; parentId = Some 364055; name = "Prototype"; }
    let private marketGroup1700()= {MarketGroupData.id = 1700; parentId = Some 19; name = "Security Tags"; }
    let private marketGroup364491()= {MarketGroupData.id = 364491; parentId = Some 353563; name = "Active Scanners"; }
    let private marketGroup364492()= {MarketGroupData.id = 364492; parentId = Some 364491; name = "Standard"; }
    let private marketGroup364493()= {MarketGroupData.id = 364493; parentId = Some 364491; name = "Advanced"; }
    let private marketGroup364494()= {MarketGroupData.id = 364494; parentId = Some 364491; name = "Prototype"; }
    let private marketGroup364760()= {MarketGroupData.id = 364760; parentId = Some 353651; name = "Enforcer"; }
    let private marketGroup364765()= {MarketGroupData.id = 364765; parentId = Some 353652; name = "Scout"; }
    let private marketGroup364768()= {MarketGroupData.id = 364768; parentId = Some 353653; name = "Assault"; }
    let private marketGroup364885()= {MarketGroupData.id = 364885; parentId = Some 364044; name = "Basic"; }
    let private marketGroup364886()= {MarketGroupData.id = 364886; parentId = Some 364885; name = "Standard"; }
    let private marketGroup364887()= {MarketGroupData.id = 364887; parentId = Some 364885; name = "Advanced"; }
    let private marketGroup364888()= {MarketGroupData.id = 364888; parentId = Some 364885; name = "Prototype"; }
    let private marketGroup364889()= {MarketGroupData.id = 364889; parentId = Some 364045; name = "Basic"; }
    let private marketGroup364890()= {MarketGroupData.id = 364890; parentId = Some 364889; name = "Standard"; }
    let private marketGroup364891()= {MarketGroupData.id = 364891; parentId = Some 364889; name = "Advanced"; }
    let private marketGroup364892()= {MarketGroupData.id = 364892; parentId = Some 364889; name = "Prototype"; }
    let private marketGroup364893()= {MarketGroupData.id = 364893; parentId = Some 364046; name = "Basic"; }
    let private marketGroup364894()= {MarketGroupData.id = 364894; parentId = Some 364893; name = "Standard"; }
    let private marketGroup364895()= {MarketGroupData.id = 364895; parentId = Some 364893; name = "Advanced"; }
    let private marketGroup364896()= {MarketGroupData.id = 364896; parentId = Some 364893; name = "Prototype"; }
    let private marketGroup1703()= {MarketGroupData.id = 1703; parentId = Some 1374; name = "Faction Battlecruisers"; }
    let private marketGroup1711()= {MarketGroupData.id = 1711; parentId = Some 209; name = "Harvest Equipment"; }
    let private marketGroup1710()= {MarketGroupData.id = 1710; parentId = Some 209; name = "Scanning Equipment"; }
    let private marketGroup1713()= {MarketGroupData.id = 1713; parentId = Some 9; name = "Harvest Equipment"; }
    let private marketGroup1708()= {MarketGroupData.id = 1708; parentId = Some 9; name = "Scanning Equipment"; }
    let private marketGroup365244()= {MarketGroupData.id = 365244; parentId = Some 354423; name = "Armor Plates"; }
    let private marketGroup365245()= {MarketGroupData.id = 365245; parentId = Some 354423; name = "Ferroscale Plates"; }
    let private marketGroup365246()= {MarketGroupData.id = 365246; parentId = Some 354423; name = "Reactive Plates"; }
    let private marketGroup354423()= {MarketGroupData.id = 354423; parentId = Some 353582; name = "Armor Plates"; }
    let private marketGroup365247()= {MarketGroupData.id = 365247; parentId = Some 354424; name = "Armor Repairers"; }
    let private marketGroup354424()= {MarketGroupData.id = 354424; parentId = Some 353582; name = "Armor Repairers"; }
    let private marketGroup365248()= {MarketGroupData.id = 365248; parentId = Some 354432; name = "Shield Extenders"; }
    let private marketGroup354432()= {MarketGroupData.id = 354432; parentId = Some 353581; name = "Shield Extenders"; }
    let private marketGroup365249()= {MarketGroupData.id = 365249; parentId = Some 355590; name = "Shield Regulators"; }
    let private marketGroup355590()= {MarketGroupData.id = 355590; parentId = Some 353581; name = "Shield Regulators"; }
    let private marketGroup365250()= {MarketGroupData.id = 365250; parentId = Some 354433; name = "Shield Rechargers"; }
    let private marketGroup365251()= {MarketGroupData.id = 365251; parentId = Some 354433; name = "Shield Energizers"; }
    let private marketGroup354433()= {MarketGroupData.id = 354433; parentId = Some 353581; name = "Shield Rechargers"; }
    let private marketGroup365272()= {MarketGroupData.id = 365272; parentId = Some 364044; name = "Pilot"; }
    let private marketGroup365274()= {MarketGroupData.id = 365274; parentId = Some 365272; name = "Standard"; }
    let private marketGroup365276()= {MarketGroupData.id = 365276; parentId = Some 365272; name = "Advanced"; }
    let private marketGroup365277()= {MarketGroupData.id = 365277; parentId = Some 365272; name = "Prototype"; }
    let private marketGroup365278()= {MarketGroupData.id = 365278; parentId = Some 364046; name = "Commando"; }
    let private marketGroup365279()= {MarketGroupData.id = 365279; parentId = Some 365278; name = "Standard"; }
    let private marketGroup365280()= {MarketGroupData.id = 365280; parentId = Some 365278; name = "Advanced"; }
    let private marketGroup365282()= {MarketGroupData.id = 365282; parentId = Some 365278; name = "Prototype"; }
    let private marketGroup1761()= {MarketGroupData.id = 1761; parentId = Some 531; name = "Targeting Implants"; }
    let private marketGroup1762()= {MarketGroupData.id = 1762; parentId = Some 531; name = "Resource Processing Implants"; }
    let private marketGroup1763()= {MarketGroupData.id = 1763; parentId = Some 531; name = "Scanning Implants"; }
    let private marketGroup1764()= {MarketGroupData.id = 1764; parentId = Some 531; name = "Neural Enhancement Implants"; }
    let private marketGroup365496()= {MarketGroupData.id = 365496; parentId = Some 353633; name = "Dropsuit Upgrades"; }
    let private marketGroup353708()= {MarketGroupData.id = 353708; parentId = Some 365496; name = "Dropsuit Upgrades"; }
    let private marketGroup365497()= {MarketGroupData.id = 365497; parentId = Some 353633; name = "Vehicle Upgrades"; }
    let private marketGroup365001()= {MarketGroupData.id = 365001; parentId = Some 365497; name = "Vehicle Upgrades"; }
    let private marketGroup1815()= {MarketGroupData.id = 1815; parentId = Some 4; name = "Corvettes"; }
    let private marketGroup1794()= {MarketGroupData.id = 1794; parentId = Some 943; name = "Resource Processing Rigs"; }
    let private marketGroup1796()= {MarketGroupData.id = 1796; parentId = Some 943; name = "Targeting Rigs"; }
    let private marketGroup1795()= {MarketGroupData.id = 1795; parentId = Some 943; name = "Scanning Rigs"; }
    let private marketGroup1779()= {MarketGroupData.id = 1779; parentId = Some 1111; name = "Resource Processing Rigs"; }
    let private marketGroup1780()= {MarketGroupData.id = 1780; parentId = Some 1111; name = "Scanning Rigs"; }
    let private marketGroup1781()= {MarketGroupData.id = 1781; parentId = Some 1111; name = "Targeting Rigs"; }
    let private marketGroup356579()= {MarketGroupData.id = 356579; parentId = Some 356575; name = "Blaster Damage Amplifiers"; }
    let private marketGroup356581()= {MarketGroupData.id = 356581; parentId = Some 356575; name = "Railgun Damage Amplifiers"; }
    let private marketGroup356584()= {MarketGroupData.id = 356584; parentId = Some 356576; name = "Missile Damage Amplifiers"; }
    let private marketGroup365765()= {MarketGroupData.id = 365765; parentId = Some 364047; name = "Combat Rifles"; }
    let private marketGroup365766()= {MarketGroupData.id = 365766; parentId = Some 365765; name = "Standard"; }
    let private marketGroup365767()= {MarketGroupData.id = 365767; parentId = Some 365765; name = "Advanced"; }
    let private marketGroup365768()= {MarketGroupData.id = 365768; parentId = Some 365765; name = "Prototype"; }
    let private marketGroup365769()= {MarketGroupData.id = 365769; parentId = Some 364047; name = "Rail Rifles"; }
    let private marketGroup365770()= {MarketGroupData.id = 365770; parentId = Some 365769; name = "Standard"; }
    let private marketGroup365771()= {MarketGroupData.id = 365771; parentId = Some 365769; name = "Advanced"; }
    let private marketGroup365772()= {MarketGroupData.id = 365772; parentId = Some 365769; name = "Prototype"; }
    let private marketGroup365949()= {MarketGroupData.id = 365949; parentId = Some 365946; name = "Dropship"; }
    let private marketGroup365950()= {MarketGroupData.id = 365950; parentId = Some 365946; name = "Light Attack Vehicle (LAV)"; }
    let private marketGroup365951()= {MarketGroupData.id = 365951; parentId = Some 365946; name = "Heavy Attack Vehicle (HAV)"; }
    let private marketGroup366021()= {MarketGroupData.id = 366021; parentId = Some 354534; name = "Faction Booster Amarr"; }
    let private marketGroup366111()= {MarketGroupData.id = 366111; parentId = Some 353557; name = "Contact Grenades"; }
    let private marketGroup366112()= {MarketGroupData.id = 366112; parentId = Some 366111; name = "Standard"; }
    let private marketGroup366113()= {MarketGroupData.id = 366113; parentId = Some 366111; name = "Advanced"; }
    let private marketGroup366114()= {MarketGroupData.id = 366114; parentId = Some 366111; name = "Prototype"; }
    let private marketGroup366173()= {MarketGroupData.id = 366173; parentId = Some 365996; name = "Dropsuits"; }
    let private marketGroup366179()= {MarketGroupData.id = 366179; parentId = Some 365997; name = "Weapons"; }
    let private marketGroup366175()= {MarketGroupData.id = 366175; parentId = Some 365998; name = "Dropsuits"; }
    let private marketGroup366177()= {MarketGroupData.id = 366177; parentId = Some 365999; name = "Dropsuits"; }
    let private marketGroup366174()= {MarketGroupData.id = 366174; parentId = Some 365997; name = "Dropsuits"; }
    let private marketGroup366178()= {MarketGroupData.id = 366178; parentId = Some 365996; name = "Weapons"; }
    let private marketGroup366180()= {MarketGroupData.id = 366180; parentId = Some 365998; name = "Weapons"; }
    let private marketGroup366181()= {MarketGroupData.id = 366181; parentId = Some 365999; name = "Weapons"; }
    let private marketGroup366182()= {MarketGroupData.id = 366182; parentId = Some 365996; name = "Vehicles"; }
    let private marketGroup366185()= {MarketGroupData.id = 366185; parentId = Some 365999; name = "Vehicles"; }
    let private marketGroup366189()= {MarketGroupData.id = 366189; parentId = Some 365999; name = "Turrets"; }
    let private marketGroup366186()= {MarketGroupData.id = 366186; parentId = Some 365996; name = "Turrets"; }
    let private marketGroup366190()= {MarketGroupData.id = 366190; parentId = Some 365996; name = "Dropsuit Modules"; }
    let private marketGroup366191()= {MarketGroupData.id = 366191; parentId = Some 365997; name = "Dropsuit Modules"; }
    let private marketGroup366193()= {MarketGroupData.id = 366193; parentId = Some 365998; name = "Dropsuit Modules"; }
    let private marketGroup366194()= {MarketGroupData.id = 366194; parentId = Some 365999; name = "Dropsuit Modules"; }
    let private marketGroup366197()= {MarketGroupData.id = 366197; parentId = Some 366174; name = "Standard"; }
    let private marketGroup366198()= {MarketGroupData.id = 366198; parentId = Some 366174; name = "Advanced"; }
    let private marketGroup366199()= {MarketGroupData.id = 366199; parentId = Some 366174; name = "Prototype"; }
    let private marketGroup366200()= {MarketGroupData.id = 366200; parentId = Some 366173; name = "Standard"; }
    let private marketGroup366201()= {MarketGroupData.id = 366201; parentId = Some 366173; name = "Advanced"; }
    let private marketGroup366202()= {MarketGroupData.id = 366202; parentId = Some 366173; name = "Prototype"; }
    let private marketGroup366203()= {MarketGroupData.id = 366203; parentId = Some 366175; name = "Standard"; }
    let private marketGroup366204()= {MarketGroupData.id = 366204; parentId = Some 366175; name = "Advanced"; }
    let private marketGroup366205()= {MarketGroupData.id = 366205; parentId = Some 366175; name = "Prototype"; }
    let private marketGroup366206()= {MarketGroupData.id = 366206; parentId = Some 366177; name = "Standard"; }
    let private marketGroup366207()= {MarketGroupData.id = 366207; parentId = Some 366177; name = "Advanced"; }
    let private marketGroup366208()= {MarketGroupData.id = 366208; parentId = Some 366177; name = "Prototype"; }
    let private marketGroup366209()= {MarketGroupData.id = 366209; parentId = Some 366182; name = "Standard"; }
    let private marketGroup366210()= {MarketGroupData.id = 366210; parentId = Some 366186; name = "Standard"; }
    let private marketGroup366211()= {MarketGroupData.id = 366211; parentId = Some 366186; name = "Advanced"; }
    let private marketGroup366212()= {MarketGroupData.id = 366212; parentId = Some 366186; name = "Prototype"; }
    let private marketGroup366213()= {MarketGroupData.id = 366213; parentId = Some 366189; name = "Standard"; }
    let private marketGroup366214()= {MarketGroupData.id = 366214; parentId = Some 366189; name = "Advanced"; }
    let private marketGroup366215()= {MarketGroupData.id = 366215; parentId = Some 366189; name = "Prototype"; }
    let private marketGroup366216()= {MarketGroupData.id = 366216; parentId = Some 366185; name = "Standard"; }
    let private marketGroup366219()= {MarketGroupData.id = 366219; parentId = Some 366181; name = "Standard"; }
    let private marketGroup366220()= {MarketGroupData.id = 366220; parentId = Some 366181; name = "Advanced"; }
    let private marketGroup366221()= {MarketGroupData.id = 366221; parentId = Some 366181; name = "Prototype"; }
    let private marketGroup366222()= {MarketGroupData.id = 366222; parentId = Some 366178; name = "Standard"; }
    let private marketGroup366223()= {MarketGroupData.id = 366223; parentId = Some 366178; name = "Advanced"; }
    let private marketGroup366224()= {MarketGroupData.id = 366224; parentId = Some 366178; name = "Prototype"; }
    let private marketGroup366253()= {MarketGroupData.id = 366253; parentId = Some 366190; name = "Standard"; }
    let private marketGroup366254()= {MarketGroupData.id = 366254; parentId = Some 366190; name = "Advanced"; }
    let private marketGroup366255()= {MarketGroupData.id = 366255; parentId = Some 366190; name = "Prototype"; }
    let private marketGroup366257()= {MarketGroupData.id = 366257; parentId = Some 366179; name = "Standard"; }
    let private marketGroup366258()= {MarketGroupData.id = 366258; parentId = Some 366179; name = "Advanced"; }
    let private marketGroup366259()= {MarketGroupData.id = 366259; parentId = Some 366179; name = "Prototype"; }
    let private marketGroup366260()= {MarketGroupData.id = 366260; parentId = Some 365996; name = "Equipment"; }
    let private marketGroup366261()= {MarketGroupData.id = 366261; parentId = Some 366260; name = "Standard"; }
    let private marketGroup366262()= {MarketGroupData.id = 366262; parentId = Some 366260; name = "Advanced"; }
    let private marketGroup366263()= {MarketGroupData.id = 366263; parentId = Some 366260; name = "Prototype"; }
    let private marketGroup366264()= {MarketGroupData.id = 366264; parentId = Some 365997; name = "Equipment"; }
    let private marketGroup366265()= {MarketGroupData.id = 366265; parentId = Some 366264; name = "Standard"; }
    let private marketGroup366266()= {MarketGroupData.id = 366266; parentId = Some 366264; name = "Advanced"; }
    let private marketGroup366267()= {MarketGroupData.id = 366267; parentId = Some 366264; name = "Prototype"; }
    let private marketGroup366268()= {MarketGroupData.id = 366268; parentId = Some 366191; name = "Standard"; }
    let private marketGroup366269()= {MarketGroupData.id = 366269; parentId = Some 366191; name = "Advanced"; }
    let private marketGroup366271()= {MarketGroupData.id = 366271; parentId = Some 366191; name = "Prototype"; }
    let private marketGroup366272()= {MarketGroupData.id = 366272; parentId = Some 366180; name = "Standard"; }
    let private marketGroup366273()= {MarketGroupData.id = 366273; parentId = Some 366180; name = "Advanced"; }
    let private marketGroup366274()= {MarketGroupData.id = 366274; parentId = Some 366180; name = "Prototype"; }
    let private marketGroup366275()= {MarketGroupData.id = 366275; parentId = Some 365998; name = "Equipment"; }
    let private marketGroup366276()= {MarketGroupData.id = 366276; parentId = Some 366275; name = "Standard"; }
    let private marketGroup366277()= {MarketGroupData.id = 366277; parentId = Some 366275; name = "Advanced"; }
    let private marketGroup366278()= {MarketGroupData.id = 366278; parentId = Some 366275; name = "Prototype"; }
    let private marketGroup366279()= {MarketGroupData.id = 366279; parentId = Some 366193; name = "Standard"; }
    let private marketGroup366280()= {MarketGroupData.id = 366280; parentId = Some 366193; name = "Advanced"; }
    let private marketGroup366281()= {MarketGroupData.id = 366281; parentId = Some 366193; name = "Prototype"; }
    let private marketGroup366282()= {MarketGroupData.id = 366282; parentId = Some 365999; name = "Equipment"; }
    let private marketGroup366283()= {MarketGroupData.id = 366283; parentId = Some 366282; name = "Standard"; }
    let private marketGroup366284()= {MarketGroupData.id = 366284; parentId = Some 366282; name = "Advanced"; }
    let private marketGroup366285()= {MarketGroupData.id = 366285; parentId = Some 366282; name = "Prototype"; }
    let private marketGroup366286()= {MarketGroupData.id = 366286; parentId = Some 366194; name = "Standard"; }
    let private marketGroup366287()= {MarketGroupData.id = 366287; parentId = Some 366194; name = "Advanced"; }
    let private marketGroup366288()= {MarketGroupData.id = 366288; parentId = Some 366194; name = "Prototype"; }
    let private marketGroup366350()= {MarketGroupData.id = 366350; parentId = Some 354534; name = "Faction Booster Caldari"; }
    let private marketGroup366351()= {MarketGroupData.id = 366351; parentId = Some 354534; name = "Faction Booster Gallente"; }
    let private marketGroup366352()= {MarketGroupData.id = 366352; parentId = Some 354534; name = "Faction Booster Minmatar"; }
    let private marketGroup365898()= {MarketGroupData.id = 365898; parentId = Some 353592; name = "Ammo Expansion Units"; }
    let private marketGroup365899()= {MarketGroupData.id = 365899; parentId = Some 365898; name = "Blaster Ammo Expansion Units"; }
    let private marketGroup365900()= {MarketGroupData.id = 365900; parentId = Some 365898; name = "Missile Launcher Ammo Expansion Units"; }
    let private marketGroup365901()= {MarketGroupData.id = 365901; parentId = Some 365898; name = "Railgun Ammo Expansion Units"; }
    let private marketGroup365995()= {MarketGroupData.id = 365995; parentId = Some 350001; name = "Loyalty Store"; }
    let private marketGroup365996()= {MarketGroupData.id = 365996; parentId = Some 365995; name = "Federal Marines"; }
    let private marketGroup365997()= {MarketGroupData.id = 365997; parentId = Some 365995; name = "Imperial Guard"; }
    let private marketGroup365998()= {MarketGroupData.id = 365998; parentId = Some 365995; name = "Republic Command"; }
    let private marketGroup365999()= {MarketGroupData.id = 365999; parentId = Some 365995; name = "State Peacekeepers"; }
    let private marketGroup366570()= {MarketGroupData.id = 366570; parentId = Some 364048; name = "Bolt Pistols"; }
    let private marketGroup366571()= {MarketGroupData.id = 366571; parentId = Some 366570; name = "Standard"; }
    let private marketGroup366572()= {MarketGroupData.id = 366572; parentId = Some 366570; name = "Advanced"; }
    let private marketGroup366573()= {MarketGroupData.id = 366573; parentId = Some 366570; name = "Prototype"; }
    let private marketGroup366574()= {MarketGroupData.id = 366574; parentId = Some 364048; name = "Magsec SMGs"; }
    let private marketGroup366575()= {MarketGroupData.id = 366575; parentId = Some 366574; name = "Standard"; }
    let private marketGroup366576()= {MarketGroupData.id = 366576; parentId = Some 366574; name = "Advanced"; }
    let private marketGroup366577()= {MarketGroupData.id = 366577; parentId = Some 366574; name = "Prototype"; }
    let private marketGroup406()= {MarketGroupData.id = 406; parentId = Some 1338; name = "Deployable Structures"; }
    let private marketGroup1841()= {MarketGroupData.id = 1841; parentId = Some 1338; name = "Starbase Structures"; }
    let private marketGroup1534()= {MarketGroupData.id = 1534; parentId = Some 1841; name = "Weapon Batteries"; }
    let private marketGroup404()= {MarketGroupData.id = 404; parentId = Some 477; name = "Deployable Structures"; }
    let private marketGroup366741()= {MarketGroupData.id = 366741; parentId = Some 364048; name = "Ion Pistols"; }
    let private marketGroup366742()= {MarketGroupData.id = 366742; parentId = Some 366741; name = "Standard"; }
    let private marketGroup366743()= {MarketGroupData.id = 366743; parentId = Some 366741; name = "Advanced"; }
    let private marketGroup366744()= {MarketGroupData.id = 366744; parentId = Some 366741; name = "Prototype"; }
    let private marketGroup366752()= {MarketGroupData.id = 366752; parentId = Some 353563; name = "Cloak Fields"; }
    let private marketGroup366753()= {MarketGroupData.id = 366753; parentId = Some 366752; name = "Standard"; }
    let private marketGroup366754()= {MarketGroupData.id = 366754; parentId = Some 366752; name = "Advanced"; }
    let private marketGroup366755()= {MarketGroupData.id = 366755; parentId = Some 366752; name = "Prototype"; }
    let private marketGroup1850()= {MarketGroupData.id = 1850; parentId = Some 1849; name = "Simple Reactions"; }
    let private marketGroup1851()= {MarketGroupData.id = 1851; parentId = Some 1849; name = "Complex Reactions"; }
    let private marketGroup1852()= {MarketGroupData.id = 1852; parentId = Some 1849; name = "Simple Biochemical Reactions"; }
    let private marketGroup1853()= {MarketGroupData.id = 1853; parentId = Some 1849; name = "Complex Biochemical Reactions"; }
    let private marketGroup1854()= {MarketGroupData.id = 1854; parentId = Some 1849; name = "Polymer Reactions"; }
    let private marketGroup1033()= {MarketGroupData.id = 1033; parentId = Some 533; name = "Ice Products"; }
    let private marketGroup1855()= {MarketGroupData.id = 1855; parentId = Some 1031; name = "Ice Ores"; }
    let private marketGroup1856()= {MarketGroupData.id = 1856; parentId = Some 1031; name = "Alloys & Compounds"; }
    let private marketGroup1857()= {MarketGroupData.id = 1857; parentId = Some 533; name = "Minerals"; }
    let private marketGroup1858()= {MarketGroupData.id = 1858; parentId = Some 1034; name = "Booster Materials"; }
    let private marketGroup1859()= {MarketGroupData.id = 1859; parentId = Some 1032; name = "Fullerenes"; }
    let private marketGroup1032()= {MarketGroupData.id = 1032; parentId = Some 533; name = "Gas Clouds Materials"; }
    let private marketGroup1860()= {MarketGroupData.id = 1860; parentId = Some 1034; name = "Polymer Materials"; }
    let private marketGroup501()= {MarketGroupData.id = 501; parentId = Some 1034; name = "Raw Moon Materials"; }
    let private marketGroup500()= {MarketGroupData.id = 500; parentId = Some 1034; name = "Processed Moon Materials"; }
    let private marketGroup499()= {MarketGroupData.id = 499; parentId = Some 1034; name = "Advanced Moon Materials"; }
    let private marketGroup1333()= {MarketGroupData.id = 1333; parentId = Some 1332; name = "Raw Planetary Materials"; }
    let private marketGroup1334()= {MarketGroupData.id = 1334; parentId = Some 1332; name = "Processed Planetary Materials"; }
    let private marketGroup1335()= {MarketGroupData.id = 1335; parentId = Some 1332; name = "Refined Planetary Materials"; }
    let private marketGroup1336()= {MarketGroupData.id = 1336; parentId = Some 1332; name = "Specialized Planetary Materials"; }
    let private marketGroup1337()= {MarketGroupData.id = 1337; parentId = Some 1332; name = "Advanced Planetary Materials"; }
    let private marketGroup1861()= {MarketGroupData.id = 1861; parentId = Some 533; name = "Salvage Materials"; }
    let private marketGroup1862()= {MarketGroupData.id = 1862; parentId = Some 1861; name = "Ancient Salvaged Materials"; }
    let private marketGroup1863()= {MarketGroupData.id = 1863; parentId = Some 1861; name = "Salvaged Materials"; }
    let private marketGroup983()= {MarketGroupData.id = 983; parentId = Some 1032; name = "Booster Gas Clouds"; }
    let private marketGroup802()= {MarketGroupData.id = 802; parentId = Some 65; name = "Amarr"; }
    let private marketGroup803()= {MarketGroupData.id = 803; parentId = Some 65; name = "Caldari"; }
    let private marketGroup65()= {MarketGroupData.id = 65; parentId = Some 1035; name = "Advanced Components"; }
    let private marketGroup1864()= {MarketGroupData.id = 1864; parentId = Some 1021; name = "Construction Platforms"; }
    let private marketGroup1865()= {MarketGroupData.id = 1865; parentId = Some 1021; name = "Station Components"; }
    let private marketGroup1022()= {MarketGroupData.id = 1022; parentId = Some 1021; name = "Improvement Platforms"; }
    let private marketGroup1866()= {MarketGroupData.id = 1866; parentId = Some 1022; name = "Amarr Improvement Platforms"; }
    let private marketGroup1867()= {MarketGroupData.id = 1867; parentId = Some 1022; name = "Caldari Improvement Platforms"; }
    let private marketGroup1868()= {MarketGroupData.id = 1868; parentId = Some 1022; name = "Gallente Improvement Platforms"; }
    let private marketGroup1869()= {MarketGroupData.id = 1869; parentId = Some 1022; name = "Minmatar Improvement Platforms"; }
    let private marketGroup1870()= {MarketGroupData.id = 1870; parentId = Some 1035; name = "Fuel Blocks"; }
    let private marketGroup781()= {MarketGroupData.id = 781; parentId = Some 1035; name = "Standard Capital Ship Components"; }
    let private marketGroup1872()= {MarketGroupData.id = 1872; parentId = Some 475; name = "Research Equipment"; }
    let private marketGroup1880()= {MarketGroupData.id = 1880; parentId = Some 1872; name = "Datacores"; }
    let private marketGroup1883()= {MarketGroupData.id = 1883; parentId = Some 1035; name = "Advanced Capital Components"; }
    let private marketGroup1884()= {MarketGroupData.id = 1884; parentId = Some 1883; name = "Amarr"; }
    let private marketGroup1885()= {MarketGroupData.id = 1885; parentId = Some 1883; name = "Caldari"; }
    let private marketGroup1886()= {MarketGroupData.id = 1886; parentId = Some 1883; name = "Gallente"; }
    let private marketGroup1887()= {MarketGroupData.id = 1887; parentId = Some 1883; name = "Minmatar"; }
    let private marketGroup1888()= {MarketGroupData.id = 1888; parentId = Some 65; name = "Gallente"; }
    let private marketGroup1889()= {MarketGroupData.id = 1889; parentId = Some 65; name = "Minmatar"; }
    let private marketGroup1897()= {MarketGroupData.id = 1897; parentId = Some 533; name = "Faction Materials"; }
    let private marketGroup1898()= {MarketGroupData.id = 1898; parentId = Some 1897; name = "Angel Cartel"; }
    let private marketGroup1899()= {MarketGroupData.id = 1899; parentId = Some 1897; name = "Blood Raiders"; }
    let private marketGroup1900()= {MarketGroupData.id = 1900; parentId = Some 1897; name = "Guristas"; }
    let private marketGroup1901()= {MarketGroupData.id = 1901; parentId = Some 1897; name = "Serpentis"; }
    let private marketGroup1902()= {MarketGroupData.id = 1902; parentId = Some 1897; name = "Sleeper"; }
    let private marketGroup1903()= {MarketGroupData.id = 1903; parentId = Some 1897; name = "Talocan"; }
    let private marketGroup1904()= {MarketGroupData.id = 1904; parentId = Some 1897; name = "Yan Jung"; }
    let private marketGroup1905()= {MarketGroupData.id = 1905; parentId = Some 1897; name = "Takmahl"; }
    let private marketGroup1906()= {MarketGroupData.id = 1906; parentId = Some 1897; name = "Rogue Drones"; }
    let private marketGroup1907()= {MarketGroupData.id = 1907; parentId = Some 1872; name = "R.Db"; }
    let private marketGroup1908()= {MarketGroupData.id = 1908; parentId = Some 1035; name = "R.A.M."; }
    let private marketGroup1147()= {MarketGroupData.id = 1147; parentId = Some 1035; name = "Subsystem Components"; }
    let private marketGroup1909()= {MarketGroupData.id = 1909; parentId = Some 1872; name = "Ancient Relics"; }
    let private marketGroup1016()= {MarketGroupData.id = 1016; parentId = Some 211; name = "Bombs"; }
    let private marketGroup339()= {MarketGroupData.id = 339; parentId = Some 211; name = "Cap Booster Charges"; }
    let private marketGroup753()= {MarketGroupData.id = 753; parentId = Some 211; name = "Mining Crystals"; }
    let private marketGroup1358()= {MarketGroupData.id = 1358; parentId = Some 211; name = "Nanite Repair Paste"; }
    let private marketGroup1105()= {MarketGroupData.id = 1105; parentId = Some 211; name = "Scripts"; }
    let private marketGroup1408()= {MarketGroupData.id = 1408; parentId = Some 1407; name = "Eyewear"; }
    let private marketGroup1836()= {MarketGroupData.id = 1836; parentId = Some 1407; name = "Augmentations"; }
    let private marketGroup1822()= {MarketGroupData.id = 1822; parentId = Some 1407; name = "Tattoos"; }
    let private marketGroup1401()= {MarketGroupData.id = 1401; parentId = Some 1397; name = "Bottoms"; }
    let private marketGroup1400()= {MarketGroupData.id = 1400; parentId = Some 1397; name = "Footwear"; }
    let private marketGroup1399()= {MarketGroupData.id = 1399; parentId = Some 1397; name = "Outerwear"; }
    let private marketGroup1398()= {MarketGroupData.id = 1398; parentId = Some 1397; name = "Tops"; }
    let private marketGroup1403()= {MarketGroupData.id = 1403; parentId = Some 1402; name = "Bottoms"; }
    let private marketGroup1404()= {MarketGroupData.id = 1404; parentId = Some 1402; name = "Footwear"; }
    let private marketGroup1405()= {MarketGroupData.id = 1405; parentId = Some 1402; name = "Outerwear"; }
    let private marketGroup1406()= {MarketGroupData.id = 1406; parentId = Some 1402; name = "Tops"; }
    let private marketGroup1567()= {MarketGroupData.id = 1567; parentId = Some 1566; name = "Electronic Counter Measures"; }
    let private marketGroup1568()= {MarketGroupData.id = 1568; parentId = Some 1566; name = "ECM Burst"; }
    let private marketGroup1570()= {MarketGroupData.id = 1570; parentId = Some 1566; name = "Stasis Webifiers"; }
    let private marketGroup1571()= {MarketGroupData.id = 1571; parentId = Some 1566; name = "Target Painters"; }
    let private marketGroup1572()= {MarketGroupData.id = 1572; parentId = Some 1566; name = "Warp Disruption Field Generators"; }
    let private marketGroup1574()= {MarketGroupData.id = 1574; parentId = Some 1566; name = "Weapon Disruptors"; }
    let private marketGroup1575()= {MarketGroupData.id = 1575; parentId = Some 1566; name = "ECCM"; }
    let private marketGroup1576()= {MarketGroupData.id = 1576; parentId = Some 1566; name = "Remote Sensor Dampeners"; }
    let private marketGroup1577()= {MarketGroupData.id = 1577; parentId = Some 1566; name = "Projected ECCM"; }
    let private marketGroup1583()= {MarketGroupData.id = 1583; parentId = Some 1566; name = "Sensor Backup Arrays"; }
    let private marketGroup430()= {MarketGroupData.id = 430; parentId = Some 1578; name = "Cloaking Devices"; }
    let private marketGroup905()= {MarketGroupData.id = 905; parentId = Some 1578; name = "Tractor Beams"; }
    let private marketGroup1579()= {MarketGroupData.id = 1579; parentId = Some 1578; name = "Automated Targeting Systems"; }
    let private marketGroup1580()= {MarketGroupData.id = 1580; parentId = Some 1578; name = "Remote Sensor Boosters"; }
    let private marketGroup1581()= {MarketGroupData.id = 1581; parentId = Some 1578; name = "Sensor Boosters"; }
    let private marketGroup1582()= {MarketGroupData.id = 1582; parentId = Some 1578; name = "Passive Targeting Systems"; }
    let private marketGroup1584()= {MarketGroupData.id = 1584; parentId = Some 1578; name = "CPU Upgrades"; }
    let private marketGroup1585()= {MarketGroupData.id = 1585; parentId = Some 1578; name = "Signal Amplifiers"; }
    let private marketGroup1555()= {MarketGroupData.id = 1555; parentId = Some 1546; name = "Capacitor Rechargers"; }
    let private marketGroup1556()= {MarketGroupData.id = 1556; parentId = Some 1546; name = "Capacitor Flux Coils"; }
    let private marketGroup1557()= {MarketGroupData.id = 1557; parentId = Some 1546; name = "Capacitor Power Relays"; }
    let private marketGroup1558()= {MarketGroupData.id = 1558; parentId = Some 1546; name = "Capacitor Batteries"; }
    let private marketGroup1559()= {MarketGroupData.id = 1559; parentId = Some 1546; name = "Auxiliary Power Controls"; }
    let private marketGroup1560()= {MarketGroupData.id = 1560; parentId = Some 1546; name = "Power Diagnostic Systems"; }
    let private marketGroup1561()= {MarketGroupData.id = 1561; parentId = Some 1546; name = "Reactor Control Units"; }
    let private marketGroup1562()= {MarketGroupData.id = 1562; parentId = Some 1546; name = "Remote Capacitor Transmitters"; }
    let private marketGroup1563()= {MarketGroupData.id = 1563; parentId = Some 1546; name = "Capacitor Boosters"; }
    let private marketGroup1564()= {MarketGroupData.id = 1564; parentId = Some 1546; name = "Energy Nosferatu"; }
    let private marketGroup1565()= {MarketGroupData.id = 1565; parentId = Some 1546; name = "Energy Neutralizers"; }
    let private marketGroup338()= {MarketGroupData.id = 338; parentId = Some 1711; name = "Mining Lasers"; }
    let private marketGroup937()= {MarketGroupData.id = 937; parentId = Some 1711; name = "Mining Upgrades"; }
    let private marketGroup1712()= {MarketGroupData.id = 1712; parentId = Some 1711; name = "Salvagers"; }
    let private marketGroup1536()= {MarketGroupData.id = 1536; parentId = Some 214; name = "Armor Repairers"; }
    let private marketGroup1537()= {MarketGroupData.id = 1537; parentId = Some 214; name = "Hull Repairers"; }
    let private marketGroup335()= {MarketGroupData.id = 335; parentId = Some 214; name = "Hull Upgrades"; }
    let private marketGroup1538()= {MarketGroupData.id = 1538; parentId = Some 214; name = "Remote Hull Repairers"; }
    let private marketGroup1539()= {MarketGroupData.id = 1539; parentId = Some 214; name = "Remote Armor Repairers"; }
    let private marketGroup1540()= {MarketGroupData.id = 1540; parentId = Some 214; name = "Armor Hardeners"; }
    let private marketGroup1541()= {MarketGroupData.id = 1541; parentId = Some 214; name = "Armor Plates"; }
    let private marketGroup1542()= {MarketGroupData.id = 1542; parentId = Some 214; name = "Damage Controls"; }
    let private marketGroup1543()= {MarketGroupData.id = 1543; parentId = Some 214; name = "Energized Plating"; }
    let private marketGroup1544()= {MarketGroupData.id = 1544; parentId = Some 214; name = "Resistance Plating"; }
    let private marketGroup331()= {MarketGroupData.id = 331; parentId = Some 252; name = "Microwarpdrives"; }
    let private marketGroup332()= {MarketGroupData.id = 332; parentId = Some 252; name = "Propulsion Upgrades"; }
    let private marketGroup1525()= {MarketGroupData.id = 1525; parentId = Some 252; name = "Afterburners"; }
    let private marketGroup1697()= {MarketGroupData.id = 1697; parentId = Some 252; name = "Micro Jump Drives"; }
    let private marketGroup325()= {MarketGroupData.id = 325; parentId = Some 1710; name = "Scanners"; }
    let private marketGroup1198()= {MarketGroupData.id = 1198; parentId = Some 1710; name = "Scan Probe Launchers"; }
    let private marketGroup1707()= {MarketGroupData.id = 1707; parentId = Some 1710; name = "Scanning Upgrades"; }
    let private marketGroup1716()= {MarketGroupData.id = 1716; parentId = Some 1710; name = "Survey Probe Launchers"; }
    let private marketGroup1809()= {MarketGroupData.id = 1809; parentId = Some 1710; name = "Analyzers"; }
    let private marketGroup1547()= {MarketGroupData.id = 1547; parentId = Some 1545; name = "Shield Flux Coils"; }
    let private marketGroup1548()= {MarketGroupData.id = 1548; parentId = Some 1545; name = "Shield Hardeners"; }
    let private marketGroup1549()= {MarketGroupData.id = 1549; parentId = Some 1545; name = "Shield Extenders"; }
    let private marketGroup1550()= {MarketGroupData.id = 1550; parentId = Some 1545; name = "Shield Power Relays"; }
    let private marketGroup1551()= {MarketGroupData.id = 1551; parentId = Some 1545; name = "Shield Rechargers"; }
    let private marketGroup1552()= {MarketGroupData.id = 1552; parentId = Some 1545; name = "Shield Boosters"; }
    let private marketGroup1553()= {MarketGroupData.id = 1553; parentId = Some 1545; name = "Remote Shield Boosters"; }
    let private marketGroup1554()= {MarketGroupData.id = 1554; parentId = Some 1545; name = "Shield Resistance Amplifiers"; }
    let private marketGroup289()= {MarketGroupData.id = 289; parentId = Some 286; name = "Large"; }
    let private marketGroup290()= {MarketGroupData.id = 290; parentId = Some 286; name = "Medium"; }
    let private marketGroup291()= {MarketGroupData.id = 291; parentId = Some 286; name = "Small"; }
    let private marketGroup792()= {MarketGroupData.id = 792; parentId = Some 286; name = "Extra Large"; }
    let private marketGroup296()= {MarketGroupData.id = 296; parentId = Some 287; name = "Small"; }
    let private marketGroup297()= {MarketGroupData.id = 297; parentId = Some 287; name = "Medium"; }
    let private marketGroup298()= {MarketGroupData.id = 298; parentId = Some 287; name = "Large"; }
    let private marketGroup793()= {MarketGroupData.id = 793; parentId = Some 287; name = "Extra Large"; }
    let private marketGroup292()= {MarketGroupData.id = 292; parentId = Some 288; name = "Small"; }
    let private marketGroup293()= {MarketGroupData.id = 293; parentId = Some 288; name = "Medium"; }
    let private marketGroup295()= {MarketGroupData.id = 295; parentId = Some 288; name = "Large"; }
    let private marketGroup794()= {MarketGroupData.id = 794; parentId = Some 288; name = "Extra Large"; }
    let private marketGroup340()= {MarketGroupData.id = 340; parentId = Some 210; name = "Missile Launchers"; }
    let private marketGroup343()= {MarketGroupData.id = 343; parentId = Some 210; name = "Weapon Upgrades"; }
    let private marketGroup913()= {MarketGroupData.id = 913; parentId = Some 210; name = "Superweapons"; }
    let private marketGroup1019()= {MarketGroupData.id = 1019; parentId = Some 210; name = "Bomb Launchers"; }
    let private marketGroup341()= {MarketGroupData.id = 341; parentId = Some 209; name = "Smartbombs"; }
    let private marketGroup799()= {MarketGroupData.id = 799; parentId = Some 209; name = "Fleet Assistance Modules"; }
    let private marketGroup939()= {MarketGroupData.id = 939; parentId = Some 209; name = "Drone Upgrades"; }
    let private marketGroup1202()= {MarketGroupData.id = 1202; parentId = Some 944; name = "Large Armor Rigs"; }
    let private marketGroup1203()= {MarketGroupData.id = 1203; parentId = Some 944; name = "Small Armor Rigs"; }
    let private marketGroup1204()= {MarketGroupData.id = 1204; parentId = Some 944; name = "Medium Armor Rigs"; }
    let private marketGroup1719()= {MarketGroupData.id = 1719; parentId = Some 944; name = "Capital Armor Rigs"; }
    let private marketGroup1240()= {MarketGroupData.id = 1240; parentId = Some 945; name = "Small Astronautic Rigs"; }
    let private marketGroup1241()= {MarketGroupData.id = 1241; parentId = Some 945; name = "Medium Astronautic Rigs"; }
    let private marketGroup1242()= {MarketGroupData.id = 1242; parentId = Some 945; name = "Large Astronautic Rigs"; }
    let private marketGroup1720()= {MarketGroupData.id = 1720; parentId = Some 945; name = "Capital Astronautic Rigs"; }
    let private marketGroup1243()= {MarketGroupData.id = 1243; parentId = Some 946; name = "Small Drone Rigs"; }
    let private marketGroup1244()= {MarketGroupData.id = 1244; parentId = Some 946; name = "Medium Drone Rigs"; }
    let private marketGroup1245()= {MarketGroupData.id = 1245; parentId = Some 946; name = "Large Drone Rigs"; }
    let private marketGroup1721()= {MarketGroupData.id = 1721; parentId = Some 946; name = "Capital Drone Rigs"; }
    let private marketGroup1249()= {MarketGroupData.id = 1249; parentId = Some 948; name = "Small Electronics Superiority Rigs"; }
    let private marketGroup1250()= {MarketGroupData.id = 1250; parentId = Some 948; name = "Medium Electronics Superiority Rigs"; }
    let private marketGroup1251()= {MarketGroupData.id = 1251; parentId = Some 948; name = "Large Electronics Superiority Rigs"; }
    let private marketGroup1723()= {MarketGroupData.id = 1723; parentId = Some 948; name = "Capital Electronics Superiority Rigs"; }
    let private marketGroup1252()= {MarketGroupData.id = 1252; parentId = Some 949; name = "Small Engineering Rigs"; }
    let private marketGroup1253()= {MarketGroupData.id = 1253; parentId = Some 949; name = "Medium Engineering Rigs"; }
    let private marketGroup1254()= {MarketGroupData.id = 1254; parentId = Some 949; name = "Large Engineering Rigs"; }
    let private marketGroup1724()= {MarketGroupData.id = 1724; parentId = Some 949; name = "Capital Engineering Rigs"; }
    let private marketGroup1255()= {MarketGroupData.id = 1255; parentId = Some 950; name = "Small Energy Weapon Rigs"; }
    let private marketGroup1256()= {MarketGroupData.id = 1256; parentId = Some 950; name = "Medium Energy Weapon Rigs"; }
    let private marketGroup1257()= {MarketGroupData.id = 1257; parentId = Some 950; name = "Large Energy Weapon Rigs"; }
    let private marketGroup1725()= {MarketGroupData.id = 1725; parentId = Some 950; name = "Capital Energy Weapon Rigs"; }
    let private marketGroup1258()= {MarketGroupData.id = 1258; parentId = Some 951; name = "Small Hybrid Weapon Rigs"; }
    let private marketGroup1259()= {MarketGroupData.id = 1259; parentId = Some 951; name = "Medium Hybrid Weapon Rigs"; }
    let private marketGroup1260()= {MarketGroupData.id = 1260; parentId = Some 951; name = "Large Hybrid Weapon Rigs"; }
    let private marketGroup1726()= {MarketGroupData.id = 1726; parentId = Some 951; name = "Capital Hybrid Weapon Rigs"; }
    let private marketGroup1261()= {MarketGroupData.id = 1261; parentId = Some 952; name = "Small Missile Launcher Rigs"; }
    let private marketGroup1262()= {MarketGroupData.id = 1262; parentId = Some 952; name = "Medium Missile Launcher Rigs"; }
    let private marketGroup1263()= {MarketGroupData.id = 1263; parentId = Some 952; name = "Large Missile Launcher Rigs"; }
    let private marketGroup1727()= {MarketGroupData.id = 1727; parentId = Some 952; name = "Capital Missile Launcher Rigs"; }
    let private marketGroup1264()= {MarketGroupData.id = 1264; parentId = Some 953; name = "Small Projectile Weapon Rigs"; }
    let private marketGroup1265()= {MarketGroupData.id = 1265; parentId = Some 953; name = "Medium Projectile Weapon Rigs"; }
    let private marketGroup1266()= {MarketGroupData.id = 1266; parentId = Some 953; name = "Large Projectile Weapon Rigs"; }
    let private marketGroup1728()= {MarketGroupData.id = 1728; parentId = Some 953; name = "Capital Projectile Weapon Rigs"; }
    let private marketGroup1267()= {MarketGroupData.id = 1267; parentId = Some 954; name = "Small Shield Rigs"; }
    let private marketGroup1268()= {MarketGroupData.id = 1268; parentId = Some 954; name = "Medium Shield Rigs"; }
    let private marketGroup1269()= {MarketGroupData.id = 1269; parentId = Some 954; name = "Large Shield Rigs"; }
    let private marketGroup1729()= {MarketGroupData.id = 1729; parentId = Some 954; name = "Capital Shield Rigs"; }
    let private marketGroup1797()= {MarketGroupData.id = 1797; parentId = Some 1794; name = "Capital Resource Processing Rigs"; }
    let private marketGroup1798()= {MarketGroupData.id = 1798; parentId = Some 1794; name = "Large Resource Processing Rigs"; }
    let private marketGroup1799()= {MarketGroupData.id = 1799; parentId = Some 1794; name = "Medium Resource Processing Rigs"; }
    let private marketGroup1800()= {MarketGroupData.id = 1800; parentId = Some 1794; name = "Small Resource Processing Rigs"; }
    let private marketGroup1801()= {MarketGroupData.id = 1801; parentId = Some 1795; name = "Small Scanning Rigs"; }
    let private marketGroup1802()= {MarketGroupData.id = 1802; parentId = Some 1795; name = "Medium Scanning Rigs"; }
    let private marketGroup1803()= {MarketGroupData.id = 1803; parentId = Some 1795; name = "Large Scanning Rigs"; }
    let private marketGroup1804()= {MarketGroupData.id = 1804; parentId = Some 1795; name = "Capital Scanning Rigs"; }
    let private marketGroup1805()= {MarketGroupData.id = 1805; parentId = Some 1796; name = "Small Targeting Rigs"; }
    let private marketGroup1806()= {MarketGroupData.id = 1806; parentId = Some 1796; name = "Medium Targeting Rigs"; }
    let private marketGroup1807()= {MarketGroupData.id = 1807; parentId = Some 1796; name = "Large Targeting Rigs"; }
    let private marketGroup1808()= {MarketGroupData.id = 1808; parentId = Some 1796; name = "Capital Targeting Rigs"; }
    let private marketGroup407()= {MarketGroupData.id = 407; parentId = Some 406; name = "Warp Disruption Fields"; }
    let private marketGroup1008()= {MarketGroupData.id = 1008; parentId = Some 406; name = "Cargo Containers"; }
    let private marketGroup1828()= {MarketGroupData.id = 1828; parentId = Some 406; name = "Mobile Depots"; }
    let private marketGroup1829()= {MarketGroupData.id = 1829; parentId = Some 406; name = "Mobile Cynosural Inhibitors"; }
    let private marketGroup1830()= {MarketGroupData.id = 1830; parentId = Some 406; name = "Mobile Tractor Units"; }
    let private marketGroup1834()= {MarketGroupData.id = 1834; parentId = Some 406; name = "Mobile Siphon Units"; }
    let private marketGroup1842()= {MarketGroupData.id = 1842; parentId = Some 406; name = "Mobile Micro Jump Units"; }
    let private marketGroup1843()= {MarketGroupData.id = 1843; parentId = Some 406; name = "Mobile Scan Inhibitors"; }
    let private marketGroup1339()= {MarketGroupData.id = 1339; parentId = Some 1841; name = "Control Towers"; }
    let private marketGroup1340()= {MarketGroupData.id = 1340; parentId = Some 1841; name = "Assembly Arrays"; }
    let private marketGroup1341()= {MarketGroupData.id = 1341; parentId = Some 1841; name = "Corporate Hangar Arrays"; }
    let private marketGroup1342()= {MarketGroupData.id = 1342; parentId = Some 1841; name = "Cynosural Generator Arrays"; }
    let private marketGroup1343()= {MarketGroupData.id = 1343; parentId = Some 1841; name = "Cynosural System Jammers"; }
    let private marketGroup1346()= {MarketGroupData.id = 1346; parentId = Some 1841; name = "Jump Bridge"; }
    let private marketGroup1351()= {MarketGroupData.id = 1351; parentId = Some 1841; name = "Reactors"; }
    let private marketGroup1352()= {MarketGroupData.id = 1352; parentId = Some 1841; name = "Moon Harvesting Arrays"; }
    let private marketGroup1353()= {MarketGroupData.id = 1353; parentId = Some 1841; name = "Reprocessing Arrays"; }
    let private marketGroup1354()= {MarketGroupData.id = 1354; parentId = Some 1841; name = "Shield Hardening Arrays"; }
    let private marketGroup1355()= {MarketGroupData.id = 1355; parentId = Some 1841; name = "Silos"; }
    let private marketGroup1359()= {MarketGroupData.id = 1359; parentId = Some 1841; name = "Laboratories"; }
    let private marketGroup1344()= {MarketGroupData.id = 1344; parentId = Some 1534; name = "Electronic Warfare Batteries"; }
    let private marketGroup1345()= {MarketGroupData.id = 1345; parentId = Some 1534; name = "Energy Neutralization Batteries"; }
    let private marketGroup1347()= {MarketGroupData.id = 1347; parentId = Some 1534; name = "Hybrid Batteries"; }
    let private marketGroup1348()= {MarketGroupData.id = 1348; parentId = Some 1534; name = "Laser Batteries"; }
    let private marketGroup1349()= {MarketGroupData.id = 1349; parentId = Some 1534; name = "Missile Batteries"; }
    let private marketGroup1350()= {MarketGroupData.id = 1350; parentId = Some 1534; name = "Projectile Batteries"; }
    let private marketGroup1535()= {MarketGroupData.id = 1535; parentId = Some 1841; name = "Ship Maintenance Arrays"; }
    let private marketGroup1701()= {MarketGroupData.id = 1701; parentId = Some 1841; name = "Personal Hangar Arrays"; }
    let private marketGroup359()= {MarketGroupData.id = 359; parentId = Some 1530; name = "Heavy Attack Drones"; }
    let private marketGroup1531()= {MarketGroupData.id = 1531; parentId = Some 1530; name = "Light Scout Drones"; }
    let private marketGroup1532()= {MarketGroupData.id = 1532; parentId = Some 1530; name = "Medium Scout Drones"; }
    let private marketGroup1533()= {MarketGroupData.id = 1533; parentId = Some 1530; name = "Sentry Drones"; }
    let private marketGroup358()= {MarketGroupData.id = 358; parentId = Some 357; name = "Mining Drones"; }
    let private marketGroup1029()= {MarketGroupData.id = 1029; parentId = Some 357; name = "Electronic Warfare Drones"; }
    let private marketGroup1030()= {MarketGroupData.id = 1030; parentId = Some 357; name = "Logistic Drones"; }
    let private marketGroup1586()= {MarketGroupData.id = 1586; parentId = Some 357; name = "Combat Utility Drones"; }
    let private marketGroup1643()= {MarketGroupData.id = 1643; parentId = Some 357; name = "Salvage Drones"; }
    let private marketGroup977()= {MarketGroupData.id = 977; parentId = Some 24; name = "Booster"; }
    let private marketGroup618()= {MarketGroupData.id = 618; parentId = Some 532; name = "Implant Slot 01"; }
    let private marketGroup619()= {MarketGroupData.id = 619; parentId = Some 532; name = "Implant Slot 02"; }
    let private marketGroup620()= {MarketGroupData.id = 620; parentId = Some 532; name = "Implant Slot 03"; }
    let private marketGroup621()= {MarketGroupData.id = 621; parentId = Some 532; name = "Implant Slot 04"; }
    let private marketGroup622()= {MarketGroupData.id = 622; parentId = Some 532; name = "Implant Slot 05"; }
    let private marketGroup1514()= {MarketGroupData.id = 1514; parentId = Some 1469; name = "Implant Slot 06"; }
    let private marketGroup1515()= {MarketGroupData.id = 1515; parentId = Some 1469; name = "Implant Slot 07"; }
    let private marketGroup1516()= {MarketGroupData.id = 1516; parentId = Some 1469; name = "Implant Slot 08"; }
    let private marketGroup1517()= {MarketGroupData.id = 1517; parentId = Some 1469; name = "Implant Slot 09"; }
    let private marketGroup1518()= {MarketGroupData.id = 1518; parentId = Some 1469; name = "Implant Slot 10"; }
    let private marketGroup1512()= {MarketGroupData.id = 1512; parentId = Some 1470; name = "Implant Slot 08"; }
    let private marketGroup1513()= {MarketGroupData.id = 1513; parentId = Some 1470; name = "Implant Slot 09"; }
    let private marketGroup1507()= {MarketGroupData.id = 1507; parentId = Some 1471; name = "Implant Slot 06"; }
    let private marketGroup1508()= {MarketGroupData.id = 1508; parentId = Some 1471; name = "Implant Slot 07"; }
    let private marketGroup1509()= {MarketGroupData.id = 1509; parentId = Some 1471; name = "Implant Slot 08"; }
    let private marketGroup1506()= {MarketGroupData.id = 1506; parentId = Some 1472; name = "Implant Slot 06"; }
    let private marketGroup1498()= {MarketGroupData.id = 1498; parentId = Some 1473; name = "Implant Slot 06"; }
    let private marketGroup1499()= {MarketGroupData.id = 1499; parentId = Some 1473; name = "Implant Slot 07"; }
    let private marketGroup1500()= {MarketGroupData.id = 1500; parentId = Some 1473; name = "Implant Slot 08"; }
    let private marketGroup1501()= {MarketGroupData.id = 1501; parentId = Some 1473; name = "Implant Slot 09"; }
    let private marketGroup1502()= {MarketGroupData.id = 1502; parentId = Some 1473; name = "Implant Slot 10"; }
    let private marketGroup1504()= {MarketGroupData.id = 1504; parentId = Some 1474; name = "Implant Slot 08"; }
    let private marketGroup1505()= {MarketGroupData.id = 1505; parentId = Some 1475; name = "Implant Slot 10"; }
    let private marketGroup1493()= {MarketGroupData.id = 1493; parentId = Some 1476; name = "Implant Slot 06"; }
    let private marketGroup1494()= {MarketGroupData.id = 1494; parentId = Some 1476; name = "Implant Slot 07"; }
    let private marketGroup1495()= {MarketGroupData.id = 1495; parentId = Some 1476; name = "Implant Slot 08"; }
    let private marketGroup1497()= {MarketGroupData.id = 1497; parentId = Some 1476; name = "Implant Slot 10"; }
    let private marketGroup1496()= {MarketGroupData.id = 1496; parentId = Some 1476; name = "Implant Slot 09"; }
    let private marketGroup1489()= {MarketGroupData.id = 1489; parentId = Some 1477; name = "Implant Slot 06"; }
    let private marketGroup1490()= {MarketGroupData.id = 1490; parentId = Some 1477; name = "Implant Slot 07"; }
    let private marketGroup1491()= {MarketGroupData.id = 1491; parentId = Some 1477; name = "Implant Slot 08"; }
    let private marketGroup1492()= {MarketGroupData.id = 1492; parentId = Some 1477; name = "Implant Slot 09"; }
    let private marketGroup1484()= {MarketGroupData.id = 1484; parentId = Some 1478; name = "Implant Slot 06"; }
    let private marketGroup1485()= {MarketGroupData.id = 1485; parentId = Some 1478; name = "Implant Slot 07"; }
    let private marketGroup1486()= {MarketGroupData.id = 1486; parentId = Some 1478; name = "Implant Slot 08"; }
    let private marketGroup1480()= {MarketGroupData.id = 1480; parentId = Some 1479; name = "Implant Slot 06"; }
    let private marketGroup1481()= {MarketGroupData.id = 1481; parentId = Some 1479; name = "Implant Slot 07"; }
    let private marketGroup1482()= {MarketGroupData.id = 1482; parentId = Some 1479; name = "Implant Slot 08"; }
    let private marketGroup1483()= {MarketGroupData.id = 1483; parentId = Some 1479; name = "Implant Slot 09"; }
    let private marketGroup1765()= {MarketGroupData.id = 1765; parentId = Some 1761; name = "Implant Slot 07"; }
    let private marketGroup1766()= {MarketGroupData.id = 1766; parentId = Some 1761; name = "Implant Slot 08"; }
    let private marketGroup1767()= {MarketGroupData.id = 1767; parentId = Some 1762; name = "Implant Slot 10"; }
    let private marketGroup1768()= {MarketGroupData.id = 1768; parentId = Some 1762; name = "Implant Slot 08"; }
    let private marketGroup1769()= {MarketGroupData.id = 1769; parentId = Some 1762; name = "Implant Slot 07"; }
    let private marketGroup1770()= {MarketGroupData.id = 1770; parentId = Some 1763; name = "Implant Slot 06"; }
    let private marketGroup1771()= {MarketGroupData.id = 1771; parentId = Some 1763; name = "Implant Slot 07"; }
    let private marketGroup1772()= {MarketGroupData.id = 1772; parentId = Some 1763; name = "Implant Slot 08"; }
    let private marketGroup1773()= {MarketGroupData.id = 1773; parentId = Some 1763; name = "Implant Slot 09"; }
    let private marketGroup1774()= {MarketGroupData.id = 1774; parentId = Some 1763; name = "Implant Slot 10"; }
    let private marketGroup1775()= {MarketGroupData.id = 1775; parentId = Some 1764; name = "Implant Slot 08"; }
    let private marketGroup1776()= {MarketGroupData.id = 1776; parentId = Some 1764; name = "Implant Slot 09"; }
    let private marketGroup1777()= {MarketGroupData.id = 1777; parentId = Some 1764; name = "Implant Slot 10"; }
    let private marketGroup866()= {MarketGroupData.id = 866; parentId = Some 852; name = "Large"; }
    let private marketGroup867()= {MarketGroupData.id = 867; parentId = Some 852; name = "Medium"; }
    let private marketGroup868()= {MarketGroupData.id = 868; parentId = Some 852; name = "Small"; }
    let private marketGroup869()= {MarketGroupData.id = 869; parentId = Some 853; name = "Large"; }
    let private marketGroup870()= {MarketGroupData.id = 870; parentId = Some 853; name = "Medium"; }
    let private marketGroup871()= {MarketGroupData.id = 871; parentId = Some 853; name = "Small"; }
    let private marketGroup995()= {MarketGroupData.id = 995; parentId = Some 994; name = "Large"; }
    let private marketGroup996()= {MarketGroupData.id = 996; parentId = Some 994; name = "Medium"; }
    let private marketGroup997()= {MarketGroupData.id = 997; parentId = Some 994; name = "Small"; }
    let private marketGroup1007()= {MarketGroupData.id = 1007; parentId = Some 994; name = "Extra Large"; }
    let private marketGroup102()= {MarketGroupData.id = 102; parentId = Some 851; name = "Small"; }
    let private marketGroup103()= {MarketGroupData.id = 103; parentId = Some 851; name = "Medium"; }
    let private marketGroup105()= {MarketGroupData.id = 105; parentId = Some 851; name = "Large"; }
    let private marketGroup503()= {MarketGroupData.id = 503; parentId = Some 851; name = "Extra Large"; }
    let private marketGroup1599()= {MarketGroupData.id = 1599; parentId = Some 101; name = "Orbital Strike"; }
    let private marketGroup860()= {MarketGroupData.id = 860; parentId = Some 849; name = "Large"; }
    let private marketGroup861()= {MarketGroupData.id = 861; parentId = Some 849; name = "Medium"; }
    let private marketGroup862()= {MarketGroupData.id = 862; parentId = Some 849; name = "Small"; }
    let private marketGroup863()= {MarketGroupData.id = 863; parentId = Some 850; name = "Large"; }
    let private marketGroup864()= {MarketGroupData.id = 864; parentId = Some 850; name = "Medium"; }
    let private marketGroup865()= {MarketGroupData.id = 865; parentId = Some 850; name = "Small"; }
    let private marketGroup991()= {MarketGroupData.id = 991; parentId = Some 990; name = "Large"; }
    let private marketGroup992()= {MarketGroupData.id = 992; parentId = Some 990; name = "Medium"; }
    let private marketGroup993()= {MarketGroupData.id = 993; parentId = Some 990; name = "Small"; }
    let private marketGroup1004()= {MarketGroupData.id = 1004; parentId = Some 990; name = "Extra Large"; }
    let private marketGroup106()= {MarketGroupData.id = 106; parentId = Some 848; name = "Large"; }
    let private marketGroup107()= {MarketGroupData.id = 107; parentId = Some 848; name = "Small"; }
    let private marketGroup108()= {MarketGroupData.id = 108; parentId = Some 848; name = "Medium"; }
    let private marketGroup504()= {MarketGroupData.id = 504; parentId = Some 848; name = "Extra Large"; }
    let private marketGroup1600()= {MarketGroupData.id = 1600; parentId = Some 100; name = "Orbital Strike"; }
    let private marketGroup914()= {MarketGroupData.id = 914; parentId = Some 115; name = "Standard Auto-Targeting"; }
    let private marketGroup1192()= {MarketGroupData.id = 1192; parentId = Some 115; name = "Faction Auto-Targeting"; }
    let private marketGroup116()= {MarketGroupData.id = 116; parentId = Some 114; name = "Defender"; }
    let private marketGroup917()= {MarketGroupData.id = 917; parentId = Some 117; name = "Advanced High Precision Light Missiles"; }
    let private marketGroup920()= {MarketGroupData.id = 920; parentId = Some 117; name = "Standard Light Missiles"; }
    let private marketGroup927()= {MarketGroupData.id = 927; parentId = Some 117; name = "Advanced High Damage Light Missiles"; }
    let private marketGroup998()= {MarketGroupData.id = 998; parentId = Some 117; name = "Faction Light Missiles"; }
    let private marketGroup922()= {MarketGroupData.id = 922; parentId = Some 118; name = "Standard Rockets"; }
    let private marketGroup928()= {MarketGroupData.id = 928; parentId = Some 118; name = "Advanced Long Range Rockets"; }
    let private marketGroup930()= {MarketGroupData.id = 930; parentId = Some 118; name = "Advanced Anti-Ship Rockets"; }
    let private marketGroup999()= {MarketGroupData.id = 999; parentId = Some 118; name = "Faction Rockets"; }
    let private marketGroup923()= {MarketGroupData.id = 923; parentId = Some 387; name = "Standard Torpedoes"; }
    let private marketGroup929()= {MarketGroupData.id = 929; parentId = Some 387; name = "Advanced Long Range Torpedoes"; }
    let private marketGroup931()= {MarketGroupData.id = 931; parentId = Some 387; name = "Advanced Anti-Ship Torpedoes"; }
    let private marketGroup1000()= {MarketGroupData.id = 1000; parentId = Some 387; name = "Faction Torpedoes"; }
    let private marketGroup1193()= {MarketGroupData.id = 1193; parentId = Some 505; name = "Standard XL Torpedoes"; }
    let private marketGroup1194()= {MarketGroupData.id = 1194; parentId = Some 505; name = "Faction XL Torpedoes"; }
    let private marketGroup918()= {MarketGroupData.id = 918; parentId = Some 580; name = "Advanced High Precision Cruise Missiles"; }
    let private marketGroup921()= {MarketGroupData.id = 921; parentId = Some 580; name = "Standard Cruise Missiles"; }
    let private marketGroup925()= {MarketGroupData.id = 925; parentId = Some 580; name = "Advanced High Damage Cruise Missiles"; }
    let private marketGroup1001()= {MarketGroupData.id = 1001; parentId = Some 580; name = "Faction Cruise Missiles"; }
    let private marketGroup919()= {MarketGroupData.id = 919; parentId = Some 581; name = "Advanced High Precision Heavy Missiles"; }
    let private marketGroup924()= {MarketGroupData.id = 924; parentId = Some 581; name = "Standard Heavy Missiles"; }
    let private marketGroup926()= {MarketGroupData.id = 926; parentId = Some 581; name = "Advanced High Damage Heavy Missiles"; }
    let private marketGroup1002()= {MarketGroupData.id = 1002; parentId = Some 581; name = "Faction Heavy Missiles"; }
    let private marketGroup971()= {MarketGroupData.id = 971; parentId = Some 968; name = "Standard Heavy Assault Missiles"; }
    let private marketGroup972()= {MarketGroupData.id = 972; parentId = Some 968; name = "Advanced Long Range Heavy Assault Missiles"; }
    let private marketGroup973()= {MarketGroupData.id = 973; parentId = Some 968; name = "Advanced Anti-Ship Heavy Assault Missile"; }
    let private marketGroup1003()= {MarketGroupData.id = 1003; parentId = Some 968; name = "Faction Heavy Assault Missiles"; }
    let private marketGroup1287()= {MarketGroupData.id = 1287; parentId = Some 1316; name = "Standard XL Cruise Missiles"; }
    let private marketGroup1317()= {MarketGroupData.id = 1317; parentId = Some 1316; name = "Faction XL Cruise Missiles"; }
    let private marketGroup1201()= {MarketGroupData.id = 1201; parentId = Some 120; name = "Interdiction Probes"; }
    let private marketGroup1199()= {MarketGroupData.id = 1199; parentId = Some 120; name = "Scan Probes"; }
    let private marketGroup1200()= {MarketGroupData.id = 1200; parentId = Some 120; name = "Survey Probes"; }
    let private marketGroup854()= {MarketGroupData.id = 854; parentId = Some 846; name = "Large"; }
    let private marketGroup855()= {MarketGroupData.id = 855; parentId = Some 846; name = "Medium"; }
    let private marketGroup856()= {MarketGroupData.id = 856; parentId = Some 846; name = "Small"; }
    let private marketGroup857()= {MarketGroupData.id = 857; parentId = Some 847; name = "Large"; }
    let private marketGroup858()= {MarketGroupData.id = 858; parentId = Some 847; name = "Medium"; }
    let private marketGroup859()= {MarketGroupData.id = 859; parentId = Some 847; name = "Small"; }
    let private marketGroup987()= {MarketGroupData.id = 987; parentId = Some 986; name = "Large"; }
    let private marketGroup988()= {MarketGroupData.id = 988; parentId = Some 986; name = "Medium"; }
    let private marketGroup989()= {MarketGroupData.id = 989; parentId = Some 986; name = "Small"; }
    let private marketGroup1006()= {MarketGroupData.id = 1006; parentId = Some 986; name = "Extra Large"; }
    let private marketGroup1598()= {MarketGroupData.id = 1598; parentId = Some 99; name = "Orbital Strike"; }
    let private marketGroup109()= {MarketGroupData.id = 109; parentId = Some 845; name = "Large"; }
    let private marketGroup112()= {MarketGroupData.id = 112; parentId = Some 845; name = "Medium"; }
    let private marketGroup113()= {MarketGroupData.id = 113; parentId = Some 845; name = "Small"; }
    let private marketGroup502()= {MarketGroupData.id = 502; parentId = Some 845; name = "Extra Large"; }
    let private marketGroup139()= {MarketGroupData.id = 139; parentId = Some 11; name = "Cap Booster Charges"; }
    let private marketGroup593()= {MarketGroupData.id = 593; parentId = Some 11; name = "Mining Crystals"; }
    let private marketGroup1015()= {MarketGroupData.id = 1015; parentId = Some 11; name = "Bombs"; }
    let private marketGroup1094()= {MarketGroupData.id = 1094; parentId = Some 11; name = "Scripts"; }
    let private marketGroup1103()= {MarketGroupData.id = 1103; parentId = Some 11; name = "Nanite Repair Paste"; }
    let private marketGroup309()= {MarketGroupData.id = 309; parentId = Some 299; name = "Large"; }
    let private marketGroup312()= {MarketGroupData.id = 312; parentId = Some 299; name = "Medium"; }
    let private marketGroup313()= {MarketGroupData.id = 313; parentId = Some 299; name = "Small"; }
    let private marketGroup597()= {MarketGroupData.id = 597; parentId = Some 299; name = "Extra Large"; }
    let private marketGroup1603()= {MarketGroupData.id = 1603; parentId = Some 299; name = "Orbital Strike"; }
    let private marketGroup306()= {MarketGroupData.id = 306; parentId = Some 300; name = "Large"; }
    let private marketGroup307()= {MarketGroupData.id = 307; parentId = Some 300; name = "Small"; }
    let private marketGroup308()= {MarketGroupData.id = 308; parentId = Some 300; name = "Medium"; }
    let private marketGroup598()= {MarketGroupData.id = 598; parentId = Some 300; name = "Extra Large"; }
    let private marketGroup1601()= {MarketGroupData.id = 1601; parentId = Some 300; name = "Orbital Strike"; }
    let private marketGroup302()= {MarketGroupData.id = 302; parentId = Some 301; name = "Small"; }
    let private marketGroup303()= {MarketGroupData.id = 303; parentId = Some 301; name = "Medium"; }
    let private marketGroup305()= {MarketGroupData.id = 305; parentId = Some 301; name = "Large"; }
    let private marketGroup599()= {MarketGroupData.id = 599; parentId = Some 301; name = "Extra Large"; }
    let private marketGroup1602()= {MarketGroupData.id = 1602; parentId = Some 301; name = "Orbital Strike"; }
    let private marketGroup315()= {MarketGroupData.id = 315; parentId = Some 314; name = "Auto-Targeting"; }
    let private marketGroup316()= {MarketGroupData.id = 316; parentId = Some 314; name = "Defender"; }
    let private marketGroup318()= {MarketGroupData.id = 318; parentId = Some 314; name = "Rockets"; }
    let private marketGroup390()= {MarketGroupData.id = 390; parentId = Some 314; name = "Torpedoes"; }
    let private marketGroup617()= {MarketGroupData.id = 617; parentId = Some 314; name = "XL Torpedoes"; }
    let private marketGroup975()= {MarketGroupData.id = 975; parentId = Some 314; name = "Heavy Assault Missiles"; }
    let private marketGroup1286()= {MarketGroupData.id = 1286; parentId = Some 314; name = "XL Cruise Missiles"; }
    let private marketGroup1526()= {MarketGroupData.id = 1526; parentId = Some 314; name = "Cruise Missiles"; }
    let private marketGroup1527()= {MarketGroupData.id = 1527; parentId = Some 314; name = "Heavy Missiles"; }
    let private marketGroup1528()= {MarketGroupData.id = 1528; parentId = Some 314; name = "Light Missiles"; }
    let private marketGroup320()= {MarketGroupData.id = 320; parentId = Some 1520; name = "Scan Probes"; }
    let private marketGroup1521()= {MarketGroupData.id = 1521; parentId = Some 1520; name = "Survey Probes"; }
    let private marketGroup1529()= {MarketGroupData.id = 1529; parentId = Some 1520; name = "Interdiction Probes"; }
    let private marketGroup261()= {MarketGroupData.id = 261; parentId = Some 205; name = "Caldari"; }
    let private marketGroup264()= {MarketGroupData.id = 264; parentId = Some 205; name = "Minmatar"; }
    let private marketGroup272()= {MarketGroupData.id = 272; parentId = Some 205; name = "Amarr"; }
    let private marketGroup277()= {MarketGroupData.id = 277; parentId = Some 205; name = "Gallente"; }
    let private marketGroup1617()= {MarketGroupData.id = 1617; parentId = Some 205; name = "ORE"; }
    let private marketGroup273()= {MarketGroupData.id = 273; parentId = Some 206; name = "Minmatar"; }
    let private marketGroup274()= {MarketGroupData.id = 274; parentId = Some 206; name = "Amarr"; }
    let private marketGroup275()= {MarketGroupData.id = 275; parentId = Some 206; name = "Caldari"; }
    let private marketGroup276()= {MarketGroupData.id = 276; parentId = Some 206; name = "Gallente"; }
    let private marketGroup278()= {MarketGroupData.id = 278; parentId = Some 207; name = "Minmatar"; }
    let private marketGroup279()= {MarketGroupData.id = 279; parentId = Some 207; name = "Amarr"; }
    let private marketGroup280()= {MarketGroupData.id = 280; parentId = Some 207; name = "Caldari"; }
    let private marketGroup281()= {MarketGroupData.id = 281; parentId = Some 207; name = "Gallente"; }
    let private marketGroup282()= {MarketGroupData.id = 282; parentId = Some 208; name = "Minmatar"; }
    let private marketGroup284()= {MarketGroupData.id = 284; parentId = Some 208; name = "Caldari"; }
    let private marketGroup285()= {MarketGroupData.id = 285; parentId = Some 208; name = "Amarr"; }
    let private marketGroup1389()= {MarketGroupData.id = 1389; parentId = Some 208; name = "ORE"; }
    let private marketGroup410()= {MarketGroupData.id = 410; parentId = Some 408; name = "Amarr"; }
    let private marketGroup411()= {MarketGroupData.id = 411; parentId = Some 408; name = "Caldari"; }
    let private marketGroup412()= {MarketGroupData.id = 412; parentId = Some 408; name = "Gallente"; }
    let private marketGroup413()= {MarketGroupData.id = 413; parentId = Some 408; name = "Minmatar"; }
    let private marketGroup415()= {MarketGroupData.id = 415; parentId = Some 414; name = "Amarr"; }
    let private marketGroup416()= {MarketGroupData.id = 416; parentId = Some 414; name = "Caldari"; }
    let private marketGroup417()= {MarketGroupData.id = 417; parentId = Some 414; name = "Gallente"; }
    let private marketGroup418()= {MarketGroupData.id = 418; parentId = Some 414; name = "Minmatar"; }
    let private marketGroup425()= {MarketGroupData.id = 425; parentId = Some 419; name = "Amarr"; }
    let private marketGroup427()= {MarketGroupData.id = 427; parentId = Some 419; name = "Caldari"; }
    let private marketGroup428()= {MarketGroupData.id = 428; parentId = Some 419; name = "Gallente"; }
    let private marketGroup429()= {MarketGroupData.id = 429; parentId = Some 419; name = "Minmatar"; }
    let private marketGroup443()= {MarketGroupData.id = 443; parentId = Some 442; name = "Amarr"; }
    let private marketGroup444()= {MarketGroupData.id = 444; parentId = Some 442; name = "Caldari"; }
    let private marketGroup445()= {MarketGroupData.id = 445; parentId = Some 442; name = "Gallente"; }
    let private marketGroup446()= {MarketGroupData.id = 446; parentId = Some 442; name = "Minmatar"; }
    let private marketGroup454()= {MarketGroupData.id = 454; parentId = Some 453; name = "Amarr"; }
    let private marketGroup455()= {MarketGroupData.id = 455; parentId = Some 453; name = "Caldari"; }
    let private marketGroup456()= {MarketGroupData.id = 456; parentId = Some 453; name = "Gallente"; }
    let private marketGroup457()= {MarketGroupData.id = 457; parentId = Some 453; name = "Minmatar"; }
    let private marketGroup459()= {MarketGroupData.id = 459; parentId = Some 458; name = "Amarr"; }
    let private marketGroup461()= {MarketGroupData.id = 461; parentId = Some 458; name = "Caldari"; }
    let private marketGroup462()= {MarketGroupData.id = 462; parentId = Some 458; name = "Gallente"; }
    let private marketGroup463()= {MarketGroupData.id = 463; parentId = Some 458; name = "Minmatar"; }
    let private marketGroup497()= {MarketGroupData.id = 497; parentId = Some 496; name = "ORE"; }
    let private marketGroup583()= {MarketGroupData.id = 583; parentId = Some 582; name = "Amarr"; }
    let private marketGroup584()= {MarketGroupData.id = 584; parentId = Some 582; name = "Caldari"; }
    let private marketGroup585()= {MarketGroupData.id = 585; parentId = Some 582; name = "Gallente"; }
    let private marketGroup586()= {MarketGroupData.id = 586; parentId = Some 582; name = "Minmatar"; }
    let private marketGroup589()= {MarketGroupData.id = 589; parentId = Some 588; name = "Amarr"; }
    let private marketGroup590()= {MarketGroupData.id = 590; parentId = Some 588; name = "Caldari"; }
    let private marketGroup591()= {MarketGroupData.id = 591; parentId = Some 588; name = "Gallente"; }
    let private marketGroup592()= {MarketGroupData.id = 592; parentId = Some 588; name = "Minmatar"; }
    let private marketGroup635()= {MarketGroupData.id = 635; parentId = Some 634; name = "Amarr"; }
    let private marketGroup636()= {MarketGroupData.id = 636; parentId = Some 634; name = "Caldari"; }
    let private marketGroup637()= {MarketGroupData.id = 637; parentId = Some 634; name = "Gallente"; }
    let private marketGroup638()= {MarketGroupData.id = 638; parentId = Some 634; name = "Minmatar"; }
    let private marketGroup783()= {MarketGroupData.id = 783; parentId = Some 782; name = "Amarr"; }
    let private marketGroup784()= {MarketGroupData.id = 784; parentId = Some 782; name = "Caldari"; }
    let private marketGroup785()= {MarketGroupData.id = 785; parentId = Some 782; name = "Gallente"; }
    let private marketGroup786()= {MarketGroupData.id = 786; parentId = Some 782; name = "Minmatar"; }
    let private marketGroup788()= {MarketGroupData.id = 788; parentId = Some 787; name = "Amarr"; }
    let private marketGroup789()= {MarketGroupData.id = 789; parentId = Some 787; name = "Caldari"; }
    let private marketGroup790()= {MarketGroupData.id = 790; parentId = Some 787; name = "Gallente"; }
    let private marketGroup791()= {MarketGroupData.id = 791; parentId = Some 787; name = "Minmatar"; }
    let private marketGroup884()= {MarketGroupData.id = 884; parentId = Some 878; name = "Amarr"; }
    let private marketGroup885()= {MarketGroupData.id = 885; parentId = Some 878; name = "Caldari"; }
    let private marketGroup886()= {MarketGroupData.id = 886; parentId = Some 878; name = "Gallente"; }
    let private marketGroup887()= {MarketGroupData.id = 887; parentId = Some 878; name = "Minmatar"; }
    let private marketGroup888()= {MarketGroupData.id = 888; parentId = Some 879; name = "Amarr"; }
    let private marketGroup889()= {MarketGroupData.id = 889; parentId = Some 879; name = "Caldari"; }
    let private marketGroup890()= {MarketGroupData.id = 890; parentId = Some 879; name = "Gallente"; }
    let private marketGroup891()= {MarketGroupData.id = 891; parentId = Some 879; name = "Minmatar"; }
    let private marketGroup892()= {MarketGroupData.id = 892; parentId = Some 880; name = "Amarr"; }
    let private marketGroup893()= {MarketGroupData.id = 893; parentId = Some 880; name = "Caldari"; }
    let private marketGroup894()= {MarketGroupData.id = 894; parentId = Some 880; name = "Gallente"; }
    let private marketGroup895()= {MarketGroupData.id = 895; parentId = Some 880; name = "Minmatar"; }
    let private marketGroup896()= {MarketGroupData.id = 896; parentId = Some 881; name = "Amarr"; }
    let private marketGroup897()= {MarketGroupData.id = 897; parentId = Some 881; name = "Caldari"; }
    let private marketGroup898()= {MarketGroupData.id = 898; parentId = Some 881; name = "Gallente"; }
    let private marketGroup899()= {MarketGroupData.id = 899; parentId = Some 881; name = "Minmatar"; }
    let private marketGroup900()= {MarketGroupData.id = 900; parentId = Some 882; name = "Amarr"; }
    let private marketGroup901()= {MarketGroupData.id = 901; parentId = Some 882; name = "Caldari"; }
    let private marketGroup902()= {MarketGroupData.id = 902; parentId = Some 882; name = "Gallente"; }
    let private marketGroup903()= {MarketGroupData.id = 903; parentId = Some 882; name = "Minmatar"; }
    let private marketGroup904()= {MarketGroupData.id = 904; parentId = Some 883; name = "ORE"; }
    let private marketGroup1046()= {MarketGroupData.id = 1046; parentId = Some 1045; name = "ORE"; }
    let private marketGroup393()= {MarketGroupData.id = 393; parentId = Some 391; name = "Amarr"; }
    let private marketGroup72()= {MarketGroupData.id = 72; parentId = Some 5; name = "Amarr"; }
    let private marketGroup400()= {MarketGroupData.id = 400; parentId = Some 399; name = "Amarr"; }
    let private marketGroup421()= {MarketGroupData.id = 421; parentId = Some 420; name = "Amarr"; }
    let private marketGroup433()= {MarketGroupData.id = 433; parentId = Some 432; name = "Amarr"; }
    let private marketGroup1066()= {MarketGroupData.id = 1066; parentId = Some 1065; name = "Amarr"; }
    let private marketGroup74()= {MarketGroupData.id = 74; parentId = Some 6; name = "Amarr"; }
    let private marketGroup438()= {MarketGroupData.id = 438; parentId = Some 437; name = "Amarr"; }
    let private marketGroup449()= {MarketGroupData.id = 449; parentId = Some 448; name = "Amarr"; }
    let private marketGroup827()= {MarketGroupData.id = 827; parentId = Some 824; name = "Amarr"; }
    let private marketGroup1071()= {MarketGroupData.id = 1071; parentId = Some 1070; name = "Amarr"; }
    let private marketGroup1139()= {MarketGroupData.id = 1139; parentId = Some 1138; name = "Amarr"; }
    let private marketGroup465()= {MarketGroupData.id = 465; parentId = Some 464; name = "Amarr"; }
    let private marketGroup826()= {MarketGroupData.id = 826; parentId = Some 823; name = "Amarr"; }
    let private marketGroup470()= {MarketGroupData.id = 470; parentId = Some 469; name = "Amarr"; }
    let private marketGroup825()= {MarketGroupData.id = 825; parentId = Some 822; name = "Amarr"; }
    let private marketGroup79()= {MarketGroupData.id = 79; parentId = Some 7; name = "Amarr"; }
    let private marketGroup1076()= {MarketGroupData.id = 1076; parentId = Some 1075; name = "Amarr"; }
    let private marketGroup1081()= {MarketGroupData.id = 1081; parentId = Some 1080; name = "Amarr"; }
    let private marketGroup762()= {MarketGroupData.id = 762; parentId = Some 761; name = "Amarr"; }
    let private marketGroup767()= {MarketGroupData.id = 767; parentId = Some 766; name = "Amarr"; }
    let private marketGroup813()= {MarketGroupData.id = 813; parentId = Some 812; name = "Amarr"; }
    let private marketGroup818()= {MarketGroupData.id = 818; parentId = Some 817; name = "Amarr"; }
    let private marketGroup1090()= {MarketGroupData.id = 1090; parentId = Some 1089; name = "Amarr"; }
    let private marketGroup85()= {MarketGroupData.id = 85; parentId = Some 8; name = "Amarr"; }
    let private marketGroup630()= {MarketGroupData.id = 630; parentId = Some 629; name = "Amarr"; }
    let private marketGroup1816()= {MarketGroupData.id = 1816; parentId = Some 1815; name = "Amarr"; }
    let private marketGroup396()= {MarketGroupData.id = 396; parentId = Some 391; name = "Caldari"; }
    let private marketGroup61()= {MarketGroupData.id = 61; parentId = Some 5; name = "Caldari"; }
    let private marketGroup401()= {MarketGroupData.id = 401; parentId = Some 399; name = "Caldari"; }
    let private marketGroup422()= {MarketGroupData.id = 422; parentId = Some 420; name = "Caldari"; }
    let private marketGroup434()= {MarketGroupData.id = 434; parentId = Some 432; name = "Caldari"; }
    let private marketGroup1067()= {MarketGroupData.id = 1067; parentId = Some 1065; name = "Caldari"; }
    let private marketGroup75()= {MarketGroupData.id = 75; parentId = Some 6; name = "Caldari"; }
    let private marketGroup439()= {MarketGroupData.id = 439; parentId = Some 437; name = "Caldari"; }
    let private marketGroup450()= {MarketGroupData.id = 450; parentId = Some 448; name = "Caldari"; }
    let private marketGroup830()= {MarketGroupData.id = 830; parentId = Some 824; name = "Caldari"; }
    let private marketGroup1072()= {MarketGroupData.id = 1072; parentId = Some 1070; name = "Caldari"; }
    let private marketGroup1140()= {MarketGroupData.id = 1140; parentId = Some 1138; name = "Caldari"; }
    let private marketGroup466()= {MarketGroupData.id = 466; parentId = Some 464; name = "Caldari"; }
    let private marketGroup829()= {MarketGroupData.id = 829; parentId = Some 823; name = "Caldari"; }
    let private marketGroup471()= {MarketGroupData.id = 471; parentId = Some 469; name = "Caldari"; }
    let private marketGroup828()= {MarketGroupData.id = 828; parentId = Some 822; name = "Caldari"; }
    let private marketGroup80()= {MarketGroupData.id = 80; parentId = Some 7; name = "Caldari"; }
    let private marketGroup1077()= {MarketGroupData.id = 1077; parentId = Some 1075; name = "Caldari"; }
    let private marketGroup1082()= {MarketGroupData.id = 1082; parentId = Some 1080; name = "Caldari"; }
    let private marketGroup763()= {MarketGroupData.id = 763; parentId = Some 761; name = "Caldari"; }
    let private marketGroup768()= {MarketGroupData.id = 768; parentId = Some 766; name = "Caldari"; }
    let private marketGroup814()= {MarketGroupData.id = 814; parentId = Some 812; name = "Caldari"; }
    let private marketGroup819()= {MarketGroupData.id = 819; parentId = Some 817; name = "Caldari"; }
    let private marketGroup1091()= {MarketGroupData.id = 1091; parentId = Some 1089; name = "Caldari"; }
    let private marketGroup84()= {MarketGroupData.id = 84; parentId = Some 8; name = "Caldari"; }
    let private marketGroup631()= {MarketGroupData.id = 631; parentId = Some 629; name = "Caldari"; }
    let private marketGroup1817()= {MarketGroupData.id = 1817; parentId = Some 1815; name = "Caldari"; }
    let private marketGroup395()= {MarketGroupData.id = 395; parentId = Some 391; name = "Gallente"; }
    let private marketGroup77()= {MarketGroupData.id = 77; parentId = Some 5; name = "Gallente"; }
    let private marketGroup402()= {MarketGroupData.id = 402; parentId = Some 399; name = "Gallente"; }
    let private marketGroup423()= {MarketGroupData.id = 423; parentId = Some 420; name = "Gallente"; }
    let private marketGroup435()= {MarketGroupData.id = 435; parentId = Some 432; name = "Gallente"; }
    let private marketGroup1068()= {MarketGroupData.id = 1068; parentId = Some 1065; name = "Gallente"; }
    let private marketGroup76()= {MarketGroupData.id = 76; parentId = Some 6; name = "Gallente"; }
    let private marketGroup440()= {MarketGroupData.id = 440; parentId = Some 437; name = "Gallente"; }
    let private marketGroup451()= {MarketGroupData.id = 451; parentId = Some 448; name = "Gallente"; }
    let private marketGroup833()= {MarketGroupData.id = 833; parentId = Some 824; name = "Gallente"; }
    let private marketGroup1073()= {MarketGroupData.id = 1073; parentId = Some 1070; name = "Gallente"; }
    let private marketGroup1141()= {MarketGroupData.id = 1141; parentId = Some 1138; name = "Gallente"; }
    let private marketGroup467()= {MarketGroupData.id = 467; parentId = Some 464; name = "Gallente"; }
    let private marketGroup832()= {MarketGroupData.id = 832; parentId = Some 823; name = "Gallente"; }
    let private marketGroup472()= {MarketGroupData.id = 472; parentId = Some 469; name = "Gallente"; }
    let private marketGroup831()= {MarketGroupData.id = 831; parentId = Some 822; name = "Gallente"; }
    let private marketGroup81()= {MarketGroupData.id = 81; parentId = Some 7; name = "Gallente"; }
    let private marketGroup1078()= {MarketGroupData.id = 1078; parentId = Some 1075; name = "Gallente"; }
    let private marketGroup1083()= {MarketGroupData.id = 1083; parentId = Some 1080; name = "Gallente"; }
    let private marketGroup764()= {MarketGroupData.id = 764; parentId = Some 761; name = "Gallente"; }
    let private marketGroup769()= {MarketGroupData.id = 769; parentId = Some 766; name = "Gallente"; }
    let private marketGroup815()= {MarketGroupData.id = 815; parentId = Some 812; name = "Gallente"; }
    let private marketGroup820()= {MarketGroupData.id = 820; parentId = Some 817; name = "Gallente"; }
    let private marketGroup1092()= {MarketGroupData.id = 1092; parentId = Some 1089; name = "Gallente"; }
    let private marketGroup83()= {MarketGroupData.id = 83; parentId = Some 8; name = "Gallente"; }
    let private marketGroup632()= {MarketGroupData.id = 632; parentId = Some 629; name = "Gallente"; }
    let private marketGroup1818()= {MarketGroupData.id = 1818; parentId = Some 1815; name = "Gallente"; }
    let private marketGroup394()= {MarketGroupData.id = 394; parentId = Some 391; name = "Minmatar"; }
    let private marketGroup64()= {MarketGroupData.id = 64; parentId = Some 5; name = "Minmatar"; }
    let private marketGroup403()= {MarketGroupData.id = 403; parentId = Some 399; name = "Minmatar"; }
    let private marketGroup424()= {MarketGroupData.id = 424; parentId = Some 420; name = "Minmatar"; }
    let private marketGroup436()= {MarketGroupData.id = 436; parentId = Some 432; name = "Minmatar"; }
    let private marketGroup1069()= {MarketGroupData.id = 1069; parentId = Some 1065; name = "Minmatar"; }
    let private marketGroup73()= {MarketGroupData.id = 73; parentId = Some 6; name = "Minmatar"; }
    let private marketGroup441()= {MarketGroupData.id = 441; parentId = Some 437; name = "Minmatar"; }
    let private marketGroup836()= {MarketGroupData.id = 836; parentId = Some 824; name = "Minmatar"; }
    let private marketGroup1074()= {MarketGroupData.id = 1074; parentId = Some 1070; name = "Minmatar"; }
    let private marketGroup468()= {MarketGroupData.id = 468; parentId = Some 464; name = "Minmatar"; }
    let private marketGroup835()= {MarketGroupData.id = 835; parentId = Some 823; name = "Minmatar"; }
    let private marketGroup473()= {MarketGroupData.id = 473; parentId = Some 469; name = "Minmatar"; }
    let private marketGroup834()= {MarketGroupData.id = 834; parentId = Some 822; name = "Minmatar"; }
    let private marketGroup78()= {MarketGroupData.id = 78; parentId = Some 7; name = "Minmatar"; }
    let private marketGroup1079()= {MarketGroupData.id = 1079; parentId = Some 1075; name = "Minmatar"; }
    let private marketGroup1084()= {MarketGroupData.id = 1084; parentId = Some 1080; name = "Minmatar"; }
    let private marketGroup765()= {MarketGroupData.id = 765; parentId = Some 761; name = "Minmatar"; }
    let private marketGroup770()= {MarketGroupData.id = 770; parentId = Some 766; name = "Minmatar"; }
    let private marketGroup816()= {MarketGroupData.id = 816; parentId = Some 812; name = "Minmatar"; }
    let private marketGroup821()= {MarketGroupData.id = 821; parentId = Some 817; name = "Minmatar"; }
    let private marketGroup1093()= {MarketGroupData.id = 1093; parentId = Some 1089; name = "Minmatar"; }
    let private marketGroup82()= {MarketGroupData.id = 82; parentId = Some 8; name = "Minmatar"; }
    let private marketGroup633()= {MarketGroupData.id = 633; parentId = Some 629; name = "Minmatar"; }
    let private marketGroup1819()= {MarketGroupData.id = 1819; parentId = Some 1815; name = "Minmatar"; }
    let private marketGroup283()= {MarketGroupData.id = 283; parentId = Some 208; name = "Gallente"; }
    let private marketGroup158()= {MarketGroupData.id = 158; parentId = Some 157; name = "Mining Drones"; }
    let private marketGroup837()= {MarketGroupData.id = 837; parentId = Some 159; name = "Light Scout Drones"; }
    let private marketGroup838()= {MarketGroupData.id = 838; parentId = Some 159; name = "Medium Scout Drones"; }
    let private marketGroup839()= {MarketGroupData.id = 839; parentId = Some 159; name = "Heavy Attack Drones"; }
    let private marketGroup911()= {MarketGroupData.id = 911; parentId = Some 159; name = "Sentry Drones"; }
    let private marketGroup841()= {MarketGroupData.id = 841; parentId = Some 157; name = "Electronic Warfare Drones"; }
    let private marketGroup843()= {MarketGroupData.id = 843; parentId = Some 157; name = "Combat Utility Drones"; }
    let private marketGroup1646()= {MarketGroupData.id = 1646; parentId = Some 157; name = "Salvage Drones"; }
    let private marketGroup842()= {MarketGroupData.id = 842; parentId = Some 157; name = "Logistic Drones"; }
    let private marketGroup1410()= {MarketGroupData.id = 1410; parentId = Some 1320; name = "Orbital Infrastructure"; }
    let private marketGroup725()= {MarketGroupData.id = 725; parentId = Some 685; name = "Gravimetric Sensors"; }
    let private marketGroup726()= {MarketGroupData.id = 726; parentId = Some 685; name = "Ladar Sensors"; }
    let private marketGroup727()= {MarketGroupData.id = 727; parentId = Some 685; name = "Magnetometric Sensors"; }
    let private marketGroup728()= {MarketGroupData.id = 728; parentId = Some 685; name = "Multi-Spectrum Sensors"; }
    let private marketGroup729()= {MarketGroupData.id = 729; parentId = Some 685; name = "Radar Sensors"; }
    let private marketGroup686()= {MarketGroupData.id = 686; parentId = Some 657; name = "Projected ECCM"; }
    let private marketGroup678()= {MarketGroupData.id = 678; parentId = Some 657; name = "ECM Bursts"; }
    let private marketGroup679()= {MarketGroupData.id = 679; parentId = Some 657; name = "Remote Sensor Dampeners"; }
    let private marketGroup680()= {MarketGroupData.id = 680; parentId = Some 657; name = "Weapon Disruptors"; }
    let private marketGroup720()= {MarketGroupData.id = 720; parentId = Some 681; name = "Gravimetric Backup Arrays"; }
    let private marketGroup721()= {MarketGroupData.id = 721; parentId = Some 681; name = "Ladar Backup Arrays"; }
    let private marketGroup722()= {MarketGroupData.id = 722; parentId = Some 681; name = "Radar Backup Arrays"; }
    let private marketGroup723()= {MarketGroupData.id = 723; parentId = Some 681; name = "Magnetometric Backup Arrays"; }
    let private marketGroup724()= {MarketGroupData.id = 724; parentId = Some 681; name = "Multi-Frequency Backup Arrays"; }
    let private marketGroup683()= {MarketGroupData.id = 683; parentId = Some 657; name = "Stasis Webifiers"; }
    let private marketGroup757()= {MarketGroupData.id = 757; parentId = Some 657; name = "Target Painters"; }
    let private marketGroup1426()= {MarketGroupData.id = 1426; parentId = Some 657; name = "Target Breaker"; }
    let private marketGroup564()= {MarketGroupData.id = 564; parentId = Some 555; name = "Small"; }
    let private marketGroup565()= {MarketGroupData.id = 565; parentId = Some 555; name = "Medium"; }
    let private marketGroup566()= {MarketGroupData.id = 566; parentId = Some 555; name = "Large"; }
    let private marketGroup772()= {MarketGroupData.id = 772; parentId = Some 555; name = "Extra Large"; }
    let private marketGroup561()= {MarketGroupData.id = 561; parentId = Some 556; name = "Small"; }
    let private marketGroup562()= {MarketGroupData.id = 562; parentId = Some 556; name = "Medium"; }
    let private marketGroup563()= {MarketGroupData.id = 563; parentId = Some 556; name = "Large"; }
    let private marketGroup771()= {MarketGroupData.id = 771; parentId = Some 556; name = "Extra Large"; }
    let private marketGroup574()= {MarketGroupData.id = 574; parentId = Some 559; name = "Small"; }
    let private marketGroup575()= {MarketGroupData.id = 575; parentId = Some 559; name = "Medium"; }
    let private marketGroup576()= {MarketGroupData.id = 576; parentId = Some 559; name = "Large"; }
    let private marketGroup776()= {MarketGroupData.id = 776; parentId = Some 559; name = "Extra Large"; }
    let private marketGroup577()= {MarketGroupData.id = 577; parentId = Some 560; name = "Small"; }
    let private marketGroup578()= {MarketGroupData.id = 578; parentId = Some 560; name = "Medium"; }
    let private marketGroup579()= {MarketGroupData.id = 579; parentId = Some 560; name = "Large"; }
    let private marketGroup775()= {MarketGroupData.id = 775; parentId = Some 560; name = "Extra Large"; }
    let private marketGroup567()= {MarketGroupData.id = 567; parentId = Some 557; name = "Small"; }
    let private marketGroup568()= {MarketGroupData.id = 568; parentId = Some 557; name = "Medium"; }
    let private marketGroup569()= {MarketGroupData.id = 569; parentId = Some 557; name = "Large"; }
    let private marketGroup773()= {MarketGroupData.id = 773; parentId = Some 557; name = "Extra Large"; }
    let private marketGroup570()= {MarketGroupData.id = 570; parentId = Some 558; name = "Small"; }
    let private marketGroup572()= {MarketGroupData.id = 572; parentId = Some 558; name = "Medium"; }
    let private marketGroup573()= {MarketGroupData.id = 573; parentId = Some 558; name = "Large"; }
    let private marketGroup774()= {MarketGroupData.id = 774; parentId = Some 558; name = "Extra Large"; }
    let private marketGroup777()= {MarketGroupData.id = 777; parentId = Some 140; name = "XL Launchers"; }
    let private marketGroup639()= {MarketGroupData.id = 639; parentId = Some 140; name = "Rocket Launchers"; }
    let private marketGroup640()= {MarketGroupData.id = 640; parentId = Some 140; name = "Light Missile Launchers"; }
    let private marketGroup641()= {MarketGroupData.id = 641; parentId = Some 140; name = "Rapid Light Missile Launchers"; }
    let private marketGroup642()= {MarketGroupData.id = 642; parentId = Some 140; name = "Heavy Launchers"; }
    let private marketGroup643()= {MarketGroupData.id = 643; parentId = Some 140; name = "Cruise Launchers"; }
    let private marketGroup644()= {MarketGroupData.id = 644; parentId = Some 140; name = "Torpedo Launchers"; }
    let private marketGroup974()= {MarketGroupData.id = 974; parentId = Some 140; name = "Heavy Assault Launchers"; }
    let private marketGroup1827()= {MarketGroupData.id = 1827; parentId = Some 140; name = "Rapid Heavy Missile Launchers"; }
    let private marketGroup646()= {MarketGroupData.id = 646; parentId = Some 143; name = "Gyrostabilizers"; }
    let private marketGroup647()= {MarketGroupData.id = 647; parentId = Some 143; name = "Heat Sinks"; }
    let private marketGroup648()= {MarketGroupData.id = 648; parentId = Some 143; name = "Magnetic Field Stabilizers"; }
    let private marketGroup706()= {MarketGroupData.id = 706; parentId = Some 143; name = "Tracking Computers"; }
    let private marketGroup707()= {MarketGroupData.id = 707; parentId = Some 143; name = "Tracking Enhancers"; }
    let private marketGroup708()= {MarketGroupData.id = 708; parentId = Some 143; name = "Remote Tracking Computers"; }
    let private marketGroup801()= {MarketGroupData.id = 801; parentId = Some 143; name = "Siege Modules"; }
    let private marketGroup1014()= {MarketGroupData.id = 1014; parentId = Some 10; name = "Bomb Launchers"; }
    let private marketGroup1672()= {MarketGroupData.id = 1672; parentId = Some 133; name = "100mm Armor Plate"; }
    let private marketGroup1673()= {MarketGroupData.id = 1673; parentId = Some 133; name = "200mm Armor Plate"; }
    let private marketGroup1674()= {MarketGroupData.id = 1674; parentId = Some 133; name = "400mm Armor Plate"; }
    let private marketGroup1675()= {MarketGroupData.id = 1675; parentId = Some 133; name = "800mm Armor Plate"; }
    let private marketGroup1676()= {MarketGroupData.id = 1676; parentId = Some 133; name = "1600mm Armor Plate"; }
    let private marketGroup1049()= {MarketGroupData.id = 1049; parentId = Some 134; name = "Small"; }
    let private marketGroup1050()= {MarketGroupData.id = 1050; parentId = Some 134; name = "Medium"; }
    let private marketGroup1051()= {MarketGroupData.id = 1051; parentId = Some 134; name = "Large"; }
    let private marketGroup1052()= {MarketGroupData.id = 1052; parentId = Some 134; name = "Capital"; }
    let private marketGroup1197()= {MarketGroupData.id = 1197; parentId = Some 135; name = "Expanded Cargoholds"; }
    let private marketGroup1196()= {MarketGroupData.id = 1196; parentId = Some 135; name = "Nanofiber Internal Structures"; }
    let private marketGroup1195()= {MarketGroupData.id = 1195; parentId = Some 135; name = "Reinforced Bulkheads"; }
    let private marketGroup1056()= {MarketGroupData.id = 1056; parentId = Some 537; name = "Capital"; }
    let private marketGroup1057()= {MarketGroupData.id = 1057; parentId = Some 537; name = "Large"; }
    let private marketGroup1058()= {MarketGroupData.id = 1058; parentId = Some 537; name = "Medium"; }
    let private marketGroup1059()= {MarketGroupData.id = 1059; parentId = Some 537; name = "Small"; }
    let private marketGroup1053()= {MarketGroupData.id = 1053; parentId = Some 538; name = "Small"; }
    let private marketGroup1054()= {MarketGroupData.id = 1054; parentId = Some 538; name = "Medium"; }
    let private marketGroup1055()= {MarketGroupData.id = 1055; parentId = Some 538; name = "Large"; }
    let private marketGroup1060()= {MarketGroupData.id = 1060; parentId = Some 1018; name = "Small"; }
    let private marketGroup1061()= {MarketGroupData.id = 1061; parentId = Some 1018; name = "Medium"; }
    let private marketGroup1062()= {MarketGroupData.id = 1062; parentId = Some 1018; name = "Large"; }
    let private marketGroup1063()= {MarketGroupData.id = 1063; parentId = Some 1018; name = "Capital"; }
    let private marketGroup1669()= {MarketGroupData.id = 1669; parentId = Some 14; name = "Layered Plating"; }
    let private marketGroup1687()= {MarketGroupData.id = 1687; parentId = Some 14; name = "Energized Armor Layering"; }
    let private marketGroup131()= {MarketGroupData.id = 131; parentId = Some 52; name = "Microwarpdrives"; }
    let private marketGroup1086()= {MarketGroupData.id = 1086; parentId = Some 132; name = "Inertial Stabilizers"; }
    let private marketGroup1087()= {MarketGroupData.id = 1087; parentId = Some 132; name = "Overdrives"; }
    let private marketGroup1088()= {MarketGroupData.id = 1088; parentId = Some 132; name = "Warp Core Stabilizers"; }
    let private marketGroup542()= {MarketGroupData.id = 542; parentId = Some 52; name = "Afterburners"; }
    let private marketGroup1650()= {MarketGroupData.id = 1650; parentId = Some 52; name = "Micro Jump Drives"; }
    let private marketGroup380()= {MarketGroupData.id = 380; parentId = Some 141; name = "Micro"; }
    let private marketGroup381()= {MarketGroupData.id = 381; parentId = Some 141; name = "Large"; }
    let private marketGroup382()= {MarketGroupData.id = 382; parentId = Some 141; name = "Small"; }
    let private marketGroup383()= {MarketGroupData.id = 383; parentId = Some 141; name = "Medium"; }
    let private marketGroup126()= {MarketGroupData.id = 126; parentId = Some 554; name = "Shield Rechargers"; }
    let private marketGroup600()= {MarketGroupData.id = 600; parentId = Some 128; name = "Capital"; }
    let private marketGroup601()= {MarketGroupData.id = 601; parentId = Some 128; name = "Large"; }
    let private marketGroup602()= {MarketGroupData.id = 602; parentId = Some 128; name = "Medium"; }
    let private marketGroup603()= {MarketGroupData.id = 603; parentId = Some 128; name = "Small"; }
    let private marketGroup604()= {MarketGroupData.id = 604; parentId = Some 128; name = "Micro"; }
    let private marketGroup687()= {MarketGroupData.id = 687; parentId = Some 554; name = "Shield Flux Coils"; }
    let private marketGroup688()= {MarketGroupData.id = 688; parentId = Some 554; name = "Shield Power Relays"; }
    let private marketGroup658()= {MarketGroupData.id = 658; parentId = Some 655; name = "Power Diagnostic Systems"; }
    let private marketGroup659()= {MarketGroupData.id = 659; parentId = Some 655; name = "Reactor Control Units"; }
    let private marketGroup660()= {MarketGroupData.id = 660; parentId = Some 655; name = "Auxiliary Power Controls"; }
    let private marketGroup689()= {MarketGroupData.id = 689; parentId = Some 661; name = "Small"; }
    let private marketGroup690()= {MarketGroupData.id = 690; parentId = Some 661; name = "Medium"; }
    let private marketGroup691()= {MarketGroupData.id = 691; parentId = Some 661; name = "Heavy"; }
    let private marketGroup692()= {MarketGroupData.id = 692; parentId = Some 662; name = "Small"; }
    let private marketGroup693()= {MarketGroupData.id = 693; parentId = Some 662; name = "Medium"; }
    let private marketGroup694()= {MarketGroupData.id = 694; parentId = Some 662; name = "Heavy"; }
    let private marketGroup695()= {MarketGroupData.id = 695; parentId = Some 663; name = "Small"; }
    let private marketGroup696()= {MarketGroupData.id = 696; parentId = Some 663; name = "Medium"; }
    let private marketGroup697()= {MarketGroupData.id = 697; parentId = Some 663; name = "Large"; }
    let private marketGroup910()= {MarketGroupData.id = 910; parentId = Some 663; name = "Capital"; }
    let private marketGroup702()= {MarketGroupData.id = 702; parentId = Some 664; name = "Micro"; }
    let private marketGroup703()= {MarketGroupData.id = 703; parentId = Some 664; name = "Small"; }
    let private marketGroup704()= {MarketGroupData.id = 704; parentId = Some 664; name = "Medium"; }
    let private marketGroup705()= {MarketGroupData.id = 705; parentId = Some 664; name = "Large"; }
    let private marketGroup665()= {MarketGroupData.id = 665; parentId = Some 655; name = "Capacitor Rechargers"; }
    let private marketGroup666()= {MarketGroupData.id = 666; parentId = Some 655; name = "Capacitor Flux Coils"; }
    let private marketGroup667()= {MarketGroupData.id = 667; parentId = Some 655; name = "Capacitor Power Relays"; }
    let private marketGroup698()= {MarketGroupData.id = 698; parentId = Some 668; name = "Micro"; }
    let private marketGroup699()= {MarketGroupData.id = 699; parentId = Some 668; name = "Small"; }
    let private marketGroup701()= {MarketGroupData.id = 701; parentId = Some 668; name = "Heavy"; }
    let private marketGroup670()= {MarketGroupData.id = 670; parentId = Some 656; name = "Automated Targeting Systems"; }
    let private marketGroup669()= {MarketGroupData.id = 669; parentId = Some 656; name = "Signal Amplifiers"; }
    let private marketGroup671()= {MarketGroupData.id = 671; parentId = Some 656; name = "Sensor Boosters"; }
    let private marketGroup672()= {MarketGroupData.id = 672; parentId = Some 656; name = "Passive Targeting Systems"; }
    let private marketGroup700()= {MarketGroupData.id = 700; parentId = Some 668; name = "Medium"; }
    let private marketGroup673()= {MarketGroupData.id = 673; parentId = Some 656; name = "Remote Sensor Boosters"; }
    let private marketGroup675()= {MarketGroupData.id = 675; parentId = Some 656; name = "Cloaking Devices"; }
    let private marketGroup676()= {MarketGroupData.id = 676; parentId = Some 656; name = "CPU Upgrades"; }
    let private marketGroup872()= {MarketGroupData.id = 872; parentId = Some 656; name = "Tractor Beams"; }
    let private marketGroup717()= {MarketGroupData.id = 717; parentId = Some 677; name = "Gravimetric Jammers"; }
    let private marketGroup715()= {MarketGroupData.id = 715; parentId = Some 677; name = "Magnetometric Jammers"; }
    let private marketGroup716()= {MarketGroupData.id = 716; parentId = Some 677; name = "Ladar Jammers"; }
    let private marketGroup718()= {MarketGroupData.id = 718; parentId = Some 677; name = "Radar Jammers"; }
    let private marketGroup719()= {MarketGroupData.id = 719; parentId = Some 677; name = "Multi Spectrum Jammers"; }
    let private marketGroup967()= {MarketGroupData.id = 967; parentId = Some 677; name = "Signal Distortion Amplifier"; }
    let private marketGroup1639()= {MarketGroupData.id = 1639; parentId = Some 779; name = "Command Processors"; }
    let private marketGroup1640()= {MarketGroupData.id = 1640; parentId = Some 779; name = "Jump Portal Generators"; }
    let private marketGroup1641()= {MarketGroupData.id = 1641; parentId = Some 779; name = "Cynosural Field Generators"; }
    let private marketGroup1642()= {MarketGroupData.id = 1642; parentId = Some 779; name = "Clone Vat Bays"; }
    let private marketGroup938()= {MarketGroupData.id = 938; parentId = Some 9; name = "Drone Upgrades"; }
    let private marketGroup1718()= {MarketGroupData.id = 1718; parentId = Some 1708; name = "Analyzers"; }
    let private marketGroup711()= {MarketGroupData.id = 711; parentId = Some 1708; name = "Cargo Scanners"; }
    let private marketGroup712()= {MarketGroupData.id = 712; parentId = Some 1708; name = "Scan Probe Launchers"; }
    let private marketGroup713()= {MarketGroupData.id = 713; parentId = Some 1708; name = "Ship Scanners"; }
    let private marketGroup714()= {MarketGroupData.id = 714; parentId = Some 1708; name = "Survey Scanners"; }
    let private marketGroup1709()= {MarketGroupData.id = 1709; parentId = Some 1708; name = "Scanning Upgrades"; }
    let private marketGroup1717()= {MarketGroupData.id = 1717; parentId = Some 1708; name = "Survey Probe Launchers"; }
    let private marketGroup1037()= {MarketGroupData.id = 1037; parentId = Some 1713; name = "Gas Cloud Harvesters"; }
    let private marketGroup935()= {MarketGroupData.id = 935; parentId = Some 1713; name = "Mining Upgrades"; }
    let private marketGroup1038()= {MarketGroupData.id = 1038; parentId = Some 1713; name = "Ice Harvesters"; }
    let private marketGroup1039()= {MarketGroupData.id = 1039; parentId = Some 1713; name = "Mining Lasers"; }
    let private marketGroup1040()= {MarketGroupData.id = 1040; parentId = Some 1713; name = "Strip Miners"; }
    let private marketGroup1715()= {MarketGroupData.id = 1715; parentId = Some 1713; name = "Salvagers"; }
    let private marketGroup20()= {MarketGroupData.id = 20; parentId = Some 19; name = "Industrial Goods"; }
    let private marketGroup22()= {MarketGroupData.id = 22; parentId = Some 19; name = "Radioactive Goods"; }
    let private marketGroup23()= {MarketGroupData.id = 23; parentId = Some 19; name = "Passengers"; }
    let private marketGroup491()= {MarketGroupData.id = 491; parentId = Some 19; name = "Narcotics"; }
    let private marketGroup492()= {MarketGroupData.id = 492; parentId = Some 19; name = "Consumer Products"; }
    let private marketGroup730()= {MarketGroupData.id = 730; parentId = Some 616; name = "Amarr Navy"; }
    let private marketGroup731()= {MarketGroupData.id = 731; parentId = Some 616; name = "Ammatar Navy"; }
    let private marketGroup732()= {MarketGroupData.id = 732; parentId = Some 616; name = "Caldari Navy"; }
    let private marketGroup734()= {MarketGroupData.id = 734; parentId = Some 616; name = "Gallente Navy"; }
    let private marketGroup735()= {MarketGroupData.id = 735; parentId = Some 616; name = "Khanid Navy"; }
    let private marketGroup736()= {MarketGroupData.id = 736; parentId = Some 616; name = "Minmatar Fleet"; }
    let private marketGroup737()= {MarketGroupData.id = 737; parentId = Some 616; name = "Individuals"; }
    let private marketGroup733()= {MarketGroupData.id = 733; parentId = Some 616; name = "CONCORD"; }
    let private marketGroup738()= {MarketGroupData.id = 738; parentId = Some 19; name = "Nexus Chips"; }
    let private marketGroup740()= {MarketGroupData.id = 740; parentId = Some 739; name = "Angels"; }
    let private marketGroup741()= {MarketGroupData.id = 741; parentId = Some 739; name = "Blood Raiders"; }
    let private marketGroup742()= {MarketGroupData.id = 742; parentId = Some 739; name = "Dark Blood"; }
    let private marketGroup743()= {MarketGroupData.id = 743; parentId = Some 739; name = "Domination"; }
    let private marketGroup744()= {MarketGroupData.id = 744; parentId = Some 739; name = "Dread Guristas"; }
    let private marketGroup745()= {MarketGroupData.id = 745; parentId = Some 739; name = "Guristas"; }
    let private marketGroup746()= {MarketGroupData.id = 746; parentId = Some 739; name = "Sansha"; }
    let private marketGroup747()= {MarketGroupData.id = 747; parentId = Some 739; name = "Serpentis"; }
    let private marketGroup748()= {MarketGroupData.id = 748; parentId = Some 739; name = "Shadow Serpentis"; }
    let private marketGroup749()= {MarketGroupData.id = 749; parentId = Some 739; name = "True Sansha"; }
    let private marketGroup750()= {MarketGroupData.id = 750; parentId = Some 739; name = "Commanders"; }
    let private marketGroup754()= {MarketGroupData.id = 754; parentId = Some 19; name = "Political Paraphernalia"; }
    let private marketGroup940()= {MarketGroupData.id = 940; parentId = Some 19; name = "Starbase Charters"; }
    let private marketGroup1109()= {MarketGroupData.id = 1109; parentId = Some 19; name = "Sleeper Components"; }
    let private marketGroup1846()= {MarketGroupData.id = 1846; parentId = Some 19; name = "Bounty Reimbursement Tags"; }
    let private marketGroup364()= {MarketGroupData.id = 364; parentId = Some 150; name = "Gunnery"; }
    let private marketGroup365()= {MarketGroupData.id = 365; parentId = Some 150; name = "Corporation Management"; }
    let private marketGroup366()= {MarketGroupData.id = 366; parentId = Some 150; name = "Drones"; }
    let private marketGroup367()= {MarketGroupData.id = 367; parentId = Some 150; name = "Electronic Systems"; }
    let private marketGroup368()= {MarketGroupData.id = 368; parentId = Some 150; name = "Engineering"; }
    let private marketGroup369()= {MarketGroupData.id = 369; parentId = Some 150; name = "Production"; }
    let private marketGroup370()= {MarketGroupData.id = 370; parentId = Some 150; name = "Fleet Support"; }
    let private marketGroup372()= {MarketGroupData.id = 372; parentId = Some 150; name = "Rigging"; }
    let private marketGroup373()= {MarketGroupData.id = 373; parentId = Some 150; name = "Missiles"; }
    let private marketGroup374()= {MarketGroupData.id = 374; parentId = Some 150; name = "Navigation"; }
    let private marketGroup375()= {MarketGroupData.id = 375; parentId = Some 150; name = "Science"; }
    let private marketGroup376()= {MarketGroupData.id = 376; parentId = Some 150; name = "Social"; }
    let private marketGroup377()= {MarketGroupData.id = 377; parentId = Some 150; name = "Spaceship Command"; }
    let private marketGroup378()= {MarketGroupData.id = 378; parentId = Some 150; name = "Trade"; }
    let private marketGroup1110()= {MarketGroupData.id = 1110; parentId = Some 150; name = "Scanning"; }
    let private marketGroup1323()= {MarketGroupData.id = 1323; parentId = Some 150; name = "Resource Processing"; }
    let private marketGroup1745()= {MarketGroupData.id = 1745; parentId = Some 150; name = "Armor"; }
    let private marketGroup1746()= {MarketGroupData.id = 1746; parentId = Some 150; name = "Neural Enhancement"; }
    let private marketGroup1747()= {MarketGroupData.id = 1747; parentId = Some 150; name = "Shields"; }
    let private marketGroup1748()= {MarketGroupData.id = 1748; parentId = Some 150; name = "Targeting"; }
    let private marketGroup1823()= {MarketGroupData.id = 1823; parentId = Some 150; name = "Planet Management"; }
    let private marketGroup1824()= {MarketGroupData.id = 1824; parentId = Some 150; name = "Subsystems"; }
    let private marketGroup1651()= {MarketGroupData.id = 1651; parentId = Some 379; name = "Secure Containers"; }
    let private marketGroup1652()= {MarketGroupData.id = 1652; parentId = Some 379; name = "Audit Log Containers"; }
    let private marketGroup1653()= {MarketGroupData.id = 1653; parentId = Some 379; name = "Freight Containers"; }
    let private marketGroup1657()= {MarketGroupData.id = 1657; parentId = Some 379; name = "Standard Containers"; }
    let private marketGroup1658()= {MarketGroupData.id = 1658; parentId = Some 379; name = "Station Containers"; }
    let private marketGroup405()= {MarketGroupData.id = 405; parentId = Some 404; name = "Warp Disruption Fields"; }
    let private marketGroup1831()= {MarketGroupData.id = 1831; parentId = Some 404; name = "Mobile Depots"; }
    let private marketGroup1832()= {MarketGroupData.id = 1832; parentId = Some 404; name = "Mobile Cynosural Inhibitors"; }
    let private marketGroup1833()= {MarketGroupData.id = 1833; parentId = Some 404; name = "Mobile Tractor Units"; }
    let private marketGroup1835()= {MarketGroupData.id = 1835; parentId = Some 404; name = "Mobile Siphon Units"; }
    let private marketGroup1844()= {MarketGroupData.id = 1844; parentId = Some 404; name = "Mobile Micro Jump Units"; }
    let private marketGroup1845()= {MarketGroupData.id = 1845; parentId = Some 404; name = "Mobile Scan Inhibitors"; }
    let private marketGroup1847()= {MarketGroupData.id = 1847; parentId = Some 404; name = "Encounter Surveillance Systems"; }
    let private marketGroup1284()= {MarketGroupData.id = 1284; parentId = Some 1276; name = "Military Upgrades"; }
    let private marketGroup1282()= {MarketGroupData.id = 1282; parentId = Some 1276; name = "Strategic Upgrades"; }
    let private marketGroup1283()= {MarketGroupData.id = 1283; parentId = Some 1276; name = "Industrial Upgrades"; }
    let private marketGroup1273()= {MarketGroupData.id = 1273; parentId = Some 1272; name = "Territorial Claim Units"; }
    let private marketGroup1274()= {MarketGroupData.id = 1274; parentId = Some 1272; name = "Sovereignty Blockade Units"; }
    let private marketGroup1275()= {MarketGroupData.id = 1275; parentId = Some 1272; name = "Infrastructure Hubs"; }
    let private marketGroup478()= {MarketGroupData.id = 478; parentId = Some 1285; name = "Control Towers"; }
    let private marketGroup479()= {MarketGroupData.id = 479; parentId = Some 480; name = "Missile Batteries"; }
    let private marketGroup481()= {MarketGroupData.id = 481; parentId = Some 480; name = "Electronic Warfare Batteries"; }
    let private marketGroup594()= {MarketGroupData.id = 594; parentId = Some 480; name = "Projectile Batteries"; }
    let private marketGroup595()= {MarketGroupData.id = 595; parentId = Some 480; name = "Hybrid Batteries"; }
    let private marketGroup596()= {MarketGroupData.id = 596; parentId = Some 480; name = "Laser Batteries"; }
    let private marketGroup1009()= {MarketGroupData.id = 1009; parentId = Some 480; name = "Energy Neutralization Batteries"; }
    let private marketGroup482()= {MarketGroupData.id = 482; parentId = Some 1285; name = "Reprocessing Arrays"; }
    let private marketGroup483()= {MarketGroupData.id = 483; parentId = Some 1285; name = "Silos"; }
    let private marketGroup484()= {MarketGroupData.id = 484; parentId = Some 1285; name = "Ship Maintenance Arrays"; }
    let private marketGroup485()= {MarketGroupData.id = 485; parentId = Some 1285; name = "Shield Hardening Arrays"; }
    let private marketGroup488()= {MarketGroupData.id = 488; parentId = Some 1285; name = "Moon Harvesting Arrays"; }
    let private marketGroup490()= {MarketGroupData.id = 490; parentId = Some 1285; name = "Reactors"; }
    let private marketGroup506()= {MarketGroupData.id = 506; parentId = Some 1285; name = "Corporate Hangar Array"; }
    let private marketGroup932()= {MarketGroupData.id = 932; parentId = Some 1285; name = "Assembly Arrays"; }
    let private marketGroup933()= {MarketGroupData.id = 933; parentId = Some 1285; name = "Laboratory"; }
    let private marketGroup1010()= {MarketGroupData.id = 1010; parentId = Some 1285; name = "System Scanning Array"; }
    let private marketGroup1011()= {MarketGroupData.id = 1011; parentId = Some 1285; name = "Jump Bridge"; }
    let private marketGroup1012()= {MarketGroupData.id = 1012; parentId = Some 1285; name = "Cynosural System Jammer"; }
    let private marketGroup1013()= {MarketGroupData.id = 1013; parentId = Some 1285; name = "Cynosural Generator Array"; }
    let private marketGroup1702()= {MarketGroupData.id = 1702; parentId = Some 1285; name = "Personal Hangar Arrays"; }
    let private marketGroup1206()= {MarketGroupData.id = 1206; parentId = Some 956; name = "Small Armor Rigs"; }
    let private marketGroup1207()= {MarketGroupData.id = 1207; parentId = Some 956; name = "Medium Armor Rigs"; }
    let private marketGroup1208()= {MarketGroupData.id = 1208; parentId = Some 956; name = "Large Armor Rigs"; }
    let private marketGroup1730()= {MarketGroupData.id = 1730; parentId = Some 956; name = "Capital Armor Rigs"; }
    let private marketGroup1210()= {MarketGroupData.id = 1210; parentId = Some 957; name = "Small Astronautic Rigs"; }
    let private marketGroup1211()= {MarketGroupData.id = 1211; parentId = Some 957; name = "Medium Astronautic Rigs"; }
    let private marketGroup1212()= {MarketGroupData.id = 1212; parentId = Some 957; name = "Large Astronautic Rigs"; }
    let private marketGroup1740()= {MarketGroupData.id = 1740; parentId = Some 957; name = "Capital Astronautic Rigs"; }
    let private marketGroup1213()= {MarketGroupData.id = 1213; parentId = Some 958; name = "Small Drone Rigs"; }
    let private marketGroup1214()= {MarketGroupData.id = 1214; parentId = Some 958; name = "Medium Drone Rigs"; }
    let private marketGroup1215()= {MarketGroupData.id = 1215; parentId = Some 958; name = "Large Drone Rigs"; }
    let private marketGroup1739()= {MarketGroupData.id = 1739; parentId = Some 958; name = "Capital Drone Rigs"; }
    let private marketGroup1219()= {MarketGroupData.id = 1219; parentId = Some 960; name = "Small Electronics Superiority Rigs"; }
    let private marketGroup1220()= {MarketGroupData.id = 1220; parentId = Some 960; name = "Medium Electronics Superiority Rigs"; }
    let private marketGroup1221()= {MarketGroupData.id = 1221; parentId = Some 960; name = "Large Electronics Superiority Rigs"; }
    let private marketGroup1737()= {MarketGroupData.id = 1737; parentId = Some 960; name = "Capital Electronics Superiority Rigs"; }
    let private marketGroup1222()= {MarketGroupData.id = 1222; parentId = Some 961; name = "Small Engineering Rigs"; }
    let private marketGroup1223()= {MarketGroupData.id = 1223; parentId = Some 961; name = "Medium Engineering Rigs"; }
    let private marketGroup1224()= {MarketGroupData.id = 1224; parentId = Some 961; name = "Large Engineering Rigs"; }
    let private marketGroup1736()= {MarketGroupData.id = 1736; parentId = Some 961; name = "Capital Engineering Rigs"; }
    let private marketGroup1225()= {MarketGroupData.id = 1225; parentId = Some 962; name = "Small Energy Weapon Rigs"; }
    let private marketGroup1226()= {MarketGroupData.id = 1226; parentId = Some 962; name = "Medium Energy Weapon Rigs"; }
    let private marketGroup1227()= {MarketGroupData.id = 1227; parentId = Some 962; name = "Large Energy Weapon Rigs"; }
    let private marketGroup1735()= {MarketGroupData.id = 1735; parentId = Some 962; name = "Capital Energy Weapon Rigs"; }
    let private marketGroup1228()= {MarketGroupData.id = 1228; parentId = Some 963; name = "Small Hybrid Weapon Rigs"; }
    let private marketGroup1229()= {MarketGroupData.id = 1229; parentId = Some 963; name = "Medium Hybrid Weapon Rigs"; }
    let private marketGroup1230()= {MarketGroupData.id = 1230; parentId = Some 963; name = "Large Hybrid Weapon Rigs"; }
    let private marketGroup1734()= {MarketGroupData.id = 1734; parentId = Some 963; name = "Capital Hybrid Weapon Rigs"; }
    let private marketGroup1231()= {MarketGroupData.id = 1231; parentId = Some 964; name = "Small Missile Launcher Rigs"; }
    let private marketGroup1232()= {MarketGroupData.id = 1232; parentId = Some 964; name = "Medium Missile Launcher Rigs"; }
    let private marketGroup1233()= {MarketGroupData.id = 1233; parentId = Some 964; name = "Large Missile Launcher Rigs"; }
    let private marketGroup1733()= {MarketGroupData.id = 1733; parentId = Some 964; name = "Capital Missile Launcher Rigs"; }
    let private marketGroup1234()= {MarketGroupData.id = 1234; parentId = Some 965; name = "Small Shield Rigs"; }
    let private marketGroup1235()= {MarketGroupData.id = 1235; parentId = Some 965; name = "Medium Shield Rigs"; }
    let private marketGroup1236()= {MarketGroupData.id = 1236; parentId = Some 965; name = "Large Shield Rigs"; }
    let private marketGroup1732()= {MarketGroupData.id = 1732; parentId = Some 965; name = "Capital Shield Rigs"; }
    let private marketGroup1237()= {MarketGroupData.id = 1237; parentId = Some 979; name = "Small Projectile Weapon Rigs"; }
    let private marketGroup1238()= {MarketGroupData.id = 1238; parentId = Some 979; name = "Medium Projectile Weapon Rigs"; }
    let private marketGroup1239()= {MarketGroupData.id = 1239; parentId = Some 979; name = "Large Projectile Weapon Rigs"; }
    let private marketGroup1731()= {MarketGroupData.id = 1731; parentId = Some 979; name = "Capital Projectile Weapon Rigs"; }
    let private marketGroup1782()= {MarketGroupData.id = 1782; parentId = Some 1779; name = "Small Resource Processing Rigs"; }
    let private marketGroup1783()= {MarketGroupData.id = 1783; parentId = Some 1779; name = "Medium Resource Processing Rigs"; }
    let private marketGroup1784()= {MarketGroupData.id = 1784; parentId = Some 1779; name = "Large Resource Processing Rigs"; }
    let private marketGroup1785()= {MarketGroupData.id = 1785; parentId = Some 1779; name = "Capital Resource Processing Rigs"; }
    let private marketGroup1786()= {MarketGroupData.id = 1786; parentId = Some 1780; name = "Small Scanning Rigs"; }
    let private marketGroup1787()= {MarketGroupData.id = 1787; parentId = Some 1780; name = "Medium Scanning Rigs"; }
    let private marketGroup1788()= {MarketGroupData.id = 1788; parentId = Some 1780; name = "Large Scanning Rigs"; }
    let private marketGroup1789()= {MarketGroupData.id = 1789; parentId = Some 1780; name = "Capital Scanning Rigs"; }
    let private marketGroup1790()= {MarketGroupData.id = 1790; parentId = Some 1781; name = "Small Targeting Rigs"; }
    let private marketGroup1791()= {MarketGroupData.id = 1791; parentId = Some 1781; name = "Medium Targeting Rigs"; }
    let private marketGroup1792()= {MarketGroupData.id = 1792; parentId = Some 1781; name = "Large Targeting Rigs"; }
    let private marketGroup1793()= {MarketGroupData.id = 1793; parentId = Some 1781; name = "Capital Targeting Rigs"; }
    let private marketGroup1660()= {MarketGroupData.id = 1660; parentId = Some 1659; name = "Special Edition Tournament Cards"; }
    let private marketGroup1810()= {MarketGroupData.id = 1810; parentId = Some 1660; name = "Alliance Tournament Cards"; }
    let private marketGroup1811()= {MarketGroupData.id = 1811; parentId = Some 1660; name = "New Eden Open Cards"; }
    let private marketGroup1661()= {MarketGroupData.id = 1661; parentId = Some 1659; name = "Special Edition Commodities"; }
    let private marketGroup1662()= {MarketGroupData.id = 1662; parentId = Some 1659; name = "Special Edition Apparel"; }
    let private marketGroup1664()= {MarketGroupData.id = 1664; parentId = Some 1659; name = "Special Edition Blueprints"; }
    let private marketGroup1663()= {MarketGroupData.id = 1663; parentId = Some 1659; name = "Special Edition Festival Assets"; }
    let private marketGroup494()= {MarketGroupData.id = 494; parentId = Some 1384; name = "Mining Barges"; }
    let private marketGroup874()= {MarketGroupData.id = 874; parentId = Some 1384; name = "Exhumers"; }
    let private marketGroup1614()= {MarketGroupData.id = 1614; parentId = Some 1612; name = "Special Edition Industrial Ships"; }
    let private marketGroup1618()= {MarketGroupData.id = 1618; parentId = Some 1612; name = "Special Edition Shuttles"; }
    let private marketGroup1619()= {MarketGroupData.id = 1619; parentId = Some 1612; name = "Special Edition Frigates"; }
    let private marketGroup1620()= {MarketGroupData.id = 1620; parentId = Some 1612; name = "Special Edition Battleships"; }
    let private marketGroup1621()= {MarketGroupData.id = 1621; parentId = Some 1612; name = "Special Edition Heavy Assault Cruisers"; }
    let private marketGroup1623()= {MarketGroupData.id = 1623; parentId = Some 1612; name = "Special Edition Assault Frigates"; }
    let private marketGroup1624()= {MarketGroupData.id = 1624; parentId = Some 1612; name = "Special Edition Logistics"; }
    let private marketGroup1698()= {MarketGroupData.id = 1698; parentId = Some 1612; name = "Special Edition Battlecruisers"; }
    let private marketGroup1699()= {MarketGroupData.id = 1699; parentId = Some 1612; name = "Special Edition Cruisers"; }
    let private marketGroup1837()= {MarketGroupData.id = 1837; parentId = Some 1612; name = "Special Edition Recon Ships"; }
    let private marketGroup1838()= {MarketGroupData.id = 1838; parentId = Some 1612; name = "Special Edition Covert Ops"; }
    let private marketGroup1631()= {MarketGroupData.id = 1631; parentId = Some 391; name = "Faction Shuttles"; }
    let private marketGroup1365()= {MarketGroupData.id = 1365; parentId = Some 1362; name = "Pirate Faction"; }
    let private marketGroup1366()= {MarketGroupData.id = 1366; parentId = Some 1362; name = "Navy Faction"; }
    let private marketGroup1370()= {MarketGroupData.id = 1370; parentId = Some 1369; name = "Navy Faction"; }
    let private marketGroup1371()= {MarketGroupData.id = 1371; parentId = Some 1369; name = "Pirate Faction"; }
    let private marketGroup1704()= {MarketGroupData.id = 1704; parentId = Some 1703; name = "Navy Faction"; }
    let private marketGroup1379()= {MarketGroupData.id = 1379; parentId = Some 1378; name = "Navy Faction"; }
    let private marketGroup1380()= {MarketGroupData.id = 1380; parentId = Some 1378; name = "Pirate Faction"; }
    let private marketGroup1392()= {MarketGroupData.id = 1392; parentId = Some 817; name = "Faction Carrier"; }
    let private marketGroup1048()= {MarketGroupData.id = 1048; parentId = Some 1047; name = "ORE"; }
    let private marketGroup605()= {MarketGroupData.id = 605; parentId = Some 551; name = "Small"; }
    let private marketGroup606()= {MarketGroupData.id = 606; parentId = Some 551; name = "Medium"; }
    let private marketGroup608()= {MarketGroupData.id = 608; parentId = Some 551; name = "Large"; }
    let private marketGroup609()= {MarketGroupData.id = 609; parentId = Some 552; name = "Small"; }
    let private marketGroup610()= {MarketGroupData.id = 610; parentId = Some 552; name = "Medium"; }
    let private marketGroup611()= {MarketGroupData.id = 611; parentId = Some 552; name = "Large"; }
    let private marketGroup612()= {MarketGroupData.id = 612; parentId = Some 552; name = "Extra Large"; }
    let private marketGroup613()= {MarketGroupData.id = 613; parentId = Some 552; name = "Boost Amplifiers"; }
    let private marketGroup778()= {MarketGroupData.id = 778; parentId = Some 552; name = "Capital"; }
    let private marketGroup796()= {MarketGroupData.id = 796; parentId = Some 800; name = "Standard Capital Ship Components"; }
    let private marketGroup1912()= {MarketGroupData.id = 1912; parentId = Some 798; name = "Construction Platforms"; }
    let private marketGroup1913()= {MarketGroupData.id = 1913; parentId = Some 798; name = "Station Components"; }
    let private marketGroup1918()= {MarketGroupData.id = 1918; parentId = Some 800; name = "R.A.M."; }
    let private marketGroup1919()= {MarketGroupData.id = 1919; parentId = Some 1522; name = "R.Db"; }
    let private marketGroup1920()= {MarketGroupData.id = 1920; parentId = Some 800; name = "Fuel Blocks"; }
    let private marketGroup1587()= {MarketGroupData.id = 1587; parentId = Some 1097; name = "Amarr"; }
    let private marketGroup1588()= {MarketGroupData.id = 1588; parentId = Some 1097; name = "Caldari"; }
    let private marketGroup1589()= {MarketGroupData.id = 1589; parentId = Some 1097; name = "Gallente"; }
    let private marketGroup1590()= {MarketGroupData.id = 1590; parentId = Some 1097; name = "Minmatar"; }
    let private marketGroup1191()= {MarketGroupData.id = 1191; parentId = Some 800; name = "Subsystem Components"; }
    let private marketGroup1592()= {MarketGroupData.id = 1592; parentId = Some 1591; name = "Amarr"; }
    let private marketGroup1593()= {MarketGroupData.id = 1593; parentId = Some 1591; name = "Caldari"; }
    let private marketGroup1594()= {MarketGroupData.id = 1594; parentId = Some 1591; name = "Gallente"; }
    let private marketGroup1595()= {MarketGroupData.id = 1595; parentId = Some 1591; name = "Minmatar"; }
    let private marketGroup1027()= {MarketGroupData.id = 1027; parentId = Some 1021; name = "Outpost Upgrade Platforms"; }
    let private marketGroup512()= {MarketGroupData.id = 512; parentId = Some 54; name = "Arkonor"; }
    let private marketGroup514()= {MarketGroupData.id = 514; parentId = Some 54; name = "Bistot"; }
    let private marketGroup515()= {MarketGroupData.id = 515; parentId = Some 54; name = "Pyroxeres"; }
    let private marketGroup516()= {MarketGroupData.id = 516; parentId = Some 54; name = "Plagioclase"; }
    let private marketGroup517()= {MarketGroupData.id = 517; parentId = Some 54; name = "Spodumain"; }
    let private marketGroup518()= {MarketGroupData.id = 518; parentId = Some 54; name = "Veldspar"; }
    let private marketGroup519()= {MarketGroupData.id = 519; parentId = Some 54; name = "Scordite"; }
    let private marketGroup521()= {MarketGroupData.id = 521; parentId = Some 54; name = "Crokite"; }
    let private marketGroup522()= {MarketGroupData.id = 522; parentId = Some 54; name = "Dark Ochre"; }
    let private marketGroup523()= {MarketGroupData.id = 523; parentId = Some 54; name = "Kernite"; }
    let private marketGroup525()= {MarketGroupData.id = 525; parentId = Some 54; name = "Gneiss"; }
    let private marketGroup526()= {MarketGroupData.id = 526; parentId = Some 54; name = "Omber"; }
    let private marketGroup527()= {MarketGroupData.id = 527; parentId = Some 54; name = "Hedbergite"; }
    let private marketGroup528()= {MarketGroupData.id = 528; parentId = Some 54; name = "Hemorphite"; }
    let private marketGroup529()= {MarketGroupData.id = 529; parentId = Some 54; name = "Jaspet"; }
    let private marketGroup530()= {MarketGroupData.id = 530; parentId = Some 54; name = "Mercoxit"; }
    let private marketGroup1085()= {MarketGroupData.id = 1085; parentId = Some 657; name = "Warp Disruption Field Generators"; }
    let private marketGroup615()= {MarketGroupData.id = 615; parentId = Some 14; name = "Damage Controls"; }
    let private marketGroup452()= {MarketGroupData.id = 452; parentId = Some 448; name = "Minmatar"; }
    let private marketGroup1142()= {MarketGroupData.id = 1142; parentId = Some 1138; name = "Minmatar"; }
    let private marketGroup1616()= {MarketGroupData.id = 1616; parentId = Some 5; name = "ORE"; }
    let private marketGroup1390()= {MarketGroupData.id = 1390; parentId = Some 8; name = "ORE"; }
    let private marketGroup1812()= {MarketGroupData.id = 1812; parentId = Some 1810; name = "Alliance Tournament All Star Teams"; }
    let private marketGroup1813()= {MarketGroupData.id = 1813; parentId = Some 1811; name = "NEO YC 114 Team Cards"; }
    let private marketGroup1814()= {MarketGroupData.id = 1814; parentId = Some 1659; name = "Special Edition Implants"; }
    let private marketGroup1921()= {MarketGroupData.id = 1921; parentId = Some 1285; name = "Compression Array"; }
    let private marketGroup1924()= {MarketGroupData.id = 1924; parentId = Some 1364; name = "Expedition Frigates"; }
    let private marketGroup1935()= {MarketGroupData.id = 1935; parentId = Some 657; name = "Warp Disruptors"; }
    let private marketGroup1936()= {MarketGroupData.id = 1936; parentId = Some 657; name = "Warp Scramblers"; }
    let private marketGroup1937()= {MarketGroupData.id = 1937; parentId = Some 657; name = "Interdiction Sphere Launchers"; }
    let private marketGroup1938()= {MarketGroupData.id = 1938; parentId = Some 1566; name = "Warp Disruptors"; }
    let private marketGroup1939()= {MarketGroupData.id = 1939; parentId = Some 1566; name = "Warp Scramblers"; }
    let private marketGroup1940()= {MarketGroupData.id = 1940; parentId = Some 1566; name = "Interdiction Sphere Launchers"; }
    let private marketGroup798()= {MarketGroupData.id = 798; parentId = Some 800; name = "Outpost Components"; }
    let private marketGroup1943()= {MarketGroupData.id = 1943; parentId = Some 1407; name = "Headwear"; }
    let private marketGroup1944()= {MarketGroupData.id = 1944; parentId = Some 1402; name = "Bottoms, extras"; }
    let private marketGroup1941()= {MarketGroupData.id = 1941; parentId = Some 132; name = "Jump Economizers"; }
    let private marketGroup1931()= {MarketGroupData.id = 1931; parentId = Some 132; name = "Warp Accelerators"; }
    let private marketGroup1945()= {MarketGroupData.id = 1945; parentId = Some 1841; name = "Compression Array"; }
    let private marketGroup1932()= {MarketGroupData.id = 1932; parentId = Some 1612; name = "Special Edition Interceptors"; }
    let private marketGroup1840()= {MarketGroupData.id = 1840; parentId = Some 19; name = "Covert Research Tools"; }
    let private marketGroup1942()= {MarketGroupData.id = 1942; parentId = Some 1922; name = "Pilot's Services"; }
    let private marketGroup367566()= {MarketGroupData.id = 367566; parentId = Some 350001; name = "Special Offers"; }
    let private marketGroup365946()= {MarketGroupData.id = 365946; parentId = Some 367566; name = "Vehicle Loadouts"; }
    let private marketGroup365374()= {MarketGroupData.id = 365374; parentId = Some 367566; name = "Item Bundles"; }
    let private marketGroup367569()= {MarketGroupData.id = 367569; parentId = Some 365374; name = "Item Bundles"; }
    let private marketGroup367486()= {MarketGroupData.id = 367486; parentId = Some 367570; name = "Services"; }
    let private marketGroup367571()= {MarketGroupData.id = 367571; parentId = Some 367570; name = "Agents"; }
    let private marketGroup367593()= {MarketGroupData.id = 367593; parentId = Some 350001; name = "Visual Customization"; }
    let private marketGroup353565()= {MarketGroupData.id = 353565; parentId = Some 353566; name = "Vehicle Turrets"; }
    let private marketGroup1873()= {MarketGroupData.id = 1873; parentId = Some 1872; name = "Decryptors"; }
    let private marketGroup367771()= {MarketGroupData.id = 367771; parentId = Some 350001; name = "Salvage"; }
    let private marketGroup367772()= {MarketGroupData.id = 367772; parentId = Some 367771; name = "Containers"; }
    let private marketGroup367773()= {MarketGroupData.id = 367773; parentId = Some 367771; name = "Decryptors"; }
    let private marketGroup353567()= {MarketGroupData.id = 353567; parentId = Some 353562; name = "Dropsuit Weapons"; }
    let private marketGroup353563()= {MarketGroupData.id = 353563; parentId = Some 353562; name = "Dropsuit Equipment"; }
    let private marketGroup353579()= {MarketGroupData.id = 353579; parentId = Some 353562; name = "Dropsuit Modules"; }
    let private marketGroup353580()= {MarketGroupData.id = 353580; parentId = Some 353566; name = "Vehicle Modules"; }
    let private marketGroup1949()= {MarketGroupData.id = 1949; parentId = Some 787; name = "ORE"; }
    let private marketGroup1952()= {MarketGroupData.id = 1952; parentId = Some 1951; name = "Amarr"; }
    let private marketGroup368017()= {MarketGroupData.id = 368017; parentId = Some 350001; name = "Loadouts"; }
    let private marketGroup368105()= {MarketGroupData.id = 368105; parentId = Some 368017; name = "Basic"; }
    let private marketGroup368091()= {MarketGroupData.id = 368091; parentId = Some 368105; name = "Basic"; }
    let private marketGroup368106()= {MarketGroupData.id = 368106; parentId = Some 368017; name = "Assault"; }
    let private marketGroup368019()= {MarketGroupData.id = 368019; parentId = Some 368106; name = "Assault"; }
    let private marketGroup368107()= {MarketGroupData.id = 368107; parentId = Some 368017; name = "Scout"; }
    let private marketGroup368018()= {MarketGroupData.id = 368018; parentId = Some 368107; name = "Scout"; }
    let private marketGroup368108()= {MarketGroupData.id = 368108; parentId = Some 368017; name = "Heavy"; }
    let private marketGroup368020()= {MarketGroupData.id = 368020; parentId = Some 368108; name = "Sentinel"; }
    let private marketGroup368109()= {MarketGroupData.id = 368109; parentId = Some 368017; name = "Logistics"; }
    let private marketGroup368021()= {MarketGroupData.id = 368021; parentId = Some 368109; name = "Logistics"; }
    let private marketGroup1951()= {MarketGroupData.id = 1951; parentId = Some 1373; name = "Tactical Destroyers"; }
    let private marketGroup368655()= {MarketGroupData.id = 368655; parentId = Some 367771; name = "Battle Salvage"; }
    let private marketGroup368667()= {MarketGroupData.id = 368667; parentId = Some 350001; name = "Warbarge"; }
    let private marketGroup368668()= {MarketGroupData.id = 368668; parentId = Some 368667; name = "Resources"; }
    let private marketGroup1953()= {MarketGroupData.id = 1953; parentId = Some 1951; name = "Minmatar"; }
    let private marketGroup368916()= {MarketGroupData.id = 368916; parentId = Some 353587; name = "Shield Regulators"; }
    let private marketGroup368917()= {MarketGroupData.id = 368917; parentId = Some 368916; name = "Shield Regulators"; }
    let private marketGroup368918()= {MarketGroupData.id = 368918; parentId = Some 353592; name = "Heat Sinks"; }
    let private marketGroup368919()= {MarketGroupData.id = 368919; parentId = Some 368918; name = "Heat Sinks"; }
    let private marketGroup368920()= {MarketGroupData.id = 368920; parentId = Some 353592; name = "Dispersion Stabilizers"; }
    let private marketGroup368921()= {MarketGroupData.id = 368921; parentId = Some 368920; name = "Dispersion Stabilizers"; }
    let private marketGroup368922()= {MarketGroupData.id = 368922; parentId = Some 353651; name = "Advanced"; }
    let private marketGroup368923()= {MarketGroupData.id = 368923; parentId = Some 353651; name = "Prototype"; }
    let private marketGroup2013()= {MarketGroupData.id = 2013; parentId = Some 19; name = "Unknown Components"; }
    let private marketGroup2015()= {MarketGroupData.id = 2015; parentId = Some 1338; name = "Sovereignty and Infrastructure"; }
    let private marketGroup1356()= {MarketGroupData.id = 1356; parentId = Some 2015; name = "Sovereignty Structures"; }
    let private marketGroup2014()= {MarketGroupData.id = 2014; parentId = Some 2015; name = "Industrial Upgrades"; }
    let private marketGroup2016()= {MarketGroupData.id = 2016; parentId = Some 2015; name = "Military Upgrades"; }
    let private marketGroup2017()= {MarketGroupData.id = 2017; parentId = Some 2015; name = "Strategic Upgrades"; }
    let private marketGroup2018()= {MarketGroupData.id = 2018; parentId = Some 1708; name = "Entosis Links"; }
    let private marketGroup2020()= {MarketGroupData.id = 2020; parentId = Some 1710; name = "Entosis Links"; }
    let private marketGroup1964()= {MarketGroupData.id = 1964; parentId = Some 1962; name = "Amarr"; }
    let private marketGroup1984()= {MarketGroupData.id = 1984; parentId = Some 1972; name = "Amarr"; }
    let private marketGroup2002()= {MarketGroupData.id = 2002; parentId = Some 2001; name = "Amarr"; }
    let private marketGroup1965()= {MarketGroupData.id = 1965; parentId = Some 1962; name = "Caldari"; }
    let private marketGroup1985()= {MarketGroupData.id = 1985; parentId = Some 1972; name = "Caldari"; }
    let private marketGroup2003()= {MarketGroupData.id = 2003; parentId = Some 2001; name = "Caldari"; }
    let private marketGroup1966()= {MarketGroupData.id = 1966; parentId = Some 1962; name = "Gallente"; }
    let private marketGroup1986()= {MarketGroupData.id = 1986; parentId = Some 1972; name = "Gallente"; }
    let private marketGroup2004()= {MarketGroupData.id = 2004; parentId = Some 2001; name = "Gallente"; }
    let private marketGroup1967()= {MarketGroupData.id = 1967; parentId = Some 1962; name = "Minmatar"; }
    let private marketGroup1987()= {MarketGroupData.id = 1987; parentId = Some 1972; name = "Minmatar"; }
    let private marketGroup2005()= {MarketGroupData.id = 2005; parentId = Some 2001; name = "Minmatar"; }
    let private marketGroup1955()= {MarketGroupData.id = 1955; parentId = Some 1954; name = "Battlecruisers"; }
    let private marketGroup1962()= {MarketGroupData.id = 1962; parentId = Some 1960; name = "Standard Battleships"; }
    let private marketGroup1961()= {MarketGroupData.id = 1961; parentId = Some 1960; name = "Faction Battleships"; }
    let private marketGroup1960()= {MarketGroupData.id = 1960; parentId = Some 1954; name = "Battleships"; }
    let private marketGroup1954()= {MarketGroupData.id = 1954; parentId = None; name = "Ship SKINs"; }
    let private marketGroup1968()= {MarketGroupData.id = 1968; parentId = Some 1954; name = "Capital Ships"; }
    let private marketGroup1970()= {MarketGroupData.id = 1970; parentId = Some 1968; name = "Carriers"; }
    let private marketGroup1971()= {MarketGroupData.id = 1971; parentId = Some 1968; name = "Dreadnoughts"; }
    let private marketGroup1972()= {MarketGroupData.id = 1972; parentId = Some 1968; name = "Freighters"; }
    let private marketGroup1973()= {MarketGroupData.id = 1973; parentId = Some 1968; name = "Titans"; }
    let private marketGroup1988()= {MarketGroupData.id = 1988; parentId = Some 1954; name = "Cruisers"; }
    let private marketGroup1989()= {MarketGroupData.id = 1989; parentId = Some 1954; name = "Destroyers"; }
    let private marketGroup1998()= {MarketGroupData.id = 1998; parentId = Some 1954; name = "Frigates"; }
    let private marketGroup1999()= {MarketGroupData.id = 1999; parentId = Some 1998; name = "Faction Frigates"; }
    let private marketGroup2001()= {MarketGroupData.id = 2001; parentId = Some 1998; name = "Standard Frigates"; }
    let private marketGroup2000()= {MarketGroupData.id = 2000; parentId = Some 1999; name = "Navy Faction"; }
    let private marketGroup2006()= {MarketGroupData.id = 2006; parentId = Some 1954; name = "Industrial Ships"; }
    let private marketGroup2011()= {MarketGroupData.id = 2011; parentId = Some 1954; name = "Mining Barges"; }
    let private marketGroup2012()= {MarketGroupData.id = 2012; parentId = Some 2011; name = "Exhumers"; }
    let private marketGroup1963()= {MarketGroupData.id = 1963; parentId = Some 1961; name = "Pirate Faction"; }
    let private marketGroup369212()= {MarketGroupData.id = 369212; parentId = Some 367593; name = "Dropsuits"; }
    let private marketGroup369213()= {MarketGroupData.id = 369213; parentId = Some 369212; name = "Dropsuits"; }
    let private marketGroup369214()= {MarketGroupData.id = 369214; parentId = Some 367593; name = "Skins"; }
    let private marketGroup369215()= {MarketGroupData.id = 369215; parentId = Some 369214; name = "Skins"; }
    let private marketGroup369216()= {MarketGroupData.id = 369216; parentId = Some 368017; name = "APEX"; }
    let private marketGroup369217()= {MarketGroupData.id = 369217; parentId = Some 369216; name = "APEX"; }
    let private marketGroup369220()= {MarketGroupData.id = 369220; parentId = Some 365997; name = "SKIN"; }
    let private marketGroup369221()= {MarketGroupData.id = 369221; parentId = Some 369220; name = "SKIN"; }
    let private marketGroup369222()= {MarketGroupData.id = 369222; parentId = Some 365998; name = "SKIN"; }
    let private marketGroup369223()= {MarketGroupData.id = 369223; parentId = Some 369222; name = "SKIN"; }
    let private marketGroup369224()= {MarketGroupData.id = 369224; parentId = Some 365999; name = "SKIN"; }
    let private marketGroup369225()= {MarketGroupData.id = 369225; parentId = Some 369224; name = "SKIN"; }
    let private marketGroup369226()= {MarketGroupData.id = 369226; parentId = Some 365996; name = "SKIN"; }
    let private marketGroup369227()= {MarketGroupData.id = 369227; parentId = Some 369226; name = "SKIN"; }
    let private marketGroup2021()= {MarketGroupData.id = 2021; parentId = Some 1951; name = "Caldari"; }
    let private marketGroup369234()= {MarketGroupData.id = 369234; parentId = Some 350001; name = "Boosters & Services"; }
    let private marketGroup354534()= {MarketGroupData.id = 354534; parentId = Some 369234; name = "Boosters"; }
    let private marketGroup367570()= {MarketGroupData.id = 367570; parentId = Some 369234; name = "Services"; }
    let private marketGroup353633()= {MarketGroupData.id = 353633; parentId = Some 369234; name = "Skills"; }
    let private marketGroup2024()= {MarketGroupData.id = 2024; parentId = Some 2023; name = "Amarr"; }
    let private marketGroup2025()= {MarketGroupData.id = 2025; parentId = Some 2023; name = "Caldari"; }
    let private marketGroup2026()= {MarketGroupData.id = 2026; parentId = Some 2023; name = "Gallente"; }
    let private marketGroup2027()= {MarketGroupData.id = 2027; parentId = Some 2023; name = "Minmatar"; }
    let private marketGroup2028()= {MarketGroupData.id = 2028; parentId = Some 1988; name = "Standard Cruisers"; }
    let private marketGroup2029()= {MarketGroupData.id = 2029; parentId = Some 1988; name = "Faction Cruisers"; }
    let private marketGroup2030()= {MarketGroupData.id = 2030; parentId = Some 2029; name = "Pirate Faction"; }
    let private marketGroup1990()= {MarketGroupData.id = 1990; parentId = Some 2028; name = "Amarr"; }
    let private marketGroup1991()= {MarketGroupData.id = 1991; parentId = Some 2028; name = "Caldari"; }
    let private marketGroup1992()= {MarketGroupData.id = 1992; parentId = Some 2028; name = "Gallente"; }
    let private marketGroup1993()= {MarketGroupData.id = 1993; parentId = Some 2028; name = "Minmatar"; }
    let private marketGroup2031()= {MarketGroupData.id = 2031; parentId = Some 1999; name = "Pirate Faction"; }
    let private marketGroup2022()= {MarketGroupData.id = 2022; parentId = Some 1960; name = "Advanced Battleships"; }
    let private marketGroup2023()= {MarketGroupData.id = 2023; parentId = Some 2022; name = "Marauders"; }
    let private marketGroup2034()= {MarketGroupData.id = 2034; parentId = Some 1951; name = "Gallente"; }
    let private marketGroup2035()= {MarketGroupData.id = 2035; parentId = Some 1989; name = "Standard Destroyers"; }
    let private marketGroup1997()= {MarketGroupData.id = 1997; parentId = Some 2035; name = "Minmatar"; }
    let private marketGroup1996()= {MarketGroupData.id = 1996; parentId = Some 2035; name = "Gallente"; }
    let private marketGroup1995()= {MarketGroupData.id = 1995; parentId = Some 2035; name = "Caldari"; }
    let private marketGroup1994()= {MarketGroupData.id = 1994; parentId = Some 2035; name = "Amarr"; }
    let private marketGroup2036()= {MarketGroupData.id = 2036; parentId = Some 1989; name = "Advanced Destroyers"; }
    let private marketGroup2037()= {MarketGroupData.id = 2037; parentId = Some 2036; name = "Interdictors"; }
    let private marketGroup2038()= {MarketGroupData.id = 2038; parentId = Some 2037; name = "Amarr"; }
    let private marketGroup2039()= {MarketGroupData.id = 2039; parentId = Some 2037; name = "Caldari"; }
    let private marketGroup2040()= {MarketGroupData.id = 2040; parentId = Some 2037; name = "Gallente"; }
    let private marketGroup2041()= {MarketGroupData.id = 2041; parentId = Some 2037; name = "Minmatar"; }
    let private marketGroup2042()= {MarketGroupData.id = 2042; parentId = Some 1998; name = "Advanced Frigates"; }
    let private marketGroup2043()= {MarketGroupData.id = 2043; parentId = Some 2042; name = "Assault Frigates"; }
    let private marketGroup2044()= {MarketGroupData.id = 2044; parentId = Some 2042; name = "Covert Ops"; }
    let private marketGroup2045()= {MarketGroupData.id = 2045; parentId = Some 2042; name = "Electronic Attack Frigates"; }
    let private marketGroup2046()= {MarketGroupData.id = 2046; parentId = Some 2042; name = "Interceptors"; }
    let private marketGroup2047()= {MarketGroupData.id = 2047; parentId = Some 2043; name = "Amarr"; }
    let private marketGroup2048()= {MarketGroupData.id = 2048; parentId = Some 2043; name = "Caldari"; }
    let private marketGroup2049()= {MarketGroupData.id = 2049; parentId = Some 2043; name = "Gallente"; }
    let private marketGroup2050()= {MarketGroupData.id = 2050; parentId = Some 2043; name = "Minmatar"; }
    let private marketGroup2051()= {MarketGroupData.id = 2051; parentId = Some 2044; name = "Amarr"; }
    let private marketGroup2052()= {MarketGroupData.id = 2052; parentId = Some 2044; name = "Caldari"; }
    let private marketGroup2053()= {MarketGroupData.id = 2053; parentId = Some 2044; name = "Gallente"; }
    let private marketGroup2054()= {MarketGroupData.id = 2054; parentId = Some 2044; name = "Minmatar"; }
    let private marketGroup2055()= {MarketGroupData.id = 2055; parentId = Some 2045; name = "Amarr"; }
    let private marketGroup2056()= {MarketGroupData.id = 2056; parentId = Some 2045; name = "Caldari"; }
    let private marketGroup2057()= {MarketGroupData.id = 2057; parentId = Some 2045; name = "Gallente"; }
    let private marketGroup2058()= {MarketGroupData.id = 2058; parentId = Some 2045; name = "Minmatar"; }
    let private marketGroup2059()= {MarketGroupData.id = 2059; parentId = Some 2046; name = "Amarr"; }
    let private marketGroup2060()= {MarketGroupData.id = 2060; parentId = Some 2046; name = "Caldari"; }
    let private marketGroup2061()= {MarketGroupData.id = 2061; parentId = Some 2046; name = "Gallente"; }
    let private marketGroup2062()= {MarketGroupData.id = 2062; parentId = Some 2046; name = "Minmatar"; }
    let private marketGroup2063()= {MarketGroupData.id = 2063; parentId = Some 2029; name = "Navy Faction"; }
    let private marketGroup2064()= {MarketGroupData.id = 2064; parentId = Some 1988; name = "Advanced Cruisers"; }
    let private marketGroup2065()= {MarketGroupData.id = 2065; parentId = Some 2064; name = "Heavy Assault Cruisers"; }
    let private marketGroup2066()= {MarketGroupData.id = 2066; parentId = Some 2064; name = "Heavy Interdiction Cruisers"; }
    let private marketGroup2067()= {MarketGroupData.id = 2067; parentId = Some 2064; name = "Logistics"; }
    let private marketGroup2068()= {MarketGroupData.id = 2068; parentId = Some 2064; name = "Recon Ships"; }
    let private marketGroup2069()= {MarketGroupData.id = 2069; parentId = Some 2065; name = "Amarr"; }
    let private marketGroup2070()= {MarketGroupData.id = 2070; parentId = Some 2065; name = "Caldari"; }
    let private marketGroup2071()= {MarketGroupData.id = 2071; parentId = Some 2065; name = "Gallente"; }
    let private marketGroup2072()= {MarketGroupData.id = 2072; parentId = Some 2065; name = "Minmatar"; }
    let private marketGroup2073()= {MarketGroupData.id = 2073; parentId = Some 2066; name = "Amarr"; }
    let private marketGroup2074()= {MarketGroupData.id = 2074; parentId = Some 2066; name = "Caldari"; }
    let private marketGroup2075()= {MarketGroupData.id = 2075; parentId = Some 2066; name = "Gallente"; }
    let private marketGroup2076()= {MarketGroupData.id = 2076; parentId = Some 2066; name = "Minmatar"; }
    let private marketGroup2077()= {MarketGroupData.id = 2077; parentId = Some 2067; name = "Amarr"; }
    let private marketGroup2078()= {MarketGroupData.id = 2078; parentId = Some 2067; name = "Caldari"; }
    let private marketGroup2079()= {MarketGroupData.id = 2079; parentId = Some 2067; name = "Gallente"; }
    let private marketGroup2080()= {MarketGroupData.id = 2080; parentId = Some 2067; name = "Minmatar"; }
    let private marketGroup2081()= {MarketGroupData.id = 2081; parentId = Some 2068; name = "Amarr"; }
    let private marketGroup2082()= {MarketGroupData.id = 2082; parentId = Some 2068; name = "Caldari"; }
    let private marketGroup2083()= {MarketGroupData.id = 2083; parentId = Some 2068; name = "Gallente"; }
    let private marketGroup2084()= {MarketGroupData.id = 2084; parentId = Some 2068; name = "Minmatar"; }
    let private marketGroup2085()= {MarketGroupData.id = 2085; parentId = Some 2006; name = "Standard Industrial Ships"; }
    let private marketGroup2086()= {MarketGroupData.id = 2086; parentId = Some 2006; name = "Advanced Industrial Ships"; }
    let private marketGroup2007()= {MarketGroupData.id = 2007; parentId = Some 2085; name = "Amarr"; }
    let private marketGroup2008()= {MarketGroupData.id = 2008; parentId = Some 2085; name = "Caldari"; }
    let private marketGroup2009()= {MarketGroupData.id = 2009; parentId = Some 2085; name = "Gallente"; }
    let private marketGroup2010()= {MarketGroupData.id = 2010; parentId = Some 2085; name = "Minmatar"; }
    let private marketGroup2087()= {MarketGroupData.id = 2087; parentId = Some 2086; name = "Transport Ships"; }
    let private marketGroup2088()= {MarketGroupData.id = 2088; parentId = Some 2087; name = "Amarr"; }
    let private marketGroup2089()= {MarketGroupData.id = 2089; parentId = Some 2087; name = "Caldari"; }
    let private marketGroup2090()= {MarketGroupData.id = 2090; parentId = Some 2087; name = "Gallente"; }
    let private marketGroup2091()= {MarketGroupData.id = 2091; parentId = Some 2087; name = "Minmatar"; }
    let private marketGroup1950()= {MarketGroupData.id = 1950; parentId = Some 766; name = "ORE"; }
    let private marketGroup2094()= {MarketGroupData.id = 2094; parentId = Some 1968; name = "Jump Freighters"; }
    let private marketGroup2095()= {MarketGroupData.id = 2095; parentId = Some 2094; name = "Amarr"; }
    let private marketGroup2096()= {MarketGroupData.id = 2096; parentId = Some 2094; name = "Caldari"; }
    let private marketGroup2097()= {MarketGroupData.id = 2097; parentId = Some 2094; name = "Gallente"; }
    let private marketGroup2098()= {MarketGroupData.id = 2098; parentId = Some 2094; name = "Minmatar"; }
    let private marketGroup2099()= {MarketGroupData.id = 2099; parentId = Some 1955; name = "Advanced Battlecruisers"; }
    let private marketGroup2100()= {MarketGroupData.id = 2100; parentId = Some 1955; name = "Faction Battlecruisers"; }
    let private marketGroup2101()= {MarketGroupData.id = 2101; parentId = Some 1955; name = "Standard Battlecruisers"; }
    let private marketGroup1956()= {MarketGroupData.id = 1956; parentId = Some 2101; name = "Amarr"; }
    let private marketGroup1957()= {MarketGroupData.id = 1957; parentId = Some 2101; name = "Caldari"; }
    let private marketGroup1958()= {MarketGroupData.id = 1958; parentId = Some 2101; name = "Gallente"; }
    let private marketGroup1959()= {MarketGroupData.id = 1959; parentId = Some 2101; name = "Minmatar"; }
    let private marketGroup2102()= {MarketGroupData.id = 2102; parentId = Some 2099; name = "Command Ships"; }
    let private marketGroup2103()= {MarketGroupData.id = 2103; parentId = Some 2100; name = "Navy Faction"; }
    let private marketGroup2104()= {MarketGroupData.id = 2104; parentId = Some 2102; name = "Amarr"; }
    let private marketGroup2105()= {MarketGroupData.id = 2105; parentId = Some 2102; name = "Caldari"; }
    let private marketGroup2106()= {MarketGroupData.id = 2106; parentId = Some 2102; name = "Gallente"; }
    let private marketGroup2107()= {MarketGroupData.id = 2107; parentId = Some 2102; name = "Minmatar"; }
    let private marketGroup2108()= {MarketGroupData.id = 2108; parentId = Some 1961; name = "Navy Faction"; }
    let private marketGroup2109()= {MarketGroupData.id = 2109; parentId = Some 2022; name = "Black Ops"; }
    let private marketGroup2110()= {MarketGroupData.id = 2110; parentId = Some 2109; name = "Amarr"; }
    let private marketGroup2111()= {MarketGroupData.id = 2111; parentId = Some 2109; name = "Caldari"; }
    let private marketGroup2112()= {MarketGroupData.id = 2112; parentId = Some 2109; name = "Gallente"; }
    let private marketGroup2113()= {MarketGroupData.id = 2113; parentId = Some 2109; name = "Minmatar"; }
    let private marketGroup645()= {MarketGroupData.id = 645; parentId = Some 143; name = "Ballistic Control Systems"; }
    let private marketGroup143()= {MarketGroupData.id = 143; parentId = Some 10; name = "Weapon Upgrades"; }
    let private marketGroup2032()= {MarketGroupData.id = 2032; parentId = Some 143; name = "Missile Guidance Computers"; }
    let private marketGroup2033()= {MarketGroupData.id = 2033; parentId = Some 143; name = "Missile Guidance Enhancers"; }
    let private marketGroup2114()= {MarketGroupData.id = 2114; parentId = Some 1968; name = "Capital Industrial Ships"; }
    let private marketGroup1969()= {MarketGroupData.id = 1969; parentId = Some 2114; name = "ORE"; }
    let private marketGroup2115()= {MarketGroupData.id = 2115; parentId = Some 1612; name = "Special Edition Heavy Interdiction Cruisers"; }
    let private marketGroup1922()= {MarketGroupData.id = 1922; parentId = None; name = "Pilot's Services"; }
    let private marketGroup1923()= {MarketGroupData.id = 1923; parentId = Some 1922; name = "PLEX"; }
    let private marketGroup2119()= {MarketGroupData.id = 2119; parentId = Some 1954; name = "Multiple Hull SKINs"; }
    let private marketGroup2120()= {MarketGroupData.id = 2120; parentId = Some 2119; name = "Special Edition SKINs"; }
    let private marketGroup2125()= {MarketGroupData.id = 2125; parentId = Some 1373; name = "Command Destroyers"; }
    let private marketGroup2134()= {MarketGroupData.id = 2134; parentId = Some 252; name = "Micro Jump Field Generators"; }
    let private marketGroup2136()= {MarketGroupData.id = 2136; parentId = Some 2042; name = "Logistics Frigates"; }
    let private marketGroup2137()= {MarketGroupData.id = 2137; parentId = Some 2136; name = "Amarr"; }
    let private marketGroup2138()= {MarketGroupData.id = 2138; parentId = Some 2136; name = "Caldari"; }
    let private marketGroup2139()= {MarketGroupData.id = 2139; parentId = Some 2136; name = "Gallente"; }
    let private marketGroup2140()= {MarketGroupData.id = 2140; parentId = Some 2136; name = "Minmatar"; }
    let private marketGroup2141()= {MarketGroupData.id = 2141; parentId = Some 2036; name = "Command Destroyers"; }
    let private marketGroup2142()= {MarketGroupData.id = 2142; parentId = Some 2141; name = "Amarr"; }
    let private marketGroup2143()= {MarketGroupData.id = 2143; parentId = Some 2141; name = "Caldari"; }
    let private marketGroup2144()= {MarketGroupData.id = 2144; parentId = Some 2141; name = "Gallente"; }
    let private marketGroup2145()= {MarketGroupData.id = 2145; parentId = Some 2141; name = "Minmatar"; }
    let private marketGroup2146()= {MarketGroupData.id = 2146; parentId = Some 1364; name = "Logistics Frigates"; }
    let private marketGroup2147()= {MarketGroupData.id = 2147; parentId = Some 2146; name = "Amarr"; }
    let private marketGroup2148()= {MarketGroupData.id = 2148; parentId = Some 2146; name = "Caldari"; }
    let private marketGroup2149()= {MarketGroupData.id = 2149; parentId = Some 2146; name = "Gallente"; }
    let private marketGroup2150()= {MarketGroupData.id = 2150; parentId = Some 2146; name = "Minmatar"; }
    let private marketGroup2135()= {MarketGroupData.id = 2135; parentId = Some 52; name = "Micro Jump Field Generators"; }
    let private marketGroup2151()= {MarketGroupData.id = 2151; parentId = Some 1713; name = "Ice Mining Lasers"; }
    let private marketGroup2126()= {MarketGroupData.id = 2126; parentId = Some 2125; name = "Amarr"; }
    let private marketGroup2131()= {MarketGroupData.id = 2131; parentId = Some 2125; name = "Caldari"; }
    let private marketGroup2132()= {MarketGroupData.id = 2132; parentId = Some 2125; name = "Gallente"; }
    let private marketGroup2133()= {MarketGroupData.id = 2133; parentId = Some 2125; name = "Minmatar"; }
    let private marketGroup2152()= {MarketGroupData.id = 2152; parentId = Some 150; name = "Structure Management"; }
    let private marketGroup2153()= {MarketGroupData.id = 2153; parentId = Some 1566; name = "Stasis Grapplers"; }
    let private marketGroup2154()= {MarketGroupData.id = 2154; parentId = Some 657; name = "Stasis Grapplers"; }
    let private marketGroup2156()= {MarketGroupData.id = 2156; parentId = Some 1338; name = "Citadels"; }
    let private marketGroup2157()= {MarketGroupData.id = 2157; parentId = Some 2; name = "Structure Modifications"; }
    let private marketGroup2158()= {MarketGroupData.id = 2158; parentId = Some 2; name = "Structure Equipment"; }
    let private marketGroup2159()= {MarketGroupData.id = 2159; parentId = Some 2157; name = "Structure Combat Rigs"; }
    let private marketGroup2160()= {MarketGroupData.id = 2160; parentId = Some 2157; name = "Structure Resource Processing Rigs"; }
    let private marketGroup2161()= {MarketGroupData.id = 2161; parentId = Some 2158; name = "Electronic Warfare"; }
    let private marketGroup2162()= {MarketGroupData.id = 2162; parentId = Some 2158; name = "Electronics and Sensor Upgrades"; }
    let private marketGroup2163()= {MarketGroupData.id = 2163; parentId = Some 2158; name = "Engineering Equipment"; }
    let private marketGroup2164()= {MarketGroupData.id = 2164; parentId = Some 2158; name = "Structure Weapons"; }
    let private marketGroup2165()= {MarketGroupData.id = 2165; parentId = Some 2158; name = "Fighter Upgrades"; }
    let private marketGroup2166()= {MarketGroupData.id = 2166; parentId = Some 2158; name = "Service Modules"; }
    let private marketGroup2167()= {MarketGroupData.id = 2167; parentId = Some 2161; name = "Electronic Counter Measures"; }
    let private marketGroup2168()= {MarketGroupData.id = 2168; parentId = Some 2161; name = "Remote Sensor Dampeners"; }
    let private marketGroup2169()= {MarketGroupData.id = 2169; parentId = Some 2161; name = "Stasis Webifiers"; }
    let private marketGroup2170()= {MarketGroupData.id = 2170; parentId = Some 2161; name = "Target Painters"; }
    let private marketGroup2172()= {MarketGroupData.id = 2172; parentId = Some 2161; name = "Warp Scramblers"; }
    let private marketGroup2173()= {MarketGroupData.id = 2173; parentId = Some 2162; name = "CPU Upgrades"; }
    let private marketGroup2174()= {MarketGroupData.id = 2174; parentId = Some 2162; name = "Signal Amplifiers"; }
    let private marketGroup2175()= {MarketGroupData.id = 2175; parentId = Some 2163; name = "Capacitor Batteries"; }
    let private marketGroup2176()= {MarketGroupData.id = 2176; parentId = Some 2163; name = "Energy Neutralizers"; }
    let private marketGroup2177()= {MarketGroupData.id = 2177; parentId = Some 2163; name = "Reactor Control Units"; }
    let private marketGroup2178()= {MarketGroupData.id = 2178; parentId = Some 2164; name = "Missile Launchers"; }
    let private marketGroup2179()= {MarketGroupData.id = 2179; parentId = Some 2164; name = "Weapon Upgrades"; }
    let private marketGroup2180()= {MarketGroupData.id = 2180; parentId = Some 2164; name = "Doomsday Devices"; }
    let private marketGroup2181()= {MarketGroupData.id = 2181; parentId = Some 2166; name = "Citadel Service Modules"; }
    let private marketGroup2182()= {MarketGroupData.id = 2182; parentId = Some 2166; name = "Resource Processing Service Modules"; }
    let private marketGroup2183()= {MarketGroupData.id = 2183; parentId = Some 2178; name = "Structure Anticapital Launcher"; }
    let private marketGroup2184()= {MarketGroupData.id = 2184; parentId = Some 2178; name = "Structure Antisubcapital Launcher"; }
    let private marketGroup2185()= {MarketGroupData.id = 2185; parentId = Some 2164; name = "Guided Bomb Launchers"; }
    let private marketGroup2187()= {MarketGroupData.id = 2187; parentId = Some 2162; name = "Ship Tractor Beams"; }
    let private marketGroup2188()= {MarketGroupData.id = 2188; parentId = Some 2163; name = "Capacitor Power Relays"; }
    let private marketGroup2189()= {MarketGroupData.id = 2189; parentId = Some 2179; name = "Ballistic Control Systems"; }
    let private marketGroup2190()= {MarketGroupData.id = 2190; parentId = Some 2179; name = "Missile Guidance Enhancers"; }
    let private marketGroup2191()= {MarketGroupData.id = 2191; parentId = Some 314; name = "Structure Anticapital Missiles"; }
    let private marketGroup2192()= {MarketGroupData.id = 2192; parentId = Some 314; name = "Structure Antisubcapital Missiles"; }
    let private marketGroup2193()= {MarketGroupData.id = 2193; parentId = Some 211; name = "Structure Guided Bombs"; }
    let private marketGroup2196()= {MarketGroupData.id = 2196; parentId = Some 114; name = "Structure Antisubcapital Missiles"; }
    let private marketGroup2197()= {MarketGroupData.id = 2197; parentId = Some 114; name = "Structure Anticapital Missiles"; }
    let private marketGroup2198()= {MarketGroupData.id = 2198; parentId = Some 11; name = "Structure Guided Bombs"; }
    let private marketGroup2199()= {MarketGroupData.id = 2199; parentId = Some 477; name = "Citadels"; }
    let private marketGroup2200()= {MarketGroupData.id = 2200; parentId = Some 2199; name = "Faction Citadels"; }
    let private marketGroup2201()= {MarketGroupData.id = 2201; parentId = Some 2199; name = "Standard Citadels"; }
    let private marketGroup2206()= {MarketGroupData.id = 2206; parentId = Some 2202; name = "Electronic Warfare"; }
    let private marketGroup2207()= {MarketGroupData.id = 2207; parentId = Some 2202; name = "Electronics and Sensor Upgrades"; }
    let private marketGroup2208()= {MarketGroupData.id = 2208; parentId = Some 2202; name = "Engineering Equipment"; }
    let private marketGroup2209()= {MarketGroupData.id = 2209; parentId = Some 2202; name = "Structure Weapons"; }
    let private marketGroup2210()= {MarketGroupData.id = 2210; parentId = Some 2202; name = "Service Modules"; }
    let private marketGroup2211()= {MarketGroupData.id = 2211; parentId = Some 2206; name = "Electronic Counter Measures"; }
    let private marketGroup2212()= {MarketGroupData.id = 2212; parentId = Some 2206; name = "Remote Sensor Dampeners"; }
    let private marketGroup2213()= {MarketGroupData.id = 2213; parentId = Some 2206; name = "Stasis Webifiers"; }
    let private marketGroup2214()= {MarketGroupData.id = 2214; parentId = Some 2206; name = "Target Painters"; }
    let private marketGroup2216()= {MarketGroupData.id = 2216; parentId = Some 2206; name = "Warp Disruptors"; }
    let private marketGroup2218()= {MarketGroupData.id = 2218; parentId = Some 2207; name = "CPU Upgrades"; }
    let private marketGroup2219()= {MarketGroupData.id = 2219; parentId = Some 2207; name = "Signal Amplifiers"; }
    let private marketGroup2221()= {MarketGroupData.id = 2221; parentId = Some 2208; name = "Point Defense Batteries"; }
    let private marketGroup2222()= {MarketGroupData.id = 2222; parentId = Some 2208; name = "Reactor Control Units"; }
    let private marketGroup2223()= {MarketGroupData.id = 2223; parentId = Some 2208; name = "Energy Neutralizers"; }
    let private marketGroup2226()= {MarketGroupData.id = 2226; parentId = Some 2209; name = "Missile Launchers"; }
    let private marketGroup2227()= {MarketGroupData.id = 2227; parentId = Some 2209; name = "Weapon Upgrades"; }
    let private marketGroup2228()= {MarketGroupData.id = 2228; parentId = Some 2209; name = "Doomsday Devices"; }
    let private marketGroup2229()= {MarketGroupData.id = 2229; parentId = Some 2209; name = "Guided Bomb Launchers"; }
    let private marketGroup2230()= {MarketGroupData.id = 2230; parentId = Some 2226; name = "Structure Anticapital Launcher"; }
    let private marketGroup2231()= {MarketGroupData.id = 2231; parentId = Some 2226; name = "Structure Antisubcapital Launcher"; }
    let private marketGroup2232()= {MarketGroupData.id = 2232; parentId = Some 2210; name = "Citadel Service Modules"; }
    let private marketGroup2233()= {MarketGroupData.id = 2233; parentId = Some 2210; name = "Resource Processing Service Modules"; }
    let private marketGroup2234()= {MarketGroupData.id = 2234; parentId = Some 2227; name = "Ballistic Control Systems"; }
    let private marketGroup2235()= {MarketGroupData.id = 2235; parentId = Some 2227; name = "Missile Guidance Enhancers"; }
    let private marketGroup2186()= {MarketGroupData.id = 2186; parentId = Some 2163; name = "Point Defense Batteries"; }
    let private marketGroup1028()= {MarketGroupData.id = 1028; parentId = Some 2237; name = "Light Fighters"; }
    let private marketGroup1313()= {MarketGroupData.id = 1313; parentId = Some 2237; name = "Heavy Fighters"; }
    let private marketGroup2238()= {MarketGroupData.id = 2238; parentId = Some 2237; name = "Support Fighters"; }
    let private marketGroup2240()= {MarketGroupData.id = 2240; parentId = Some 133; name = "25000mm Armor Plate"; }
    let private marketGroup2241()= {MarketGroupData.id = 2241; parentId = Some 551; name = "Capital"; }
    let private marketGroup2242()= {MarketGroupData.id = 2242; parentId = Some 664; name = "Capital"; }
    let private marketGroup2243()= {MarketGroupData.id = 2243; parentId = Some 668; name = "Capital"; }
    let private marketGroup2244()= {MarketGroupData.id = 2244; parentId = Some 538; name = "Capital"; }
    let private marketGroup1416()= {MarketGroupData.id = 1416; parentId = Some 535; name = "Reactive Armor Hardeners"; }
    let private marketGroup2245()= {MarketGroupData.id = 2245; parentId = Some 535; name = "Scriptable Armor Hardeners"; }
    let private marketGroup2246()= {MarketGroupData.id = 2246; parentId = Some 553; name = "Scriptable Shield Hardeners"; }
    let private marketGroup2247()= {MarketGroupData.id = 2247; parentId = Some 140; name = "Rapid Torpedo Launchers"; }
    let private marketGroup2248()= {MarketGroupData.id = 2248; parentId = Some 1566; name = "Burst Projectors"; }
    let private marketGroup2249()= {MarketGroupData.id = 2249; parentId = Some 657; name = "Burst Projectors"; }
    let private marketGroup2250()= {MarketGroupData.id = 2250; parentId = Some 661; name = "Capital"; }
    let private marketGroup2251()= {MarketGroupData.id = 2251; parentId = Some 662; name = "Capital"; }
    let private marketGroup2237()= {MarketGroupData.id = 2237; parentId = Some 357; name = "Fighters"; }
    let private marketGroup2258()= {MarketGroupData.id = 2258; parentId = Some 505; name = "Advanced Anti-Ship XL Torpedoes"; }
    let private marketGroup2259()= {MarketGroupData.id = 2259; parentId = Some 505; name = "Advanced Long Range XL Torpedoes"; }
    let private marketGroup2260()= {MarketGroupData.id = 2260; parentId = Some 1316; name = "Advanced High Precision XL Cruise Missiles"; }
    let private marketGroup2261()= {MarketGroupData.id = 2261; parentId = Some 1316; name = "Advanced High Damage XL Cruise Missiles"; }
    let private marketGroup2257()= {MarketGroupData.id = 2257; parentId = Some 852; name = "Extra Large"; }
    let private marketGroup2256()= {MarketGroupData.id = 2256; parentId = Some 853; name = "Extra Large"; }
    let private marketGroup2254()= {MarketGroupData.id = 2254; parentId = Some 849; name = "Extra Large"; }
    let private marketGroup2255()= {MarketGroupData.id = 2255; parentId = Some 850; name = "Extra Large"; }
    let private marketGroup2252()= {MarketGroupData.id = 2252; parentId = Some 846; name = "Extra Large"; }
    let private marketGroup2253()= {MarketGroupData.id = 2253; parentId = Some 847; name = "Extra Large"; }
    let private marketGroup2262()= {MarketGroupData.id = 2262; parentId = Some 204; name = "Force Auxiliaries"; }
    let private marketGroup2263()= {MarketGroupData.id = 2263; parentId = Some 2262; name = "Amarr"; }
    let private marketGroup2264()= {MarketGroupData.id = 2264; parentId = Some 2262; name = "Caldari"; }
    let private marketGroup2265()= {MarketGroupData.id = 2265; parentId = Some 2262; name = "Gallente"; }
    let private marketGroup2266()= {MarketGroupData.id = 2266; parentId = Some 2262; name = "Minmatar"; }
    let private marketGroup2267()= {MarketGroupData.id = 2267; parentId = Some 912; name = "Amarr"; }
    let private marketGroup2268()= {MarketGroupData.id = 2268; parentId = Some 912; name = "Caldari"; }
    let private marketGroup2269()= {MarketGroupData.id = 2269; parentId = Some 912; name = "Gallente"; }
    let private marketGroup2270()= {MarketGroupData.id = 2270; parentId = Some 912; name = "Minmatar"; }
    let private marketGroup2271()= {MarketGroupData.id = 2271; parentId = Some 1381; name = "Force Auxiliaries"; }
    let private marketGroup2272()= {MarketGroupData.id = 2272; parentId = Some 2271; name = "Amarr"; }
    let private marketGroup2273()= {MarketGroupData.id = 2273; parentId = Some 2271; name = "Caldari"; }
    let private marketGroup2274()= {MarketGroupData.id = 2274; parentId = Some 2271; name = "Gallente"; }
    let private marketGroup2275()= {MarketGroupData.id = 2275; parentId = Some 2271; name = "Minmatar"; }
    let private marketGroup2276()= {MarketGroupData.id = 2276; parentId = Some 912; name = "Non-Racial"; }
    let private marketGroup912()= {MarketGroupData.id = 912; parentId = Some 10; name = "Superweapons"; }
    let private marketGroup2277()= {MarketGroupData.id = 2277; parentId = Some 1968; name = "Force Auxiliaries"; }
    let private marketGroup2278()= {MarketGroupData.id = 2278; parentId = Some 2277; name = "Amarr"; }
    let private marketGroup2279()= {MarketGroupData.id = 2279; parentId = Some 2277; name = "Caldari"; }
    let private marketGroup2280()= {MarketGroupData.id = 2280; parentId = Some 2277; name = "Gallente"; }
    let private marketGroup2281()= {MarketGroupData.id = 2281; parentId = Some 2277; name = "Minmatar"; }
    let private marketGroup2155()= {MarketGroupData.id = 2155; parentId = Some 533; name = "Named Components"; }
    let private marketGroup2283()= {MarketGroupData.id = 2283; parentId = Some 1954; name = "Capsules"; }
    let private marketGroup2285()= {MarketGroupData.id = 2285; parentId = Some 2283; name = "Capsules"; }
    let private marketGroup2286()= {MarketGroupData.id = 2286; parentId = Some 2283; name = "Special Edition Capsules"; }
    let private marketGroup2287()= {MarketGroupData.id = 2287; parentId = Some 812; name = "Faction Titans"; }
    let private marketGroup2288()= {MarketGroupData.id = 2288; parentId = Some 761; name = "Faction Dreadnoughts"; }
    let private marketGroup2297()= {MarketGroupData.id = 2297; parentId = Some 11; name = "Command Burst Charges"; }
    let private marketGroup2298()= {MarketGroupData.id = 2298; parentId = Some 2297; name = "Armor Command Burst Charges"; }
    let private marketGroup2299()= {MarketGroupData.id = 2299; parentId = Some 2297; name = "Information Command Burst Charges"; }
    let private marketGroup2300()= {MarketGroupData.id = 2300; parentId = Some 2297; name = "Mining Foreman Burst Charges"; }
    let private marketGroup2301()= {MarketGroupData.id = 2301; parentId = Some 2297; name = "Shield Command Burst Charges"; }
    let private marketGroup2302()= {MarketGroupData.id = 2302; parentId = Some 2297; name = "Skirmish Command Burst Charges"; }
    let private marketGroup2306()= {MarketGroupData.id = 2306; parentId = Some 1954; name = "Corvettes"; }
    let private marketGroup2309()= {MarketGroupData.id = 2309; parentId = Some 2036; name = "Tactical Destroyers"; }
    let private marketGroup2310()= {MarketGroupData.id = 2310; parentId = Some 2309; name = "Amarr"; }
    let private marketGroup2291()= {MarketGroupData.id = 2291; parentId = Some 2290; name = "Armor Command Burst Charges"; }
    let private marketGroup2292()= {MarketGroupData.id = 2292; parentId = Some 2290; name = "Information Command Burst Charges"; }
    let private marketGroup2293()= {MarketGroupData.id = 2293; parentId = Some 2290; name = "Mining Foreman Burst Charges"; }
    let private marketGroup2294()= {MarketGroupData.id = 2294; parentId = Some 2290; name = "Shield Command Burst Charges"; }
    let private marketGroup2295()= {MarketGroupData.id = 2295; parentId = Some 2290; name = "Skirmish Command Burst Charges"; }
    let private marketGroup2290()= {MarketGroupData.id = 2290; parentId = Some 211; name = "Command Burst Charges"; }
    let private marketGroup2311()= {MarketGroupData.id = 2311; parentId = Some 1955; name = "Special Battlecruisers"; }
    let private marketGroup2312()= {MarketGroupData.id = 2312; parentId = Some 2311; name = "Special Battlecruisers"; }
    let private marketGroup2313()= {MarketGroupData.id = 2313; parentId = Some 1989; name = "Special Destroyers"; }
    let private marketGroup2314()= {MarketGroupData.id = 2314; parentId = Some 2313; name = "Special Destroyers"; }
    let private marketGroup2315()= {MarketGroupData.id = 2315; parentId = Some 1954; name = "Shuttles"; }
    let private marketGroup2316()= {MarketGroupData.id = 2316; parentId = Some 2315; name = "Special Shuttles"; }
    let private marketGroup2317()= {MarketGroupData.id = 2317; parentId = Some 19; name = "Strong Boxes"; }
    let private marketGroup2318()= {MarketGroupData.id = 2318; parentId = Some 1972; name = "ORE"; }
    let private marketGroup2319()= {MarketGroupData.id = 2319; parentId = Some 2011; name = "Mining Barges"; }
    let private marketGroup2320()= {MarketGroupData.id = 2320; parentId = Some 2042; name = "Expedition Frigates"; }
    let private marketGroup2321()= {MarketGroupData.id = 2321; parentId = Some 2001; name = "ORE"; }
    let private marketGroup1633()= {MarketGroupData.id = 1633; parentId = Some 779; name = "Command Bursts"; }
    let private marketGroup2322()= {MarketGroupData.id = 2322; parentId = Some 1338; name = "Engineering Complexes"; }
    let private marketGroup2323()= {MarketGroupData.id = 2323; parentId = Some 2166; name = "Engineering Service Modules"; }
    let private marketGroup2324()= {MarketGroupData.id = 2324; parentId = Some 477; name = "Engineering Complexes"; }
    let private marketGroup2325()= {MarketGroupData.id = 2325; parentId = Some 912; name = "ORE"; }
    let private marketGroup2328()= {MarketGroupData.id = 2328; parentId = Some 2085; name = "ORE"; }
    let private marketGroup2330()= {MarketGroupData.id = 2330; parentId = Some 2006; name = "Special Edition Industrial Ships"; }
    let private marketGroup2331()= {MarketGroupData.id = 2331; parentId = Some 2330; name = "ORE"; }
    let private marketGroup2332()= {MarketGroupData.id = 2332; parentId = Some 2210; name = "Engineering Service Modules"; }
    let private marketGroup2333()= {MarketGroupData.id = 2333; parentId = Some 204; name = "Industrial Command Ships"; }
    let private marketGroup2334()= {MarketGroupData.id = 2334; parentId = Some 2333; name = "ORE"; }
    let private marketGroup2335()= {MarketGroupData.id = 2335; parentId = Some 1382; name = "Industrial Command Ships"; }
    let private marketGroup2336()= {MarketGroupData.id = 2336; parentId = Some 2335; name = "ORE"; }
    let private marketGroup2337()= {MarketGroupData.id = 2337; parentId = Some 2006; name = "Industrial Command Ships"; }
    let private marketGroup2338()= {MarketGroupData.id = 2338; parentId = Some 2337; name = "ORE"; }
    let private marketGroup2339()= {MarketGroupData.id = 2339; parentId = Some 2157; name = "Structure Engineering Rigs"; }
    let private marketGroup2204()= {MarketGroupData.id = 2204; parentId = Some 2203; name = "Structure Resource Processing Rigs"; }
    let private marketGroup2205()= {MarketGroupData.id = 2205; parentId = Some 2203; name = "Structure Combat Rigs"; }
    let private marketGroup2340()= {MarketGroupData.id = 2340; parentId = Some 2203; name = "Structure Engineering Rigs"; }
    let private marketGroup2341()= {MarketGroupData.id = 2341; parentId = Some 2204; name = "Medium Structure Resource Processing Rigs"; }
    let private marketGroup2342()= {MarketGroupData.id = 2342; parentId = Some 2204; name = "Large Structure Resource Processing Rigs"; }
    let private marketGroup2343()= {MarketGroupData.id = 2343; parentId = Some 2204; name = "X-Large Structure Resource Processing Rigs"; }
    let private marketGroup2344()= {MarketGroupData.id = 2344; parentId = Some 2205; name = "Medium Structure Combat Rigs"; }
    let private marketGroup2345()= {MarketGroupData.id = 2345; parentId = Some 2205; name = "Large Structure Combat Rigs"; }
    let private marketGroup2346()= {MarketGroupData.id = 2346; parentId = Some 2205; name = "X-Large Structure Combat Rigs"; }
    let private marketGroup2347()= {MarketGroupData.id = 2347; parentId = Some 2340; name = "Medium Structure Engineering Rigs"; }
    let private marketGroup2348()= {MarketGroupData.id = 2348; parentId = Some 2340; name = "Large Structure Engineering Rigs"; }
    let private marketGroup2349()= {MarketGroupData.id = 2349; parentId = Some 2340; name = "X-Large Structure Engineering Rigs"; }
    let private marketGroup2350()= {MarketGroupData.id = 2350; parentId = Some 1612; name = "Special Edition Destroyers"; }
    let private marketGroup2351()= {MarketGroupData.id = 2351; parentId = Some 140; name = "Defender Launchers"; }
    let private marketGroup2236()= {MarketGroupData.id = 2236; parentId = Some 157; name = "Fighters"; }
    let private marketGroup2202()= {MarketGroupData.id = 2202; parentId = None; name = "Structure Equipment"; }
    let private marketGroup2203()= {MarketGroupData.id = 2203; parentId = None; name = "Structure Modifications"; }
    let private marketGroup2353()= {MarketGroupData.id = 2353; parentId = Some 2307; name = "Caldari"; }
    let private marketGroup2354()= {MarketGroupData.id = 2354; parentId = Some 2307; name = "Gallente"; }
    let private marketGroup2355()= {MarketGroupData.id = 2355; parentId = Some 2307; name = "Minmatar"; }
    let private marketGroup2356()= {MarketGroupData.id = 2356; parentId = Some 2309; name = "Gallente"; }
    let private marketGroup2357()= {MarketGroupData.id = 2357; parentId = Some 2271; name = "Faction Force Auxiliaries"; }
    let private marketGroup2358()= {MarketGroupData.id = 2358; parentId = Some 1922; name = "Skill Trading"; }
    let private marketGroup2307()= {MarketGroupData.id = 2307; parentId = Some 2306; name = "Standard Corvettes"; }
    let private marketGroup2359()= {MarketGroupData.id = 2359; parentId = Some 2306; name = "Faction Corvettes"; }
    let private marketGroup2360()= {MarketGroupData.id = 2360; parentId = Some 2359; name = "Pirate Faction"; }
    let private marketGroup2361()= {MarketGroupData.id = 2361; parentId = Some 2044; name = "Special Covert Ops"; }
    let private marketGroup2362()= {MarketGroupData.id = 2362; parentId = Some 2068; name = "Special Recon Ships"; }
    let private marketGroup2369()= {MarketGroupData.id = 2369; parentId = Some 2064; name = "Strategic Cruisers"; }
    let private marketGroup2370()= {MarketGroupData.id = 2370; parentId = Some 2369; name = "Caldari"; }
    let private marketGroup2371()= {MarketGroupData.id = 2371; parentId = Some 2369; name = "Amarr"; }
    let private marketGroup2372()= {MarketGroupData.id = 2372; parentId = Some 2369; name = "Gallente"; }
    let private marketGroup2373()= {MarketGroupData.id = 2373; parentId = Some 2369; name = "Minmatar"; }
    let private marketGroup2374()= {MarketGroupData.id = 2374; parentId = Some 1970; name = "Standard Carriers"; }
    let private marketGroup1974()= {MarketGroupData.id = 1974; parentId = Some 2374; name = "Amarr"; }
    let private marketGroup1975()= {MarketGroupData.id = 1975; parentId = Some 2374; name = "Caldari"; }
    let private marketGroup1976()= {MarketGroupData.id = 1976; parentId = Some 2374; name = "Gallente"; }
    let private marketGroup1977()= {MarketGroupData.id = 1977; parentId = Some 2374; name = "Minmatar"; }
    let private marketGroup2375()= {MarketGroupData.id = 2375; parentId = Some 1970; name = "Faction Carriers"; }
    let private marketGroup2376()= {MarketGroupData.id = 2376; parentId = Some 2375; name = "Pirate Faction"; }
    let private marketGroup2377()= {MarketGroupData.id = 2377; parentId = Some 1971; name = "Standard Dreadnoughts"; }
    let private marketGroup1981()= {MarketGroupData.id = 1981; parentId = Some 2377; name = "Caldari"; }
    let private marketGroup1982()= {MarketGroupData.id = 1982; parentId = Some 2377; name = "Gallente"; }
    let private marketGroup1983()= {MarketGroupData.id = 1983; parentId = Some 2377; name = "Minmatar"; }
    let private marketGroup1980()= {MarketGroupData.id = 1980; parentId = Some 2377; name = "Amarr"; }
    let private marketGroup2378()= {MarketGroupData.id = 2378; parentId = Some 1971; name = "Faction Dreadnoughts"; }
    let private marketGroup2380()= {MarketGroupData.id = 2380; parentId = Some 2378; name = "Pirate Faction"; }
    let private marketGroup2381()= {MarketGroupData.id = 2381; parentId = Some 1973; name = "Standard Titans"; }
    let private marketGroup1978()= {MarketGroupData.id = 1978; parentId = Some 2381; name = "Amarr"; }
    let private marketGroup1979()= {MarketGroupData.id = 1979; parentId = Some 2381; name = "Gallente"; }
    let private marketGroup2092()= {MarketGroupData.id = 2092; parentId = Some 2381; name = "Caldari"; }
    let private marketGroup2093()= {MarketGroupData.id = 2093; parentId = Some 2381; name = "Minmatar"; }
    let private marketGroup2382()= {MarketGroupData.id = 2382; parentId = Some 1973; name = "Faction Titans"; }
    let private marketGroup2383()= {MarketGroupData.id = 2383; parentId = Some 2382; name = "Pirate Faction"; }
    let private marketGroup2387()= {MarketGroupData.id = 2387; parentId = Some 2315; name = "Amarr"; }
    let private marketGroup2388()= {MarketGroupData.id = 2388; parentId = Some 2315; name = "Caldari"; }
    let private marketGroup2389()= {MarketGroupData.id = 2389; parentId = Some 2315; name = "Gallente"; }
    let private marketGroup2390()= {MarketGroupData.id = 2390; parentId = Some 2315; name = "Minmatar"; }
    let private marketGroup2308()= {MarketGroupData.id = 2308; parentId = Some 2307; name = "Amarr"; }
    let private marketGroup2391()= {MarketGroupData.id = 2391; parentId = Some 2309; name = "Caldari"; }
    let private marketGroup2392()= {MarketGroupData.id = 2392; parentId = Some 2309; name = "Minmatar"; }
    let private marketGroup2393()= {MarketGroupData.id = 2393; parentId = Some 1338; name = "Refineries"; }
    let private marketGroup2327()= {MarketGroupData.id = 2327; parentId = Some 477; name = "Refineries"; }
    let private marketGroup2395()= {MarketGroupData.id = 2395; parentId = Some 1031; name = "Moon Ores"; }
    let private marketGroup2396()= {MarketGroupData.id = 2396; parentId = Some 2395; name = "Ubiquitous Moon Ores"; }
    let private marketGroup2397()= {MarketGroupData.id = 2397; parentId = Some 2395; name = "Common Moon Ores"; }
    let private marketGroup2398()= {MarketGroupData.id = 2398; parentId = Some 2395; name = "Uncommon Moon Ores"; }
    let private marketGroup2400()= {MarketGroupData.id = 2400; parentId = Some 2395; name = "Rare Moon Ores"; }
    let private marketGroup2401()= {MarketGroupData.id = 2401; parentId = Some 2395; name = "Exceptional Moon Ores"; }
    let private marketGroup1849()= {MarketGroupData.id = 1849; parentId = Some 2; name = "Reaction Formulas"; }
    let private marketGroup2402()= {MarketGroupData.id = 2402; parentId = Some 1849; name = "Biochemical Reaction Formulas"; }
    let private marketGroup2403()= {MarketGroupData.id = 2403; parentId = Some 1849; name = "Composite Reaction Formulas"; }
    let private marketGroup2404()= {MarketGroupData.id = 2404; parentId = Some 1849; name = "Polymer Reaction Formulas"; }
    let private marketGroup2171()= {MarketGroupData.id = 2171; parentId = Some 2161; name = "Weapon Disruptors"; }
    let private marketGroup2215()= {MarketGroupData.id = 2215; parentId = Some 2206; name = "Weapon Disruptors"; }
    let private marketGroup2406()= {MarketGroupData.id = 2406; parentId = Some 2109; name = "Special Black Ops"; }
    let private marketGroup2407()= {MarketGroupData.id = 2407; parentId = Some 2161; name = "Structure Burst Projectors"; }
    let private marketGroup2408()= {MarketGroupData.id = 2408; parentId = Some 2206; name = "Structure Burst Projectors"; }
    let private marketGroup2409()= {MarketGroupData.id = 2409; parentId = Some 2236; name = "Structure-based Fighters"; }
    let private marketGroup2410()= {MarketGroupData.id = 2410; parentId = Some 2236; name = "Carrier-based Fighters"; }
    let private marketGroup840()= {MarketGroupData.id = 840; parentId = Some 2410; name = "Light Fighters"; }
    let private marketGroup1310()= {MarketGroupData.id = 1310; parentId = Some 2410; name = "Heavy Fighters"; }
    let private marketGroup2239()= {MarketGroupData.id = 2239; parentId = Some 2410; name = "Support Fighters"; }
    let private marketGroup2411()= {MarketGroupData.id = 2411; parentId = Some 2409; name = "Standup Light Fighters"; }
    let private marketGroup2412()= {MarketGroupData.id = 2412; parentId = Some 2409; name = "Standup Heavy Fighters"; }
    let private marketGroup2413()= {MarketGroupData.id = 2413; parentId = Some 2409; name = "Standup Support Fighters"; }
    let private marketGroup2224()= {MarketGroupData.id = 2224; parentId = Some 2208; name = "Capacitor Batteries"; }
    let private marketGroup2220()= {MarketGroupData.id = 2220; parentId = Some 2208; name = "Capacitor Power Relays"; }
    let private marketGroup2414()= {MarketGroupData.id = 2414; parentId = Some 2208; name = "Armor Reinforcers"; }
    let private marketGroup2415()= {MarketGroupData.id = 2415; parentId = Some 2163; name = "Armor Reinforcers"; }
    let private marketGroup2416()= {MarketGroupData.id = 2416; parentId = Some 1368; name = "Flag Cruisers"; }
    let private marketGroup2417()= {MarketGroupData.id = 2417; parentId = Some 2416; name = "CONCORD"; }
    let private marketGroup2418()= {MarketGroupData.id = 2418; parentId = Some 2064; name = "Flag Cruisers"; }
    let private marketGroup2419()= {MarketGroupData.id = 2419; parentId = Some 2418; name = "CONCORD"; }
    let private marketGroup2420()= {MarketGroupData.id = 2420; parentId = Some 1960; name = "Special Battleships"; }
    let private marketGroup2421()= {MarketGroupData.id = 2421; parentId = Some 2420; name = "Special Battleships"; }
    let marketgroup = 
        function
        | 2 -> marketGroup2() |> Some
        | 4 -> marketGroup4() |> Some
        | 9 -> marketGroup9() |> Some
        | 10 -> marketGroup10() |> Some
        | 11 -> marketGroup11() |> Some
        | 14 -> marketGroup14() |> Some
        | 19 -> marketGroup19() |> Some
        | 24 -> marketGroup24() |> Some
        | 27 -> marketGroup27() |> Some
        | 52 -> marketGroup52() |> Some
        | 54 -> marketGroup54() |> Some
        | 86 -> marketGroup86() |> Some
        | 87 -> marketGroup87() |> Some
        | 88 -> marketGroup88() |> Some
        | 99 -> marketGroup99() |> Some
        | 100 -> marketGroup100() |> Some
        | 101 -> marketGroup101() |> Some
        | 114 -> marketGroup114() |> Some
        | 115 -> marketGroup115() |> Some
        | 117 -> marketGroup117() |> Some
        | 118 -> marketGroup118() |> Some
        | 128 -> marketGroup128() |> Some
        | 132 -> marketGroup132() |> Some
        | 134 -> marketGroup134() |> Some
        | 140 -> marketGroup140() |> Some
        | 141 -> marketGroup141() |> Some
        | 150 -> marketGroup150() |> Some
        | 157 -> marketGroup157() |> Some
        | 159 -> marketGroup159() |> Some
        | 204 -> marketGroup204() |> Some
        | 205 -> marketGroup205() |> Some
        | 206 -> marketGroup206() |> Some
        | 207 -> marketGroup207() |> Some
        | 208 -> marketGroup208() |> Some
        | 209 -> marketGroup209() |> Some
        | 210 -> marketGroup210() |> Some
        | 214 -> marketGroup214() |> Some
        | 252 -> marketGroup252() |> Some
        | 286 -> marketGroup286() |> Some
        | 287 -> marketGroup287() |> Some
        | 288 -> marketGroup288() |> Some
        | 299 -> marketGroup299() |> Some
        | 300 -> marketGroup300() |> Some
        | 301 -> marketGroup301() |> Some
        | 314 -> marketGroup314() |> Some
        | 387 -> marketGroup387() |> Some
        | 391 -> marketGroup391() |> Some
        | 408 -> marketGroup408() |> Some
        | 414 -> marketGroup414() |> Some
        | 419 -> marketGroup419() |> Some
        | 442 -> marketGroup442() |> Some
        | 453 -> marketGroup453() |> Some
        | 458 -> marketGroup458() |> Some
        | 475 -> marketGroup475() |> Some
        | 496 -> marketGroup496() |> Some
        | 531 -> marketGroup531() |> Some
        | 532 -> marketGroup532() |> Some
        | 533 -> marketGroup533() |> Some
        | 537 -> marketGroup537() |> Some
        | 538 -> marketGroup538() |> Some
        | 551 -> marketGroup551() |> Some
        | 552 -> marketGroup552() |> Some
        | 554 -> marketGroup554() |> Some
        | 555 -> marketGroup555() |> Some
        | 556 -> marketGroup556() |> Some
        | 557 -> marketGroup557() |> Some
        | 558 -> marketGroup558() |> Some
        | 559 -> marketGroup559() |> Some
        | 560 -> marketGroup560() |> Some
        | 580 -> marketGroup580() |> Some
        | 581 -> marketGroup581() |> Some
        | 582 -> marketGroup582() |> Some
        | 588 -> marketGroup588() |> Some
        | 614 -> marketGroup614() |> Some
        | 616 -> marketGroup616() |> Some
        | 634 -> marketGroup634() |> Some
        | 655 -> marketGroup655() |> Some
        | 656 -> marketGroup656() |> Some
        | 657 -> marketGroup657() |> Some
        | 662 -> marketGroup662() |> Some
        | 663 -> marketGroup663() |> Some
        | 664 -> marketGroup664() |> Some
        | 668 -> marketGroup668() |> Some
        | 677 -> marketGroup677() |> Some
        | 681 -> marketGroup681() |> Some
        | 685 -> marketGroup685() |> Some
        | 739 -> marketGroup739() |> Some
        | 751 -> marketGroup751() |> Some
        | 752 -> marketGroup752() |> Some
        | 782 -> marketGroup782() |> Some
        | 787 -> marketGroup787() |> Some
        | 845 -> marketGroup845() |> Some
        | 846 -> marketGroup846() |> Some
        | 847 -> marketGroup847() |> Some
        | 848 -> marketGroup848() |> Some
        | 849 -> marketGroup849() |> Some
        | 850 -> marketGroup850() |> Some
        | 852 -> marketGroup852() |> Some
        | 853 -> marketGroup853() |> Some
        | 878 -> marketGroup878() |> Some
        | 879 -> marketGroup879() |> Some
        | 880 -> marketGroup880() |> Some
        | 881 -> marketGroup881() |> Some
        | 882 -> marketGroup882() |> Some
        | 943 -> marketGroup943() |> Some
        | 968 -> marketGroup968() |> Some
        | 986 -> marketGroup986() |> Some
        | 1041 -> marketGroup1041() |> Some
        | 1018 -> marketGroup1018() |> Some
        | 990 -> marketGroup990() |> Some
        | 851 -> marketGroup851() |> Some
        | 994 -> marketGroup994() |> Some
        | 1031 -> marketGroup1031() |> Some
        | 1034 -> marketGroup1034() |> Some
        | 1035 -> marketGroup1035() |> Some
        | 1021 -> marketGroup1021() |> Some
        | 1111 -> marketGroup1111() |> Some
        | 505 -> marketGroup505() |> Some
        | 135 -> marketGroup135() |> Some
        | 120 -> marketGroup120() |> Some
        | 944 -> marketGroup944() |> Some
        | 956 -> marketGroup956() |> Some
        | 957 -> marketGroup957() |> Some
        | 958 -> marketGroup958() |> Some
        | 960 -> marketGroup960() |> Some
        | 961 -> marketGroup961() |> Some
        | 962 -> marketGroup962() |> Some
        | 963 -> marketGroup963() |> Some
        | 964 -> marketGroup964() |> Some
        | 965 -> marketGroup965() |> Some
        | 979 -> marketGroup979() |> Some
        | 945 -> marketGroup945() |> Some
        | 946 -> marketGroup946() |> Some
        | 948 -> marketGroup948() |> Some
        | 949 -> marketGroup949() |> Some
        | 950 -> marketGroup950() |> Some
        | 951 -> marketGroup951() |> Some
        | 952 -> marketGroup952() |> Some
        | 954 -> marketGroup954() |> Some
        | 477 -> marketGroup477() |> Some
        | 1276 -> marketGroup1276() |> Some
        | 953 -> marketGroup953() |> Some
        | 1320 -> marketGroup1320() |> Some
        | 5 -> marketGroup5() |> Some
        | 432 -> marketGroup432() |> Some
        | 1065 -> marketGroup1065() |> Some
        | 420 -> marketGroup420() |> Some
        | 399 -> marketGroup399() |> Some
        | 6 -> marketGroup6() |> Some
        | 1070 -> marketGroup1070() |> Some
        | 824 -> marketGroup824() |> Some
        | 448 -> marketGroup448() |> Some
        | 437 -> marketGroup437() |> Some
        | 464 -> marketGroup464() |> Some
        | 469 -> marketGroup469() |> Some
        | 822 -> marketGroup822() |> Some
        | 7 -> marketGroup7() |> Some
        | 1080 -> marketGroup1080() |> Some
        | 1075 -> marketGroup1075() |> Some
        | 817 -> marketGroup817() |> Some
        | 1089 -> marketGroup1089() |> Some
        | 812 -> marketGroup812() |> Some
        | 761 -> marketGroup761() |> Some
        | 1047 -> marketGroup1047() |> Some
        | 766 -> marketGroup766() |> Some
        | 8 -> marketGroup8() |> Some
        | 629 -> marketGroup629() |> Some
        | 1332 -> marketGroup1332() |> Some
        | 661 -> marketGroup661() |> Some
        | 1396 -> marketGroup1396() |> Some
        | 1397 -> marketGroup1397() |> Some
        | 1402 -> marketGroup1402() |> Some
        | 1407 -> marketGroup1407() |> Some
        | 883 -> marketGroup883() |> Some
        | 1045 -> marketGroup1045() |> Some
        | 1338 -> marketGroup1338() |> Some
        | 1361 -> marketGroup1361() |> Some
        | 1362 -> marketGroup1362() |> Some
        | 1364 -> marketGroup1364() |> Some
        | 1367 -> marketGroup1367() |> Some
        | 1368 -> marketGroup1368() |> Some
        | 1138 -> marketGroup1138() |> Some
        | 1369 -> marketGroup1369() |> Some
        | 1372 -> marketGroup1372() |> Some
        | 1373 -> marketGroup1373() |> Some
        | 823 -> marketGroup823() |> Some
        | 1374 -> marketGroup1374() |> Some
        | 1375 -> marketGroup1375() |> Some
        | 1376 -> marketGroup1376() |> Some
        | 1377 -> marketGroup1377() |> Some
        | 1378 -> marketGroup1378() |> Some
        | 1381 -> marketGroup1381() |> Some
        | 1382 -> marketGroup1382() |> Some
        | 1385 -> marketGroup1385() |> Some
        | 1384 -> marketGroup1384() |> Some
        | 1316 -> marketGroup1316() |> Some
        | 1285 -> marketGroup1285() |> Some
        | 1272 -> marketGroup1272() |> Some
        | 955 -> marketGroup955() |> Some
        | 1112 -> marketGroup1112() |> Some
        | 1322 -> marketGroup1322() |> Some
        | 350001 -> marketGroup350001() |> Some
        | 353562 -> marketGroup353562() |> Some
        | 353566 -> marketGroup353566() |> Some
        | 355449 -> marketGroup355449() |> Some
        | 1427 -> marketGroup1427() |> Some
        | 1469 -> marketGroup1469() |> Some
        | 1470 -> marketGroup1470() |> Some
        | 1471 -> marketGroup1471() |> Some
        | 1472 -> marketGroup1472() |> Some
        | 1473 -> marketGroup1473() |> Some
        | 1474 -> marketGroup1474() |> Some
        | 1475 -> marketGroup1475() |> Some
        | 1476 -> marketGroup1476() |> Some
        | 1477 -> marketGroup1477() |> Some
        | 1478 -> marketGroup1478() |> Some
        | 1479 -> marketGroup1479() |> Some
        | 1520 -> marketGroup1520() |> Some
        | 357 -> marketGroup357() |> Some
        | 800 -> marketGroup800() |> Some
        | 1522 -> marketGroup1522() |> Some
        | 211 -> marketGroup211() |> Some
        | 1530 -> marketGroup1530() |> Some
        | 480 -> marketGroup480() |> Some
        | 1545 -> marketGroup1545() |> Some
        | 1546 -> marketGroup1546() |> Some
        | 1566 -> marketGroup1566() |> Some
        | 1578 -> marketGroup1578() |> Some
        | 1097 -> marketGroup1097() |> Some
        | 1591 -> marketGroup1591() |> Some
        | 1610 -> marketGroup1610() |> Some
        | 1612 -> marketGroup1612() |> Some
        | 1625 -> marketGroup1625() |> Some
        | 1626 -> marketGroup1626() |> Some
        | 1627 -> marketGroup1627() |> Some
        | 1122 -> marketGroup1122() |> Some
        | 1123 -> marketGroup1123() |> Some
        | 1124 -> marketGroup1124() |> Some
        | 1125 -> marketGroup1125() |> Some
        | 1126 -> marketGroup1126() |> Some
        | 1127 -> marketGroup1127() |> Some
        | 1128 -> marketGroup1128() |> Some
        | 1129 -> marketGroup1129() |> Some
        | 1130 -> marketGroup1130() |> Some
        | 1131 -> marketGroup1131() |> Some
        | 1132 -> marketGroup1132() |> Some
        | 1133 -> marketGroup1133() |> Some
        | 1134 -> marketGroup1134() |> Some
        | 1135 -> marketGroup1135() |> Some
        | 1136 -> marketGroup1136() |> Some
        | 1137 -> marketGroup1137() |> Some
        | 357120 -> marketGroup357120() |> Some
        | 779 -> marketGroup779() |> Some
        | 379 -> marketGroup379() |> Some
        | 354461 -> marketGroup354461() |> Some
        | 354460 -> marketGroup354460() |> Some
        | 363304 -> marketGroup363304() |> Some
        | 363305 -> marketGroup363305() |> Some
        | 363306 -> marketGroup363306() |> Some
        | 363440 -> marketGroup363440() |> Some
        | 363441 -> marketGroup363441() |> Some
        | 363442 -> marketGroup363442() |> Some
        | 363448 -> marketGroup363448() |> Some
        | 363449 -> marketGroup363449() |> Some
        | 363452 -> marketGroup363452() |> Some
        | 363456 -> marketGroup363456() |> Some
        | 363457 -> marketGroup363457() |> Some
        | 363464 -> marketGroup363464() |> Some
        | 363465 -> marketGroup363465() |> Some
        | 363466 -> marketGroup363466() |> Some
        | 363467 -> marketGroup363467() |> Some
        | 363468 -> marketGroup363468() |> Some
        | 363469 -> marketGroup363469() |> Some
        | 363470 -> marketGroup363470() |> Some
        | 363471 -> marketGroup363471() |> Some
        | 363472 -> marketGroup363472() |> Some
        | 356971 -> marketGroup356971() |> Some
        | 354331 -> marketGroup354331() |> Some
        | 354332 -> marketGroup354332() |> Some
        | 354333 -> marketGroup354333() |> Some
        | 354335 -> marketGroup354335() |> Some
        | 354336 -> marketGroup354336() |> Some
        | 354337 -> marketGroup354337() |> Some
        | 354338 -> marketGroup354338() |> Some
        | 354339 -> marketGroup354339() |> Some
        | 354340 -> marketGroup354340() |> Some
        | 354343 -> marketGroup354343() |> Some
        | 354344 -> marketGroup354344() |> Some
        | 354345 -> marketGroup354345() |> Some
        | 354347 -> marketGroup354347() |> Some
        | 354348 -> marketGroup354348() |> Some
        | 354350 -> marketGroup354350() |> Some
        | 354352 -> marketGroup354352() |> Some
        | 354353 -> marketGroup354353() |> Some
        | 354354 -> marketGroup354354() |> Some
        | 356916 -> marketGroup356916() |> Some
        | 354364 -> marketGroup354364() |> Some
        | 354366 -> marketGroup354366() |> Some
        | 354367 -> marketGroup354367() |> Some
        | 356972 -> marketGroup356972() |> Some
        | 354376 -> marketGroup354376() |> Some
        | 354377 -> marketGroup354377() |> Some
        | 354378 -> marketGroup354378() |> Some
        | 354380 -> marketGroup354380() |> Some
        | 354381 -> marketGroup354381() |> Some
        | 354382 -> marketGroup354382() |> Some
        | 354384 -> marketGroup354384() |> Some
        | 354385 -> marketGroup354385() |> Some
        | 354386 -> marketGroup354386() |> Some
        | 356435 -> marketGroup356435() |> Some
        | 354388 -> marketGroup354388() |> Some
        | 354389 -> marketGroup354389() |> Some
        | 354390 -> marketGroup354390() |> Some
        | 356964 -> marketGroup356964() |> Some
        | 356965 -> marketGroup356965() |> Some
        | 356960 -> marketGroup356960() |> Some
        | 356961 -> marketGroup356961() |> Some
        | 356962 -> marketGroup356962() |> Some
        | 354403 -> marketGroup354403() |> Some
        | 354404 -> marketGroup354404() |> Some
        | 354405 -> marketGroup354405() |> Some
        | 356968 -> marketGroup356968() |> Some
        | 356969 -> marketGroup356969() |> Some
        | 354410 -> marketGroup354410() |> Some
        | 354411 -> marketGroup354411() |> Some
        | 354412 -> marketGroup354412() |> Some
        | 356973 -> marketGroup356973() |> Some
        | 354414 -> marketGroup354414() |> Some
        | 354415 -> marketGroup354415() |> Some
        | 354416 -> marketGroup354416() |> Some
        | 356977 -> marketGroup356977() |> Some
        | 356978 -> marketGroup356978() |> Some
        | 356979 -> marketGroup356979() |> Some
        | 356980 -> marketGroup356980() |> Some
        | 356981 -> marketGroup356981() |> Some
        | 354425 -> marketGroup354425() |> Some
        | 354427 -> marketGroup354427() |> Some
        | 354429 -> marketGroup354429() |> Some
        | 354430 -> marketGroup354430() |> Some
        | 354431 -> marketGroup354431() |> Some
        | 354434 -> marketGroup354434() |> Some
        | 355461 -> marketGroup355461() |> Some
        | 355462 -> marketGroup355462() |> Some
        | 355463 -> marketGroup355463() |> Some
        | 355457 -> marketGroup355457() |> Some
        | 355465 -> marketGroup355465() |> Some
        | 355466 -> marketGroup355466() |> Some
        | 355467 -> marketGroup355467() |> Some
        | 354444 -> marketGroup354444() |> Some
        | 355469 -> marketGroup355469() |> Some
        | 354448 -> marketGroup354448() |> Some
        | 354453 -> marketGroup354453() |> Some
        | 354454 -> marketGroup354454() |> Some
        | 354455 -> marketGroup354455() |> Some
        | 354458 -> marketGroup354458() |> Some
        | 354459 -> marketGroup354459() |> Some
        | 356976 -> marketGroup356976() |> Some
        | 354469 -> marketGroup354469() |> Some
        | 354471 -> marketGroup354471() |> Some
        | 354478 -> marketGroup354478() |> Some
        | 354483 -> marketGroup354483() |> Some
        | 354488 -> marketGroup354488() |> Some
        | 354489 -> marketGroup354489() |> Some
        | 354490 -> marketGroup354490() |> Some
        | 354491 -> marketGroup354491() |> Some
        | 355189 -> marketGroup355189() |> Some
        | 355193 -> marketGroup355193() |> Some
        | 355187 -> marketGroup355187() |> Some
        | 356575 -> marketGroup356575() |> Some
        | 356576 -> marketGroup356576() |> Some
        | 355460 -> marketGroup355460() |> Some
        | 356580 -> marketGroup356580() |> Some
        | 356583 -> marketGroup356583() |> Some
        | 354542 -> marketGroup354542() |> Some
        | 354543 -> marketGroup354543() |> Some
        | 355572 -> marketGroup355572() |> Some
        | 356597 -> marketGroup356597() |> Some
        | 355188 -> marketGroup355188() |> Some
        | 354565 -> marketGroup354565() |> Some
        | 354566 -> marketGroup354566() |> Some
        | 354567 -> marketGroup354567() |> Some
        | 355458 -> marketGroup355458() |> Some
        | 355459 -> marketGroup355459() |> Some
        | 353557 -> marketGroup353557() |> Some
        | 353574 -> marketGroup353574() |> Some
        | 353575 -> marketGroup353575() |> Some
        | 353576 -> marketGroup353576() |> Some
        | 353581 -> marketGroup353581() |> Some
        | 353582 -> marketGroup353582() |> Some
        | 353583 -> marketGroup353583() |> Some
        | 353584 -> marketGroup353584() |> Some
        | 353585 -> marketGroup353585() |> Some
        | 353586 -> marketGroup353586() |> Some
        | 353587 -> marketGroup353587() |> Some
        | 353588 -> marketGroup353588() |> Some
        | 353589 -> marketGroup353589() |> Some
        | 353590 -> marketGroup353590() |> Some
        | 353591 -> marketGroup353591() |> Some
        | 353592 -> marketGroup353592() |> Some
        | 354618 -> marketGroup354618() |> Some
        | 354619 -> marketGroup354619() |> Some
        | 354620 -> marketGroup354620() |> Some
        | 353605 -> marketGroup353605() |> Some
        | 353608 -> marketGroup353608() |> Some
        | 355468 -> marketGroup355468() |> Some
        | 353613 -> marketGroup353613() |> Some
        | 355464 -> marketGroup355464() |> Some
        | 356963 -> marketGroup356963() |> Some
        | 356582 -> marketGroup356582() |> Some
        | 355181 -> marketGroup355181() |> Some
        | 354671 -> marketGroup354671() |> Some
        | 353651 -> marketGroup353651() |> Some
        | 353652 -> marketGroup353652() |> Some
        | 353653 -> marketGroup353653() |> Some
        | 356970 -> marketGroup356970() |> Some
        | 357121 -> marketGroup357121() |> Some
        | 353657 -> marketGroup353657() |> Some
        | 355194 -> marketGroup355194() |> Some
        | 355195 -> marketGroup355195() |> Some
        | 355196 -> marketGroup355196() |> Some
        | 353663 -> marketGroup353663() |> Some
        | 353664 -> marketGroup353664() |> Some
        | 354690 -> marketGroup354690() |> Some
        | 354691 -> marketGroup354691() |> Some
        | 354692 -> marketGroup354692() |> Some
        | 353669 -> marketGroup353669() |> Some
        | 353671 -> marketGroup353671() |> Some
        | 354696 -> marketGroup354696() |> Some
        | 354697 -> marketGroup354697() |> Some
        | 354698 -> marketGroup354698() |> Some
        | 353676 -> marketGroup353676() |> Some
        | 353681 -> marketGroup353681() |> Some
        | 353684 -> marketGroup353684() |> Some
        | 353706 -> marketGroup353706() |> Some
        | 353707 -> marketGroup353707() |> Some
        | 353710 -> marketGroup353710() |> Some
        | 353711 -> marketGroup353711() |> Some
        | 353713 -> marketGroup353713() |> Some
        | 353715 -> marketGroup353715() |> Some
        | 353716 -> marketGroup353716() |> Some
        | 356434 -> marketGroup356434() |> Some
        | 356436 -> marketGroup356436() |> Some
        | 363475 -> marketGroup363475() |> Some
        | 363476 -> marketGroup363476() |> Some
        | 1659 -> marketGroup1659() |> Some
        | 540 -> marketGroup540() |> Some
        | 1665 -> marketGroup1665() |> Some
        | 1666 -> marketGroup1666() |> Some
        | 1667 -> marketGroup1667() |> Some
        | 1668 -> marketGroup1668() |> Some
        | 1670 -> marketGroup1670() |> Some
        | 133 -> marketGroup133() |> Some
        | 1678 -> marketGroup1678() |> Some
        | 1679 -> marketGroup1679() |> Some
        | 1680 -> marketGroup1680() |> Some
        | 1681 -> marketGroup1681() |> Some
        | 535 -> marketGroup535() |> Some
        | 1682 -> marketGroup1682() |> Some
        | 1683 -> marketGroup1683() |> Some
        | 1684 -> marketGroup1684() |> Some
        | 1685 -> marketGroup1685() |> Some
        | 541 -> marketGroup541() |> Some
        | 1686 -> marketGroup1686() |> Some
        | 550 -> marketGroup550() |> Some
        | 1688 -> marketGroup1688() |> Some
        | 1689 -> marketGroup1689() |> Some
        | 1690 -> marketGroup1690() |> Some
        | 1691 -> marketGroup1691() |> Some
        | 553 -> marketGroup553() |> Some
        | 1692 -> marketGroup1692() |> Some
        | 1693 -> marketGroup1693() |> Some
        | 1694 -> marketGroup1694() |> Some
        | 1695 -> marketGroup1695() |> Some
        | 1696 -> marketGroup1696() |> Some
        | 363791 -> marketGroup363791() |> Some
        | 363792 -> marketGroup363792() |> Some
        | 363793 -> marketGroup363793() |> Some
        | 364044 -> marketGroup364044() |> Some
        | 364045 -> marketGroup364045() |> Some
        | 364046 -> marketGroup364046() |> Some
        | 364047 -> marketGroup364047() |> Some
        | 364048 -> marketGroup364048() |> Some
        | 364049 -> marketGroup364049() |> Some
        | 363790 -> marketGroup363790() |> Some
        | 354686 -> marketGroup354686() |> Some
        | 353571 -> marketGroup353571() |> Some
        | 353570 -> marketGroup353570() |> Some
        | 353569 -> marketGroup353569() |> Some
        | 354616 -> marketGroup354616() |> Some
        | 354693 -> marketGroup354693() |> Some
        | 353572 -> marketGroup353572() |> Some
        | 353573 -> marketGroup353573() |> Some
        | 356433 -> marketGroup356433() |> Some
        | 353568 -> marketGroup353568() |> Some
        | 354563 -> marketGroup354563() |> Some
        | 353600 -> marketGroup353600() |> Some
        | 353601 -> marketGroup353601() |> Some
        | 353602 -> marketGroup353602() |> Some
        | 353604 -> marketGroup353604() |> Some
        | 364051 -> marketGroup364051() |> Some
        | 364052 -> marketGroup364052() |> Some
        | 364053 -> marketGroup364053() |> Some
        | 364054 -> marketGroup364054() |> Some
        | 364055 -> marketGroup364055() |> Some
        | 364056 -> marketGroup364056() |> Some
        | 364057 -> marketGroup364057() |> Some
        | 364058 -> marketGroup364058() |> Some
        | 1700 -> marketGroup1700() |> Some
        | 364491 -> marketGroup364491() |> Some
        | 364492 -> marketGroup364492() |> Some
        | 364493 -> marketGroup364493() |> Some
        | 364494 -> marketGroup364494() |> Some
        | 364760 -> marketGroup364760() |> Some
        | 364765 -> marketGroup364765() |> Some
        | 364768 -> marketGroup364768() |> Some
        | 364885 -> marketGroup364885() |> Some
        | 364886 -> marketGroup364886() |> Some
        | 364887 -> marketGroup364887() |> Some
        | 364888 -> marketGroup364888() |> Some
        | 364889 -> marketGroup364889() |> Some
        | 364890 -> marketGroup364890() |> Some
        | 364891 -> marketGroup364891() |> Some
        | 364892 -> marketGroup364892() |> Some
        | 364893 -> marketGroup364893() |> Some
        | 364894 -> marketGroup364894() |> Some
        | 364895 -> marketGroup364895() |> Some
        | 364896 -> marketGroup364896() |> Some
        | 1703 -> marketGroup1703() |> Some
        | 1711 -> marketGroup1711() |> Some
        | 1710 -> marketGroup1710() |> Some
        | 1713 -> marketGroup1713() |> Some
        | 1708 -> marketGroup1708() |> Some
        | 365244 -> marketGroup365244() |> Some
        | 365245 -> marketGroup365245() |> Some
        | 365246 -> marketGroup365246() |> Some
        | 354423 -> marketGroup354423() |> Some
        | 365247 -> marketGroup365247() |> Some
        | 354424 -> marketGroup354424() |> Some
        | 365248 -> marketGroup365248() |> Some
        | 354432 -> marketGroup354432() |> Some
        | 365249 -> marketGroup365249() |> Some
        | 355590 -> marketGroup355590() |> Some
        | 365250 -> marketGroup365250() |> Some
        | 365251 -> marketGroup365251() |> Some
        | 354433 -> marketGroup354433() |> Some
        | 365272 -> marketGroup365272() |> Some
        | 365274 -> marketGroup365274() |> Some
        | 365276 -> marketGroup365276() |> Some
        | 365277 -> marketGroup365277() |> Some
        | 365278 -> marketGroup365278() |> Some
        | 365279 -> marketGroup365279() |> Some
        | 365280 -> marketGroup365280() |> Some
        | 365282 -> marketGroup365282() |> Some
        | 1761 -> marketGroup1761() |> Some
        | 1762 -> marketGroup1762() |> Some
        | 1763 -> marketGroup1763() |> Some
        | 1764 -> marketGroup1764() |> Some
        | 365496 -> marketGroup365496() |> Some
        | 353708 -> marketGroup353708() |> Some
        | 365497 -> marketGroup365497() |> Some
        | 365001 -> marketGroup365001() |> Some
        | 1815 -> marketGroup1815() |> Some
        | 1794 -> marketGroup1794() |> Some
        | 1796 -> marketGroup1796() |> Some
        | 1795 -> marketGroup1795() |> Some
        | 1779 -> marketGroup1779() |> Some
        | 1780 -> marketGroup1780() |> Some
        | 1781 -> marketGroup1781() |> Some
        | 356579 -> marketGroup356579() |> Some
        | 356581 -> marketGroup356581() |> Some
        | 356584 -> marketGroup356584() |> Some
        | 365765 -> marketGroup365765() |> Some
        | 365766 -> marketGroup365766() |> Some
        | 365767 -> marketGroup365767() |> Some
        | 365768 -> marketGroup365768() |> Some
        | 365769 -> marketGroup365769() |> Some
        | 365770 -> marketGroup365770() |> Some
        | 365771 -> marketGroup365771() |> Some
        | 365772 -> marketGroup365772() |> Some
        | 365949 -> marketGroup365949() |> Some
        | 365950 -> marketGroup365950() |> Some
        | 365951 -> marketGroup365951() |> Some
        | 366021 -> marketGroup366021() |> Some
        | 366111 -> marketGroup366111() |> Some
        | 366112 -> marketGroup366112() |> Some
        | 366113 -> marketGroup366113() |> Some
        | 366114 -> marketGroup366114() |> Some
        | 366173 -> marketGroup366173() |> Some
        | 366179 -> marketGroup366179() |> Some
        | 366175 -> marketGroup366175() |> Some
        | 366177 -> marketGroup366177() |> Some
        | 366174 -> marketGroup366174() |> Some
        | 366178 -> marketGroup366178() |> Some
        | 366180 -> marketGroup366180() |> Some
        | 366181 -> marketGroup366181() |> Some
        | 366182 -> marketGroup366182() |> Some
        | 366185 -> marketGroup366185() |> Some
        | 366189 -> marketGroup366189() |> Some
        | 366186 -> marketGroup366186() |> Some
        | 366190 -> marketGroup366190() |> Some
        | 366191 -> marketGroup366191() |> Some
        | 366193 -> marketGroup366193() |> Some
        | 366194 -> marketGroup366194() |> Some
        | 366197 -> marketGroup366197() |> Some
        | 366198 -> marketGroup366198() |> Some
        | 366199 -> marketGroup366199() |> Some
        | 366200 -> marketGroup366200() |> Some
        | 366201 -> marketGroup366201() |> Some
        | 366202 -> marketGroup366202() |> Some
        | 366203 -> marketGroup366203() |> Some
        | 366204 -> marketGroup366204() |> Some
        | 366205 -> marketGroup366205() |> Some
        | 366206 -> marketGroup366206() |> Some
        | 366207 -> marketGroup366207() |> Some
        | 366208 -> marketGroup366208() |> Some
        | 366209 -> marketGroup366209() |> Some
        | 366210 -> marketGroup366210() |> Some
        | 366211 -> marketGroup366211() |> Some
        | 366212 -> marketGroup366212() |> Some
        | 366213 -> marketGroup366213() |> Some
        | 366214 -> marketGroup366214() |> Some
        | 366215 -> marketGroup366215() |> Some
        | 366216 -> marketGroup366216() |> Some
        | 366219 -> marketGroup366219() |> Some
        | 366220 -> marketGroup366220() |> Some
        | 366221 -> marketGroup366221() |> Some
        | 366222 -> marketGroup366222() |> Some
        | 366223 -> marketGroup366223() |> Some
        | 366224 -> marketGroup366224() |> Some
        | 366253 -> marketGroup366253() |> Some
        | 366254 -> marketGroup366254() |> Some
        | 366255 -> marketGroup366255() |> Some
        | 366257 -> marketGroup366257() |> Some
        | 366258 -> marketGroup366258() |> Some
        | 366259 -> marketGroup366259() |> Some
        | 366260 -> marketGroup366260() |> Some
        | 366261 -> marketGroup366261() |> Some
        | 366262 -> marketGroup366262() |> Some
        | 366263 -> marketGroup366263() |> Some
        | 366264 -> marketGroup366264() |> Some
        | 366265 -> marketGroup366265() |> Some
        | 366266 -> marketGroup366266() |> Some
        | 366267 -> marketGroup366267() |> Some
        | 366268 -> marketGroup366268() |> Some
        | 366269 -> marketGroup366269() |> Some
        | 366271 -> marketGroup366271() |> Some
        | 366272 -> marketGroup366272() |> Some
        | 366273 -> marketGroup366273() |> Some
        | 366274 -> marketGroup366274() |> Some
        | 366275 -> marketGroup366275() |> Some
        | 366276 -> marketGroup366276() |> Some
        | 366277 -> marketGroup366277() |> Some
        | 366278 -> marketGroup366278() |> Some
        | 366279 -> marketGroup366279() |> Some
        | 366280 -> marketGroup366280() |> Some
        | 366281 -> marketGroup366281() |> Some
        | 366282 -> marketGroup366282() |> Some
        | 366283 -> marketGroup366283() |> Some
        | 366284 -> marketGroup366284() |> Some
        | 366285 -> marketGroup366285() |> Some
        | 366286 -> marketGroup366286() |> Some
        | 366287 -> marketGroup366287() |> Some
        | 366288 -> marketGroup366288() |> Some
        | 366350 -> marketGroup366350() |> Some
        | 366351 -> marketGroup366351() |> Some
        | 366352 -> marketGroup366352() |> Some
        | 365898 -> marketGroup365898() |> Some
        | 365899 -> marketGroup365899() |> Some
        | 365900 -> marketGroup365900() |> Some
        | 365901 -> marketGroup365901() |> Some
        | 365995 -> marketGroup365995() |> Some
        | 365996 -> marketGroup365996() |> Some
        | 365997 -> marketGroup365997() |> Some
        | 365998 -> marketGroup365998() |> Some
        | 365999 -> marketGroup365999() |> Some
        | 366570 -> marketGroup366570() |> Some
        | 366571 -> marketGroup366571() |> Some
        | 366572 -> marketGroup366572() |> Some
        | 366573 -> marketGroup366573() |> Some
        | 366574 -> marketGroup366574() |> Some
        | 366575 -> marketGroup366575() |> Some
        | 366576 -> marketGroup366576() |> Some
        | 366577 -> marketGroup366577() |> Some
        | 406 -> marketGroup406() |> Some
        | 1841 -> marketGroup1841() |> Some
        | 1534 -> marketGroup1534() |> Some
        | 404 -> marketGroup404() |> Some
        | 366741 -> marketGroup366741() |> Some
        | 366742 -> marketGroup366742() |> Some
        | 366743 -> marketGroup366743() |> Some
        | 366744 -> marketGroup366744() |> Some
        | 366752 -> marketGroup366752() |> Some
        | 366753 -> marketGroup366753() |> Some
        | 366754 -> marketGroup366754() |> Some
        | 366755 -> marketGroup366755() |> Some
        | 1850 -> marketGroup1850() |> Some
        | 1851 -> marketGroup1851() |> Some
        | 1852 -> marketGroup1852() |> Some
        | 1853 -> marketGroup1853() |> Some
        | 1854 -> marketGroup1854() |> Some
        | 1033 -> marketGroup1033() |> Some
        | 1855 -> marketGroup1855() |> Some
        | 1856 -> marketGroup1856() |> Some
        | 1857 -> marketGroup1857() |> Some
        | 1858 -> marketGroup1858() |> Some
        | 1859 -> marketGroup1859() |> Some
        | 1032 -> marketGroup1032() |> Some
        | 1860 -> marketGroup1860() |> Some
        | 501 -> marketGroup501() |> Some
        | 500 -> marketGroup500() |> Some
        | 499 -> marketGroup499() |> Some
        | 1333 -> marketGroup1333() |> Some
        | 1334 -> marketGroup1334() |> Some
        | 1335 -> marketGroup1335() |> Some
        | 1336 -> marketGroup1336() |> Some
        | 1337 -> marketGroup1337() |> Some
        | 1861 -> marketGroup1861() |> Some
        | 1862 -> marketGroup1862() |> Some
        | 1863 -> marketGroup1863() |> Some
        | 983 -> marketGroup983() |> Some
        | 802 -> marketGroup802() |> Some
        | 803 -> marketGroup803() |> Some
        | 65 -> marketGroup65() |> Some
        | 1864 -> marketGroup1864() |> Some
        | 1865 -> marketGroup1865() |> Some
        | 1022 -> marketGroup1022() |> Some
        | 1866 -> marketGroup1866() |> Some
        | 1867 -> marketGroup1867() |> Some
        | 1868 -> marketGroup1868() |> Some
        | 1869 -> marketGroup1869() |> Some
        | 1870 -> marketGroup1870() |> Some
        | 781 -> marketGroup781() |> Some
        | 1872 -> marketGroup1872() |> Some
        | 1880 -> marketGroup1880() |> Some
        | 1883 -> marketGroup1883() |> Some
        | 1884 -> marketGroup1884() |> Some
        | 1885 -> marketGroup1885() |> Some
        | 1886 -> marketGroup1886() |> Some
        | 1887 -> marketGroup1887() |> Some
        | 1888 -> marketGroup1888() |> Some
        | 1889 -> marketGroup1889() |> Some
        | 1897 -> marketGroup1897() |> Some
        | 1898 -> marketGroup1898() |> Some
        | 1899 -> marketGroup1899() |> Some
        | 1900 -> marketGroup1900() |> Some
        | 1901 -> marketGroup1901() |> Some
        | 1902 -> marketGroup1902() |> Some
        | 1903 -> marketGroup1903() |> Some
        | 1904 -> marketGroup1904() |> Some
        | 1905 -> marketGroup1905() |> Some
        | 1906 -> marketGroup1906() |> Some
        | 1907 -> marketGroup1907() |> Some
        | 1908 -> marketGroup1908() |> Some
        | 1147 -> marketGroup1147() |> Some
        | 1909 -> marketGroup1909() |> Some
        | 1016 -> marketGroup1016() |> Some
        | 339 -> marketGroup339() |> Some
        | 753 -> marketGroup753() |> Some
        | 1358 -> marketGroup1358() |> Some
        | 1105 -> marketGroup1105() |> Some
        | 1408 -> marketGroup1408() |> Some
        | 1836 -> marketGroup1836() |> Some
        | 1822 -> marketGroup1822() |> Some
        | 1401 -> marketGroup1401() |> Some
        | 1400 -> marketGroup1400() |> Some
        | 1399 -> marketGroup1399() |> Some
        | 1398 -> marketGroup1398() |> Some
        | 1403 -> marketGroup1403() |> Some
        | 1404 -> marketGroup1404() |> Some
        | 1405 -> marketGroup1405() |> Some
        | 1406 -> marketGroup1406() |> Some
        | 1567 -> marketGroup1567() |> Some
        | 1568 -> marketGroup1568() |> Some
        | 1570 -> marketGroup1570() |> Some
        | 1571 -> marketGroup1571() |> Some
        | 1572 -> marketGroup1572() |> Some
        | 1574 -> marketGroup1574() |> Some
        | 1575 -> marketGroup1575() |> Some
        | 1576 -> marketGroup1576() |> Some
        | 1577 -> marketGroup1577() |> Some
        | 1583 -> marketGroup1583() |> Some
        | 430 -> marketGroup430() |> Some
        | 905 -> marketGroup905() |> Some
        | 1579 -> marketGroup1579() |> Some
        | 1580 -> marketGroup1580() |> Some
        | 1581 -> marketGroup1581() |> Some
        | 1582 -> marketGroup1582() |> Some
        | 1584 -> marketGroup1584() |> Some
        | 1585 -> marketGroup1585() |> Some
        | 1555 -> marketGroup1555() |> Some
        | 1556 -> marketGroup1556() |> Some
        | 1557 -> marketGroup1557() |> Some
        | 1558 -> marketGroup1558() |> Some
        | 1559 -> marketGroup1559() |> Some
        | 1560 -> marketGroup1560() |> Some
        | 1561 -> marketGroup1561() |> Some
        | 1562 -> marketGroup1562() |> Some
        | 1563 -> marketGroup1563() |> Some
        | 1564 -> marketGroup1564() |> Some
        | 1565 -> marketGroup1565() |> Some
        | 338 -> marketGroup338() |> Some
        | 937 -> marketGroup937() |> Some
        | 1712 -> marketGroup1712() |> Some
        | 1536 -> marketGroup1536() |> Some
        | 1537 -> marketGroup1537() |> Some
        | 335 -> marketGroup335() |> Some
        | 1538 -> marketGroup1538() |> Some
        | 1539 -> marketGroup1539() |> Some
        | 1540 -> marketGroup1540() |> Some
        | 1541 -> marketGroup1541() |> Some
        | 1542 -> marketGroup1542() |> Some
        | 1543 -> marketGroup1543() |> Some
        | 1544 -> marketGroup1544() |> Some
        | 331 -> marketGroup331() |> Some
        | 332 -> marketGroup332() |> Some
        | 1525 -> marketGroup1525() |> Some
        | 1697 -> marketGroup1697() |> Some
        | 325 -> marketGroup325() |> Some
        | 1198 -> marketGroup1198() |> Some
        | 1707 -> marketGroup1707() |> Some
        | 1716 -> marketGroup1716() |> Some
        | 1809 -> marketGroup1809() |> Some
        | 1547 -> marketGroup1547() |> Some
        | 1548 -> marketGroup1548() |> Some
        | 1549 -> marketGroup1549() |> Some
        | 1550 -> marketGroup1550() |> Some
        | 1551 -> marketGroup1551() |> Some
        | 1552 -> marketGroup1552() |> Some
        | 1553 -> marketGroup1553() |> Some
        | 1554 -> marketGroup1554() |> Some
        | 289 -> marketGroup289() |> Some
        | 290 -> marketGroup290() |> Some
        | 291 -> marketGroup291() |> Some
        | 792 -> marketGroup792() |> Some
        | 296 -> marketGroup296() |> Some
        | 297 -> marketGroup297() |> Some
        | 298 -> marketGroup298() |> Some
        | 793 -> marketGroup793() |> Some
        | 292 -> marketGroup292() |> Some
        | 293 -> marketGroup293() |> Some
        | 295 -> marketGroup295() |> Some
        | 794 -> marketGroup794() |> Some
        | 340 -> marketGroup340() |> Some
        | 343 -> marketGroup343() |> Some
        | 913 -> marketGroup913() |> Some
        | 1019 -> marketGroup1019() |> Some
        | 341 -> marketGroup341() |> Some
        | 799 -> marketGroup799() |> Some
        | 939 -> marketGroup939() |> Some
        | 1202 -> marketGroup1202() |> Some
        | 1203 -> marketGroup1203() |> Some
        | 1204 -> marketGroup1204() |> Some
        | 1719 -> marketGroup1719() |> Some
        | 1240 -> marketGroup1240() |> Some
        | 1241 -> marketGroup1241() |> Some
        | 1242 -> marketGroup1242() |> Some
        | 1720 -> marketGroup1720() |> Some
        | 1243 -> marketGroup1243() |> Some
        | 1244 -> marketGroup1244() |> Some
        | 1245 -> marketGroup1245() |> Some
        | 1721 -> marketGroup1721() |> Some
        | 1249 -> marketGroup1249() |> Some
        | 1250 -> marketGroup1250() |> Some
        | 1251 -> marketGroup1251() |> Some
        | 1723 -> marketGroup1723() |> Some
        | 1252 -> marketGroup1252() |> Some
        | 1253 -> marketGroup1253() |> Some
        | 1254 -> marketGroup1254() |> Some
        | 1724 -> marketGroup1724() |> Some
        | 1255 -> marketGroup1255() |> Some
        | 1256 -> marketGroup1256() |> Some
        | 1257 -> marketGroup1257() |> Some
        | 1725 -> marketGroup1725() |> Some
        | 1258 -> marketGroup1258() |> Some
        | 1259 -> marketGroup1259() |> Some
        | 1260 -> marketGroup1260() |> Some
        | 1726 -> marketGroup1726() |> Some
        | 1261 -> marketGroup1261() |> Some
        | 1262 -> marketGroup1262() |> Some
        | 1263 -> marketGroup1263() |> Some
        | 1727 -> marketGroup1727() |> Some
        | 1264 -> marketGroup1264() |> Some
        | 1265 -> marketGroup1265() |> Some
        | 1266 -> marketGroup1266() |> Some
        | 1728 -> marketGroup1728() |> Some
        | 1267 -> marketGroup1267() |> Some
        | 1268 -> marketGroup1268() |> Some
        | 1269 -> marketGroup1269() |> Some
        | 1729 -> marketGroup1729() |> Some
        | 1797 -> marketGroup1797() |> Some
        | 1798 -> marketGroup1798() |> Some
        | 1799 -> marketGroup1799() |> Some
        | 1800 -> marketGroup1800() |> Some
        | 1801 -> marketGroup1801() |> Some
        | 1802 -> marketGroup1802() |> Some
        | 1803 -> marketGroup1803() |> Some
        | 1804 -> marketGroup1804() |> Some
        | 1805 -> marketGroup1805() |> Some
        | 1806 -> marketGroup1806() |> Some
        | 1807 -> marketGroup1807() |> Some
        | 1808 -> marketGroup1808() |> Some
        | 407 -> marketGroup407() |> Some
        | 1008 -> marketGroup1008() |> Some
        | 1828 -> marketGroup1828() |> Some
        | 1829 -> marketGroup1829() |> Some
        | 1830 -> marketGroup1830() |> Some
        | 1834 -> marketGroup1834() |> Some
        | 1842 -> marketGroup1842() |> Some
        | 1843 -> marketGroup1843() |> Some
        | 1339 -> marketGroup1339() |> Some
        | 1340 -> marketGroup1340() |> Some
        | 1341 -> marketGroup1341() |> Some
        | 1342 -> marketGroup1342() |> Some
        | 1343 -> marketGroup1343() |> Some
        | 1346 -> marketGroup1346() |> Some
        | 1351 -> marketGroup1351() |> Some
        | 1352 -> marketGroup1352() |> Some
        | 1353 -> marketGroup1353() |> Some
        | 1354 -> marketGroup1354() |> Some
        | 1355 -> marketGroup1355() |> Some
        | 1359 -> marketGroup1359() |> Some
        | 1344 -> marketGroup1344() |> Some
        | 1345 -> marketGroup1345() |> Some
        | 1347 -> marketGroup1347() |> Some
        | 1348 -> marketGroup1348() |> Some
        | 1349 -> marketGroup1349() |> Some
        | 1350 -> marketGroup1350() |> Some
        | 1535 -> marketGroup1535() |> Some
        | 1701 -> marketGroup1701() |> Some
        | 359 -> marketGroup359() |> Some
        | 1531 -> marketGroup1531() |> Some
        | 1532 -> marketGroup1532() |> Some
        | 1533 -> marketGroup1533() |> Some
        | 358 -> marketGroup358() |> Some
        | 1029 -> marketGroup1029() |> Some
        | 1030 -> marketGroup1030() |> Some
        | 1586 -> marketGroup1586() |> Some
        | 1643 -> marketGroup1643() |> Some
        | 977 -> marketGroup977() |> Some
        | 618 -> marketGroup618() |> Some
        | 619 -> marketGroup619() |> Some
        | 620 -> marketGroup620() |> Some
        | 621 -> marketGroup621() |> Some
        | 622 -> marketGroup622() |> Some
        | 1514 -> marketGroup1514() |> Some
        | 1515 -> marketGroup1515() |> Some
        | 1516 -> marketGroup1516() |> Some
        | 1517 -> marketGroup1517() |> Some
        | 1518 -> marketGroup1518() |> Some
        | 1512 -> marketGroup1512() |> Some
        | 1513 -> marketGroup1513() |> Some
        | 1507 -> marketGroup1507() |> Some
        | 1508 -> marketGroup1508() |> Some
        | 1509 -> marketGroup1509() |> Some
        | 1506 -> marketGroup1506() |> Some
        | 1498 -> marketGroup1498() |> Some
        | 1499 -> marketGroup1499() |> Some
        | 1500 -> marketGroup1500() |> Some
        | 1501 -> marketGroup1501() |> Some
        | 1502 -> marketGroup1502() |> Some
        | 1504 -> marketGroup1504() |> Some
        | 1505 -> marketGroup1505() |> Some
        | 1493 -> marketGroup1493() |> Some
        | 1494 -> marketGroup1494() |> Some
        | 1495 -> marketGroup1495() |> Some
        | 1497 -> marketGroup1497() |> Some
        | 1496 -> marketGroup1496() |> Some
        | 1489 -> marketGroup1489() |> Some
        | 1490 -> marketGroup1490() |> Some
        | 1491 -> marketGroup1491() |> Some
        | 1492 -> marketGroup1492() |> Some
        | 1484 -> marketGroup1484() |> Some
        | 1485 -> marketGroup1485() |> Some
        | 1486 -> marketGroup1486() |> Some
        | 1480 -> marketGroup1480() |> Some
        | 1481 -> marketGroup1481() |> Some
        | 1482 -> marketGroup1482() |> Some
        | 1483 -> marketGroup1483() |> Some
        | 1765 -> marketGroup1765() |> Some
        | 1766 -> marketGroup1766() |> Some
        | 1767 -> marketGroup1767() |> Some
        | 1768 -> marketGroup1768() |> Some
        | 1769 -> marketGroup1769() |> Some
        | 1770 -> marketGroup1770() |> Some
        | 1771 -> marketGroup1771() |> Some
        | 1772 -> marketGroup1772() |> Some
        | 1773 -> marketGroup1773() |> Some
        | 1774 -> marketGroup1774() |> Some
        | 1775 -> marketGroup1775() |> Some
        | 1776 -> marketGroup1776() |> Some
        | 1777 -> marketGroup1777() |> Some
        | 866 -> marketGroup866() |> Some
        | 867 -> marketGroup867() |> Some
        | 868 -> marketGroup868() |> Some
        | 869 -> marketGroup869() |> Some
        | 870 -> marketGroup870() |> Some
        | 871 -> marketGroup871() |> Some
        | 995 -> marketGroup995() |> Some
        | 996 -> marketGroup996() |> Some
        | 997 -> marketGroup997() |> Some
        | 1007 -> marketGroup1007() |> Some
        | 102 -> marketGroup102() |> Some
        | 103 -> marketGroup103() |> Some
        | 105 -> marketGroup105() |> Some
        | 503 -> marketGroup503() |> Some
        | 1599 -> marketGroup1599() |> Some
        | 860 -> marketGroup860() |> Some
        | 861 -> marketGroup861() |> Some
        | 862 -> marketGroup862() |> Some
        | 863 -> marketGroup863() |> Some
        | 864 -> marketGroup864() |> Some
        | 865 -> marketGroup865() |> Some
        | 991 -> marketGroup991() |> Some
        | 992 -> marketGroup992() |> Some
        | 993 -> marketGroup993() |> Some
        | 1004 -> marketGroup1004() |> Some
        | 106 -> marketGroup106() |> Some
        | 107 -> marketGroup107() |> Some
        | 108 -> marketGroup108() |> Some
        | 504 -> marketGroup504() |> Some
        | 1600 -> marketGroup1600() |> Some
        | 914 -> marketGroup914() |> Some
        | 1192 -> marketGroup1192() |> Some
        | 116 -> marketGroup116() |> Some
        | 917 -> marketGroup917() |> Some
        | 920 -> marketGroup920() |> Some
        | 927 -> marketGroup927() |> Some
        | 998 -> marketGroup998() |> Some
        | 922 -> marketGroup922() |> Some
        | 928 -> marketGroup928() |> Some
        | 930 -> marketGroup930() |> Some
        | 999 -> marketGroup999() |> Some
        | 923 -> marketGroup923() |> Some
        | 929 -> marketGroup929() |> Some
        | 931 -> marketGroup931() |> Some
        | 1000 -> marketGroup1000() |> Some
        | 1193 -> marketGroup1193() |> Some
        | 1194 -> marketGroup1194() |> Some
        | 918 -> marketGroup918() |> Some
        | 921 -> marketGroup921() |> Some
        | 925 -> marketGroup925() |> Some
        | 1001 -> marketGroup1001() |> Some
        | 919 -> marketGroup919() |> Some
        | 924 -> marketGroup924() |> Some
        | 926 -> marketGroup926() |> Some
        | 1002 -> marketGroup1002() |> Some
        | 971 -> marketGroup971() |> Some
        | 972 -> marketGroup972() |> Some
        | 973 -> marketGroup973() |> Some
        | 1003 -> marketGroup1003() |> Some
        | 1287 -> marketGroup1287() |> Some
        | 1317 -> marketGroup1317() |> Some
        | 1201 -> marketGroup1201() |> Some
        | 1199 -> marketGroup1199() |> Some
        | 1200 -> marketGroup1200() |> Some
        | 854 -> marketGroup854() |> Some
        | 855 -> marketGroup855() |> Some
        | 856 -> marketGroup856() |> Some
        | 857 -> marketGroup857() |> Some
        | 858 -> marketGroup858() |> Some
        | 859 -> marketGroup859() |> Some
        | 987 -> marketGroup987() |> Some
        | 988 -> marketGroup988() |> Some
        | 989 -> marketGroup989() |> Some
        | 1006 -> marketGroup1006() |> Some
        | 1598 -> marketGroup1598() |> Some
        | 109 -> marketGroup109() |> Some
        | 112 -> marketGroup112() |> Some
        | 113 -> marketGroup113() |> Some
        | 502 -> marketGroup502() |> Some
        | 139 -> marketGroup139() |> Some
        | 593 -> marketGroup593() |> Some
        | 1015 -> marketGroup1015() |> Some
        | 1094 -> marketGroup1094() |> Some
        | 1103 -> marketGroup1103() |> Some
        | 309 -> marketGroup309() |> Some
        | 312 -> marketGroup312() |> Some
        | 313 -> marketGroup313() |> Some
        | 597 -> marketGroup597() |> Some
        | 1603 -> marketGroup1603() |> Some
        | 306 -> marketGroup306() |> Some
        | 307 -> marketGroup307() |> Some
        | 308 -> marketGroup308() |> Some
        | 598 -> marketGroup598() |> Some
        | 1601 -> marketGroup1601() |> Some
        | 302 -> marketGroup302() |> Some
        | 303 -> marketGroup303() |> Some
        | 305 -> marketGroup305() |> Some
        | 599 -> marketGroup599() |> Some
        | 1602 -> marketGroup1602() |> Some
        | 315 -> marketGroup315() |> Some
        | 316 -> marketGroup316() |> Some
        | 318 -> marketGroup318() |> Some
        | 390 -> marketGroup390() |> Some
        | 617 -> marketGroup617() |> Some
        | 975 -> marketGroup975() |> Some
        | 1286 -> marketGroup1286() |> Some
        | 1526 -> marketGroup1526() |> Some
        | 1527 -> marketGroup1527() |> Some
        | 1528 -> marketGroup1528() |> Some
        | 320 -> marketGroup320() |> Some
        | 1521 -> marketGroup1521() |> Some
        | 1529 -> marketGroup1529() |> Some
        | 261 -> marketGroup261() |> Some
        | 264 -> marketGroup264() |> Some
        | 272 -> marketGroup272() |> Some
        | 277 -> marketGroup277() |> Some
        | 1617 -> marketGroup1617() |> Some
        | 273 -> marketGroup273() |> Some
        | 274 -> marketGroup274() |> Some
        | 275 -> marketGroup275() |> Some
        | 276 -> marketGroup276() |> Some
        | 278 -> marketGroup278() |> Some
        | 279 -> marketGroup279() |> Some
        | 280 -> marketGroup280() |> Some
        | 281 -> marketGroup281() |> Some
        | 282 -> marketGroup282() |> Some
        | 284 -> marketGroup284() |> Some
        | 285 -> marketGroup285() |> Some
        | 1389 -> marketGroup1389() |> Some
        | 410 -> marketGroup410() |> Some
        | 411 -> marketGroup411() |> Some
        | 412 -> marketGroup412() |> Some
        | 413 -> marketGroup413() |> Some
        | 415 -> marketGroup415() |> Some
        | 416 -> marketGroup416() |> Some
        | 417 -> marketGroup417() |> Some
        | 418 -> marketGroup418() |> Some
        | 425 -> marketGroup425() |> Some
        | 427 -> marketGroup427() |> Some
        | 428 -> marketGroup428() |> Some
        | 429 -> marketGroup429() |> Some
        | 443 -> marketGroup443() |> Some
        | 444 -> marketGroup444() |> Some
        | 445 -> marketGroup445() |> Some
        | 446 -> marketGroup446() |> Some
        | 454 -> marketGroup454() |> Some
        | 455 -> marketGroup455() |> Some
        | 456 -> marketGroup456() |> Some
        | 457 -> marketGroup457() |> Some
        | 459 -> marketGroup459() |> Some
        | 461 -> marketGroup461() |> Some
        | 462 -> marketGroup462() |> Some
        | 463 -> marketGroup463() |> Some
        | 497 -> marketGroup497() |> Some
        | 583 -> marketGroup583() |> Some
        | 584 -> marketGroup584() |> Some
        | 585 -> marketGroup585() |> Some
        | 586 -> marketGroup586() |> Some
        | 589 -> marketGroup589() |> Some
        | 590 -> marketGroup590() |> Some
        | 591 -> marketGroup591() |> Some
        | 592 -> marketGroup592() |> Some
        | 635 -> marketGroup635() |> Some
        | 636 -> marketGroup636() |> Some
        | 637 -> marketGroup637() |> Some
        | 638 -> marketGroup638() |> Some
        | 783 -> marketGroup783() |> Some
        | 784 -> marketGroup784() |> Some
        | 785 -> marketGroup785() |> Some
        | 786 -> marketGroup786() |> Some
        | 788 -> marketGroup788() |> Some
        | 789 -> marketGroup789() |> Some
        | 790 -> marketGroup790() |> Some
        | 791 -> marketGroup791() |> Some
        | 884 -> marketGroup884() |> Some
        | 885 -> marketGroup885() |> Some
        | 886 -> marketGroup886() |> Some
        | 887 -> marketGroup887() |> Some
        | 888 -> marketGroup888() |> Some
        | 889 -> marketGroup889() |> Some
        | 890 -> marketGroup890() |> Some
        | 891 -> marketGroup891() |> Some
        | 892 -> marketGroup892() |> Some
        | 893 -> marketGroup893() |> Some
        | 894 -> marketGroup894() |> Some
        | 895 -> marketGroup895() |> Some
        | 896 -> marketGroup896() |> Some
        | 897 -> marketGroup897() |> Some
        | 898 -> marketGroup898() |> Some
        | 899 -> marketGroup899() |> Some
        | 900 -> marketGroup900() |> Some
        | 901 -> marketGroup901() |> Some
        | 902 -> marketGroup902() |> Some
        | 903 -> marketGroup903() |> Some
        | 904 -> marketGroup904() |> Some
        | 1046 -> marketGroup1046() |> Some
        | 393 -> marketGroup393() |> Some
        | 72 -> marketGroup72() |> Some
        | 400 -> marketGroup400() |> Some
        | 421 -> marketGroup421() |> Some
        | 433 -> marketGroup433() |> Some
        | 1066 -> marketGroup1066() |> Some
        | 74 -> marketGroup74() |> Some
        | 438 -> marketGroup438() |> Some
        | 449 -> marketGroup449() |> Some
        | 827 -> marketGroup827() |> Some
        | 1071 -> marketGroup1071() |> Some
        | 1139 -> marketGroup1139() |> Some
        | 465 -> marketGroup465() |> Some
        | 826 -> marketGroup826() |> Some
        | 470 -> marketGroup470() |> Some
        | 825 -> marketGroup825() |> Some
        | 79 -> marketGroup79() |> Some
        | 1076 -> marketGroup1076() |> Some
        | 1081 -> marketGroup1081() |> Some
        | 762 -> marketGroup762() |> Some
        | 767 -> marketGroup767() |> Some
        | 813 -> marketGroup813() |> Some
        | 818 -> marketGroup818() |> Some
        | 1090 -> marketGroup1090() |> Some
        | 85 -> marketGroup85() |> Some
        | 630 -> marketGroup630() |> Some
        | 1816 -> marketGroup1816() |> Some
        | 396 -> marketGroup396() |> Some
        | 61 -> marketGroup61() |> Some
        | 401 -> marketGroup401() |> Some
        | 422 -> marketGroup422() |> Some
        | 434 -> marketGroup434() |> Some
        | 1067 -> marketGroup1067() |> Some
        | 75 -> marketGroup75() |> Some
        | 439 -> marketGroup439() |> Some
        | 450 -> marketGroup450() |> Some
        | 830 -> marketGroup830() |> Some
        | 1072 -> marketGroup1072() |> Some
        | 1140 -> marketGroup1140() |> Some
        | 466 -> marketGroup466() |> Some
        | 829 -> marketGroup829() |> Some
        | 471 -> marketGroup471() |> Some
        | 828 -> marketGroup828() |> Some
        | 80 -> marketGroup80() |> Some
        | 1077 -> marketGroup1077() |> Some
        | 1082 -> marketGroup1082() |> Some
        | 763 -> marketGroup763() |> Some
        | 768 -> marketGroup768() |> Some
        | 814 -> marketGroup814() |> Some
        | 819 -> marketGroup819() |> Some
        | 1091 -> marketGroup1091() |> Some
        | 84 -> marketGroup84() |> Some
        | 631 -> marketGroup631() |> Some
        | 1817 -> marketGroup1817() |> Some
        | 395 -> marketGroup395() |> Some
        | 77 -> marketGroup77() |> Some
        | 402 -> marketGroup402() |> Some
        | 423 -> marketGroup423() |> Some
        | 435 -> marketGroup435() |> Some
        | 1068 -> marketGroup1068() |> Some
        | 76 -> marketGroup76() |> Some
        | 440 -> marketGroup440() |> Some
        | 451 -> marketGroup451() |> Some
        | 833 -> marketGroup833() |> Some
        | 1073 -> marketGroup1073() |> Some
        | 1141 -> marketGroup1141() |> Some
        | 467 -> marketGroup467() |> Some
        | 832 -> marketGroup832() |> Some
        | 472 -> marketGroup472() |> Some
        | 831 -> marketGroup831() |> Some
        | 81 -> marketGroup81() |> Some
        | 1078 -> marketGroup1078() |> Some
        | 1083 -> marketGroup1083() |> Some
        | 764 -> marketGroup764() |> Some
        | 769 -> marketGroup769() |> Some
        | 815 -> marketGroup815() |> Some
        | 820 -> marketGroup820() |> Some
        | 1092 -> marketGroup1092() |> Some
        | 83 -> marketGroup83() |> Some
        | 632 -> marketGroup632() |> Some
        | 1818 -> marketGroup1818() |> Some
        | 394 -> marketGroup394() |> Some
        | 64 -> marketGroup64() |> Some
        | 403 -> marketGroup403() |> Some
        | 424 -> marketGroup424() |> Some
        | 436 -> marketGroup436() |> Some
        | 1069 -> marketGroup1069() |> Some
        | 73 -> marketGroup73() |> Some
        | 441 -> marketGroup441() |> Some
        | 836 -> marketGroup836() |> Some
        | 1074 -> marketGroup1074() |> Some
        | 468 -> marketGroup468() |> Some
        | 835 -> marketGroup835() |> Some
        | 473 -> marketGroup473() |> Some
        | 834 -> marketGroup834() |> Some
        | 78 -> marketGroup78() |> Some
        | 1079 -> marketGroup1079() |> Some
        | 1084 -> marketGroup1084() |> Some
        | 765 -> marketGroup765() |> Some
        | 770 -> marketGroup770() |> Some
        | 816 -> marketGroup816() |> Some
        | 821 -> marketGroup821() |> Some
        | 1093 -> marketGroup1093() |> Some
        | 82 -> marketGroup82() |> Some
        | 633 -> marketGroup633() |> Some
        | 1819 -> marketGroup1819() |> Some
        | 283 -> marketGroup283() |> Some
        | 158 -> marketGroup158() |> Some
        | 837 -> marketGroup837() |> Some
        | 838 -> marketGroup838() |> Some
        | 839 -> marketGroup839() |> Some
        | 911 -> marketGroup911() |> Some
        | 841 -> marketGroup841() |> Some
        | 843 -> marketGroup843() |> Some
        | 1646 -> marketGroup1646() |> Some
        | 842 -> marketGroup842() |> Some
        | 1410 -> marketGroup1410() |> Some
        | 725 -> marketGroup725() |> Some
        | 726 -> marketGroup726() |> Some
        | 727 -> marketGroup727() |> Some
        | 728 -> marketGroup728() |> Some
        | 729 -> marketGroup729() |> Some
        | 686 -> marketGroup686() |> Some
        | 678 -> marketGroup678() |> Some
        | 679 -> marketGroup679() |> Some
        | 680 -> marketGroup680() |> Some
        | 720 -> marketGroup720() |> Some
        | 721 -> marketGroup721() |> Some
        | 722 -> marketGroup722() |> Some
        | 723 -> marketGroup723() |> Some
        | 724 -> marketGroup724() |> Some
        | 683 -> marketGroup683() |> Some
        | 757 -> marketGroup757() |> Some
        | 1426 -> marketGroup1426() |> Some
        | 564 -> marketGroup564() |> Some
        | 565 -> marketGroup565() |> Some
        | 566 -> marketGroup566() |> Some
        | 772 -> marketGroup772() |> Some
        | 561 -> marketGroup561() |> Some
        | 562 -> marketGroup562() |> Some
        | 563 -> marketGroup563() |> Some
        | 771 -> marketGroup771() |> Some
        | 574 -> marketGroup574() |> Some
        | 575 -> marketGroup575() |> Some
        | 576 -> marketGroup576() |> Some
        | 776 -> marketGroup776() |> Some
        | 577 -> marketGroup577() |> Some
        | 578 -> marketGroup578() |> Some
        | 579 -> marketGroup579() |> Some
        | 775 -> marketGroup775() |> Some
        | 567 -> marketGroup567() |> Some
        | 568 -> marketGroup568() |> Some
        | 569 -> marketGroup569() |> Some
        | 773 -> marketGroup773() |> Some
        | 570 -> marketGroup570() |> Some
        | 572 -> marketGroup572() |> Some
        | 573 -> marketGroup573() |> Some
        | 774 -> marketGroup774() |> Some
        | 777 -> marketGroup777() |> Some
        | 639 -> marketGroup639() |> Some
        | 640 -> marketGroup640() |> Some
        | 641 -> marketGroup641() |> Some
        | 642 -> marketGroup642() |> Some
        | 643 -> marketGroup643() |> Some
        | 644 -> marketGroup644() |> Some
        | 974 -> marketGroup974() |> Some
        | 1827 -> marketGroup1827() |> Some
        | 646 -> marketGroup646() |> Some
        | 647 -> marketGroup647() |> Some
        | 648 -> marketGroup648() |> Some
        | 706 -> marketGroup706() |> Some
        | 707 -> marketGroup707() |> Some
        | 708 -> marketGroup708() |> Some
        | 801 -> marketGroup801() |> Some
        | 1014 -> marketGroup1014() |> Some
        | 1672 -> marketGroup1672() |> Some
        | 1673 -> marketGroup1673() |> Some
        | 1674 -> marketGroup1674() |> Some
        | 1675 -> marketGroup1675() |> Some
        | 1676 -> marketGroup1676() |> Some
        | 1049 -> marketGroup1049() |> Some
        | 1050 -> marketGroup1050() |> Some
        | 1051 -> marketGroup1051() |> Some
        | 1052 -> marketGroup1052() |> Some
        | 1197 -> marketGroup1197() |> Some
        | 1196 -> marketGroup1196() |> Some
        | 1195 -> marketGroup1195() |> Some
        | 1056 -> marketGroup1056() |> Some
        | 1057 -> marketGroup1057() |> Some
        | 1058 -> marketGroup1058() |> Some
        | 1059 -> marketGroup1059() |> Some
        | 1053 -> marketGroup1053() |> Some
        | 1054 -> marketGroup1054() |> Some
        | 1055 -> marketGroup1055() |> Some
        | 1060 -> marketGroup1060() |> Some
        | 1061 -> marketGroup1061() |> Some
        | 1062 -> marketGroup1062() |> Some
        | 1063 -> marketGroup1063() |> Some
        | 1669 -> marketGroup1669() |> Some
        | 1687 -> marketGroup1687() |> Some
        | 131 -> marketGroup131() |> Some
        | 1086 -> marketGroup1086() |> Some
        | 1087 -> marketGroup1087() |> Some
        | 1088 -> marketGroup1088() |> Some
        | 542 -> marketGroup542() |> Some
        | 1650 -> marketGroup1650() |> Some
        | 380 -> marketGroup380() |> Some
        | 381 -> marketGroup381() |> Some
        | 382 -> marketGroup382() |> Some
        | 383 -> marketGroup383() |> Some
        | 126 -> marketGroup126() |> Some
        | 600 -> marketGroup600() |> Some
        | 601 -> marketGroup601() |> Some
        | 602 -> marketGroup602() |> Some
        | 603 -> marketGroup603() |> Some
        | 604 -> marketGroup604() |> Some
        | 687 -> marketGroup687() |> Some
        | 688 -> marketGroup688() |> Some
        | 658 -> marketGroup658() |> Some
        | 659 -> marketGroup659() |> Some
        | 660 -> marketGroup660() |> Some
        | 689 -> marketGroup689() |> Some
        | 690 -> marketGroup690() |> Some
        | 691 -> marketGroup691() |> Some
        | 692 -> marketGroup692() |> Some
        | 693 -> marketGroup693() |> Some
        | 694 -> marketGroup694() |> Some
        | 695 -> marketGroup695() |> Some
        | 696 -> marketGroup696() |> Some
        | 697 -> marketGroup697() |> Some
        | 910 -> marketGroup910() |> Some
        | 702 -> marketGroup702() |> Some
        | 703 -> marketGroup703() |> Some
        | 704 -> marketGroup704() |> Some
        | 705 -> marketGroup705() |> Some
        | 665 -> marketGroup665() |> Some
        | 666 -> marketGroup666() |> Some
        | 667 -> marketGroup667() |> Some
        | 698 -> marketGroup698() |> Some
        | 699 -> marketGroup699() |> Some
        | 701 -> marketGroup701() |> Some
        | 670 -> marketGroup670() |> Some
        | 669 -> marketGroup669() |> Some
        | 671 -> marketGroup671() |> Some
        | 672 -> marketGroup672() |> Some
        | 700 -> marketGroup700() |> Some
        | 673 -> marketGroup673() |> Some
        | 675 -> marketGroup675() |> Some
        | 676 -> marketGroup676() |> Some
        | 872 -> marketGroup872() |> Some
        | 717 -> marketGroup717() |> Some
        | 715 -> marketGroup715() |> Some
        | 716 -> marketGroup716() |> Some
        | 718 -> marketGroup718() |> Some
        | 719 -> marketGroup719() |> Some
        | 967 -> marketGroup967() |> Some
        | 1639 -> marketGroup1639() |> Some
        | 1640 -> marketGroup1640() |> Some
        | 1641 -> marketGroup1641() |> Some
        | 1642 -> marketGroup1642() |> Some
        | 938 -> marketGroup938() |> Some
        | 1718 -> marketGroup1718() |> Some
        | 711 -> marketGroup711() |> Some
        | 712 -> marketGroup712() |> Some
        | 713 -> marketGroup713() |> Some
        | 714 -> marketGroup714() |> Some
        | 1709 -> marketGroup1709() |> Some
        | 1717 -> marketGroup1717() |> Some
        | 1037 -> marketGroup1037() |> Some
        | 935 -> marketGroup935() |> Some
        | 1038 -> marketGroup1038() |> Some
        | 1039 -> marketGroup1039() |> Some
        | 1040 -> marketGroup1040() |> Some
        | 1715 -> marketGroup1715() |> Some
        | 20 -> marketGroup20() |> Some
        | 22 -> marketGroup22() |> Some
        | 23 -> marketGroup23() |> Some
        | 491 -> marketGroup491() |> Some
        | 492 -> marketGroup492() |> Some
        | 730 -> marketGroup730() |> Some
        | 731 -> marketGroup731() |> Some
        | 732 -> marketGroup732() |> Some
        | 734 -> marketGroup734() |> Some
        | 735 -> marketGroup735() |> Some
        | 736 -> marketGroup736() |> Some
        | 737 -> marketGroup737() |> Some
        | 733 -> marketGroup733() |> Some
        | 738 -> marketGroup738() |> Some
        | 740 -> marketGroup740() |> Some
        | 741 -> marketGroup741() |> Some
        | 742 -> marketGroup742() |> Some
        | 743 -> marketGroup743() |> Some
        | 744 -> marketGroup744() |> Some
        | 745 -> marketGroup745() |> Some
        | 746 -> marketGroup746() |> Some
        | 747 -> marketGroup747() |> Some
        | 748 -> marketGroup748() |> Some
        | 749 -> marketGroup749() |> Some
        | 750 -> marketGroup750() |> Some
        | 754 -> marketGroup754() |> Some
        | 940 -> marketGroup940() |> Some
        | 1109 -> marketGroup1109() |> Some
        | 1846 -> marketGroup1846() |> Some
        | 364 -> marketGroup364() |> Some
        | 365 -> marketGroup365() |> Some
        | 366 -> marketGroup366() |> Some
        | 367 -> marketGroup367() |> Some
        | 368 -> marketGroup368() |> Some
        | 369 -> marketGroup369() |> Some
        | 370 -> marketGroup370() |> Some
        | 372 -> marketGroup372() |> Some
        | 373 -> marketGroup373() |> Some
        | 374 -> marketGroup374() |> Some
        | 375 -> marketGroup375() |> Some
        | 376 -> marketGroup376() |> Some
        | 377 -> marketGroup377() |> Some
        | 378 -> marketGroup378() |> Some
        | 1110 -> marketGroup1110() |> Some
        | 1323 -> marketGroup1323() |> Some
        | 1745 -> marketGroup1745() |> Some
        | 1746 -> marketGroup1746() |> Some
        | 1747 -> marketGroup1747() |> Some
        | 1748 -> marketGroup1748() |> Some
        | 1823 -> marketGroup1823() |> Some
        | 1824 -> marketGroup1824() |> Some
        | 1651 -> marketGroup1651() |> Some
        | 1652 -> marketGroup1652() |> Some
        | 1653 -> marketGroup1653() |> Some
        | 1657 -> marketGroup1657() |> Some
        | 1658 -> marketGroup1658() |> Some
        | 405 -> marketGroup405() |> Some
        | 1831 -> marketGroup1831() |> Some
        | 1832 -> marketGroup1832() |> Some
        | 1833 -> marketGroup1833() |> Some
        | 1835 -> marketGroup1835() |> Some
        | 1844 -> marketGroup1844() |> Some
        | 1845 -> marketGroup1845() |> Some
        | 1847 -> marketGroup1847() |> Some
        | 1284 -> marketGroup1284() |> Some
        | 1282 -> marketGroup1282() |> Some
        | 1283 -> marketGroup1283() |> Some
        | 1273 -> marketGroup1273() |> Some
        | 1274 -> marketGroup1274() |> Some
        | 1275 -> marketGroup1275() |> Some
        | 478 -> marketGroup478() |> Some
        | 479 -> marketGroup479() |> Some
        | 481 -> marketGroup481() |> Some
        | 594 -> marketGroup594() |> Some
        | 595 -> marketGroup595() |> Some
        | 596 -> marketGroup596() |> Some
        | 1009 -> marketGroup1009() |> Some
        | 482 -> marketGroup482() |> Some
        | 483 -> marketGroup483() |> Some
        | 484 -> marketGroup484() |> Some
        | 485 -> marketGroup485() |> Some
        | 488 -> marketGroup488() |> Some
        | 490 -> marketGroup490() |> Some
        | 506 -> marketGroup506() |> Some
        | 932 -> marketGroup932() |> Some
        | 933 -> marketGroup933() |> Some
        | 1010 -> marketGroup1010() |> Some
        | 1011 -> marketGroup1011() |> Some
        | 1012 -> marketGroup1012() |> Some
        | 1013 -> marketGroup1013() |> Some
        | 1702 -> marketGroup1702() |> Some
        | 1206 -> marketGroup1206() |> Some
        | 1207 -> marketGroup1207() |> Some
        | 1208 -> marketGroup1208() |> Some
        | 1730 -> marketGroup1730() |> Some
        | 1210 -> marketGroup1210() |> Some
        | 1211 -> marketGroup1211() |> Some
        | 1212 -> marketGroup1212() |> Some
        | 1740 -> marketGroup1740() |> Some
        | 1213 -> marketGroup1213() |> Some
        | 1214 -> marketGroup1214() |> Some
        | 1215 -> marketGroup1215() |> Some
        | 1739 -> marketGroup1739() |> Some
        | 1219 -> marketGroup1219() |> Some
        | 1220 -> marketGroup1220() |> Some
        | 1221 -> marketGroup1221() |> Some
        | 1737 -> marketGroup1737() |> Some
        | 1222 -> marketGroup1222() |> Some
        | 1223 -> marketGroup1223() |> Some
        | 1224 -> marketGroup1224() |> Some
        | 1736 -> marketGroup1736() |> Some
        | 1225 -> marketGroup1225() |> Some
        | 1226 -> marketGroup1226() |> Some
        | 1227 -> marketGroup1227() |> Some
        | 1735 -> marketGroup1735() |> Some
        | 1228 -> marketGroup1228() |> Some
        | 1229 -> marketGroup1229() |> Some
        | 1230 -> marketGroup1230() |> Some
        | 1734 -> marketGroup1734() |> Some
        | 1231 -> marketGroup1231() |> Some
        | 1232 -> marketGroup1232() |> Some
        | 1233 -> marketGroup1233() |> Some
        | 1733 -> marketGroup1733() |> Some
        | 1234 -> marketGroup1234() |> Some
        | 1235 -> marketGroup1235() |> Some
        | 1236 -> marketGroup1236() |> Some
        | 1732 -> marketGroup1732() |> Some
        | 1237 -> marketGroup1237() |> Some
        | 1238 -> marketGroup1238() |> Some
        | 1239 -> marketGroup1239() |> Some
        | 1731 -> marketGroup1731() |> Some
        | 1782 -> marketGroup1782() |> Some
        | 1783 -> marketGroup1783() |> Some
        | 1784 -> marketGroup1784() |> Some
        | 1785 -> marketGroup1785() |> Some
        | 1786 -> marketGroup1786() |> Some
        | 1787 -> marketGroup1787() |> Some
        | 1788 -> marketGroup1788() |> Some
        | 1789 -> marketGroup1789() |> Some
        | 1790 -> marketGroup1790() |> Some
        | 1791 -> marketGroup1791() |> Some
        | 1792 -> marketGroup1792() |> Some
        | 1793 -> marketGroup1793() |> Some
        | 1660 -> marketGroup1660() |> Some
        | 1810 -> marketGroup1810() |> Some
        | 1811 -> marketGroup1811() |> Some
        | 1661 -> marketGroup1661() |> Some
        | 1662 -> marketGroup1662() |> Some
        | 1664 -> marketGroup1664() |> Some
        | 1663 -> marketGroup1663() |> Some
        | 494 -> marketGroup494() |> Some
        | 874 -> marketGroup874() |> Some
        | 1614 -> marketGroup1614() |> Some
        | 1618 -> marketGroup1618() |> Some
        | 1619 -> marketGroup1619() |> Some
        | 1620 -> marketGroup1620() |> Some
        | 1621 -> marketGroup1621() |> Some
        | 1623 -> marketGroup1623() |> Some
        | 1624 -> marketGroup1624() |> Some
        | 1698 -> marketGroup1698() |> Some
        | 1699 -> marketGroup1699() |> Some
        | 1837 -> marketGroup1837() |> Some
        | 1838 -> marketGroup1838() |> Some
        | 1631 -> marketGroup1631() |> Some
        | 1365 -> marketGroup1365() |> Some
        | 1366 -> marketGroup1366() |> Some
        | 1370 -> marketGroup1370() |> Some
        | 1371 -> marketGroup1371() |> Some
        | 1704 -> marketGroup1704() |> Some
        | 1379 -> marketGroup1379() |> Some
        | 1380 -> marketGroup1380() |> Some
        | 1392 -> marketGroup1392() |> Some
        | 1048 -> marketGroup1048() |> Some
        | 605 -> marketGroup605() |> Some
        | 606 -> marketGroup606() |> Some
        | 608 -> marketGroup608() |> Some
        | 609 -> marketGroup609() |> Some
        | 610 -> marketGroup610() |> Some
        | 611 -> marketGroup611() |> Some
        | 612 -> marketGroup612() |> Some
        | 613 -> marketGroup613() |> Some
        | 778 -> marketGroup778() |> Some
        | 796 -> marketGroup796() |> Some
        | 1912 -> marketGroup1912() |> Some
        | 1913 -> marketGroup1913() |> Some
        | 1918 -> marketGroup1918() |> Some
        | 1919 -> marketGroup1919() |> Some
        | 1920 -> marketGroup1920() |> Some
        | 1587 -> marketGroup1587() |> Some
        | 1588 -> marketGroup1588() |> Some
        | 1589 -> marketGroup1589() |> Some
        | 1590 -> marketGroup1590() |> Some
        | 1191 -> marketGroup1191() |> Some
        | 1592 -> marketGroup1592() |> Some
        | 1593 -> marketGroup1593() |> Some
        | 1594 -> marketGroup1594() |> Some
        | 1595 -> marketGroup1595() |> Some
        | 1027 -> marketGroup1027() |> Some
        | 512 -> marketGroup512() |> Some
        | 514 -> marketGroup514() |> Some
        | 515 -> marketGroup515() |> Some
        | 516 -> marketGroup516() |> Some
        | 517 -> marketGroup517() |> Some
        | 518 -> marketGroup518() |> Some
        | 519 -> marketGroup519() |> Some
        | 521 -> marketGroup521() |> Some
        | 522 -> marketGroup522() |> Some
        | 523 -> marketGroup523() |> Some
        | 525 -> marketGroup525() |> Some
        | 526 -> marketGroup526() |> Some
        | 527 -> marketGroup527() |> Some
        | 528 -> marketGroup528() |> Some
        | 529 -> marketGroup529() |> Some
        | 530 -> marketGroup530() |> Some
        | 1085 -> marketGroup1085() |> Some
        | 615 -> marketGroup615() |> Some
        | 452 -> marketGroup452() |> Some
        | 1142 -> marketGroup1142() |> Some
        | 1616 -> marketGroup1616() |> Some
        | 1390 -> marketGroup1390() |> Some
        | 1812 -> marketGroup1812() |> Some
        | 1813 -> marketGroup1813() |> Some
        | 1814 -> marketGroup1814() |> Some
        | 1921 -> marketGroup1921() |> Some
        | 1924 -> marketGroup1924() |> Some
        | 1935 -> marketGroup1935() |> Some
        | 1936 -> marketGroup1936() |> Some
        | 1937 -> marketGroup1937() |> Some
        | 1938 -> marketGroup1938() |> Some
        | 1939 -> marketGroup1939() |> Some
        | 1940 -> marketGroup1940() |> Some
        | 798 -> marketGroup798() |> Some
        | 1943 -> marketGroup1943() |> Some
        | 1944 -> marketGroup1944() |> Some
        | 1941 -> marketGroup1941() |> Some
        | 1931 -> marketGroup1931() |> Some
        | 1945 -> marketGroup1945() |> Some
        | 1932 -> marketGroup1932() |> Some
        | 1840 -> marketGroup1840() |> Some
        | 1942 -> marketGroup1942() |> Some
        | 367566 -> marketGroup367566() |> Some
        | 365946 -> marketGroup365946() |> Some
        | 365374 -> marketGroup365374() |> Some
        | 367569 -> marketGroup367569() |> Some
        | 367486 -> marketGroup367486() |> Some
        | 367571 -> marketGroup367571() |> Some
        | 367593 -> marketGroup367593() |> Some
        | 353565 -> marketGroup353565() |> Some
        | 1873 -> marketGroup1873() |> Some
        | 367771 -> marketGroup367771() |> Some
        | 367772 -> marketGroup367772() |> Some
        | 367773 -> marketGroup367773() |> Some
        | 353567 -> marketGroup353567() |> Some
        | 353563 -> marketGroup353563() |> Some
        | 353579 -> marketGroup353579() |> Some
        | 353580 -> marketGroup353580() |> Some
        | 1949 -> marketGroup1949() |> Some
        | 1952 -> marketGroup1952() |> Some
        | 368017 -> marketGroup368017() |> Some
        | 368105 -> marketGroup368105() |> Some
        | 368091 -> marketGroup368091() |> Some
        | 368106 -> marketGroup368106() |> Some
        | 368019 -> marketGroup368019() |> Some
        | 368107 -> marketGroup368107() |> Some
        | 368018 -> marketGroup368018() |> Some
        | 368108 -> marketGroup368108() |> Some
        | 368020 -> marketGroup368020() |> Some
        | 368109 -> marketGroup368109() |> Some
        | 368021 -> marketGroup368021() |> Some
        | 1951 -> marketGroup1951() |> Some
        | 368655 -> marketGroup368655() |> Some
        | 368667 -> marketGroup368667() |> Some
        | 368668 -> marketGroup368668() |> Some
        | 1953 -> marketGroup1953() |> Some
        | 368916 -> marketGroup368916() |> Some
        | 368917 -> marketGroup368917() |> Some
        | 368918 -> marketGroup368918() |> Some
        | 368919 -> marketGroup368919() |> Some
        | 368920 -> marketGroup368920() |> Some
        | 368921 -> marketGroup368921() |> Some
        | 368922 -> marketGroup368922() |> Some
        | 368923 -> marketGroup368923() |> Some
        | 2013 -> marketGroup2013() |> Some
        | 2015 -> marketGroup2015() |> Some
        | 1356 -> marketGroup1356() |> Some
        | 2014 -> marketGroup2014() |> Some
        | 2016 -> marketGroup2016() |> Some
        | 2017 -> marketGroup2017() |> Some
        | 2018 -> marketGroup2018() |> Some
        | 2020 -> marketGroup2020() |> Some
        | 1964 -> marketGroup1964() |> Some
        | 1984 -> marketGroup1984() |> Some
        | 2002 -> marketGroup2002() |> Some
        | 1965 -> marketGroup1965() |> Some
        | 1985 -> marketGroup1985() |> Some
        | 2003 -> marketGroup2003() |> Some
        | 1966 -> marketGroup1966() |> Some
        | 1986 -> marketGroup1986() |> Some
        | 2004 -> marketGroup2004() |> Some
        | 1967 -> marketGroup1967() |> Some
        | 1987 -> marketGroup1987() |> Some
        | 2005 -> marketGroup2005() |> Some
        | 1955 -> marketGroup1955() |> Some
        | 1962 -> marketGroup1962() |> Some
        | 1961 -> marketGroup1961() |> Some
        | 1960 -> marketGroup1960() |> Some
        | 1954 -> marketGroup1954() |> Some
        | 1968 -> marketGroup1968() |> Some
        | 1970 -> marketGroup1970() |> Some
        | 1971 -> marketGroup1971() |> Some
        | 1972 -> marketGroup1972() |> Some
        | 1973 -> marketGroup1973() |> Some
        | 1988 -> marketGroup1988() |> Some
        | 1989 -> marketGroup1989() |> Some
        | 1998 -> marketGroup1998() |> Some
        | 1999 -> marketGroup1999() |> Some
        | 2001 -> marketGroup2001() |> Some
        | 2000 -> marketGroup2000() |> Some
        | 2006 -> marketGroup2006() |> Some
        | 2011 -> marketGroup2011() |> Some
        | 2012 -> marketGroup2012() |> Some
        | 1963 -> marketGroup1963() |> Some
        | 369212 -> marketGroup369212() |> Some
        | 369213 -> marketGroup369213() |> Some
        | 369214 -> marketGroup369214() |> Some
        | 369215 -> marketGroup369215() |> Some
        | 369216 -> marketGroup369216() |> Some
        | 369217 -> marketGroup369217() |> Some
        | 369220 -> marketGroup369220() |> Some
        | 369221 -> marketGroup369221() |> Some
        | 369222 -> marketGroup369222() |> Some
        | 369223 -> marketGroup369223() |> Some
        | 369224 -> marketGroup369224() |> Some
        | 369225 -> marketGroup369225() |> Some
        | 369226 -> marketGroup369226() |> Some
        | 369227 -> marketGroup369227() |> Some
        | 2021 -> marketGroup2021() |> Some
        | 369234 -> marketGroup369234() |> Some
        | 354534 -> marketGroup354534() |> Some
        | 367570 -> marketGroup367570() |> Some
        | 353633 -> marketGroup353633() |> Some
        | 2024 -> marketGroup2024() |> Some
        | 2025 -> marketGroup2025() |> Some
        | 2026 -> marketGroup2026() |> Some
        | 2027 -> marketGroup2027() |> Some
        | 2028 -> marketGroup2028() |> Some
        | 2029 -> marketGroup2029() |> Some
        | 2030 -> marketGroup2030() |> Some
        | 1990 -> marketGroup1990() |> Some
        | 1991 -> marketGroup1991() |> Some
        | 1992 -> marketGroup1992() |> Some
        | 1993 -> marketGroup1993() |> Some
        | 2031 -> marketGroup2031() |> Some
        | 2022 -> marketGroup2022() |> Some
        | 2023 -> marketGroup2023() |> Some
        | 2034 -> marketGroup2034() |> Some
        | 2035 -> marketGroup2035() |> Some
        | 1997 -> marketGroup1997() |> Some
        | 1996 -> marketGroup1996() |> Some
        | 1995 -> marketGroup1995() |> Some
        | 1994 -> marketGroup1994() |> Some
        | 2036 -> marketGroup2036() |> Some
        | 2037 -> marketGroup2037() |> Some
        | 2038 -> marketGroup2038() |> Some
        | 2039 -> marketGroup2039() |> Some
        | 2040 -> marketGroup2040() |> Some
        | 2041 -> marketGroup2041() |> Some
        | 2042 -> marketGroup2042() |> Some
        | 2043 -> marketGroup2043() |> Some
        | 2044 -> marketGroup2044() |> Some
        | 2045 -> marketGroup2045() |> Some
        | 2046 -> marketGroup2046() |> Some
        | 2047 -> marketGroup2047() |> Some
        | 2048 -> marketGroup2048() |> Some
        | 2049 -> marketGroup2049() |> Some
        | 2050 -> marketGroup2050() |> Some
        | 2051 -> marketGroup2051() |> Some
        | 2052 -> marketGroup2052() |> Some
        | 2053 -> marketGroup2053() |> Some
        | 2054 -> marketGroup2054() |> Some
        | 2055 -> marketGroup2055() |> Some
        | 2056 -> marketGroup2056() |> Some
        | 2057 -> marketGroup2057() |> Some
        | 2058 -> marketGroup2058() |> Some
        | 2059 -> marketGroup2059() |> Some
        | 2060 -> marketGroup2060() |> Some
        | 2061 -> marketGroup2061() |> Some
        | 2062 -> marketGroup2062() |> Some
        | 2063 -> marketGroup2063() |> Some
        | 2064 -> marketGroup2064() |> Some
        | 2065 -> marketGroup2065() |> Some
        | 2066 -> marketGroup2066() |> Some
        | 2067 -> marketGroup2067() |> Some
        | 2068 -> marketGroup2068() |> Some
        | 2069 -> marketGroup2069() |> Some
        | 2070 -> marketGroup2070() |> Some
        | 2071 -> marketGroup2071() |> Some
        | 2072 -> marketGroup2072() |> Some
        | 2073 -> marketGroup2073() |> Some
        | 2074 -> marketGroup2074() |> Some
        | 2075 -> marketGroup2075() |> Some
        | 2076 -> marketGroup2076() |> Some
        | 2077 -> marketGroup2077() |> Some
        | 2078 -> marketGroup2078() |> Some
        | 2079 -> marketGroup2079() |> Some
        | 2080 -> marketGroup2080() |> Some
        | 2081 -> marketGroup2081() |> Some
        | 2082 -> marketGroup2082() |> Some
        | 2083 -> marketGroup2083() |> Some
        | 2084 -> marketGroup2084() |> Some
        | 2085 -> marketGroup2085() |> Some
        | 2086 -> marketGroup2086() |> Some
        | 2007 -> marketGroup2007() |> Some
        | 2008 -> marketGroup2008() |> Some
        | 2009 -> marketGroup2009() |> Some
        | 2010 -> marketGroup2010() |> Some
        | 2087 -> marketGroup2087() |> Some
        | 2088 -> marketGroup2088() |> Some
        | 2089 -> marketGroup2089() |> Some
        | 2090 -> marketGroup2090() |> Some
        | 2091 -> marketGroup2091() |> Some
        | 1950 -> marketGroup1950() |> Some
        | 2094 -> marketGroup2094() |> Some
        | 2095 -> marketGroup2095() |> Some
        | 2096 -> marketGroup2096() |> Some
        | 2097 -> marketGroup2097() |> Some
        | 2098 -> marketGroup2098() |> Some
        | 2099 -> marketGroup2099() |> Some
        | 2100 -> marketGroup2100() |> Some
        | 2101 -> marketGroup2101() |> Some
        | 1956 -> marketGroup1956() |> Some
        | 1957 -> marketGroup1957() |> Some
        | 1958 -> marketGroup1958() |> Some
        | 1959 -> marketGroup1959() |> Some
        | 2102 -> marketGroup2102() |> Some
        | 2103 -> marketGroup2103() |> Some
        | 2104 -> marketGroup2104() |> Some
        | 2105 -> marketGroup2105() |> Some
        | 2106 -> marketGroup2106() |> Some
        | 2107 -> marketGroup2107() |> Some
        | 2108 -> marketGroup2108() |> Some
        | 2109 -> marketGroup2109() |> Some
        | 2110 -> marketGroup2110() |> Some
        | 2111 -> marketGroup2111() |> Some
        | 2112 -> marketGroup2112() |> Some
        | 2113 -> marketGroup2113() |> Some
        | 645 -> marketGroup645() |> Some
        | 143 -> marketGroup143() |> Some
        | 2032 -> marketGroup2032() |> Some
        | 2033 -> marketGroup2033() |> Some
        | 2114 -> marketGroup2114() |> Some
        | 1969 -> marketGroup1969() |> Some
        | 2115 -> marketGroup2115() |> Some
        | 1922 -> marketGroup1922() |> Some
        | 1923 -> marketGroup1923() |> Some
        | 2119 -> marketGroup2119() |> Some
        | 2120 -> marketGroup2120() |> Some
        | 2125 -> marketGroup2125() |> Some
        | 2134 -> marketGroup2134() |> Some
        | 2136 -> marketGroup2136() |> Some
        | 2137 -> marketGroup2137() |> Some
        | 2138 -> marketGroup2138() |> Some
        | 2139 -> marketGroup2139() |> Some
        | 2140 -> marketGroup2140() |> Some
        | 2141 -> marketGroup2141() |> Some
        | 2142 -> marketGroup2142() |> Some
        | 2143 -> marketGroup2143() |> Some
        | 2144 -> marketGroup2144() |> Some
        | 2145 -> marketGroup2145() |> Some
        | 2146 -> marketGroup2146() |> Some
        | 2147 -> marketGroup2147() |> Some
        | 2148 -> marketGroup2148() |> Some
        | 2149 -> marketGroup2149() |> Some
        | 2150 -> marketGroup2150() |> Some
        | 2135 -> marketGroup2135() |> Some
        | 2151 -> marketGroup2151() |> Some
        | 2126 -> marketGroup2126() |> Some
        | 2131 -> marketGroup2131() |> Some
        | 2132 -> marketGroup2132() |> Some
        | 2133 -> marketGroup2133() |> Some
        | 2152 -> marketGroup2152() |> Some
        | 2153 -> marketGroup2153() |> Some
        | 2154 -> marketGroup2154() |> Some
        | 2156 -> marketGroup2156() |> Some
        | 2157 -> marketGroup2157() |> Some
        | 2158 -> marketGroup2158() |> Some
        | 2159 -> marketGroup2159() |> Some
        | 2160 -> marketGroup2160() |> Some
        | 2161 -> marketGroup2161() |> Some
        | 2162 -> marketGroup2162() |> Some
        | 2163 -> marketGroup2163() |> Some
        | 2164 -> marketGroup2164() |> Some
        | 2165 -> marketGroup2165() |> Some
        | 2166 -> marketGroup2166() |> Some
        | 2167 -> marketGroup2167() |> Some
        | 2168 -> marketGroup2168() |> Some
        | 2169 -> marketGroup2169() |> Some
        | 2170 -> marketGroup2170() |> Some
        | 2172 -> marketGroup2172() |> Some
        | 2173 -> marketGroup2173() |> Some
        | 2174 -> marketGroup2174() |> Some
        | 2175 -> marketGroup2175() |> Some
        | 2176 -> marketGroup2176() |> Some
        | 2177 -> marketGroup2177() |> Some
        | 2178 -> marketGroup2178() |> Some
        | 2179 -> marketGroup2179() |> Some
        | 2180 -> marketGroup2180() |> Some
        | 2181 -> marketGroup2181() |> Some
        | 2182 -> marketGroup2182() |> Some
        | 2183 -> marketGroup2183() |> Some
        | 2184 -> marketGroup2184() |> Some
        | 2185 -> marketGroup2185() |> Some
        | 2187 -> marketGroup2187() |> Some
        | 2188 -> marketGroup2188() |> Some
        | 2189 -> marketGroup2189() |> Some
        | 2190 -> marketGroup2190() |> Some
        | 2191 -> marketGroup2191() |> Some
        | 2192 -> marketGroup2192() |> Some
        | 2193 -> marketGroup2193() |> Some
        | 2196 -> marketGroup2196() |> Some
        | 2197 -> marketGroup2197() |> Some
        | 2198 -> marketGroup2198() |> Some
        | 2199 -> marketGroup2199() |> Some
        | 2200 -> marketGroup2200() |> Some
        | 2201 -> marketGroup2201() |> Some
        | 2206 -> marketGroup2206() |> Some
        | 2207 -> marketGroup2207() |> Some
        | 2208 -> marketGroup2208() |> Some
        | 2209 -> marketGroup2209() |> Some
        | 2210 -> marketGroup2210() |> Some
        | 2211 -> marketGroup2211() |> Some
        | 2212 -> marketGroup2212() |> Some
        | 2213 -> marketGroup2213() |> Some
        | 2214 -> marketGroup2214() |> Some
        | 2216 -> marketGroup2216() |> Some
        | 2218 -> marketGroup2218() |> Some
        | 2219 -> marketGroup2219() |> Some
        | 2221 -> marketGroup2221() |> Some
        | 2222 -> marketGroup2222() |> Some
        | 2223 -> marketGroup2223() |> Some
        | 2226 -> marketGroup2226() |> Some
        | 2227 -> marketGroup2227() |> Some
        | 2228 -> marketGroup2228() |> Some
        | 2229 -> marketGroup2229() |> Some
        | 2230 -> marketGroup2230() |> Some
        | 2231 -> marketGroup2231() |> Some
        | 2232 -> marketGroup2232() |> Some
        | 2233 -> marketGroup2233() |> Some
        | 2234 -> marketGroup2234() |> Some
        | 2235 -> marketGroup2235() |> Some
        | 2186 -> marketGroup2186() |> Some
        | 1028 -> marketGroup1028() |> Some
        | 1313 -> marketGroup1313() |> Some
        | 2238 -> marketGroup2238() |> Some
        | 2240 -> marketGroup2240() |> Some
        | 2241 -> marketGroup2241() |> Some
        | 2242 -> marketGroup2242() |> Some
        | 2243 -> marketGroup2243() |> Some
        | 2244 -> marketGroup2244() |> Some
        | 1416 -> marketGroup1416() |> Some
        | 2245 -> marketGroup2245() |> Some
        | 2246 -> marketGroup2246() |> Some
        | 2247 -> marketGroup2247() |> Some
        | 2248 -> marketGroup2248() |> Some
        | 2249 -> marketGroup2249() |> Some
        | 2250 -> marketGroup2250() |> Some
        | 2251 -> marketGroup2251() |> Some
        | 2237 -> marketGroup2237() |> Some
        | 2258 -> marketGroup2258() |> Some
        | 2259 -> marketGroup2259() |> Some
        | 2260 -> marketGroup2260() |> Some
        | 2261 -> marketGroup2261() |> Some
        | 2257 -> marketGroup2257() |> Some
        | 2256 -> marketGroup2256() |> Some
        | 2254 -> marketGroup2254() |> Some
        | 2255 -> marketGroup2255() |> Some
        | 2252 -> marketGroup2252() |> Some
        | 2253 -> marketGroup2253() |> Some
        | 2262 -> marketGroup2262() |> Some
        | 2263 -> marketGroup2263() |> Some
        | 2264 -> marketGroup2264() |> Some
        | 2265 -> marketGroup2265() |> Some
        | 2266 -> marketGroup2266() |> Some
        | 2267 -> marketGroup2267() |> Some
        | 2268 -> marketGroup2268() |> Some
        | 2269 -> marketGroup2269() |> Some
        | 2270 -> marketGroup2270() |> Some
        | 2271 -> marketGroup2271() |> Some
        | 2272 -> marketGroup2272() |> Some
        | 2273 -> marketGroup2273() |> Some
        | 2274 -> marketGroup2274() |> Some
        | 2275 -> marketGroup2275() |> Some
        | 2276 -> marketGroup2276() |> Some
        | 912 -> marketGroup912() |> Some
        | 2277 -> marketGroup2277() |> Some
        | 2278 -> marketGroup2278() |> Some
        | 2279 -> marketGroup2279() |> Some
        | 2280 -> marketGroup2280() |> Some
        | 2281 -> marketGroup2281() |> Some
        | 2155 -> marketGroup2155() |> Some
        | 2283 -> marketGroup2283() |> Some
        | 2285 -> marketGroup2285() |> Some
        | 2286 -> marketGroup2286() |> Some
        | 2287 -> marketGroup2287() |> Some
        | 2288 -> marketGroup2288() |> Some
        | 2297 -> marketGroup2297() |> Some
        | 2298 -> marketGroup2298() |> Some
        | 2299 -> marketGroup2299() |> Some
        | 2300 -> marketGroup2300() |> Some
        | 2301 -> marketGroup2301() |> Some
        | 2302 -> marketGroup2302() |> Some
        | 2306 -> marketGroup2306() |> Some
        | 2309 -> marketGroup2309() |> Some
        | 2310 -> marketGroup2310() |> Some
        | 2291 -> marketGroup2291() |> Some
        | 2292 -> marketGroup2292() |> Some
        | 2293 -> marketGroup2293() |> Some
        | 2294 -> marketGroup2294() |> Some
        | 2295 -> marketGroup2295() |> Some
        | 2290 -> marketGroup2290() |> Some
        | 2311 -> marketGroup2311() |> Some
        | 2312 -> marketGroup2312() |> Some
        | 2313 -> marketGroup2313() |> Some
        | 2314 -> marketGroup2314() |> Some
        | 2315 -> marketGroup2315() |> Some
        | 2316 -> marketGroup2316() |> Some
        | 2317 -> marketGroup2317() |> Some
        | 2318 -> marketGroup2318() |> Some
        | 2319 -> marketGroup2319() |> Some
        | 2320 -> marketGroup2320() |> Some
        | 2321 -> marketGroup2321() |> Some
        | 1633 -> marketGroup1633() |> Some
        | 2322 -> marketGroup2322() |> Some
        | 2323 -> marketGroup2323() |> Some
        | 2324 -> marketGroup2324() |> Some
        | 2325 -> marketGroup2325() |> Some
        | 2328 -> marketGroup2328() |> Some
        | 2330 -> marketGroup2330() |> Some
        | 2331 -> marketGroup2331() |> Some
        | 2332 -> marketGroup2332() |> Some
        | 2333 -> marketGroup2333() |> Some
        | 2334 -> marketGroup2334() |> Some
        | 2335 -> marketGroup2335() |> Some
        | 2336 -> marketGroup2336() |> Some
        | 2337 -> marketGroup2337() |> Some
        | 2338 -> marketGroup2338() |> Some
        | 2339 -> marketGroup2339() |> Some
        | 2204 -> marketGroup2204() |> Some
        | 2205 -> marketGroup2205() |> Some
        | 2340 -> marketGroup2340() |> Some
        | 2341 -> marketGroup2341() |> Some
        | 2342 -> marketGroup2342() |> Some
        | 2343 -> marketGroup2343() |> Some
        | 2344 -> marketGroup2344() |> Some
        | 2345 -> marketGroup2345() |> Some
        | 2346 -> marketGroup2346() |> Some
        | 2347 -> marketGroup2347() |> Some
        | 2348 -> marketGroup2348() |> Some
        | 2349 -> marketGroup2349() |> Some
        | 2350 -> marketGroup2350() |> Some
        | 2351 -> marketGroup2351() |> Some
        | 2236 -> marketGroup2236() |> Some
        | 2202 -> marketGroup2202() |> Some
        | 2203 -> marketGroup2203() |> Some
        | 2353 -> marketGroup2353() |> Some
        | 2354 -> marketGroup2354() |> Some
        | 2355 -> marketGroup2355() |> Some
        | 2356 -> marketGroup2356() |> Some
        | 2357 -> marketGroup2357() |> Some
        | 2358 -> marketGroup2358() |> Some
        | 2307 -> marketGroup2307() |> Some
        | 2359 -> marketGroup2359() |> Some
        | 2360 -> marketGroup2360() |> Some
        | 2361 -> marketGroup2361() |> Some
        | 2362 -> marketGroup2362() |> Some
        | 2369 -> marketGroup2369() |> Some
        | 2370 -> marketGroup2370() |> Some
        | 2371 -> marketGroup2371() |> Some
        | 2372 -> marketGroup2372() |> Some
        | 2373 -> marketGroup2373() |> Some
        | 2374 -> marketGroup2374() |> Some
        | 1974 -> marketGroup1974() |> Some
        | 1975 -> marketGroup1975() |> Some
        | 1976 -> marketGroup1976() |> Some
        | 1977 -> marketGroup1977() |> Some
        | 2375 -> marketGroup2375() |> Some
        | 2376 -> marketGroup2376() |> Some
        | 2377 -> marketGroup2377() |> Some
        | 1981 -> marketGroup1981() |> Some
        | 1982 -> marketGroup1982() |> Some
        | 1983 -> marketGroup1983() |> Some
        | 1980 -> marketGroup1980() |> Some
        | 2378 -> marketGroup2378() |> Some
        | 2380 -> marketGroup2380() |> Some
        | 2381 -> marketGroup2381() |> Some
        | 1978 -> marketGroup1978() |> Some
        | 1979 -> marketGroup1979() |> Some
        | 2092 -> marketGroup2092() |> Some
        | 2093 -> marketGroup2093() |> Some
        | 2382 -> marketGroup2382() |> Some
        | 2383 -> marketGroup2383() |> Some
        | 2387 -> marketGroup2387() |> Some
        | 2388 -> marketGroup2388() |> Some
        | 2389 -> marketGroup2389() |> Some
        | 2390 -> marketGroup2390() |> Some
        | 2308 -> marketGroup2308() |> Some
        | 2391 -> marketGroup2391() |> Some
        | 2392 -> marketGroup2392() |> Some
        | 2393 -> marketGroup2393() |> Some
        | 2327 -> marketGroup2327() |> Some
        | 2395 -> marketGroup2395() |> Some
        | 2396 -> marketGroup2396() |> Some
        | 2397 -> marketGroup2397() |> Some
        | 2398 -> marketGroup2398() |> Some
        | 2400 -> marketGroup2400() |> Some
        | 2401 -> marketGroup2401() |> Some
        | 1849 -> marketGroup1849() |> Some
        | 2402 -> marketGroup2402() |> Some
        | 2403 -> marketGroup2403() |> Some
        | 2404 -> marketGroup2404() |> Some
        | 2171 -> marketGroup2171() |> Some
        | 2215 -> marketGroup2215() |> Some
        | 2406 -> marketGroup2406() |> Some
        | 2407 -> marketGroup2407() |> Some
        | 2408 -> marketGroup2408() |> Some
        | 2409 -> marketGroup2409() |> Some
        | 2410 -> marketGroup2410() |> Some
        | 840 -> marketGroup840() |> Some
        | 1310 -> marketGroup1310() |> Some
        | 2239 -> marketGroup2239() |> Some
        | 2411 -> marketGroup2411() |> Some
        | 2412 -> marketGroup2412() |> Some
        | 2413 -> marketGroup2413() |> Some
        | 2224 -> marketGroup2224() |> Some
        | 2220 -> marketGroup2220() |> Some
        | 2414 -> marketGroup2414() |> Some
        | 2415 -> marketGroup2415() |> Some
        | 2416 -> marketGroup2416() |> Some
        | 2417 -> marketGroup2417() |> Some
        | 2418 -> marketGroup2418() |> Some
        | 2419 -> marketGroup2419() |> Some
        | 2420 -> marketGroup2420() |> Some
        | 2421 -> marketGroup2421() |> Some
        | _ -> None
    let marketGroupChildren = function
        | None -> [| 2;4;9;11;19;24;150;157;475;477;955;1320;1396;1659;1922;1954;2202;2203;350001 |]
        | Some 9 -> [| 10;14;52;141;554;655;656;657;779;938;1708;1713 |]
        | Some 24 -> [| 27;977 |]
        | Some 1031 -> [| 54;1855;1856;2395 |]
        | Some 10 -> [| 86;87;88;140;143;912;1014 |]
        | Some 11 -> [| 99;100;101;114;120;139;593;1015;1094;1103;2198;2297 |]
        | Some 114 -> [| 115;116;117;118;387;505;580;581;968;1316;2196;2197 |]
        | Some 554 -> [| 126;128;550;551;552;553;687;688 |]
        | Some 52 -> [| 131;132;542;1650;2135 |]
        | Some 14 -> [| 133;134;135;535;537;538;540;541;615;1018;1669;1687 |]
        | Some 157 -> [| 158;159;841;842;843;1646;2236 |]
        | Some 2 -> [| 204;209;211;357;943;1041;1338;1849;2157;2158 |]
        | Some 204 -> [| 205;206;207;208;408;414;419;442;453;458;496;582;588;634;782;787;878;879;880;881;882;883;1045;2262;2333 |]
        | Some 209 -> [| 210;214;252;341;799;939;1545;1546;1566;1578;1710;1711 |]
        | Some 210 -> [| 286;287;288;340;343;913;1019 |]
        | Some 211 -> [| 299;300;301;314;339;753;1016;1105;1358;1520;2193;2290 |]
        | Some 4 -> [| 391;1361;1367;1372;1374;1376;1381;1382;1384;1612;1815 |]
        | Some 27 -> [| 531;532 |]
        | Some 475 -> [| 533;1035;1872 |]
        | Some 86 -> [| 555;556 |]
        | Some 88 -> [| 557;558 |]
        | Some 87 -> [| 559;560 |]
        | Some 19 -> [| 20;22;23;491;492;614;616;738;739;754;940;1109;1427;1700;1840;1846;2013;2317 |]
        | Some 655 -> [| 658;659;660;661;662;663;664;665;666;667;668 |]
        | Some 657 -> [| 677;678;679;680;681;683;685;686;757;1085;1426;1935;1936;1937;2154;2249 |]
        | Some 614 -> [| 751;752 |]
        | Some 99 -> [| 845;846;847;986;1598 |]
        | Some 100 -> [| 848;849;850;990;1600 |]
        | Some 101 -> [| 851;852;853;994;1599 |]
        | Some 533 -> [| 1031;1032;1033;1034;1332;1857;1861;1897;2155 |]
        | Some 1035 -> [| 65;781;1021;1147;1870;1883;1908 |]
        | Some 955 -> [| 1111;1112 |]
        | Some 943 -> [| 944;945;946;948;949;950;951;952;953;954;1794;1795;1796 |]
        | Some 1111 -> [| 956;957;958;960;961;962;963;964;965;979;1779;1780;1781 |]
        | Some 1272 -> [| 1273;1274;1275;1276 |]
        | Some 1361 -> [| 5;1362;1364 |]
        | Some 1364 -> [| 399;420;432;1065;1924;2146 |]
        | Some 1367 -> [| 6;1368;1369 |]
        | Some 1368 -> [| 437;448;824;1070;1138;2416 |]
        | Some 1372 -> [| 464;1373 |]
        | Some 1374 -> [| 469;1375;1703 |]
        | Some 1375 -> [| 822 |]
        | Some 1376 -> [| 7;1377;1378 |]
        | Some 1377 -> [| 1075;1080 |]
        | Some 1381 -> [| 761;766;812;817;1047;1089;2271 |]
        | Some 1382 -> [| 8;1385;2335 |]
        | Some 1385 -> [| 629 |]
        | Some 1396 -> [| 1397;1402;1407 |]
        | Some 1373 -> [| 823;1951;2125 |]
        | Some 477 -> [| 404;1272;1285;2199;2324;2327 |]
        | Some 1320 -> [| 1322;1410 |]
        | Some 350001 -> [| 353562;353566;355449;365995;367566;367593;367771;368017;368667;369234 |]
        | Some 531 -> [| 1469;1470;1471;1472;1473;1474;1475;1476;1477;1478;1479;1761;1762;1763;1764 |]
        | Some 1041 -> [| 800;1522 |]
        | Some 357 -> [| 358;1029;1030;1530;1586;1643;2237 |]
        | Some 1285 -> [| 478;480;482;483;484;485;488;490;506;932;933;1010;1011;1012;1013;1702;1921 |]
        | Some 800 -> [| 796;798;1097;1191;1591;1918;1920 |]
        | Some 1112 -> [| 1610;1625;1626;1627 |]
        | Some 1610 -> [| 1122;1126;1130;1134 |]
        | Some 1625 -> [| 1123;1127;1131;1135 |]
        | Some 1627 -> [| 1124;1129;1132;1136 |]
        | Some 1626 -> [| 1125;1128;1133;1137 |]
        | Some 357121 -> [| 357120 |]
        | Some 404 -> [| 379;405;1831;1832;1833;1835;1844;1845;1847 |]
        | Some 353591 -> [| 354460;354461 |]
        | Some 354444 -> [| 363304;363305;363306 |]
        | Some 354448 -> [| 363440;363441 |]
        | Some 353587 -> [| 354471;356597;363442;368916 |]
        | Some 354471 -> [| 363448;363449 |]
        | Some 356597 -> [| 363452 |]
        | Some 363442 -> [| 363456;363457 |]
        | Some 354338 -> [| 363464;363465;363466 |]
        | Some 354339 -> [| 363467;363468;363469 |]
        | Some 354340 -> [| 363470;363471;363472 |]
        | Some 354489 -> [| 356971;356972;356973 |]
        | Some 353569 -> [| 354331;354332;354333 |]
        | Some 353568 -> [| 354335;354336;354337 |]
        | Some 353557 -> [| 354338;354339;354340;366111 |]
        | Some 353573 -> [| 354343;354344;354345 |]
        | Some 353570 -> [| 354347;354348;354350 |]
        | Some 353572 -> [| 354352;354353;354354 |]
        | Some 353589 -> [| 354453;356916 |]
        | Some 353571 -> [| 354364;354366;354367 |]
        | Some 353601 -> [| 354376;354377;354378 |]
        | Some 353604 -> [| 354380;354381;354382 |]
        | Some 353602 -> [| 354384;354385;354386 |]
        | Some 356433 -> [| 356434;356435;356436 |]
        | Some 353600 -> [| 354388;354389;354390 |]
        | Some 354490 -> [| 356963;356964;356965 |]
        | Some 354491 -> [| 356960;356961;356962 |]
        | Some 353575 -> [| 354403;354404;354405 |]
        | Some 354488 -> [| 356968;356969;356970 |]
        | Some 353574 -> [| 354410;354411;354412 |]
        | Some 353576 -> [| 354414;354415;354416 |]
        | Some 354483 -> [| 356976;356977;356978 |]
        | Some 353613 -> [| 356979;356980;356981 |]
        | Some 353583 -> [| 354425;354427;354429 |]
        | Some 353584 -> [| 354430;354671;355572 |]
        | Some 353585 -> [| 354431 |]
        | Some 353586 -> [| 354434 |]
        | Some 355449 -> [| 355457;355458;355459;355460;355461;355462 |]
        | Some 355462 -> [| 355463 |]
        | Some 355460 -> [| 355465 |]
        | Some 355459 -> [| 355466;355467 |]
        | Some 353588 -> [| 354444;354448;357121 |]
        | Some 355457 -> [| 355469 |]
        | Some 353590 -> [| 354454;354455;354458;354459 |]
        | Some 353592 -> [| 354469;365898;368918;368920 |]
        | Some 353565 -> [| 353605;353608;354478 |]
        | Some 353605 -> [| 353613;354483 |]
        | Some 354478 -> [| 354488;354489 |]
        | Some 353608 -> [| 354490;354491 |]
        | Some 355181 -> [| 355187;355188;355189 |]
        | Some 353563 -> [| 353574;353575;353576;355181;355193;364491;366752 |]
        | Some 354469 -> [| 356575;356576 |]
        | Some 356575 -> [| 356579;356580;356581 |]
        | Some 356576 -> [| 356582;356583;356584 |]
        | Some 354534 -> [| 354542;354543;366021;366350;366351;366352 |]
        | Some 354563 -> [| 354565;354566;354567 |]
        | Some 353567 -> [| 353557;364047;364048;364049 |]
        | Some 353579 -> [| 353581;353582;353583;353584;353585;353586 |]
        | Some 353580 -> [| 353587;353588;353589;353590;353591;353592 |]
        | Some 354616 -> [| 354618;354619;354620 |]
        | Some 355458 -> [| 355468 |]
        | Some 355461 -> [| 355464 |]
        | Some 353566 -> [| 353565;353580;353651;353652;353653 |]
        | Some 353651 -> [| 353657;353663;364760;368922;368923 |]
        | Some 355193 -> [| 355194;355195;355196 |]
        | Some 353652 -> [| 353664;353669;364765 |]
        | Some 354686 -> [| 354690;354691;354692 |]
        | Some 353653 -> [| 353671;353676;364768 |]
        | Some 354693 -> [| 354696;354697;354698 |]
        | Some 353633 -> [| 353681;353706;353710;353713;363475;365496;365497 |]
        | Some 353681 -> [| 353684 |]
        | Some 353706 -> [| 353707 |]
        | Some 353710 -> [| 353711 |]
        | Some 353713 -> [| 353715;353716 |]
        | Some 363475 -> [| 363476 |]
        | Some 540 -> [| 1665;1666;1667;1668;1670 |]
        | Some 535 -> [| 1416;1678;1679;1680;1681;2245 |]
        | Some 541 -> [| 1682;1683;1684;1685;1686 |]
        | Some 550 -> [| 1688;1689;1690;1691 |]
        | Some 553 -> [| 1692;1693;1694;1695;1696;2246 |]
        | Some 363790 -> [| 363791;363792;363793 |]
        | Some 353562 -> [| 353563;353567;353579;364044;364045;364046 |]
        | Some 364048 -> [| 353572;353573;356433;363790;366570;366574;366741 |]
        | Some 364047 -> [| 353569;353570;353571;354616;354686;354693;364051;364055;365765;365769 |]
        | Some 364049 -> [| 353568;354563 |]
        | Some 364044 -> [| 353600;364885;365272 |]
        | Some 364045 -> [| 353601;353602;364889 |]
        | Some 364046 -> [| 353604;364893;365278 |]
        | Some 364051 -> [| 364052;364053;364054 |]
        | Some 364055 -> [| 364056;364057;364058 |]
        | Some 364491 -> [| 364492;364493;364494 |]
        | Some 364885 -> [| 364886;364887;364888 |]
        | Some 364889 -> [| 364890;364891;364892 |]
        | Some 364893 -> [| 364894;364895;364896 |]
        | Some 354423 -> [| 365244;365245;365246 |]
        | Some 353582 -> [| 354423;354424 |]
        | Some 354424 -> [| 365247 |]
        | Some 354432 -> [| 365248 |]
        | Some 353581 -> [| 354432;354433;355590 |]
        | Some 355590 -> [| 365249 |]
        | Some 354433 -> [| 365250;365251 |]
        | Some 365272 -> [| 365274;365276;365277 |]
        | Some 365278 -> [| 365279;365280;365282 |]
        | Some 365496 -> [| 353708 |]
        | Some 365497 -> [| 365001 |]
        | Some 365765 -> [| 365766;365767;365768 |]
        | Some 365769 -> [| 365770;365771;365772 |]
        | Some 365946 -> [| 365949;365950;365951 |]
        | Some 366111 -> [| 366112;366113;366114 |]
        | Some 365996 -> [| 366173;366178;366182;366186;366190;366260;369226 |]
        | Some 365997 -> [| 366174;366179;366191;366264;369220 |]
        | Some 365998 -> [| 366175;366180;366193;366275;369222 |]
        | Some 365999 -> [| 366177;366181;366185;366189;366194;366282;369224 |]
        | Some 366174 -> [| 366197;366198;366199 |]
        | Some 366173 -> [| 366200;366201;366202 |]
        | Some 366175 -> [| 366203;366204;366205 |]
        | Some 366177 -> [| 366206;366207;366208 |]
        | Some 366182 -> [| 366209 |]
        | Some 366186 -> [| 366210;366211;366212 |]
        | Some 366189 -> [| 366213;366214;366215 |]
        | Some 366185 -> [| 366216 |]
        | Some 366181 -> [| 366219;366220;366221 |]
        | Some 366178 -> [| 366222;366223;366224 |]
        | Some 366190 -> [| 366253;366254;366255 |]
        | Some 366179 -> [| 366257;366258;366259 |]
        | Some 366260 -> [| 366261;366262;366263 |]
        | Some 366264 -> [| 366265;366266;366267 |]
        | Some 366191 -> [| 366268;366269;366271 |]
        | Some 366180 -> [| 366272;366273;366274 |]
        | Some 366275 -> [| 366276;366277;366278 |]
        | Some 366193 -> [| 366279;366280;366281 |]
        | Some 366282 -> [| 366283;366284;366285 |]
        | Some 366194 -> [| 366286;366287;366288 |]
        | Some 365898 -> [| 365899;365900;365901 |]
        | Some 365995 -> [| 365996;365997;365998;365999 |]
        | Some 366570 -> [| 366571;366572;366573 |]
        | Some 366574 -> [| 366575;366576;366577 |]
        | Some 1338 -> [| 406;1841;2015;2156;2322;2393 |]
        | Some 1841 -> [| 1339;1340;1341;1342;1343;1346;1351;1352;1353;1354;1355;1359;1534;1535;1701;1945 |]
        | Some 366741 -> [| 366742;366743;366744 |]
        | Some 366752 -> [| 366753;366754;366755 |]
        | Some 1849 -> [| 1850;1851;1852;1853;1854;2402;2403;2404 |]
        | Some 1034 -> [| 499;500;501;1858;1860 |]
        | Some 1032 -> [| 983;1859 |]
        | Some 1332 -> [| 1333;1334;1335;1336;1337 |]
        | Some 1861 -> [| 1862;1863 |]
        | Some 65 -> [| 802;803;1888;1889 |]
        | Some 1021 -> [| 1022;1027;1864;1865 |]
        | Some 1022 -> [| 1866;1867;1868;1869 |]
        | Some 1872 -> [| 1873;1880;1907;1909 |]
        | Some 1883 -> [| 1884;1885;1886;1887 |]
        | Some 1897 -> [| 1898;1899;1900;1901;1902;1903;1904;1905;1906 |]
        | Some 1407 -> [| 1408;1822;1836;1943 |]
        | Some 1397 -> [| 1398;1399;1400;1401 |]
        | Some 1402 -> [| 1403;1404;1405;1406;1944 |]
        | Some 1566 -> [| 1567;1568;1570;1571;1572;1574;1575;1576;1577;1583;1938;1939;1940;2153;2248 |]
        | Some 1578 -> [| 430;905;1579;1580;1581;1582;1584;1585 |]
        | Some 1546 -> [| 1555;1556;1557;1558;1559;1560;1561;1562;1563;1564;1565 |]
        | Some 1711 -> [| 338;937;1712 |]
        | Some 214 -> [| 335;1536;1537;1538;1539;1540;1541;1542;1543;1544 |]
        | Some 252 -> [| 331;332;1525;1697;2134 |]
        | Some 1710 -> [| 325;1198;1707;1716;1809;2020 |]
        | Some 1545 -> [| 1547;1548;1549;1550;1551;1552;1553;1554 |]
        | Some 286 -> [| 289;290;291;792 |]
        | Some 287 -> [| 296;297;298;793 |]
        | Some 288 -> [| 292;293;295;794 |]
        | Some 944 -> [| 1202;1203;1204;1719 |]
        | Some 945 -> [| 1240;1241;1242;1720 |]
        | Some 946 -> [| 1243;1244;1245;1721 |]
        | Some 948 -> [| 1249;1250;1251;1723 |]
        | Some 949 -> [| 1252;1253;1254;1724 |]
        | Some 950 -> [| 1255;1256;1257;1725 |]
        | Some 951 -> [| 1258;1259;1260;1726 |]
        | Some 952 -> [| 1261;1262;1263;1727 |]
        | Some 953 -> [| 1264;1265;1266;1728 |]
        | Some 954 -> [| 1267;1268;1269;1729 |]
        | Some 1794 -> [| 1797;1798;1799;1800 |]
        | Some 1795 -> [| 1801;1802;1803;1804 |]
        | Some 1796 -> [| 1805;1806;1807;1808 |]
        | Some 406 -> [| 407;1008;1828;1829;1830;1834;1842;1843 |]
        | Some 1534 -> [| 1344;1345;1347;1348;1349;1350 |]
        | Some 1530 -> [| 359;1531;1532;1533 |]
        | Some 532 -> [| 618;619;620;621;622 |]
        | Some 1469 -> [| 1514;1515;1516;1517;1518 |]
        | Some 1470 -> [| 1512;1513 |]
        | Some 1471 -> [| 1507;1508;1509 |]
        | Some 1472 -> [| 1506 |]
        | Some 1473 -> [| 1498;1499;1500;1501;1502 |]
        | Some 1474 -> [| 1504 |]
        | Some 1475 -> [| 1505 |]
        | Some 1476 -> [| 1493;1494;1495;1496;1497 |]
        | Some 1477 -> [| 1489;1490;1491;1492 |]
        | Some 1478 -> [| 1484;1485;1486 |]
        | Some 1479 -> [| 1480;1481;1482;1483 |]
        | Some 1761 -> [| 1765;1766 |]
        | Some 1762 -> [| 1767;1768;1769 |]
        | Some 1763 -> [| 1770;1771;1772;1773;1774 |]
        | Some 1764 -> [| 1775;1776;1777 |]
        | Some 852 -> [| 866;867;868;2257 |]
        | Some 853 -> [| 869;870;871;2256 |]
        | Some 994 -> [| 995;996;997;1007 |]
        | Some 851 -> [| 102;103;105;503 |]
        | Some 849 -> [| 860;861;862;2254 |]
        | Some 850 -> [| 863;864;865;2255 |]
        | Some 990 -> [| 991;992;993;1004 |]
        | Some 848 -> [| 106;107;108;504 |]
        | Some 115 -> [| 914;1192 |]
        | Some 117 -> [| 917;920;927;998 |]
        | Some 118 -> [| 922;928;930;999 |]
        | Some 387 -> [| 923;929;931;1000 |]
        | Some 505 -> [| 1193;1194;2258;2259 |]
        | Some 580 -> [| 918;921;925;1001 |]
        | Some 581 -> [| 919;924;926;1002 |]
        | Some 968 -> [| 971;972;973;1003 |]
        | Some 1316 -> [| 1287;1317;2260;2261 |]
        | Some 120 -> [| 1199;1200;1201 |]
        | Some 846 -> [| 854;855;856;2252 |]
        | Some 847 -> [| 857;858;859;2253 |]
        | Some 986 -> [| 987;988;989;1006 |]
        | Some 845 -> [| 109;112;113;502 |]
        | Some 299 -> [| 309;312;313;597;1603 |]
        | Some 300 -> [| 306;307;308;598;1601 |]
        | Some 301 -> [| 302;303;305;599;1602 |]
        | Some 314 -> [| 315;316;318;390;617;975;1286;1526;1527;1528;2191;2192 |]
        | Some 1520 -> [| 320;1521;1529 |]
        | Some 205 -> [| 261;264;272;277;1617 |]
        | Some 206 -> [| 273;274;275;276 |]
        | Some 207 -> [| 278;279;280;281 |]
        | Some 208 -> [| 282;283;284;285;1389 |]
        | Some 408 -> [| 410;411;412;413 |]
        | Some 414 -> [| 415;416;417;418 |]
        | Some 419 -> [| 425;427;428;429 |]
        | Some 442 -> [| 443;444;445;446 |]
        | Some 453 -> [| 454;455;456;457 |]
        | Some 458 -> [| 459;461;462;463 |]
        | Some 496 -> [| 497 |]
        | Some 582 -> [| 583;584;585;586 |]
        | Some 588 -> [| 589;590;591;592 |]
        | Some 634 -> [| 635;636;637;638 |]
        | Some 782 -> [| 783;784;785;786 |]
        | Some 787 -> [| 788;789;790;791;1949 |]
        | Some 878 -> [| 884;885;886;887 |]
        | Some 879 -> [| 888;889;890;891 |]
        | Some 880 -> [| 892;893;894;895 |]
        | Some 881 -> [| 896;897;898;899 |]
        | Some 882 -> [| 900;901;902;903 |]
        | Some 883 -> [| 904 |]
        | Some 1045 -> [| 1046 |]
        | Some 391 -> [| 393;394;395;396;1631 |]
        | Some 5 -> [| 61;64;72;77;1616 |]
        | Some 399 -> [| 400;401;402;403 |]
        | Some 420 -> [| 421;422;423;424 |]
        | Some 432 -> [| 433;434;435;436 |]
        | Some 1065 -> [| 1066;1067;1068;1069 |]
        | Some 6 -> [| 73;74;75;76 |]
        | Some 437 -> [| 438;439;440;441 |]
        | Some 448 -> [| 449;450;451;452 |]
        | Some 824 -> [| 827;830;833;836 |]
        | Some 1070 -> [| 1071;1072;1073;1074 |]
        | Some 1138 -> [| 1139;1140;1141;1142 |]
        | Some 464 -> [| 465;466;467;468 |]
        | Some 823 -> [| 826;829;832;835 |]
        | Some 469 -> [| 470;471;472;473 |]
        | Some 822 -> [| 825;828;831;834 |]
        | Some 7 -> [| 78;79;80;81 |]
        | Some 1075 -> [| 1076;1077;1078;1079 |]
        | Some 1080 -> [| 1081;1082;1083;1084 |]
        | Some 761 -> [| 762;763;764;765;2288 |]
        | Some 766 -> [| 767;768;769;770;1950 |]
        | Some 812 -> [| 813;814;815;816;2287 |]
        | Some 817 -> [| 818;819;820;821;1392 |]
        | Some 1089 -> [| 1090;1091;1092;1093 |]
        | Some 8 -> [| 82;83;84;85;1390 |]
        | Some 629 -> [| 630;631;632;633 |]
        | Some 1815 -> [| 1816;1817;1818;1819 |]
        | Some 159 -> [| 837;838;839;911 |]
        | Some 685 -> [| 725;726;727;728;729 |]
        | Some 681 -> [| 720;721;722;723;724 |]
        | Some 555 -> [| 564;565;566;772 |]
        | Some 556 -> [| 561;562;563;771 |]
        | Some 559 -> [| 574;575;576;776 |]
        | Some 560 -> [| 577;578;579;775 |]
        | Some 557 -> [| 567;568;569;773 |]
        | Some 558 -> [| 570;572;573;774 |]
        | Some 140 -> [| 639;640;641;642;643;644;777;974;1827;2247;2351 |]
        | Some 143 -> [| 645;646;647;648;706;707;708;801;2032;2033 |]
        | Some 133 -> [| 1672;1673;1674;1675;1676;2240 |]
        | Some 134 -> [| 1049;1050;1051;1052 |]
        | Some 135 -> [| 1195;1196;1197 |]
        | Some 537 -> [| 1056;1057;1058;1059 |]
        | Some 538 -> [| 1053;1054;1055;2244 |]
        | Some 1018 -> [| 1060;1061;1062;1063 |]
        | Some 132 -> [| 1086;1087;1088;1931;1941 |]
        | Some 141 -> [| 380;381;382;383 |]
        | Some 128 -> [| 600;601;602;603;604 |]
        | Some 661 -> [| 689;690;691;2250 |]
        | Some 662 -> [| 692;693;694;2251 |]
        | Some 663 -> [| 695;696;697;910 |]
        | Some 664 -> [| 702;703;704;705;2242 |]
        | Some 668 -> [| 698;699;700;701;2243 |]
        | Some 656 -> [| 669;670;671;672;673;675;676;872 |]
        | Some 677 -> [| 715;716;717;718;719;967 |]
        | Some 779 -> [| 1633;1639;1640;1641;1642 |]
        | Some 1708 -> [| 711;712;713;714;1709;1717;1718;2018 |]
        | Some 1713 -> [| 935;1037;1038;1039;1040;1715;2151 |]
        | Some 616 -> [| 730;731;732;733;734;735;736;737 |]
        | Some 739 -> [| 740;741;742;743;744;745;746;747;748;749;750 |]
        | Some 150 -> [| 364;365;366;367;368;369;370;372;373;374;375;376;377;378;1110;1323;1745;1746;1747;1748;1823;1824;2152 |]
        | Some 379 -> [| 1651;1652;1653;1657;1658 |]
        | Some 1276 -> [| 1282;1283;1284 |]
        | Some 480 -> [| 479;481;594;595;596;1009 |]
        | Some 956 -> [| 1206;1207;1208;1730 |]
        | Some 957 -> [| 1210;1211;1212;1740 |]
        | Some 958 -> [| 1213;1214;1215;1739 |]
        | Some 960 -> [| 1219;1220;1221;1737 |]
        | Some 961 -> [| 1222;1223;1224;1736 |]
        | Some 962 -> [| 1225;1226;1227;1735 |]
        | Some 963 -> [| 1228;1229;1230;1734 |]
        | Some 964 -> [| 1231;1232;1233;1733 |]
        | Some 965 -> [| 1234;1235;1236;1732 |]
        | Some 979 -> [| 1237;1238;1239;1731 |]
        | Some 1779 -> [| 1782;1783;1784;1785 |]
        | Some 1780 -> [| 1786;1787;1788;1789 |]
        | Some 1781 -> [| 1790;1791;1792;1793 |]
        | Some 1659 -> [| 1660;1661;1662;1663;1664;1814 |]
        | Some 1660 -> [| 1810;1811 |]
        | Some 1384 -> [| 494;874 |]
        | Some 1612 -> [| 1614;1618;1619;1620;1621;1623;1624;1698;1699;1837;1838;1932;2115;2350 |]
        | Some 1362 -> [| 1365;1366 |]
        | Some 1369 -> [| 1370;1371 |]
        | Some 1703 -> [| 1704 |]
        | Some 1378 -> [| 1379;1380 |]
        | Some 1047 -> [| 1048 |]
        | Some 551 -> [| 605;606;608;2241 |]
        | Some 552 -> [| 609;610;611;612;613;778 |]
        | Some 798 -> [| 1912;1913 |]
        | Some 1522 -> [| 1919 |]
        | Some 1097 -> [| 1587;1588;1589;1590 |]
        | Some 1591 -> [| 1592;1593;1594;1595 |]
        | Some 54 -> [| 512;514;515;516;517;518;519;521;522;523;525;526;527;528;529;530 |]
        | Some 1810 -> [| 1812 |]
        | Some 1811 -> [| 1813 |]
        | Some 1922 -> [| 1923;1942;2358 |]
        | Some 367566 -> [| 365374;365946 |]
        | Some 365374 -> [| 367569 |]
        | Some 367570 -> [| 367486;367571 |]
        | Some 367771 -> [| 367772;367773;368655 |]
        | Some 1951 -> [| 1952;1953;2021;2034 |]
        | Some 368017 -> [| 368105;368106;368107;368108;368109;369216 |]
        | Some 368105 -> [| 368091 |]
        | Some 368106 -> [| 368019 |]
        | Some 368107 -> [| 368018 |]
        | Some 368108 -> [| 368020 |]
        | Some 368109 -> [| 368021 |]
        | Some 368667 -> [| 368668 |]
        | Some 368916 -> [| 368917 |]
        | Some 368918 -> [| 368919 |]
        | Some 368920 -> [| 368921 |]
        | Some 2015 -> [| 1356;2014;2016;2017 |]
        | Some 1962 -> [| 1964;1965;1966;1967 |]
        | Some 1972 -> [| 1984;1985;1986;1987;2318 |]
        | Some 2001 -> [| 2002;2003;2004;2005;2321 |]
        | Some 1954 -> [| 1955;1960;1968;1988;1989;1998;2006;2011;2119;2283;2306;2315 |]
        | Some 1960 -> [| 1961;1962;2022;2420 |]
        | Some 1968 -> [| 1970;1971;1972;1973;2094;2114;2277 |]
        | Some 1998 -> [| 1999;2001;2042 |]
        | Some 1999 -> [| 2000;2031 |]
        | Some 2011 -> [| 2012;2319 |]
        | Some 1961 -> [| 1963;2108 |]
        | Some 367593 -> [| 369212;369214 |]
        | Some 369212 -> [| 369213 |]
        | Some 369214 -> [| 369215 |]
        | Some 369216 -> [| 369217 |]
        | Some 369220 -> [| 369221 |]
        | Some 369222 -> [| 369223 |]
        | Some 369224 -> [| 369225 |]
        | Some 369226 -> [| 369227 |]
        | Some 369234 -> [| 353633;354534;367570 |]
        | Some 2023 -> [| 2024;2025;2026;2027 |]
        | Some 1988 -> [| 2028;2029;2064 |]
        | Some 2029 -> [| 2030;2063 |]
        | Some 2028 -> [| 1990;1991;1992;1993 |]
        | Some 2022 -> [| 2023;2109 |]
        | Some 1989 -> [| 2035;2036;2313 |]
        | Some 2035 -> [| 1994;1995;1996;1997 |]
        | Some 2036 -> [| 2037;2141;2309 |]
        | Some 2037 -> [| 2038;2039;2040;2041 |]
        | Some 2042 -> [| 2043;2044;2045;2046;2136;2320 |]
        | Some 2043 -> [| 2047;2048;2049;2050 |]
        | Some 2044 -> [| 2051;2052;2053;2054;2361 |]
        | Some 2045 -> [| 2055;2056;2057;2058 |]
        | Some 2046 -> [| 2059;2060;2061;2062 |]
        | Some 2064 -> [| 2065;2066;2067;2068;2369;2418 |]
        | Some 2065 -> [| 2069;2070;2071;2072 |]
        | Some 2066 -> [| 2073;2074;2075;2076 |]
        | Some 2067 -> [| 2077;2078;2079;2080 |]
        | Some 2068 -> [| 2081;2082;2083;2084;2362 |]
        | Some 2006 -> [| 2085;2086;2330;2337 |]
        | Some 2085 -> [| 2007;2008;2009;2010;2328 |]
        | Some 2086 -> [| 2087 |]
        | Some 2087 -> [| 2088;2089;2090;2091 |]
        | Some 2094 -> [| 2095;2096;2097;2098 |]
        | Some 1955 -> [| 2099;2100;2101;2311 |]
        | Some 2101 -> [| 1956;1957;1958;1959 |]
        | Some 2099 -> [| 2102 |]
        | Some 2100 -> [| 2103 |]
        | Some 2102 -> [| 2104;2105;2106;2107 |]
        | Some 2109 -> [| 2110;2111;2112;2113;2406 |]
        | Some 2114 -> [| 1969 |]
        | Some 2119 -> [| 2120 |]
        | Some 2136 -> [| 2137;2138;2139;2140 |]
        | Some 2141 -> [| 2142;2143;2144;2145 |]
        | Some 2146 -> [| 2147;2148;2149;2150 |]
        | Some 2125 -> [| 2126;2131;2132;2133 |]
        | Some 2157 -> [| 2159;2160;2339 |]
        | Some 2158 -> [| 2161;2162;2163;2164;2165;2166 |]
        | Some 2161 -> [| 2167;2168;2169;2170;2171;2172;2407 |]
        | Some 2162 -> [| 2173;2174;2187 |]
        | Some 2163 -> [| 2175;2176;2177;2186;2188;2415 |]
        | Some 2164 -> [| 2178;2179;2180;2185 |]
        | Some 2166 -> [| 2181;2182;2323 |]
        | Some 2178 -> [| 2183;2184 |]
        | Some 2179 -> [| 2189;2190 |]
        | Some 2199 -> [| 2200;2201 |]
        | Some 2202 -> [| 2206;2207;2208;2209;2210 |]
        | Some 2206 -> [| 2211;2212;2213;2214;2215;2216;2408 |]
        | Some 2207 -> [| 2218;2219 |]
        | Some 2208 -> [| 2220;2221;2222;2223;2224;2414 |]
        | Some 2209 -> [| 2226;2227;2228;2229 |]
        | Some 2226 -> [| 2230;2231 |]
        | Some 2210 -> [| 2232;2233;2332 |]
        | Some 2227 -> [| 2234;2235 |]
        | Some 2237 -> [| 1028;1313;2238 |]
        | Some 2262 -> [| 2263;2264;2265;2266 |]
        | Some 912 -> [| 2267;2268;2269;2270;2276;2325 |]
        | Some 2271 -> [| 2272;2273;2274;2275;2357 |]
        | Some 2277 -> [| 2278;2279;2280;2281 |]
        | Some 2283 -> [| 2285;2286 |]
        | Some 2297 -> [| 2298;2299;2300;2301;2302 |]
        | Some 2309 -> [| 2310;2356;2391;2392 |]
        | Some 2290 -> [| 2291;2292;2293;2294;2295 |]
        | Some 2311 -> [| 2312 |]
        | Some 2313 -> [| 2314 |]
        | Some 2315 -> [| 2316;2387;2388;2389;2390 |]
        | Some 2330 -> [| 2331 |]
        | Some 2333 -> [| 2334 |]
        | Some 2335 -> [| 2336 |]
        | Some 2337 -> [| 2338 |]
        | Some 2203 -> [| 2204;2205;2340 |]
        | Some 2204 -> [| 2341;2342;2343 |]
        | Some 2205 -> [| 2344;2345;2346 |]
        | Some 2340 -> [| 2347;2348;2349 |]
        | Some 2307 -> [| 2308;2353;2354;2355 |]
        | Some 2306 -> [| 2307;2359 |]
        | Some 2359 -> [| 2360 |]
        | Some 2369 -> [| 2370;2371;2372;2373 |]
        | Some 1970 -> [| 2374;2375 |]
        | Some 2374 -> [| 1974;1975;1976;1977 |]
        | Some 2375 -> [| 2376 |]
        | Some 1971 -> [| 2377;2378 |]
        | Some 2377 -> [| 1980;1981;1982;1983 |]
        | Some 2378 -> [| 2380 |]
        | Some 1973 -> [| 2381;2382 |]
        | Some 2381 -> [| 1978;1979;2092;2093 |]
        | Some 2382 -> [| 2383 |]
        | Some 2395 -> [| 2396;2397;2398;2400;2401 |]
        | Some 2236 -> [| 2409;2410 |]
        | Some 2410 -> [| 840;1310;2239 |]
        | Some 2409 -> [| 2411;2412;2413 |]
        | Some 2416 -> [| 2417 |]
        | Some 2418 -> [| 2419 |]
        | Some 2420 -> [| 2421 |]
