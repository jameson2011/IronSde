namespace IronSde.Universe
open IronSde
module internal Moons=
    let moons solarSystemId = 
        match solarSystemId with
        | x when x <= 30000398 -> Moons0.moons solarSystemId
        | x when x <= 30000795 -> Moons1.moons solarSystemId
        | x when x <= 30001192 -> Moons2.moons solarSystemId
        | x when x <= 30001589 -> Moons3.moons solarSystemId
        | x when x <= 30001986 -> Moons4.moons solarSystemId
        | x when x <= 30002383 -> Moons5.moons solarSystemId
        | x when x <= 30002779 -> Moons6.moons solarSystemId
        | x when x <= 30003175 -> Moons7.moons solarSystemId
        | x when x <= 30003571 -> Moons8.moons solarSystemId
        | x when x <= 30003967 -> Moons9.moons solarSystemId
        | x when x <= 30004363 -> Moons10.moons solarSystemId
        | x when x <= 30004759 -> Moons11.moons solarSystemId
        | x when x <= 30005156 -> Moons12.moons solarSystemId
        | x when x <= 31000128 -> Moons13.moons solarSystemId
        | x when x <= 31000524 -> Moons14.moons solarSystemId
        | x when x <= 31000920 -> Moons15.moons solarSystemId
        | x when x <= 31001316 -> Moons16.moons solarSystemId
        | x when x <= 31001712 -> Moons17.moons solarSystemId
        | x when x <= 31002108 -> Moons18.moons solarSystemId
        | x when x <= 31002504 -> Moons19.moons solarSystemId
        | _ -> [||]
