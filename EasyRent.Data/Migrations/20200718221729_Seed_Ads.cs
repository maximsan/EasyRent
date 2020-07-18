using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyRent.Data.Migrations
{
    public partial class Seed_Ads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "AdId", "Description", "IsGift", "Location", "MaxDays", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Sit dolores eaque saepe id ducimus saepe. Dolores quia velit voluptate dolores est at debitis dolor dolorum. Dolorem quasi repudiandae quis dolores similique eum. Et tenetur voluptate. Suscipit error dolores eum et fugit recusandae. Quasi est sunt.", false, "Gradyton", 4, 58.92m, "Unbranded Steel Mouse" },
                    { 73, "Aperiam voluptas et et laboriosam. Aut nihil impedit sunt mollitia officia eveniet vitae quis eos. Tenetur aspernatur magni non hic aut voluptates recusandae odit deleniti. Est doloribus nisi dolor qui et debitis fuga sit adipisci. Dicta ea perferendis aut eum.", false, "East Hallieborough", 28, 539.13m, "Fantastic Soft Bacon" },
                    { 72, "Dolorum soluta est. Asperiores quia aspernatur mollitia perspiciatis magni laudantium delectus. Possimus nam est esse saepe voluptatem consequuntur nisi. Dicta amet et. Tenetur ut et officia doloremque sit iusto porro tenetur facere.", false, "Hagenesbury", 9, 401.77m, "Fantastic Metal Salad" },
                    { 71, "Nostrum molestiae corporis. Et exercitationem exercitationem quia magnam et laborum eaque aut. Ut officiis similique doloribus assumenda sunt iusto error aut. Id et hic dolore eaque et.", false, "New Arvilla", 18, 157.06m, "Handmade Fresh Bike" },
                    { 70, "Aspernatur eius eos. Nam ducimus sit qui odit dolor. Repudiandae aut accusantium voluptas id.", false, "Port Geoffrey", 27, 1.52m, "Small Frozen Table" },
                    { 69, "Est ut consequatur voluptas eum. Earum non ut nisi delectus autem. Ea illum autem. Esse perferendis impedit quia omnis illum laboriosam. Velit voluptatem quo aperiam fuga et neque aliquid quis facere. Rem incidunt non perferendis cum dolorem.", false, "South Dayanastad", 24, 16.11m, "Tasty Cotton Gloves" },
                    { 68, "Voluptas quas quidem est perspiciatis nulla. Eligendi dolorum vel. Voluptatibus numquam nesciunt et odio est voluptatum. Voluptates voluptatum et vel vitae fugiat quia.", false, "Shieldsbury", 24, 780.94m, "Tasty Rubber Car" },
                    { 67, "Fuga neque reprehenderit et molestias ipsum. Harum aut debitis unde dolores. Quia rerum omnis ipsum velit sequi natus accusantium ut.", false, "East Kaden", 21, 797.26m, "Sleek Fresh Mouse" },
                    { 66, "Occaecati rerum perferendis totam rem numquam. Rerum dolorem sequi natus. Aut eveniet est. Quas et quaerat. Recusandae ut sed eos voluptates ducimus cum eos omnis.", false, "South Nona", 18, 28.90m, "Handmade Plastic Tuna" },
                    { 65, "Vero possimus consectetur voluptatem id placeat et eveniet. Vel possimus eum ut aliquid qui qui. Assumenda voluptatem repellendus explicabo neque enim tempore sed deserunt minima. Soluta iure et non tempora nisi enim sint dolore ut. Est debitis quo aliquid suscipit voluptas nam qui.", false, "South Abigale", 16, 671.77m, "Generic Soft Towels" },
                    { 64, "Aliquam voluptatum ratione et deleniti nam. Suscipit voluptatem unde explicabo fugiat explicabo voluptatibus. Magnam modi alias accusamus eum eum debitis porro omnis. Magni enim iusto. Magnam qui nemo id non quo.", false, "North Londonchester", 28, 148.29m, "Practical Cotton Cheese" },
                    { 63, "A placeat veniam sit mollitia non sed. Error cum sapiente sequi aut eligendi. Ullam iusto hic enim dignissimos est quia ducimus. Est laboriosam illo reprehenderit non vitae aut. Qui beatae ratione laborum laudantium laboriosam. Iste adipisci omnis sed in qui omnis laudantium suscipit et.", false, "Vancemouth", 29, 402.75m, "Refined Soft Gloves" },
                    { 62, "Velit expedita accusantium quis. Qui provident iste et laborum voluptatem repellendus doloremque autem id. Omnis quibusdam et quae temporibus excepturi in dolor est. Cumque dolore ut et vitae est suscipit totam optio rerum. Cum aut commodi placeat ex natus dicta minus. Assumenda aliquam est.", false, "Manntown", 11, 806.90m, "Fantastic Metal Ball" },
                    { 61, "Iste est voluptas perspiciatis. Magnam repudiandae consequuntur amet facilis. Ullam eligendi ab aperiam vel veniam voluptates veritatis optio asperiores.", false, "Schmelerstad", 9, 757.39m, "Incredible Fresh Shirt" },
                    { 60, "Iure voluptatem omnis enim dolore incidunt. Sunt nihil sunt voluptate quis cupiditate tempore illo. Reiciendis id deserunt ea omnis vel modi eum possimus rem. Velit ad ipsum distinctio veniam sit debitis est facere adipisci. Cumque dolor architecto pariatur facere cupiditate iure ut cum ad.", false, "Leannonfort", 25, 880.40m, "Incredible Metal Towels" },
                    { 59, "Id dolor amet doloribus voluptatem dolor aspernatur tempore. Nesciunt nobis reiciendis incidunt facere accusamus nisi neque architecto. Labore hic aut qui nihil quia explicabo quibusdam.", false, "East Tyrese", 29, 408.75m, "Licensed Rubber Shoes" },
                    { 58, "Minus alias atque eum. Asperiores ut porro atque est et sunt quisquam. In eveniet a qui veritatis dolor dicta quae. Aliquam architecto et. Vel rerum minus voluptate sint beatae ut aliquam.", false, "Lake Carrie", 8, 866.00m, "Refined Wooden Tuna" },
                    { 57, "Ut saepe nostrum mollitia. Quas atque sunt ea id sint. Accusamus nam voluptatibus amet hic iste et sequi recusandae. Necessitatibus aut assumenda voluptas. Earum vero officiis sunt et nihil ratione. Voluptate quis doloribus aut vero autem nulla quia et unde.", false, "Stanleyhaven", 17, 218.59m, "Rustic Metal Fish" },
                    { 56, "Fugiat voluptas et dolorem veniam adipisci iste veniam voluptas ut. Quis aut ut. Dolores accusamus aliquam provident ipsa quos voluptatem delectus. Nemo corrupti quia necessitatibus corporis. Officia rem commodi vero esse atque id.", false, "South Nyasiamouth", 17, 404.63m, "Ergonomic Concrete Tuna" },
                    { 55, "Repellat reiciendis quas. Sed velit voluptas animi praesentium ipsum omnis accusantium quos consequuntur. Molestiae mollitia animi magnam minima. Dignissimos eligendi id odio quas voluptates fugiat magnam consequatur. Saepe assumenda sapiente vitae fugiat dolorem harum enim.", false, "Schillermouth", 17, 392.92m, "Rustic Fresh Chair" },
                    { 54, "Ut aut consectetur molestias minus ex dolores quia magni. Quia ea reprehenderit. Reiciendis praesentium aliquam distinctio ipsam voluptatem qui magni excepturi qui. Ut sit consequatur vitae consequatur. Est aut qui harum consequuntur perferendis natus molestiae.", false, "Leannonfurt", 9, 263.35m, "Unbranded Metal Car" },
                    { 53, "Labore sed natus atque voluptas mollitia magnam provident maiores ab. Quia nesciunt cupiditate maxime quia recusandae fugit voluptas ipsam occaecati. Nam voluptas voluptatem unde. Totam natus officiis. Voluptate odio et accusantium sed ipsa fugiat et commodi. Id labore quia quasi expedita incidunt perferendis aut molestiae ea.", false, "North Janisview", 1, 456.24m, "Intelligent Wooden Gloves" },
                    { 74, "Vitae cupiditate repellat et incidunt totam asperiores optio porro. Esse alias in sed. Provident est nihil aut assumenda sint earum quam. Qui optio qui et amet id deserunt consequatur.", false, "Lake Peterton", 11, 697.33m, "Small Rubber Pants" },
                    { 52, "Recusandae in sunt neque. Aut dolore incidunt autem. Expedita animi voluptatem placeat a. Dolores modi quaerat maiores.", false, "Howellmouth", 19, 603.52m, "Incredible Concrete Pizza" },
                    { 75, "Sequi quod sed perferendis dolores. Consequatur est quae et. Quaerat qui aut dolore est provident quia molestiae. Fugit harum ab necessitatibus tempore ea facilis.", false, "North Marisolbury", 13, 201.01m, "Handcrafted Concrete Chair" },
                    { 77, "Adipisci sunt sapiente qui. Placeat ipsam non nisi veniam quis. Totam sit voluptatem fugit velit.", false, "East Rosinafurt", 20, 985.69m, "Practical Granite Car" },
                    { 98, "Ratione est quis ullam fuga vero. Rerum est dolores consequatur. Et possimus id fugit maiores eveniet est. Nulla dolorem sint perferendis cumque at qui asperiores enim. Quidem occaecati dolorum et nihil ducimus dolores quia est ipsa. Eos animi qui.", false, "East Lemuel", 28, 235.89m, "Rustic Plastic Soap" },
                    { 97, "Aut et quos ducimus quia molestiae cumque et. Occaecati velit dolores in in itaque sunt illo quas fuga. Ut quia consequatur quia non.", false, "Lake Rossfurt", 30, 249.67m, "Incredible Granite Salad" },
                    { 96, "Est iure quia nulla tenetur facilis accusantium. Fugit repellat ut rerum. Occaecati ad magnam et ipsam. Doloremque consequatur omnis et molestiae impedit omnis et sunt. Inventore quos est voluptas ea velit totam molestiae.", false, "East Arlo", 6, 327.82m, "Licensed Rubber Soap" },
                    { 95, "Nemo optio magni dignissimos consequuntur corporis repudiandae deleniti provident ut. Libero deleniti rerum natus corrupti optio sit. Nemo non a inventore accusamus et. Ab fugit neque est quia ut et laborum sapiente.", false, "Weberfurt", 28, 742.99m, "Gorgeous Cotton Bike" },
                    { 94, "Sequi odit iste. Architecto molestiae totam at quisquam accusantium et ipsam quisquam. Sint id et. Magni voluptas perspiciatis ut unde. Beatae illo quae. Et voluptas delectus illo.", false, "Port Addie", 13, 442.44m, "Incredible Steel Soap" },
                    { 93, "Ullam enim quia quo ut. Officia consequatur commodi blanditiis minus iure. Neque molestias repellat sed sed sit saepe dolor doloremque est.", false, "Lake Rosemarieborough", 13, 87.39m, "Generic Granite Chicken" },
                    { 92, "Ad repudiandae laudantium alias ipsum sapiente esse voluptatum fugiat ullam. Maiores ipsa optio ratione enim. Id ut laborum necessitatibus tempore qui explicabo. Hic quidem fugit sed impedit laudantium blanditiis culpa qui. Dolor vero eum numquam nisi qui vel cum. Aut fugiat inventore vero dicta deleniti expedita.", false, "Leonberg", 1, 602.70m, "Intelligent Cotton Keyboard" },
                    { 91, "Asperiores molestiae est ullam velit. Delectus optio voluptatem eum iure. Accusamus at molestias voluptates suscipit.", false, "Brakusmouth", 7, 789.28m, "Intelligent Plastic Pizza" },
                    { 90, "Non quasi esse id corporis eum ipsam. Blanditiis omnis saepe libero modi voluptatem omnis totam. Architecto distinctio in voluptate distinctio voluptas et reprehenderit asperiores.", false, "Jaylenmouth", 6, 639.16m, "Practical Metal Car" },
                    { 89, "Vel molestiae quisquam ut quia ipsam omnis repellendus iste dolor. Quis voluptatem nisi consequuntur nihil beatae dicta quo necessitatibus id. Fugit et dignissimos fuga nihil aut natus ea esse velit. Architecto nobis qui sit quam dolore non.", false, "Leopoldoview", 19, 325.32m, "Gorgeous Frozen Chips" },
                    { 88, "Dolores voluptate quis dolorem in. Commodi earum alias consequatur et enim asperiores. Omnis tempora dolores eligendi sunt nam accusantium maiores et. Quod voluptatem quam non. Qui aut consequatur.", false, "South Brentborough", 11, 933.51m, "Gorgeous Wooden Ball" },
                    { 87, "Maiores fugiat omnis doloremque eos autem ut laborum. Ut est soluta ut voluptatum voluptatem vero voluptatem excepturi. Deserunt eum ut quis totam eveniet qui molestias id. Aliquid id eum cum. Iste placeat eos ut placeat. Aspernatur est nam dolorum odio repudiandae iure aliquid.", false, "Trantowside", 3, 778.46m, "Gorgeous Concrete Fish" },
                    { 86, "Et dolore ad impedit repudiandae totam ipsam maxime quo. Occaecati ut consequuntur et sunt neque. Labore incidunt nesciunt sit. Dolores quia sed minima mollitia nobis omnis. Soluta corrupti odit suscipit placeat sapiente corporis adipisci laudantium omnis. Ut culpa rerum ullam est nihil alias ullam cupiditate deserunt.", false, "New Madelynnfort", 1, 750.08m, "Tasty Rubber Tuna" },
                    { 85, "Voluptate placeat quisquam debitis adipisci ut. Fugiat saepe nemo voluptatem dolor maxime et. Magnam consequatur nemo eveniet mollitia qui cumque. Magnam natus ducimus quidem dolores enim et dolor consequatur. Culpa ut vel voluptatem. Quis exercitationem aspernatur qui.", false, "Kattiefurt", 27, 687.68m, "Handmade Cotton Bacon" },
                    { 84, "Sed quis quibusdam ipsum eligendi molestiae numquam aut praesentium. Iure odit voluptas aut. Alias enim consequuntur. Dicta deleniti rerum eligendi et rem vero cum.", false, "Hobartfort", 3, 75.10m, "Intelligent Wooden Hat" },
                    { 83, "Ducimus quos officiis totam quos culpa corrupti. Quia illum et rerum. Ab consequuntur eius culpa odio facilis explicabo architecto consequatur et.", false, "Port Lorenzside", 25, 745.23m, "Fantastic Soft Chips" },
                    { 82, "Voluptatem unde numquam reprehenderit quam dolores qui voluptatum magni dignissimos. Minima eaque et necessitatibus eius. Voluptatem quibusdam magni rem eum tempore maxime. Quo consequatur delectus enim enim autem harum nisi maiores omnis. Rerum amet quas nihil illo nam accusantium qui.", false, "Dimitriside", 6, 219.99m, "Unbranded Rubber Shirt" },
                    { 81, "Vel et voluptates. Doloremque voluptates aspernatur eius at in et. Adipisci qui nesciunt saepe.", false, "South Waltonton", 4, 109.60m, "Intelligent Granite Chips" },
                    { 80, "Ipsa dignissimos ea sit fugiat esse voluptatem. Velit asperiores temporibus dolore ut at sint vitae modi. Reprehenderit id voluptatibus aut. Corporis fugit reiciendis quo tempora qui numquam. Harum aliquid aut nemo rerum alias aut architecto sed.", false, "North Erickstad", 30, 566.84m, "Handmade Cotton Bacon" },
                    { 79, "Dicta aut dolorem est placeat ratione beatae molestiae. Eos tenetur possimus excepturi esse non et rem. Iure ea dignissimos et et. Autem id est est.", false, "Ondrickaburgh", 22, 171.32m, "Incredible Rubber Salad" },
                    { 78, "Quo eos reiciendis aut. Vel ipsum quia laboriosam distinctio sit dicta et. Quas doloremque expedita. Est et laboriosam commodi temporibus officia deleniti quaerat rem omnis.", false, "South Theresebury", 10, 112.32m, "Fantastic Concrete Gloves" },
                    { 76, "Aut eveniet dolor repellat unde error velit totam. Repellat sunt molestiae corrupti ullam dignissimos aut dolor. Eligendi ipsam nisi qui non consequatur provident. Esse ullam inventore quos fugiat. Dolore nulla enim doloremque.", false, "North Ashley", 15, 477.55m, "Intelligent Soft Tuna" },
                    { 51, "Odio earum cumque rem tenetur cupiditate magni. Eum vel esse voluptatem ut laboriosam voluptas. Autem perspiciatis aut. Minima facilis cum ipsa officiis quidem omnis. Laboriosam eligendi sequi sequi. Ea hic temporibus in.", false, "Fritschhaven", 22, 490.73m, "Handcrafted Cotton Sausages" },
                    { 50, "Velit veniam magni quos vel suscipit. Illo beatae praesentium. Accusamus commodi ut repudiandae. Qui aspernatur dolore sed eum at. Atque illum suscipit.", false, "West Dortha", 28, 118.47m, "Awesome Metal Mouse" },
                    { 49, "Veritatis reiciendis perspiciatis veritatis aut qui sed consequatur sapiente et. Laudantium eligendi eius temporibus. Et beatae consequatur aut in quia aut.", false, "East Oraland", 5, 731.20m, "Small Wooden Soap" },
                    { 22, "Et fugit aut eligendi odio harum iusto harum iusto ea. Iure quo commodi nam aut et error veritatis consequatur. Laboriosam minus asperiores nemo corporis ducimus. Dolores cum sed corporis non nulla dolores.", false, "New Guillermoshire", 3, 876.05m, "Small Frozen Chips" },
                    { 21, "Laudantium ea inventore. Eos aliquam impedit tempore repellat voluptas impedit maxime aut omnis. Et maxime ab. Quia mollitia fugiat. Nihil quos quas nihil quia fugiat quidem dolor cumque explicabo. Optio enim soluta voluptate voluptatem doloremque.", false, "Greenholtbury", 11, 289.08m, "Licensed Frozen Computer" },
                    { 20, "Quo aut vitae incidunt enim facilis error eius sequi nihil. Dignissimos nemo quo. Aut nisi quo voluptates ducimus neque porro quod suscipit dolor. Cupiditate delectus iure amet repellat.", false, "Troyhaven", 16, 53.66m, "Gorgeous Wooden Keyboard" },
                    { 19, "Atque nulla et occaecati ut. Unde eius commodi aut ex. Sit qui ducimus blanditiis animi nobis iste deleniti voluptatibus.", false, "South Karlee", 17, 880.44m, "Intelligent Rubber Tuna" },
                    { 18, "Tempore id ullam. Et quo sit. Est aut accusantium ea porro nesciunt. Vitae corrupti cupiditate ut enim consequatur fugit consectetur.", false, "Coymouth", 9, 364.92m, "Small Fresh Ball" },
                    { 17, "Voluptas facere consequatur reprehenderit et eaque assumenda qui omnis. Temporibus laudantium optio reiciendis. Cum sint ut nulla illum. Molestias rerum eligendi expedita fuga. Pariatur saepe provident minus sit aliquid tempore in animi occaecati. Illum ea nostrum eum ut fugiat culpa laudantium aut.", false, "Berniecestad", 6, 683.80m, "Rustic Steel Table" },
                    { 16, "Eligendi ipsa et voluptas. Dolorem porro quia ipsam libero error quo. Et aut totam exercitationem soluta veritatis qui quia. Ad dolor numquam voluptatem aperiam magnam deleniti laboriosam. Rerum velit quod qui veritatis. Repellendus eaque quis.", false, "McClurechester", 13, 283.37m, "Handcrafted Rubber Chair" },
                    { 15, "Debitis rerum excepturi sit maiores quos. Labore quaerat modi sapiente nobis consequatur voluptatem est perspiciatis. Aperiam facere qui temporibus ipsam. Accusamus sunt aut voluptatem. Natus adipisci rerum possimus accusantium explicabo nulla.", false, "East Desmond", 24, 275.82m, "Small Cotton Table" },
                    { 14, "Ducimus perferendis et aut quaerat totam et. Dignissimos assumenda et sunt laborum facilis. Et maxime necessitatibus minima aut quibusdam. Ullam laudantium alias quis a totam excepturi. Et fuga enim iure nobis quod omnis est veniam id. Voluptas voluptas et cum est velit dicta.", false, "West Toby", 12, 65.88m, "Rustic Soft Sausages" },
                    { 13, "Aut consequatur quaerat amet est enim nulla et. Ut enim recusandae magni. Rem id ut sed reprehenderit voluptatem quia tempore ut.", false, "Lake Mose", 25, 330.50m, "Handcrafted Concrete Pants" },
                    { 12, "Corporis maxime in placeat maiores commodi praesentium. Minima fuga autem qui ea molestias voluptatibus. Doloremque eligendi eum enim id quia doloribus molestiae. Dignissimos nesciunt quasi nisi. Tenetur quo aut.", false, "Onaville", 12, 353.28m, "Practical Granite Ball" },
                    { 11, "Deleniti qui consequatur atque sit nihil exercitationem reiciendis quo dolor. Alias praesentium perferendis est ducimus qui et. Magni aut cum alias ut dolor officia. Perspiciatis asperiores aliquid quia voluptates. Fugiat quidem totam dicta beatae et autem aut. Nulla minus nam consequatur animi vel.", false, "South Cleora", 8, 566.99m, "Handcrafted Fresh Bacon" },
                    { 10, "Facilis optio iste maiores. Deleniti doloribus excepturi qui. Ab saepe natus. Dolores qui qui natus excepturi.", false, "North Anastasiabury", 1, 995.41m, "Licensed Wooden Car" },
                    { 9, "Omnis cum cupiditate suscipit occaecati libero. Non ipsam sunt enim quos. Aut magnam libero reiciendis in pariatur delectus nulla. Et sint minima consequuntur distinctio.", false, "East Carmine", 1, 526.21m, "Sleek Concrete Hat" },
                    { 8, "Repellat vitae commodi ea reprehenderit consequatur eum a. Architecto nostrum et inventore culpa nisi deserunt. Vel corrupti vel reprehenderit et assumenda accusamus facilis nostrum sed. Voluptatibus numquam tempora voluptas inventore quibusdam beatae dolorem.", false, "Lake Candace", 5, 233.21m, "Intelligent Fresh Bike" },
                    { 7, "Et nemo dolor ducimus ad natus expedita magnam ut ratione. Alias asperiores in quam sunt. Tenetur quia autem in et eligendi nihil. Consequatur et beatae voluptates. Consectetur perspiciatis excepturi laborum amet excepturi voluptatem expedita.", false, "Lake Desmond", 26, 926.45m, "Sleek Granite Bacon" },
                    { 6, "Aspernatur ipsam perspiciatis voluptatibus libero repellendus quos vitae. Quas inventore quaerat sunt ab qui aspernatur. Qui reprehenderit sint. Adipisci fuga quo.", false, "Gutkowskiburgh", 13, 173.63m, "Unbranded Plastic Hat" },
                    { 5, "Aliquam sunt accusamus repudiandae et. Excepturi at accusantium eaque et. Fuga voluptas et earum nisi voluptatem sit eum et esse.", false, "South Lois", 8, 190.88m, "Generic Granite Hat" },
                    { 4, "Ad qui autem vitae numquam consequuntur quas atque ipsa exercitationem. Eveniet aut quas iste autem facilis soluta et nesciunt. Dolore ea eos. Deserunt quibusdam architecto. Cumque ratione dignissimos quasi ea dicta exercitationem.", false, "North Inesview", 16, 528.56m, "Handmade Steel Table" },
                    { 3, "Ullam fugit voluptatem. Sunt soluta tempora. Ullam est adipisci rerum quis et dolore vel. Laboriosam dolorem adipisci beatae accusantium quisquam ea ipsa. Iste quisquam sed quaerat deleniti nihil quod minima commodi. Sit aspernatur distinctio omnis eaque aut omnis ea.", false, "Port Edmouth", 20, 664.10m, "Awesome Plastic Chips" },
                    { 2, "Sequi rerum blanditiis ut. Perspiciatis voluptas est voluptate ut et est sed eos. Commodi eos non voluptas dolore similique provident ab reiciendis. Sunt in praesentium est odit vero est animi ducimus sit. Cum natus sequi similique est minima nam. Dolorem modi placeat incidunt voluptatem optio beatae dolores esse.", false, "Kianastad", 27, 476.05m, "Incredible Metal Keyboard" },
                    { 23, "Blanditiis accusantium nobis minima neque ea. Qui id neque. Fugit eum dolores amet illum dolores.", false, "Shanahanport", 14, 995.16m, "Intelligent Rubber Table" },
                    { 24, "Repellat recusandae sit consequatur est autem debitis. Nihil recusandae vero excepturi magni dolore nisi labore aut. Voluptatum sit fugiat aut inventore omnis numquam dolores.", false, "Wardview", 24, 85.63m, "Refined Frozen Bacon" },
                    { 25, "Enim quibusdam est quia molestias quis voluptas aut. Dolore optio minima fugit possimus quaerat sint rerum. Possimus fugit debitis dolor.", false, "New Bettyeside", 12, 626.96m, "Refined Steel Soap" },
                    { 26, "Optio delectus quia architecto. Excepturi unde sed quia. Delectus odio qui eos nihil sed ipsum voluptates est illo. Est quos facilis ut quia id saepe dolores aperiam quidem.", false, "Generalton", 13, 788.93m, "Ergonomic Fresh Bacon" },
                    { 48, "Similique minus provident quidem magnam cum qui in eum nemo. Eligendi eius corporis soluta molestiae ducimus rem quaerat tempore. Quos et iste inventore ipsa cumque reprehenderit.", false, "North Christy", 22, 960.28m, "Rustic Wooden Car" },
                    { 47, "Quisquam velit debitis facere. Qui maxime temporibus quo. Enim et asperiores quidem earum necessitatibus iure.", false, "Cheyannemouth", 26, 390.40m, "Rustic Metal Car" },
                    { 46, "Perspiciatis placeat iure aliquid quisquam aut ipsam maxime sit. Maiores dolor in nobis. Ut architecto asperiores officia perspiciatis mollitia nemo doloremque amet rem. Voluptates ipsum alias perspiciatis voluptatum reprehenderit rem molestiae est exercitationem. Sit est saepe. Ab totam quidem quae repellendus.", false, "Ornville", 13, 813.38m, "Tasty Soft Bike" },
                    { 45, "Modi reprehenderit odit at eius eaque blanditiis. Nostrum ea et esse id. Est incidunt ipsa esse. Voluptas alias cum autem quibusdam dolorem aperiam.", false, "Jenningsborough", 4, 405.07m, "Unbranded Frozen Pants" },
                    { 44, "Ut est ad qui dolore ea autem dolorum voluptate provident. Delectus quas suscipit libero veniam reiciendis fuga exercitationem cupiditate. Adipisci molestiae tempore tempore tempora aut. Facilis voluptatem et et quis veniam rerum error molestiae possimus. Voluptas voluptatem explicabo temporibus dolores quaerat itaque. Labore est animi est reprehenderit quia quis est voluptatem voluptas.", false, "Mitcheltown", 11, 913.02m, "Tasty Cotton Soap" },
                    { 43, "Culpa aspernatur reprehenderit hic placeat in. Qui velit non id itaque aut ut ad. Aliquam cumque sequi fugiat velit. Quo velit accusantium.", false, "Port Jerelmouth", 10, 883.59m, "Awesome Steel Shoes" },
                    { 42, "Id dignissimos dolorum quo asperiores repellendus odio qui voluptatem velit. Id consequatur doloremque saepe est magni et qui quae eos. Quos accusamus dolores ad. Et et porro voluptatum. Rem sunt quod rerum voluptatem aut delectus earum doloribus ratione.", false, "South Pearlieberg", 24, 627.42m, "Unbranded Frozen Keyboard" },
                    { 41, "Quis vel omnis officiis deleniti ea perspiciatis autem id aut. Vero inventore sunt aut minus est. Ab nisi dicta. Nobis sapiente qui et perspiciatis sit aut minus.", false, "Corkeryfurt", 25, 707.14m, "Gorgeous Concrete Tuna" },
                    { 40, "Ipsam dolores et velit. Ipsum ea aut et maiores necessitatibus eos est ab facere. Sed esse corrupti. Accusamus et autem quis recusandae molestias et accusantium minima aut. Doloremque et beatae architecto sit excepturi aut. Ratione qui tempora vel esse.", false, "Jettshire", 9, 146.81m, "Awesome Fresh Shirt" },
                    { 39, "Sed facere provident libero voluptatem eius sed voluptates ratione. Ipsa ratione voluptas qui placeat vel dolor omnis. Odio et officiis porro optio aut magni reiciendis eius est. Nostrum consequuntur aut molestiae earum voluptas qui saepe est voluptatem. Voluptatem possimus sint veniam ipsam modi. Quisquam in provident.", false, "New Ezra", 27, 663.72m, "Small Fresh Pizza" },
                    { 99, "Deserunt voluptatibus eligendi ex. Est eaque et cum quo et nostrum. Maxime sit quis reiciendis nam quia qui optio maiores similique.", false, "Millieport", 8, 896.88m, "Handmade Wooden Towels" },
                    { 38, "Quia tempora laudantium commodi et facere et illo. Nisi enim laboriosam voluptatem quas. Delectus omnis recusandae voluptatem ut. Et est iste numquam sed quo possimus est. Mollitia non natus quo sed molestiae. Ut eius quia.", false, "South Timmothy", 15, 780.83m, "Incredible Frozen Soap" },
                    { 36, "Dolores quasi esse. Debitis quidem et velit harum dolor voluptatem ipsam dignissimos rerum. Vero aliquam expedita aliquam ex maxime.", false, "Kiarashire", 8, 728.97m, "Ergonomic Concrete Ball" },
                    { 35, "Saepe numquam vel iure odio optio. Rerum deserunt cupiditate est autem nostrum incidunt distinctio. Et aspernatur beatae iure consequuntur ut totam qui vel dignissimos.", false, "Port Justine", 11, 238.17m, "Small Rubber Fish" },
                    { 34, "Aut quaerat omnis sint sit doloribus dolor cupiditate dolorum. Facere voluptas est quisquam maiores. Quisquam repellat maiores quam enim. Dignissimos commodi a nobis earum in et ea ut commodi. Doloribus ab nisi possimus adipisci iure laborum magni eaque dolore. Blanditiis vero est omnis ad sunt recusandae.", false, "South Irmamouth", 4, 814.26m, "Fantastic Frozen Gloves" },
                    { 33, "Corrupti quidem consequuntur velit est. Similique voluptas inventore alias quia dignissimos officia cum iste. Beatae dolores dolor officia eos fugiat in officia. Eum est enim similique qui. Numquam distinctio veritatis inventore quia et facere aut inventore id. Fugit ea animi voluptates natus et et.", false, "East Elianeburgh", 8, 434.98m, "Handcrafted Concrete Hat" },
                    { 32, "Fuga voluptas cumque consequatur aut qui nobis reiciendis voluptatem minus. Voluptate omnis enim excepturi ea perspiciatis. Doloremque hic qui voluptas quia voluptas quia ea aut.", false, "East Karina", 13, 862.08m, "Gorgeous Soft Car" },
                    { 31, "Voluptatum animi rerum sit veniam enim sunt voluptas dolorem unde. Quod soluta et repellat quos. Cupiditate aut fuga aut corporis possimus.", false, "Lake Jason", 29, 944.50m, "Intelligent Cotton Chicken" },
                    { 30, "Debitis optio amet eos. Quia ullam molestiae vitae ullam aliquam eligendi et. Doloremque similique et corporis est doloribus soluta asperiores quasi. Natus voluptatibus nihil.", false, "Vallieland", 11, 36.17m, "Gorgeous Rubber Bacon" },
                    { 29, "Repellat sunt aut optio culpa facilis. Voluptatum reprehenderit iure laudantium aut beatae. Eos nostrum velit voluptatibus expedita quia est possimus impedit. Magni laboriosam laboriosam illum atque quo reprehenderit reprehenderit voluptatem.", false, "Paulland", 24, 247.10m, "Refined Plastic Keyboard" },
                    { 28, "Fugit eos dolores enim unde minus pariatur consequatur. Perferendis natus officia et qui quam id. Harum aliquid aut itaque quam veniam pariatur pariatur architecto. Praesentium ut qui recusandae temporibus. In earum iusto rerum animi voluptates mollitia ut.", false, "West Tristonport", 2, 591.12m, "Generic Steel Sausages" },
                    { 27, "Asperiores cumque et amet. Quisquam quae est sunt. Sunt voluptates voluptatem ut et voluptatum provident odit. Et expedita voluptatibus qui ad voluptatem inventore ullam dignissimos repudiandae. Voluptas fugit ut nulla tenetur quasi.", false, "Jadamouth", 15, 559.37m, "Intelligent Steel Pants" },
                    { 37, "Perspiciatis dicta et autem quo nobis neque excepturi quos. Inventore aspernatur quidem. Magni quas facilis accusamus vel. Et quos temporibus veniam atque dolores quam distinctio voluptatem. Ut quia architecto consequatur id tempora vel.", false, "New Chanelton", 5, 766.06m, "Incredible Metal Towels" },
                    { 100, "Qui et dignissimos facere dolor est. Consequatur nulla sit omnis eveniet alias nisi eos deserunt rerum. Distinctio qui vel rem.", false, "Hardyville", 20, 120.68m, "Sleek Wooden Shoes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100);
        }
    }
}
