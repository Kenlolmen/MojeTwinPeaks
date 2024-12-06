﻿using Microsoft.EntityFrameworkCore;

namespace MojeTwinPeaks.Models
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("-");
        }

        public DbSet<Character> Characters { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
        new Character
        {
            ID = 1,
            Name = "Albert Rosenfield",
            Actor = "Miguel Ferrer",
            Born = "September 13, 1956",
            Gender = Character.GenderType.Male,
            Biography = "Albert Rosenfield is a brilliant yet acerbic forensic expert with the FBI who often assists Dale Cooper in his investigations. Known for his cutting wit and impatience with small-town life, Albert initially clashes with the residents of Twin Peaks, particularly Sheriff Truman and his deputies. However, beneath his sharp exterior lies a man deeply committed to justice and compassion. Over time, Albert reveals a softer side, earning the respect of his colleagues. His contributions are crucial in uncovering the supernatural elements surrounding Laura Palmer's murder and the sinister forces at play in the town.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Albert.jpg"
        },
        new Character
        {
            ID = 2,
            Name = "The Arm",
            Actor = "Michael J. Anderson",
            Born = "October 31, 1953",
            Gender = Character.GenderType.Other,
            Biography = "The Arm, also referred to as the 'Man from Another Place,' is one of the most enigmatic figures in *Twin Peaks*. Residing in the surreal, dreamlike Red Room within the Black Lodge, The Arm appears as a small, dancing man in a red suit, speaking in cryptic riddles and reversed speech. He serves as a guide for Agent Dale Cooper, offering both warnings and obscure clues about the nature of the Lodge and its connection to the real world. Symbolically, The Arm represents both a source of wisdom and a chaotic force, embodying the duality of light and darkness that permeates the Twin Peaks mythos.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/TheArm.jpg"
        },
        new Character
        {
            ID = 3,
            Name = "The Arm (Doppelgänger)",
            Actor = "Michael J. Anderson",
            Born = "",
            Gender = Character.GenderType.Other,
            Biography = "The Doppelgänger of The Arm is a twisted, malevolent version of the original, embodying the darker aspects of the Black Lodge. Manifesting as a sinister tree-like form with a grotesque, talking head, it is a disturbing and unpredictable presence. Unlike the original Arm, which offers cryptic guidance, this entity is openly hostile, serving as an obstacle to Dale Cooper’s journey through the Lodge. Its warped appearance and menacing demeanor reflect the nightmarish nature of the doppelgängers that haunt the Lodge, representing the corruption and chaos that lurks within.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/The Arm(doppelganger).jpg"
        },
        new Character
        {
            ID = 4,
            Name = "Monica Bellucci",
            Actor = "Monica Bellucci",
            Born = "September 30, 1964",
            Gender = Character.GenderType.Female,
            Biography = "Monica Bellucci appears in *Twin Peaks: The Return* in a dream sequence experienced by Gordon Cole. Playing herself, she becomes a key figure in the series' exploration of dreams, memory, and alternate realities. In the dream, Monica cryptically poses the question, 'Who is the dreamer?'—a line that resonates deeply with the show’s overarching themes of perception and existence. Her brief yet pivotal role underscores the surreal and metaphysical nature of *Twin Peaks*, as her presence bridges the gap between the real world and the dreamlike narrative of the series.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Monica Bellucci.jpg"
        },
        new Character
        {
            ID = 5,
            Name = "Annie Blackburn",
            Actor = "Heather Graham",
            Born = "July 29, 1970",
            Gender = Character.GenderType.Female,
            Biography = "Annie Blackburn is a kind-hearted and mysterious woman who becomes romantically involved with Agent Dale Cooper. She is the younger sister of the late Carolyn, whose death deeply affected Annie’s life. Annie arrives in Twin Peaks as a waitress at the Double R Diner, where she quickly forms a bond with Cooper. Despite her sweet nature, Annie's involvement with Cooper leads her to become entangled in the dark forces that plague the town. In *Twin Peaks: Fire Walk with Me*, her tragic fate is sealed when she is taken by the Black Lodge, marking her as a victim of the same evil forces that haunt the town.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Annie Blackburn.jpg"
        },
        new Character
        {
            ID = 6,
            Name = "BOB",
            Actor = "Frank Silva",
            Born = "",
            Gender = Character.GenderType.Other,
            Biography = "BOB is a malevolent entity and the embodiment of evil in *Twin Peaks*. He is a demonic spirit who possesses individuals, most notably Leland Palmer, and compels them to commit horrific acts. BOB is directly linked to the Black Lodge, and his physical appearance is often marked by a disheveled look and a terrifying smile. As the primary antagonist, BOB represents the dark side of human nature and the spiritual corruption that permeates the town. His presence is deeply unsettling, and his actions form the crux of the series’ supernatural conflict.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/BOB.jpg"
        },
        new Character
        {
            ID = 7,
            Name = "Andy Brennan",
            Actor = "Harry Goaz",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Andy Brennan is a well-meaning and slightly naive deputy at the Twin Peaks Sheriff's Department. Known for his kind heart and sensitivity, Andy often finds himself caught in situations that are beyond his understanding, particularly when dealing with the supernatural aspects of the town. Despite his initial lack of confidence, Andy proves himself to be a key member of the law enforcement team, particularly when it comes to solving the murder of Laura Palmer. His evolution from a bumbling officer to a more competent and decisive figure adds depth to his character.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Andy Brennan.jpg"
        },
        new Character
        {
            ID = 8,
            Name = "Lucy Brennan",
            Actor = "Kimmy Robertson",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Lucy Brennan is the sweet and often perplexing receptionist at the Twin Peaks Sheriff's Department. Known for her quirky and innocent nature, Lucy often finds herself at the center of various town intrigues, particularly in her romantic entanglements with Deputy Andy Brennan and Sheriff Truman. Lucy's charmingly eccentric personality adds a lighthearted element to the show, though she plays a significant role in helping to uncover critical details in the investigation into Laura Palmer's murder. Her love triangle with Andy and Dick Tremayne is one of the show's memorable subplots.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Lucy Brennan.jpg"
        },
        new Character
        {
            ID = 9,
            Name = "Bobby Briggs",
            Actor = "Dana Ashbrook",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Bobby Briggs is a complex and often contradictory character in *Twin Peaks*. Initially portrayed as the arrogant and rebellious high school boyfriend of Laura Palmer, Bobby is revealed to be more than just a typical ‘bad boy’. Throughout the series, Bobby evolves from a troubled teen into a more sympathetic figure as he struggles with his moral compass, especially following the death of Laura. He is deeply affected by the forces of the Black Lodge, and his storyline involves his efforts to deal with his family’s issues and his own inner turmoil. Bobby's transformation from a young, reckless man to someone with more depth and understanding makes him one of the series’ most dynamic characters.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Bobby Briggs.jpg"
        },
                new Character
                {
                    ID = 10,
                    Name = "Gerland Briggs",
                    Actor = "Don S. Davis",
                    Born = "",
                    Gender = Character.GenderType.Male,
                    Biography = "Gerland Briggs is a distinguished and dedicated military man who serves as a key figure in *Twin Peaks*. As the father of Bobby Briggs, he is a deeply principled individual, often at odds with his son’s rebellious nature. Gerland is also involved in the investigation into the supernatural events surrounding the town, particularly in his work with the military and the secret research on the phenomena tied to the Black Lodge. Despite his stern exterior, Gerland cares deeply for his family and is an important part of the town's moral backbone.",
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Gerland Briggs.jpg"
                },
        new Character
        {
            ID = 11,
            Name = "Shelly Briggs",
            Actor = "Madeleine Stowe",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Shelly Briggs is a waitress at the Double R Diner and the wife of Bobby Briggs. Despite her troubled marriage, Shelly is a strong and compassionate woman who forms close bonds with several characters in Twin Peaks, including Laura Palmer. Her story is one of survival, as she contends with the darker aspects of her life, including domestic violence. Shelly’s strength and resilience make her a beloved character, and her eventual escape from her abusive relationship marks a key turning point in her character’s development. Throughout the series, Shelly’s struggles and triumphs resonate deeply with the town’s overall themes of resilience.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Shelly Briggs.jpg"
        },
        new Character
        {
            ID = 12,
            Name = "Charlie",
            Actor = "Clark Middleton",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Charlie is a mysterious and intriguing character who appears in *Twin Peaks: The Return*. He is the partner of Shelley Johnson, providing her with a sense of stability amidst the turmoil in Twin Peaks. Charlie plays a small but significant role in the new series, as his relationship with Shelly offers a glimpse into the lives of the town's residents after the events of the original series. Though his presence is more subdued, Charlie represents the ordinary lives of people who have been touched by the strange occurrences in Twin Peaks.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Charlie.jpg"
        },
        new Character
        {
            ID = 13,
            Name = "Gordon Cole",
            Actor = "David Lynch",
            Born = "April 8, 1946",
            Gender = Character.GenderType.Male,
            Biography = "Gordon Cole is an eccentric and authoritative FBI regional director who frequently works alongside Agent Dale Cooper. Known for his booming voice (due to his hearing impairment) and his offbeat sense of humor, Gordon brings an air of surrealism and oddity to the FBI's investigation into the murder of Laura Palmer. He has a deep respect for Cooper and often provides wisdom and guidance in dealing with the strange events surrounding the town. Cole’s involvement with the Black Lodge and his own cryptic insights into the town’s mysteries add a layer of intrigue to his character.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Gordon Cole.jpg"
        },
        new Character
        {
            ID = 14,
            Name = "Dale Cooper",
            Actor = "Kyle McLachlan",
            Born = "August 22, 1963",
            Gender = Character.GenderType.Male,
            Biography = "Agent Dale Cooper is the central character of *Twin Peaks*, a highly intelligent and intuitive FBI agent assigned to investigate the murder of Laura Palmer. Cooper is known for his unconventional investigative methods, which include dream analysis, intuition, and spiritual guidance. His calm demeanor and philosophical musings make him a beloved figure within the town of Twin Peaks. Throughout the series, Cooper becomes deeply entangled with the supernatural forces surrounding the town, particularly the Black Lodge. His personal journey is as much about solving the mystery as it is about confronting the darkness within himself.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Dale Cooper.jpg"
        },
        new Character
        {
            ID = 15,
            Name = "Dale Cooper (Doppelgänger)",
            Actor = "Kyle McLachlan",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Dale Cooper’s doppelgänger is a dark and malevolent version of the beloved FBI agent. Created as a result of the supernatural forces surrounding the Black Lodge, Cooper's doppelgänger is a twisted reflection of the man he once was, embodying the darkest aspects of his personality. This version of Cooper is manipulative, violent, and ruthless, serving as a primary antagonist in *Twin Peaks: The Return*. The doppelgänger’s unsettling presence is an integral part of the series’ exploration of duality, and it serves as a constant reminder of the evil lurking in the town and in Cooper himself.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Dale Cooper (doppelganger).jpg"
        },
        new Character
        {
            ID = 16,
            Name = "Caroline Earle",
            Actor = "Anna Elmasri",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Caroline Earle is the late wife of Agent Dale Cooper and plays a significant role in his backstory. Caroline’s tragic death, which occurred before the events of *Twin Peaks*, is a key point in Cooper’s life, driving much of his motivations and actions. She was murdered by the sinister Windom Earle, a former FBI agent turned antagonist. Caroline's memory haunts Cooper throughout the series, and her death becomes part of the larger mystery involving the forces of good and evil. Caroline’s absence serves as a tragic reminder of the personal sacrifices Cooper has made in his pursuit of justice.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Caroline Earle.jpg"
        },
        new Character
        {
            ID = 17,
            Name = "Caroline Earle (Doppelgänger)",
            Actor = "Anna Elmasri",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "The doppelgänger of Caroline Earle appears in *Twin Peaks: The Return*, a twisted and corrupted version of the original Caroline. This version is a reflection of the evil and corruption that pervades the Black Lodge and is part of the larger theme of duality that runs throughout the series. The doppelgänger of Caroline is not a fully realized character but represents the manipulative and dark forces that use the appearance of familiar faces to further their sinister plans. She embodies the series' exploration of how evil can warp and distort reality.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Caroline Earle (doppelganger).jpg"
        },
        new Character
        {
            ID = 18,
            Name = "Windom Earle",
            Actor = "Kenneth Welsh",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Windom Earle is a former FBI agent who becomes a central antagonist in *Twin Peaks*. A highly intelligent and ruthless man, Earle was once Dale Cooper’s mentor and partner, but he turned to darkness after a personal tragedy, ultimately seeking power through the occult and the supernatural forces surrounding the town. Earle’s obsession with the Black Lodge and his desire for revenge against Cooper make him a formidable foe. He is manipulative, sadistic, and thoroughly dangerous, and his actions set much of the plot of the series into motion, culminating in his tragic and violent confrontation with Cooper.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Windom Earle.jpg"
        },
        new Character
        {
            ID = 19,
            Name = "Diane Evans",
            Actor = "Laura Dern",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Diane Evans is Agent Dale Cooper’s trusted assistant and confidante, known for her mysterious and almost omnipresent role in his investigations. Throughout the series, Diane is often heard but never seen, with her role primarily consisting of being the recipient of Cooper's recorded thoughts and musings. Diane’s relationship with Cooper is pivotal, providing him with an outlet for his personal reflections and philosophical thoughts. In *Twin Peaks: The Return*, Diane’s role expands, and she becomes a more central character, revealing deeper layers of her own involvement in the supernatural events surrounding the town. Diane's enigmatic presence adds to the surreal nature of the series.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Diane Evans.jpg"
        },
                new Character
                {
                    ID = 20,
                    Name = "Diane Evans (Tulpa)",
                    Actor = "Laura Dern",
                    Born = "",
                    Gender = Character.GenderType.Female,
                    Biography = "Diane Evans (Tulpa) is a dark, twisted version of the original Diane Evans, created as a supernatural construct or 'tulpa' within the *Twin Peaks* mythos. In *Twin Peaks: The Return*, the tulpa version of Diane represents the eerie and unsettling nature of doppelgängers and their ability to distort reality. The Diane tulpa is used by the sinister forces to manipulate Agent Cooper and plays a pivotal role in the series' exploration of identity, self, and the forces of good and evil. The contrast between the real Diane and her tulpa version highlights the theme of duality at the heart of the series.",
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Diane Evans (tulpa).jpg"
                },
        new Character
        {
            ID = 21,
            Name = "Fireman",
            Actor = "Carel Struycken",
            Born = "",
            Gender = Character.GenderType.Other,
            Biography = "The Fireman, also known as the Giant, is a mysterious and ethereal being who exists outside of the physical realm. He appears to Agent Dale Cooper as a guiding force in his investigation of the supernatural events in Twin Peaks. The Fireman offers cryptic advice and warnings to Cooper, helping him navigate the dangerous forces of the Black Lodge. Though his true nature remains enigmatic, the Fireman symbolizes the forces of light and protection, serving as a counterbalance to the dark powers that threaten the town. His role in the series is one of subtle intervention, guiding Cooper toward understanding the mysteries of the Lodge.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Fireman.jpg"
        },
        new Character
        {
            ID = 22,
            Name = "Maddy Ferguson",
            Actor = "Sheryl Lee",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Maddy Ferguson is Laura Palmer’s cousin and a central figure in the second season of *Twin Peaks*. Maddy comes to town to live with her aunt and uncle after Laura’s death and quickly becomes involved with the residents of Twin Peaks. She bears a striking resemblance to Laura, which causes tension in the town, particularly with James Hurley, who is emotionally drawn to her. Maddy is a kind-hearted and caring woman, but her presence in the town stirs up unresolved emotions related to Laura’s death. Her tragic fate is a key turning point in the series, highlighting the destructive power of the past and the inescapable darkness that haunts the town.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Maddy Ferguson.jpg"
        },
        new Character
        {
            ID = 23,
            Name = "Hawk",
            Actor = "Michael Horse",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Hawk is a Native American deputy at the Twin Peaks Sheriff's Department, known for his calm demeanor and deep wisdom. He is one of the few characters who seems to have a profound understanding of the spiritual and supernatural elements of Twin Peaks. Throughout the series, Hawk serves as an important ally to Agent Cooper, helping him uncover the town’s mysteries. Hawk’s heritage and connection to Native American traditions play a significant role in his understanding of the strange forces at work. He is also a trusted friend to Sheriff Truman, and his steady presence provides much-needed stability amidst the chaos of Twin Peaks.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Hawk.jpg"
        },
        new Character
        {
            ID = 24,
            Name = "Donna Hayward",
            Actor = "Lara Flynn Boyle",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Donna Hayward is one of Laura Palmer's best friends and a key character in *Twin Peaks*. As a teenager, Donna is deeply affected by the mystery of Laura’s death and becomes entangled in the investigation surrounding the town's secrets. Throughout the series, Donna displays strength and determination, but also struggles with her own personal conflicts, particularly in relation to her relationships with James Hurley and her discovery of Laura's hidden life. Donna's character arc reflects the themes of innocence lost and the search for truth, as she grapples with the harsh realities of the dark forces that lurk beneath the surface of Twin Peaks.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Donna Hayward.jpg"
        },
         new Character
         {
             ID = 25,
             Name = "Audrey Horne",
             Actor = "Sherilyn Fenn",
             Born = "",
             Gender = Character.GenderType.Female,
             Biography = "Audrey Horne is one of the most iconic characters in *Twin Peaks*, known for her beauty, sharp wit, and complex personality. As the daughter of Benjamin Horne, Audrey is initially portrayed as a rebellious teenager with a penchant for trouble, but she also displays intelligence and maturity as she becomes more involved in the mysteries surrounding the town. Audrey becomes romantically involved with Agent Dale Cooper and plays a key role in investigating the events surrounding Laura Palmer’s death. Her character arc is marked by her emotional growth and the unraveling of her family's dark secrets.",
             ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Audrey Horne.jpg"
         },
        new Character
        {
            ID = 26,
            Name = "Benjamin Horne",
            Actor = "Richard Beymer",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Benjamin Horne is a wealthy and powerful businessman who owns the Great Northern Hotel in Twin Peaks. He is a central figure in the town’s political and social life, but his outward charm masks a deeply troubled and morally compromised man. Benjamin is a complex character, involved in several dark dealings, including his role in the cover-up of Laura Palmer's murder. Over the course of the series, Benjamin’s character undergoes significant change, with moments of remorse and redemption, but he is also revealed to be connected to some of the darkest events in the town’s history. His family life, including his strained relationship with his daughter Audrey, adds depth to his character.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Benjamin Horne.jpg"
        },
        new Character
        {
            ID = 27,
            Name = "Richard Horne",
            Actor = "Eamon Farren",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Richard Horne is the son of Audrey Horne and, later, the dark product of the troubled Horne family. Introduced in *Twin Peaks: The Return*, Richard is a deeply disturbed and violent young man who represents the next generation of the Horne family's dysfunction. His presence in the series is marked by his criminal behavior and a general sense of malevolence that pervades his character. Richard's actions, particularly his involvement in various criminal activities, set him on a path that intersects with the supernatural elements of Twin Peaks, and his character further highlights the ongoing themes of generational trauma and the legacy of evil in the town.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Richard Horne.jpg"
        },
        new Character
        {
            ID = 28,
            Name = "Ed Hurley",
            Actor = "Everett McGill",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Ed Hurley is a kind-hearted and hard-working mechanic who is one of the more grounded characters in *Twin Peaks*. He is married to Nadine, but his true love is Norma Jennings, whom he has been separated from for years due to his marriage and other life circumstances. Ed is deeply loyal to those he loves, and his character arc revolves around his yearning for happiness and his desire to reconcile with Norma. Despite his long-suffering situation, Ed remains a figure of integrity in the chaotic world of Twin Peaks. His relationship with Norma plays a key role in the series’ exploration of love, fidelity, and the difficulty of finding happiness in a town plagued by darkness.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Ed Hurley.jpg"
        },
        new Character
        {
            ID = 29,
            Name = "James Hurley",
            Actor = "James Marshall",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "James Hurley is a sensitive and troubled young man who is caught in a web of emotional turmoil throughout *Twin Peaks*. A close friend of Laura Palmer, James finds himself at the center of a love triangle involving Laura and Donna Hayward. He is characterized by his intense inner conflict, often struggling with his feelings and his desires. James’s storyline is marked by his search for love and meaning, and his character represents the theme of youthful idealism and disillusionment. His journey is one of personal growth, but it is also one of loss, as he becomes embroiled in the darker forces of the town.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/James Hurley.jpg"
        },
        new Character
        {
            ID = 30,
            Name = "Nadine Hurley",
            Actor = "Wendy Robie",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Nadine Hurley is an eccentric and deeply troubled character in *Twin Peaks*. She is married to Ed Hurley but has a complex and sometimes dysfunctional relationship with him. Nadine is often seen as an outcast in the town due to her odd behavior, including her obsession with youth and her attempts to invent new technologies, such as her patented silent drape runners. Nadine’s character arc revolves around her mental health struggles and her desire for acceptance and love. Her storyline in *Twin Peaks* also touches on themes of lost potential and the emotional weight of unrealized dreams.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Nadine Hurley.jpg"
        },
        new Character
        {
            ID = 31,
            Name = "Phillip Jeffries",
            Actor = "David Bowie",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Phillip Jeffries is a mysterious and pivotal character in *Twin Peaks: The Return*. A former FBI agent, Jeffries becomes involved with the supernatural elements of the series, particularly the Black Lodge and the enigmatic forces that reside within it. His character is marked by his cryptic and surreal behavior, and his scenes often involve him speaking in a disjointed, fragmented manner. Jeffries’ role in the series is crucial for understanding the broader metaphysical and cosmic elements that tie into the supernatural forces affecting the town of Twin Peaks. His connection to otherworldly realms highlights the series’ exploration of alternate realities and the blurred line between the physical and spiritual worlds.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Phillip Jeffries.jpg"
        },
        new Character
        {
            ID = 32,
            Name = "Hawk Jennings",
            Actor = "Michael Horse",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Hawk Jennings is a Native American sheriff’s deputy who has a deep understanding of the spiritual and supernatural aspects of Twin Peaks. His role in the series is significant as he is one of the few characters who is not only involved in solving the mysteries of the town but is also attuned to the deeper, metaphysical elements that shape its fate. Hawk’s connection to his heritage and his role as a protector of Twin Peaks makes him an essential ally to Agent Cooper. His wisdom and calm demeanor are contrasted by the eerie and unsettling forces he faces, particularly as the boundaries between the physical and supernatural worlds begin to blur.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Hawk Jennings.jpg"
        },
        new Character
        {
            ID = 33,
            Name = "Norma Jennings",
            Actor = "Tanya Roberts",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Norma Jennings is the owner of the Double R Diner in Twin Peaks and is known for her warmth, kindness, and strong sense of morality. She serves as a nurturing figure in the town, providing comfort and support to the people who come to her diner. Norma is deeply involved in the town's community, but her personal life is complicated by her relationship with Ed Hurley, her troubled marriage, and her dreams of a better future. Throughout the series, Norma is a symbol of resilience and compassion, and her character is central to the exploration of love, loyalty, and the human desire for connection amidst the darkness of Twin Peaks.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Norma Jennings.jpg"
        },
        new Character
        {
            ID = 34,
            Name = "Dougie Jones",
            Actor = "Kyle MacLachlan",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Dougie Jones is a key character in *Twin Peaks: The Return*, portrayed by Kyle MacLachlan. Dougie is a man who, due to a supernatural intervention, loses his sense of self and becomes a blank slate. His personality is replaced by a childlike innocence and a profound sense of confusion, making him appear as a different person to those around him. As the story progresses, Dougie’s character serves as a conduit for the return of Agent Dale Cooper, whose consciousness is trapped within Dougie’s body. Through Dougie, the series explores themes of identity, transformation, and the metaphysical intersections between different realms of reality. His character arc is one of gradual rediscovery and rebirth.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Dougie Jones.jpg"
        },
        new Character
        {
            ID = 35,
            Name = "Janey Jones",
            Actor = "Naomi Watts",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Janey Jones is the wife of Dougie Jones, whose life becomes entangled with the supernatural events unfolding in Twin Peaks. Although she is initially unaware of the bizarre and eerie circumstances surrounding her husband’s transformation, Janey becomes increasingly involved in the mysterious happenings as she tries to piece together the changes in Dougie's behavior. Janey is portrayed as a strong and determined woman, balancing her own struggles with her relationship and the bizarre nature of her husband's situation. She is one of the more grounded characters in *Twin Peaks: The Return*, providing a sense of normalcy amidst the chaos.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Janey Jones.jpg"
        },
        new Character
        {
            ID = 36,
            Name = "Leo Johnson",
            Actor = "Eric DaRe",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Leo Johnson is a violent and abusive character who plays a pivotal role in the earlier seasons of *Twin Peaks*. He is the husband of Shelly Johnson and the town's primary antagonist in terms of domestic abuse. Leo is a drug dealer and a thug, and his sinister presence in the show causes tension and danger for the other characters, particularly for Shelly. He is involved in various illegal activities, and his actions contribute to the larger criminal undercurrent of the town. Leo’s character arc explores themes of abuse, power dynamics, and the eventual consequences of his violence. His eventual fate ties into the larger supernatural conflicts occurring in Twin Peaks.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Leo Johnson.jpg"
        },
        new Character
        {
            ID = 37,
            Name = "Judy",
            Actor = "Unknown",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Judy is a mysterious and powerful figure introduced in *Twin Peaks: The Return*. She is tied to the darker forces that haunt the town of Twin Peaks and is one of the central figures in the larger cosmic battle between good and evil. Her true identity and motivations remain shrouded in ambiguity, but she is linked to the corruption that has seeped into the town. Judy’s character represents a potent and malevolent force, connected to both the Black Lodge and other supernatural elements. Her presence hints at a larger, malevolent power that threatens not only the characters in Twin Peaks but also the balance of the universe itself.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Judy.jpg"
        },
        new Character
        {
            ID = 38,
            Name = "Log Lady",
            Actor = "Catherine Coulson",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "The Log Lady, also known as Margaret Lanterman, is a beloved and eccentric character in *Twin Peaks*. She is an older woman who carries a log with her at all times, believing that it is an important conduit for understanding the mysteries of the town. The Log Lady communicates cryptic and often poignant messages, serving as a bridge between the mundane world and the supernatural realm of Twin Peaks. She is deeply connected to the town’s mysteries, and her role is one of the more symbolic elements in the series. Through her cryptic log messages, Margaret often provides guidance and insight into the strange events unfolding in the town. Her wisdom and unique perspective make her one of the series’ most iconic and enigmatic figures.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Log Lady.jpg"
        },
        new Character
        {
            ID = 39,
            Name = "Catherine Martell",
            Actor = "Piper Laurie",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Catherine Martell is a central character in *Twin Peaks*, known for her cunning and manipulative nature. She is the owner of the Great Northern Hotel and is deeply involved in the town’s underworld, particularly in illegal business dealings. Catherine is a ruthless and ambitious woman, using her sharp intellect to manipulate those around her for personal gain. Her character is complex, as she often finds herself torn between her desire for power and her complicated family relationships, particularly with her brother Andrew Packard and her husband, the much less ambitious Pete Martell. Catherine’s story explores themes of greed, power, and betrayal, as well as the lengths to which she will go to achieve her goals.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Catherine Martell.jpg"
        },
        new Character
        {
            ID = 40,
            Name = "Pete Martell",
            Actor = "Jack Nance",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Pete Martell is a kind-hearted, gentle man who is married to Catherine Martell, though their relationship is strained due to Catherine’s manipulative and controlling nature. Pete is well-liked by the people of Twin Peaks and is a man of integrity, though he often finds himself caught in the web of intrigue spun by the darker characters in the town. He works as a fisherman and is deeply in love with his wife, despite the lack of reciprocation. Pete is one of the more down-to-earth characters in the series, providing a sense of stability amidst the chaos. His loyalty and sincerity make him a tragic figure, as he becomes unwittingly involved in the darker schemes of the town.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Pete Martell.jpg"
        },
        new Character
        {
            ID = 41,
            Name = "Mike",
            Actor = "Al Strobel",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Mike, also known as the One-Armed Man, is a pivotal character in *Twin Peaks*. Once a partner to BOB in committing violent acts, Mike undergoes a profound transformation after severing his connection with the malevolent spirit. Mike becomes a more morally aware character, dedicated to stopping BOB and the evil that lurks in the town. As the One-Armed Man, he is a tragic figure, embodying the consequences of his past actions. His role in the series is key in the fight against the supernatural forces that plague Twin Peaks, and his appearance is often marked by cryptic statements and a deep sense of urgency regarding the impending danger. Mike's redemption arc provides a glimmer of hope amidst the chaos of the series.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Mike.jpg"
        },
        new Character
        {
            ID = 42,
            Name = "Carrie Page",
            Actor = "Sheryl Lee",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Carrie Page is a character who appears in *Twin Peaks: The Return*, and her identity is intricately tied to the mysterious and supernatural elements of the series. She is introduced as a woman living in Odessa, Texas, who bears a striking resemblance to Laura Palmer, the central figure of the show. Carrie’s story is shrouded in ambiguity, as her life is marked by a sense of dislocation and confusion. The deeper significance of her character, and her connection to the long-dead Laura Palmer, is left open to interpretation, adding to the complex web of themes surrounding memory, identity, and the nature of reality that pervades *Twin Peaks*. Carrie’s appearance underscores the theme of duality and the blurring of the boundaries between the real and the unreal.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Carrie Page.jpg"
        },
        new Character
        {
            ID = 43,
            Name = "Laura Palmer",
            Actor = "Sheryl Lee",
            Born = "July 22, 1971",
            Gender = Character.GenderType.Female,
            Biography = "Laura Palmer is the central figure around whom the entire *Twin Peaks* mystery revolves. Her brutal murder in the first season serves as the catalyst for the investigation led by FBI agent Dale Cooper. Laura is portrayed as a complex character, embodying the duality of innocence and darkness. While she is a beloved figure in Twin Peaks, known for her beauty and kindness, she secretly leads a troubled life filled with secrets, abuse, and her connection to the supernatural forces that haunt the town. Throughout the series, Laura's story explores themes of trauma, the masks people wear, and the ways in which the past can continue to shape the present. Her tragic fate is one of the most poignant elements of the series, and her presence continues to resonate throughout the show, even after her death.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Laura Palmer.jpg"
        },
        new Character
        {
            ID = 44,
            Name = "Laura Palmer (Doppelgänger)",
            Actor = "Sheryl Lee",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "The Doppelgänger of Laura Palmer is a dark, malevolent version of the beloved town figure, created through the supernatural forces of the Black Lodge. This version of Laura embodies the twisted aspects of her identity, representing the corruption and evil that lies beneath the surface of her seemingly perfect life. The Doppelgänger is a harbinger of destruction, and her presence in Twin Peaks is tied to the larger battle between light and dark forces. This version of Laura serves as a disturbing reflection of her true self, showing how the darker aspects of the town have infected and corrupted the lives of its inhabitants. The Laura Palmer Doppelgänger is a tragic reminder of the duality of human nature and the power of the forces that shape people’s lives.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Laura Palmer (doppelganger).jpg"
        },
        new Character
        {
            ID = 45,
            Name = "Leland Palmer",
            Actor = "Ray Wise",
            Born = "July 20, 1940",
            Gender = Character.GenderType.Male,
            Biography = "Leland Palmer is a key character in *Twin Peaks*, whose life is marked by tragedy, violence, and deep psychological turmoil. He is the father of Laura Palmer and the husband of Sarah Palmer. Leland’s descent into madness is a central element of the show, as it is revealed that he was secretly possessed by the malevolent spirit BOB, who used Leland’s body to commit unspeakable acts, including the murder of his own daughter. Leland's character explores themes of guilt, the power of possession, and the devastating effects of trauma. His internal struggle between the man he once was and the dark forces controlling him makes him one of the most tragic figures in the series.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Leland Palmer.jpg"
        },
        new Character
        {
            ID = 46,
            Name = "Leland Palmer (Doppelgänger)",
            Actor = "Ray Wise",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "The Doppelgänger of Leland Palmer is the evil, twisted version of the real Leland, controlled by the malevolent spirit BOB. This doppelgänger represents the full manifestation of Leland's corruption and the possession that overtakes him, becoming a terrifying force that acts without any moral restraint. The Leland Palmer Doppelgänger serves as a manifestation of pure evil, representing the horror of BOB’s influence on the town and the personal devastation it causes. His actions are marked by violence and an overwhelming sense of loss, further deepening the tragedy of Leland’s character and the twisted legacy he leaves behind.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Leland Palmer (doppelganger).jpg"
        },
        new Character
        {
            ID = 47,
            Name = "Sarah Palmer",
            Actor = "Grace Zabriskie",
            Born = "April 18, 1941",
            Gender = Character.GenderType.Female,
            Biography = "Sarah Palmer is the mother of Laura Palmer and the wife of Leland Palmer. She is a key figure in *Twin Peaks*, though much of her backstory is shrouded in mystery. Throughout the series, Sarah appears as a tragic and disturbed woman who has been deeply affected by the loss of her daughter, Laura. Her connection to the supernatural world is hinted at, especially through her visions and experiences with the malevolent forces in the town. Sarah’s character becomes more complex as the series progresses, revealing the deep emotional scars she carries and her own haunting relationship with the evil that has plagued her family. Her role underscores the theme of maternal grief and the lingering trauma that reverberates through generations.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Sarah Palmer.jpg"
        },
        new Character
        {
            ID = 48,
            Name = "Ronette Pulaski",
            Actor = "Phoebe Augustine",
            Born = "July 29, 1971",
            Gender = Character.GenderType.Female,
            Biography = "Ronette Pulaski is a troubled young woman who becomes a central figure in the investigation of Laura Palmer's murder. After being found in a catatonic state near the railroad tracks, she becomes a key witness to the horrific events surrounding Laura’s death. Ronette is a victim of abuse and manipulation, and much of her story is defined by the trauma she has endured. Her involvement with both Laura Palmer and the mysterious forces in Twin Peaks highlights the pervasive darkness in the town. Throughout the series, Ronette's character grapples with the aftermath of her experiences, struggling to cope with her past while trying to survive the haunting forces that continue to loom over her.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Ronette Pulaski.jpg"
        },
        new Character
        {
            ID = 49,
            Name = "Jean Renault",
            Actor = "Michael Parks",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Jean Renault is a villainous character in *Twin Peaks*, a member of the criminal underworld who operates in the shadows of the town. He is involved in various illegal activities, including drug trafficking and working as a part of the Renault family’s criminal operations. Jean is a cold and calculating individual with a ruthless streak, and his actions are often driven by a desire for power and control. As the story unfolds, Jean's role in the broader narrative becomes more significant as he becomes a central figure in the town's criminal activities, serving as both a physical and symbolic threat to the characters trying to uncover the truth about Laura Palmer’s death.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Jean Renault.jpg"
        },
        new Character
        {
            ID = 50,
            Name = "Jaques Renault",
            Actor = "Walter Olkewicz",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Jaques Renault is a sleazy and morally ambiguous character in *Twin Peaks*. A member of the Renault family, Jaques operates as a low-level drug dealer and a key figure in the town's criminal underground. He is deeply involved in the illicit activities surrounding Laura Palmer’s death and the subsequent investigation. Jaques' role in the series is largely defined by his connection to the darker elements of Twin Peaks, and his complex relationship with other characters, particularly the residents of the town, adds a layer of tension and danger. Despite his questionable morals, Jaques is a tragic figure, caught in the grip of the criminal world and the forces that shape his actions.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Jaques Renault.jpg"
        },
        new Character
        {
            ID = 51,
            Name = "Harold Smith",
            Actor = "Lenny von Dohlen",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Harold Smith is a reclusive and introverted character in *Twin Peaks*. He lives a solitary life, tending to his plants and rarely interacting with others. Harold is emotionally fragile, with a past marked by loss and trauma. His character plays a pivotal role in the investigation of Laura Palmer’s death when it is revealed that he holds a significant connection to Laura's diaries. Harold's vulnerability and isolation contrast sharply with the darker, more dangerous elements of the town. His character’s arc is a tragic exploration of grief, isolation, and the psychological toll of unresolved pain.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Harold Smith.jpg"
        },
        new Character
        {
            ID = 52,
            Name = "Dick Tremayne",
            Actor = "Ian Buchanan",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Dick Tremayne is a charming yet egotistical character in *Twin Peaks*. He is a well-groomed, confident man with a flair for fashion, and works as a salesman at Horne's Department Store. Dick’s persona is that of a playboy, constantly seeking the attention of women, particularly in his relationships with Lucy Brennan and later, Shelly Briggs. Though he often presents himself as an arrogant and self-absorbed individual, Dick's character develops over time, revealing more depth and vulnerability. His interactions with other residents of Twin Peaks often bring both humor and tension to the series, adding complexity to the town's social dynamics.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Dick Tremayne.jpg"
        },
        new Character
        {
            ID = 53,
            Name = "Mrs. Tremond",
            Actor = "Frances Bay",
            Born = "",
            Gender = Character.GenderType.Female,
            Biography = "Mrs. Tremond is a mysterious and unsettling character in *Twin Peaks*. She resides in the house that becomes a focal point of strange occurrences. Along with her grandson, she becomes involved in the supernatural elements of the series, particularly through her association with the enigmatic box that serves as a conduit to the Black Lodge. Mrs. Tremond is an enigmatic figure whose quiet, almost ethereal presence hints at the deeper, darker forces at work in Twin Peaks. Her character embodies the town’s connection to the supernatural, representing the strange and inexplicable aspects of the town that remain unexplained and unsettling.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Mrs. Tremond.jpg"
        },
        new Character
        {
            ID = 54,
            Name = "Pierre Tremond",
            Actor = "Michael J. Anderson",
            Born = "",
            Gender = Character.GenderType.Male,
            Biography = "Pierre Tremond is the grandson of Mrs. Tremond and a mysterious figure in *Twin Peaks*. Like his grandmother, Pierre is involved in the supernatural elements of the town, particularly the mysterious box that plays a key role in the series' exploration of the Black Lodge. His connection to the bizarre events that unfold in Twin Peaks ties him to the darker, otherworldly forces that govern the town. Pierre’s unsettling presence contributes to the series’ atmosphere of dread and uncertainty, as he embodies the unknowable and supernatural aspects of the town that remain unresolved.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Pierre Tremond.jpg"
        },
        new Character
        {
            ID = 55,
            Name = "Harry S. Truman",
            Actor = "Michael Ontkean",
            Born = "July 24, 1946",
            Gender = Character.GenderType.Male,
            Biography = "Harry S. Truman is the dedicated and calm sheriff of Twin Peaks. A steady presence in the face of the town’s many mysteries and tragedies, Truman is deeply loyal to his friends and colleagues. Throughout the series, he works closely with FBI Agent Dale Cooper in the investigation of Laura Palmer's murder. His relationship with the townspeople reflects his compassion and desire to protect them from the evil forces lurking in the shadows. Truman’s personal life, including his relationship with Josie Packard, adds layers to his character, making him one of the most grounded and sympathetic figures in the series.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Harry S. Truman.jpg"
        },
        new Character
        {
            ID = 56,
            Name = "Woodsman",
            Actor = "Various actors (depending on scene)",
            Born = "",
            Gender = Character.GenderType.Other,
            Biography = "The Woodsman is a mysterious and ominous figure in *Twin Peaks*, embodying the dark, supernatural forces that pervade the town. Appearing in *Twin Peaks: The Return*, the Woodsman is depicted as an eerie, ghostly presence with an unsettling aura. He is associated with the Black Lodge and is often seen in connection with the town’s more nightmarish and disturbing events. The Woodsman’s role is symbolic of the pervasive evil that lurks in the shadows of Twin Peaks, a malevolent force that works in the background to sow chaos and suffering in the lives of the town’s residents.",
            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/characterimages/Woodsman.jpg"
        }
        );
        }
        
    }
}
