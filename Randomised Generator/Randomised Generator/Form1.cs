using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomised_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Randomise_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(0, 6);

                switch (rInt)
            {
                case 0:
                    Skillbooks(r, true);
                    Skillbooks(r, false);
                    break;

                case 1:
                    History(r, true);
                    History(r, false);
                    break;

                case 2:
                    Anatomy(r, true);
                    Anatomy(r, false);
                    break;

                case 3:
                    Arcane(r, true);
                    Arcane(r, false);
                    break;

                case 4:
                    Legends(r, true);
                    Legends(r, false);
                    break;

                case 5:
                    Stories(r, true);
                    Stories(r, false);
                    break;

                case 6:
                    Botany(r, true);
                    Botany(r, false);
                    break;
            }


        }

        private void Skillbooks(Random r, bool Title)
        {
            int rInt = r.Next(0,6);
            if (Title)
            {

                switch(rInt)
                {
                    case 0:
                        TitleBox.Text = "Let's play dead";
                        break;
                    case 1:
                        TitleBox.Text = "Taste of Victory";
                        break;
                    case 2:
                        TitleBox.Text = "Shock and Awe";
                        break;
                    case 3:
                        TitleBox.Text = "Smuggler’s Teachings";
                        break;
                    case 4:
                        TitleBox.Text = "Liber ex Vasis";
                        break;
                    case 5:
                        TitleBox.Text = "A Herbalist's Guide to Surviving";
                        break;
                }
            }
            else
            {
                switch(rInt)
                {
                    case 0:
                        BookText.Text = "This 100 or so page volume consists of a childlike representation with several brightly coloured pictures of various recipes to prepare the dead for undeath.";
                        break;

                    case 1:
                        BookText.Text = "The book details a fencing techniques, with focus on various dirty tricks you can use to win a duel and get away with it.";
                        break;

                    case 2:
                        BookText.Text = "The book contains 20 basic campfire recipes, which are described in great detail and accompanied by multitude of illustrations. Anybody can use this book to craft one of the 20 meals, all of which make use of venison or other meat.";
                        break;

                    case 3:
                        BookText.Text = "The collected teachings of a dozen master blacksmiths, armourers, and artificers, walks the reader step by step through the art of metalwork, from the most basic of tools to the creation of magic weapons and armour. The text is accompanied by dozens of intricately detailed plates showing tools and techniques.";
                        break;

                    case 4:
                        BookText.Text = "A rather thin volume about the comestible plant life found in the Underdark and the different ways to prepare them. The author begins by explaining his firsthand experience tasting and testing all the recipes and flora available to the underdark. After detailing a few recipes, the writings become more rambly and saccaded. A certain plant begins to come up in several of the recipes towards the end of the book. The final page is just a repetition of that same plant's name over and over again until the words just trail off the page.";
                        break;

                    case 5:
                        BookText.Text = "This diary details the accounts a famous halfling smuggler, who was best known for smuggling his home made rum into kingdoms throughout the world during the great alcohol depression. With proper study the reader can reproduce the famous Sweetfoot Rum recipe from the different mentions, hints and references scattered across the pages of this book.";
                        break;
                }
            }
        }

        private void History(Random r, bool Title)
        {
            int rInt = r.Next(0, 8);

            if (Title)
            {
                switch(rInt)
                {
                    case 0:
                        TitleBox.Text = "For the Good of the Nation";
                        break;

                    case 1:
                        TitleBox.Text = "The Dragon's Downfall";
                        break;

                    case 2:
                        TitleBox.Text = "The Elemental Chaos and the Resulting Planes";
                        break;

                    case 3:
                        TitleBox.Text = "The True Rulers of Our Countries";
                        break;

                    case 4:
                        TitleBox.Text = "The Secret Heroes and Abominations";
                        break;

                    case 5:
                        TitleBox.Text = "Tales of times past";
                        break;

                    case 6:
                        TitleBox.Text = "The Fall of the Empire";
                        break;

                    case 7:
                        TitleBox.Text = "Gold in Ashes";
                        break;
                }
            }
            else
            {
                switch (rInt)
                {
                    case 0:
                        BookText.Text = "Autobiography of a wandering merchant, who often found himself in war torn countries and always had something to sell, even if he hadn't.";
                        break;

                    case 1:
                        BookText.Text = "This argumentative text, written by one Colonel Tavon Coyle, stresses the importance of overwhelming force when responding to foreign attacks. (“When the world is watching, one must prove that an attack upon oneself or one’s nation is folly.”) It is typically used to defend the use of downright vile acts during times of war by invoking a sense of patriotism and community. It has been criticised for dehumanising the enemy, and for being far too eager when it comes to giving carte blache authority to military commanders.";
                        break;

                    case 2:
                        BookText.Text = "This tome, bound in dragon scales, will only show its true contents to those it deems worthy. To the unworthy, it consists of a rather somber description of a period of time in which the dragon's ruled the Forgotten Realms and their inevitable downfall where the dragons were taken down by an army of the combined forces of the world's humanoid races. However, to a worthy lector, the script changes entirely and, in draconic, a tale is woven of the true downfall. The humanoid races were powerless to the dragons, but the chromatics grew vain and the metallics could no longer tolerate their greed. Thus, the metallics aided the humanoids to stage an uprising and the chromatics were banished to the Inner Planes. But, the humanoids grew greedy and tricked the metallics banishing them with their kindred. The tale ends on an ominous note of plans for the dragons' imminent return.";
                        break;

                    case 3:
                        BookText.Text = "A controversial document in and of its own right, this book talks about the creation of the Prime Material and Inner planes. A thin volume which only contains 4 pieces of paper, however these papers are magically enchanted to pass through the thousands of pages of content which this book holds. The author of the document seems almost too knowing on the subject, almost as if he were there...";
                        break;

                    case 4:
                        BookText.Text = "The original manuscript of the much-reproduced text, its well-reputed author's final work. The chronicle itself passingly mentions a rumoured artefact, the legendary Ladle of the Chef (commonly believed to be myth) as though its existence is fact. Careful reading might uncover second text that lays below the current one, scraped out, but not gone completely.";
                        break;

                    case 5:
                        BookText.Text = "This book contains recipes for various desserts and essays on their historical perspective and impacts.";
                        break;

                    case 6:
                        BookText.Text = "On the surface, this appears to merely be a recounting of the opulent Haloan Empire's fall from power centuries ago. Some claim, however, that careful analysis reveals it as a scathing commentary on the notoriously corrupt court of King Judicus, written in code to keep the author from harm.";
                        break;

                    case 7:
                        BookText.Text = "A historical analysis of the last attacks on the primaterial plane by both the gith and the modrons. The focus of it is a comparison of their vastly different tactics and what little the defenders learned of their invader's cultures.";
                        break;
                }
            }
        }

        private void Anatomy(Random r, bool Title)
        {
            int rInt = r.Next(0, 4);

            if (Title)
            {
                switch (rInt)
                {
                    case 0:
                        TitleBox.Text = "Cultures Unknown";
                        break;

                    case 1:
                        TitleBox.Text = "Short essay on the subject of marine life";
                        break;

                    case 2:
                        TitleBox.Text = "What those guts told me.";
                        break;

                    case 3:
                        TitleBox.Text = "Codex Draconis";
                        break;
                }
            }
            else
            {
                switch (rInt)
                {
                    case 0:
                        BookText.Text = "This truly massive tome features everything from text heavy pages without a hint of illustration, to brilliant anatomical illustrations that cover multiple pages. It is the magnum opus of a brilliant wizard known for her astute observations and nigh unhealthy obsession with dragons, who sadly perished during a wyvern attack while searching for a dragon graveyard in an isolated mountain chain; had she not perished she would likely have continued revising her work, as she had done for many decades beforehand. Some rarer versions have even been known to feature moving pictures, especially those of dragons in flight and their breath. While it contains a staggering amount of information, it is also very academically challenging and quite rare; as a result it is rarely found outside of restricted library sections, wizards' libraries, and the hoards of academically inclined dragons, especially blue and silver ones.";
                        break;

                    case 1:
                        BookText.Text = "An exhaustive exploration of the bodies of goblins, hobgoblins, and bugbears. It appears highly reputable, but no other surgeon has ever been willing to replicate the results presented here.";
                        break;

                    case 2:
                        BookText.Text = "Not only does this book go in-depth on the history of these creatures and their faraway worlds, it also tells that they are really into gardening and the various flowers, vegetables and fruits they have cultivated.";
                        break;

                    case 3:
                        BookText.Text = "A detailed biological survey of aquatic species in a lake near the authors residence.";
                        break;
                }
            }
        }

        private void Arcane(Random r, bool Title)
        {
            int rInt = r.Next(0, 12);

            if (Title)
            {
                switch (rInt)
                {
                    case 0:
                        TitleBox.Text = "The Forgotten Art";
                        break;

                    case 1:
                        TitleBox.Text = "From Beyond the Veil";
                        break;

                    case 2:
                        TitleBox.Text = "Edicts of Incantations";
                        break;

                    case 3:
                        TitleBox.Text = "Arcane Secrets";
                        break;

                    case 4:
                        TitleBox.Text = "Sinister Discoveries";
                        break;

                    case 5:
                        TitleBox.Text = "Theatrical Uses of Illusion";
                        break;

                    case 6:
                        TitleBox.Text = "Antipodean Harmonies";
                        break;

                    case 7:
                        TitleBox.Text = "A children's guide to necromancy";
                        break;

                    case 8:
                        TitleBox.Text = "Skritzlbon's Contraptions";
                        break;

                    case 9:
                        TitleBox.Text = "Liminal Zones and You";
                        break;

                    case 10:
                        TitleBox.Text = "Elements and Elementals";
                        break;

                    case 11:
                        TitleBox.Text = "From Ghouls to Ghosts";
                        break;
                }
            }
            else
            {
                switch (rInt)
                {
                    case 0:
                        BookText.Text = "This massive tome is a fine source of information about all things undead, and was written by one Lord Zeiram, who later ascended to lichhood. It has long been rumoured that it is a good starting point for a would-be lich, and it has thus been banned in many a jurisdiction, but truth be told it is of little use when it comes to becoming a lich, unless one counts the potential benefit of more effective minions.";
                        break;

                    case 1:
                        BookText.Text = "This introductory tome is required reading at many a magical academy, but is of relatively little value in regards to the truly esoteric. Introduces the various elements and elementals, and discusses the purpose/traits of the various elemental planes and the elemental chaos.";
                        break;

                    case 2:
                        BookText.Text = "This book is a standalone work from eccentric elven author Marybeth Hight, a scholar of the Feywild and its denizens. It was originally intended as a primer for would-be plane shifters and astral travellers, but the manuscript was partially destroyed in a fire and now the contents are damaged. The current owner has gone mildly insane trying to piece the manuscript back together, and has scrawled almost two year's worth of ramblings and half-thoughts in the margins of the text. While the work no longer primes the reader for the act of travelling to the Feywild, the combination of reading materials contained within the folio binding now prep the reader's mind for the bewildering and maddening magics encountered there (giving advantage against the enchantment and illusion effects created by denizens of the Feywild)";
                        break;

                    case 3:
                        BookText.Text = "A generous manuscript contains description of inner workings of various contraptions and automatons and instruction manual to programming automatons, allowing any intermediate transmuter to create their very own contraptions!";
                        break;

                    case 4:
                        BookText.Text = "Reading this little book takes about an hour. It contains complete instructions how to cast two cantrips from the wizard list of spells, allowing the reader to cast them for the remainder of the day.";
                        break;

                    case 5:
                        BookText.Text = "A dry but informative text detailing the blending of Positive Energy and Negative Energy (which he refers to as “the Holy Antipodes”) to better access healing and harming magics. It’s an insightful work for healers and necromancers alike, but those who read carefully and follow Sahl’s train of logic may unlock a new path of power (read gain access to a prestige class).";
                        break;

                    case 6:
                        BookText.Text = "Written by the mage playwright Rodger Goldhammer, this semi autobiography shows how the famed thespian worked intricate illusion spells into his plays. Chapters included 'Combining natural and magical light', 'Canned vs conjured thunder: a discussion', and 'Loss of concentration, or why it is vital to wear undergarments beneath an illusionary costume'.";
                        break;

                    case 7:
                        BookText.Text = "This book contains procedures regarding conjuring and exorcising ancient horrors of the deep seas.";
                        break;

                    case 8:
                        BookText.Text = "Rather well known and a piece of every wizard’s library, this book contains instructions on divination basics, and tips how to not anger the customers with unfortunate events to come.";
                        break;

                    case 9:
                        BookText.Text = "When opened, this book creates an spectral dog that starts reproducing the book contents with the skill of experienced rhetorician. Given it's a dog, it's speech consists of different barks, whines and howls. The actual contents are studies regarding blink dogs. Why this book was named the way it was is a mystery not even the author knows answer to.";
                        break;

                    case 10:
                        BookText.Text = "A collection of stories and essays focusing on a first-hand account of the journey from life to death told to the author by a ghost, a resurrected individual or a soul called forth from the other realms. Critics suggest she sensationalizes the tales a bit to make death sound more frightening than it is, to which she challenges them to explore death on their own and then come back to talk about it.";
                        break;

                    case 11:
                        BookText.Text = "The book is chaotic and hard to understand, written in an unknown dialect which makes it very slow to read. Contained within are the studies of a powerful necromancer on how interplanar travel might be used to achieve functional immortality.";
                        break;
                }
            }
        }

        private void Legends(Random r, bool Title)
        {
            int rInt = r.Next(0, 10);

            if (Title)
            {
                switch (rInt)
                {
                    case 0:
                        TitleBox.Text = "A Sheep's Tail";
                        break;

                    case 1:
                        TitleBox.Text = "Tale of Cons and Scams";
                        break;

                    case 2:
                        TitleBox.Text = "A Night to Remember";
                        break;

                    case 3:
                        TitleBox.Text = "The Stonemason's Son";
                        break;

                    case 4:
                        TitleBox.Text = "The Unaligned Monk";
                        break;

                    case 5:
                        TitleBox.Text = "The Story of Graye";
                        break;

                    case 6:
                        TitleBox.Text = "The Creepy Crawly Cremation Story";
                        break;

                    case 7:
                        TitleBox.Text = "The Cryptic Crystalline Crucifixion Story";
                        break;

                    case 8:
                        TitleBox.Text = "Most Holy of Knights";
                        break;

                    case 9:
                        TitleBox.Text = "Travellers Musings";
                        break;
                }
            }
            else
            {
                switch (rInt)
                {
                    case 0:
                        BookText.Text = "A propagandic tale featuring two main characters: A delusional young man who joins an order of paladins and sets about “restoring good and order to the world” and a young necromancer who only wants to help people. The story ends with the paladin murdering the necromancer, as the necromancer had spent his magical powers healing some innocent villagers who were hurt in a goblin raid. It has been theorised that the story might have been written and distributed by an ancient vampire wizard as part of his smear campaign against so called 'good' organised religions and militant orders, but this has never been conclusively proven.";
                        break;

                    case 1:
                        BookText.Text = "The first instalment of Critter and his friends' adventures! Watch as they journey into the Underdark searching for some bountiful booty to bring back home. Critter and his friends soon discover that the denizens of the Underdark don't take kindly to guests. Read carefully as duergars, and drow pin Critter's friends' still live bodies to crosses while torturing their mutilated bodies for being the filthy thieves that they are! A journey of friendship, kindness, dark and unending wallows of despair, and bravery that's fun for the whole family!";
                        break;

                    case 2:
                        BookText.Text = "Follow Critter and his new friends in their wacky adventures across the Forgotten Realms! They've been up to some crazy hijinxes together ever since they first met. In this latest instalment, watch as Critter and his friends are pursued by the demons of the Nine Hells for betraying a pact with Lolth. Critter gets to watch in stunned horror as each of his friends is burnt to a crisp by a demonic army! Read carefully as they discover the value of friendship, kindness, fire, and bravery!";
                        break;

                    case 3:
                        BookText.Text = "A young kobold falls for her laconic draconic master in this classic tale of love, taboo, discovery, and betrayal.";
                        break;

                    case 4:
                        BookText.Text = "A story in the form of a collection of letters from a dwarf stonemason's son that left the trade to be an adventurer.";
                        break;

                    case 5:
                        BookText.Text = "The story of a slave forced to be a pit-fighter who turned to meditation as an escape from his violent life. This book is not well written, and is probably an earlier work of a novice author that never reached wide spread fame.";
                        break;

                    case 6:
                        BookText.Text = "A short story that describes a case where the shadow realm spills into the material plane and haunts the small town of Graye.";
                        break;

                    case 7:
                        BookText.Text = "A book filled with full-page illustrations with small captions (in an esoteric language) that tell the story of a man who seeks to fight criminals by dressing up and scaring them. If the reader doesn't know the language, it appears to be about a vampire.";
                        break;

                    case 8:
                        BookText.Text = "Written like a child's book with colorful pictures. Details a murderous sheep that is burned after slaying a whole town. Then reborn as an evil sheep spirit.";
                        break;

                    case 9:
                        BookText.Text = "Within is what seems to be a collection of short stories. To anyone that can read the thieves cant, the book is a guide on how to gain membership to the thieves guilds.";
                        break;
                }
            }

        }

        private void Stories(Random r, bool Title)
        {
            int rInt = r.Next(0, 6);

            if (Title)
            {
                switch (rInt)
                {
                    case 0:
                        TitleBox.Text = "The Night's Embrace";
                        break;

                    case 1:
                        TitleBox.Text = "Collected Work of Reginald of Urholm";
                        break;

                    case 2:
                        TitleBox.Text = "Egdemort's Travels";
                        break;

                    case 3:
                        TitleBox.Text = "The Best Tales of Nameless Cults";
                        break;

                    case 4:
                        TitleBox.Text = "Stories from the Orkholds";
                        break;

                    case 5:
                        TitleBox.Text = "Children's Tales of Death and Hugs";
                        break;
                }
            }
            else
            {
                switch (rInt)
                {
                    case 0:
                        BookText.Text = "A book about the primordial titans, mostly legend and myth, collected by an eccentric young wizard who travelled the planes looking for information about them. This book is highly frustrating to scholars because the last entry is the beginning of a summary of an actual historical document, which has never been found. The book is unfinished and the wizard has not been seen for hundreds of years.";
                        break;

                    case 1:
                        BookText.Text = "Collection of seven orc legends, written in simple language that is easy to read. It can be used to each someone to read Orkish. The stories include: a tale of Gor'tak the Plunderer, who conquered an elven city and was brought down when he stole a cursed axe; the tale of Gor'tak's son Mur'nal, who tried to break the axe and two and ended up with two cursed axes; two stories about the half-orc twins Robald and Eron and their contests of strength (like when Eron tried to lift a mountain, but his feet didn't find any grip and he sunk away in the mud); and finally, three stories of the voyages of Zyarr the drunken priest and the times he ended up in a roc's nest, a frozen cave stocked with booze (all frozen solid), and Asmodeus' bathtub.";
                        break;

                    case 2:
                        BookText.Text = "A very fun collection of fairytales where half the time the protagonist dies horribly.";
                        break;

                    case 3:
                        BookText.Text = "This set of tales centres on a bard of yore who had a collection of magical tuning forks. These he assembled in the form of the instrument he dubbed the Octarion, which, when played by his expert thumping produced a temporary Portal to other worlds. The book details his wanderings and adventures in these other worlds and sadly ends with his fatal wounding at an unfortunate tea-party turned duel in the Feylands. The epilogue reveals that the tales are penned by his companion, the priest Lucedol of Tuftsburg who met the bard on his first adventure (in this book) in fact freeing him from the clutches of the dreaded Lugomorphs of Artuick-Fell. The two became inseparable friends who ever after had the other's back... until that day.";
                        break;

                    case 4:
                        BookText.Text = "A collection of poems written by an orcish adventurer and skald. The majority of the book is an epic saga, recounting the various deeds of the adventuring party the poet was a part of, with later short poems about specific aspects of adventurers' lifestyle. The later poems touch on a wide array of topics, such as the joys of a shared victory, longing for hearth and home, and the simple pleasure of splitting a foe in half lengthwise.";
                        break;

                    case 5:
                        BookText.Text = "A series of romantic novels featuring romance between vampires and humans which tries to cast vampires as villified people who just want to live in peace, while simultaneously overlooking their intense thirst for blood and blithe disregard for the lives of others. Parts of the books have been described as downright obvious attempts at convincing the reader that formally inviting strangers into ones' home is common courtesy and that sunlight is highly overrated. It conveniently fails to mention the vampiric weakness to running water, while simultaneously trying to spread awareness about potamophobia (the fear of rivers or running water).";
                        break;
                }
            }

        }

        private void Botany(Random r, bool Title)
        {
            int rInt = r.Next(0, 2);

            if (Title)
            {
                switch (rInt)
                {
                    case 0:
                        TitleBox.Text = "Our Friend the Cactus";
                        break;

                    case 1:
                        TitleBox.Text = "The Inner Workings of a Gulthias Tree";
                        break;
                }
            }
            else
            {
                switch (rInt)
                {
                    case 0:
                        BookText.Text = "Written by a dwarf wizard by the name of Daven Wraithmail, this treatise explains the growth and upkeep of a Gulthias Tree as well as several manners to corrupt seeds of other trees in order to create a suitable vessel. An entire chapter is dedicated to the domestication of the resulting blights which sprout from said tree and their training to better protect your new sapling.";
                        break;

                    case 1:
                        BookText.Text = "A dense academic treaty on the biology of cacti. If one has the patience it is very interesting in its own way. The book also details a large number of edible cacti, as well as those that can be used as water sources in the harsh deserts.";
                        break;
                }
            }
        }
    }
}
