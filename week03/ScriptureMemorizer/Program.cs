using System;
//The changes that I made to this is making the scriptures a list where it contains various scriptures. Each time you run the program it will give you a new scripture
// The next thing that I did was to determine how many words are hidden based on whether the scripture has one or several verses.
class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();

        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(new Reference("Proverbs",3,5,6), "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"));
        scriptures.Add(new Scripture(new Reference("Helaman",5,12), "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."));
        scriptures.Add(new Scripture(new Reference("Alma", 7, 11,13), "11 And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. \n12 And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.\n13 Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me."));
        scriptures.Add(new Scripture(new Reference("John", 3, 16),"For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"));
        scriptures.Add(new Scripture(new Reference("Moroni", 10, 3, 4), "3 Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts.\n4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."));

        Scripture scripture = scriptures[random.Next(scriptures.Count)];
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if(input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsSingleVerse())
            {
                scripture.HideRandomWords(3);
            } 
            else
            {
                scripture.HideRandomWords(5);
            }

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}