using Axolotl.Domain;

namespace Axolotl.Services
{
    public interface IDataService
    {
        Entry GetLatest();
    }

    public class DataService : IDataService
    {
        public Entry GetLatest()
        {
            var entry = new Entry
            {
                Title = "Axolotl <small><em>Ambustoma mexicanum</em></small>",
                Content = new[]
                {
                    new Content
                    {
                        SubHeading = "Introduction",
                        Text = @"
You will discover Axolotl's (pronounced <em>Ax-oh-lot-ul</em>)
background and biology.",
                        Media = new Media
                        {
                            MediaType = MediaType.Image,
                            Position = Position.Below,
                            Path = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQJHw8AguCg8ypo-APztRu62-gr2MOb2QDDVPNK5DG9uG0yx-A8"
                        },
                    },
                    new Content
                    {
                        SubHeading = "Amazing facts about an Axolotl - Its feathery headdress",
                        Text = @"
    <p>
        Their feathery headdress is not just for show.
    </p>
    <p>
        The impossibily silly branches that grow from the axolotl's head 
        might not seem practical, but they're actually the salamander's gills.
    </p>
    <p>
        The filaments attached to the long fills increase surface area for gas
        exchange.
    </p>
",
                        Media = new Media
                        {
                            Path = "https://s-media-cache-ak0.pinimg.com/736x/b1/ee/3f/b1ee3f0eaf4d738aca401da7fbdd201b.jpg",
                            MediaType = MediaType.Image,
                            Position = Position.Below
                        },
                    },
                    new Content
                    {
                        SubHeading = "Amazing facts about an Axolotl - Height and Weight",
                        Text = @"
    <p>
        Axolotl can reach the size of up to 12 inches in the length and the weight of up
        to 8 pounds.
    </p>
",
                        Media = new Media
                        {
                            MediaType = MediaType.Image,
                            Position = Position.Below,
                            Path = "http://www.caudata.org/forum/attachments/f46-beginner-newt-salamander-axolotl-help-topics/f48-axolotls-ambystoma-mexicanum/f62-axolotl-gallery/21017d1326170208-my-axolotl-buddy-bluegills-cimg4846.jpg"
                        },
                    },
                    new Content
                    {
                        SubHeading = "Amazing facts about an Axolotl - Gender",
                        Text = @"
    <p>
        Gender identification can be performed only by an expert,
        because males and females look similar.
    </p>
",
                        Media = new Media
                        {
                            MediaType = MediaType.Image,
                            Position = Position.Below,
                            Path = "http://bettahut.weebly.com/uploads/6/8/0/2/6802552/8327004_orig.jpg"
                        },
                    },
                    new Content
                    {
                        SubHeading = "Amazing facts about an Axolotl - Breathing",
                        Text = @"
    <p>
        Like most aquatic animals, axolotl breathes by using the gills.
    </p>
    <p>
        Besides gills, axolotl can breathe via skin, thanks to a desne
        network of capillaries.
    </p>
",
                        Media = new Media
                        {
                            MediaType = MediaType.Image,
                            Position = Position.Below,
                            Path = "http://www.caudata.org/cc/images/articles/illness/gill_fungus2.jpg"
                        },
                    },
                    new Content
                    {
                        SubHeading = "Axolotl's lifecycle",
                        Media = new Media
                        {
                            Path = "http://www.axolotl.org/images/physiology/small_stages.jpg",
                            Position = Position.Below,
                            MediaType = MediaType.Image
                        },
                    },
                    new Content
                    {
                        SubHeading = "What do axolotls eat?",
                        Text = @"
    <p>
        Axolotls eat worms, insects, small fish, and just about anything else that can 
        fit inside inside their mouth and swallow whole, including other salamanders.
    </p>
",
                        Media = new Media
                        {
                            Path = "https://i.ytimg.com/vi/vpTzXAy8ZkM/maxresdefault.jpg",
                            Position = Position.Above,
                            MediaType = MediaType.Image
                        },
                    },
                    new Content
                    {
                        SubHeading = "Colours of an axolotl",
                        Text = @"
    <p>
        Willd types vary somewhat in exact colour, but are generally shade of dark
        brown with black, yellowish, and shiny patches/speckles.
    </p>
    <p>
        Leucistic axolotls are white and pink.
    </p>
    <p>
        Leucistic axolotls are not albino, as they have black eyes, 
        and generally some varying pigment.
    </p>
    <p>
         Leucistic axolotls have pink grills on the top of their heads and backs.
    </p>
",
                        Media = new Media
                        {
                            Path = "https://s-media-cache-ak0.pinimg.com/564x/06/8c/5e/068c5e9d6b654688fa0cc56231280352.jpg",
                            Position = Position.Below,
                            MediaType = MediaType.Image
                        },
                    },
                    new Content
                    {
                        SubHeading = "How long do axolotls live?",
                        Text = @"
    <p>
        Axolotls are long-lived, surviving up to 15 years on a diet of mollucs, worms
        insect larvae, curstaceans, and some fish.
    </p>
    <p>
        Accustomed to being a top predator in its habitat, this species
        has begin to suffer from the introduction of large
        fish into its lake habitad.
    </p>
",
                        Media = new Media
                        {
                            MediaType = MediaType.Image,
                            Position = Position.Below,
                            Path = "http://img12.deviantart.net/32e9/i/2014/173/1/2/yawning_axolotl_by_threeleaves-d7nhqn4.jpg"
                        }
                    },
                    new Content
                    {
                        SubHeading = "Thank you :)",
                        Media = new Media
                        {
                            MediaType = MediaType.Image,
                            Position = Position.Below,
                            Path = "http://orig08.deviantart.net/76ce/f/2010/137/9/8/9825210dca31c1f971188b489867d8f8.png"
                        }
                    }
                }
            };
            return entry;
        }
    }
}