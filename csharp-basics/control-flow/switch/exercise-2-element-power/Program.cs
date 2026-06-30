string element = "Fire";

string power = element switch
{
    "Fire" => "You wield Inferno Blast – enemies fear your flames.",
    "Water" => "You wield Tidal Wave – the ocean bends to your will.",
    "Wind" => "You wield Storm Gale – you move faster than the eye can see.",
    "Earth" => "You wield Terra Crush – mountains crumble before you.",
    _ => "Unknown element – have you even awakened yet?"
};

Console.WriteLine(power);