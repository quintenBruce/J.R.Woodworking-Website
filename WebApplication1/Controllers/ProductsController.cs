using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        List<Products> list = new List<Products>() 
        {
            new Products(1, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825734/Products/Customer%20Views/Furniture/received_2966800056931119_aq6tij.jpg", "Desk", true, new Category("Office", "Living")),
            new Products(2, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-875890188_toanbw.jpg", "Desk", true, new Category("Office", "Living")),
            new Products(3, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-358724924_xgsyjp.jpg", "Console", true, new Category("Living")), 
            new Products(4, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-1609483947_hrlhjz.jpg", "Shelf", true, new Category("Office")),
            new Products(5, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-659061344_ampglp.jpg", "Shelf", true, new Category("Office", "Living")),
            new Products(6, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825731/Products/Customer%20Views/Furniture/Snapchat-1641100658_vvseel.jpg", "Shelf", true, new Category("Office", "Living")),
            new Products(8, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825730/Products/Customer%20Views/Furniture/Snapchat-1588502498_unqn4f.jpg", "Bench", true, new Category("Dining", "Living")),
            new Products(9, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825730/Products/Customer%20Views/Furniture/Snapchat-1603825154_sgb3q0.jpg", "Barndoor", true, new Category("Bed", "Living")),
            new Products(10, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825730/Products/Customer%20Views/Furniture/Snapchat-1205481118_gg6pou.jpg", "Door", true, new Category("Office", "Bed")),
            new Products(11, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825730/Products/Customer%20Views/Furniture/Screenshot_20211112-224716_Facebook_ub1uat.jpg", "Barndoor", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20210806-121010_Facebook_zab6jt.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20211112-224547_Facebook_hrjtcw.jpg", "Console", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20211107-213738_Facebook_qpvzfl.jpg", "Bookshelf", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20211107-213733_Facebook_dagou1.jpg", "Bookshelf", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20211017-231803_Messenger_vt9ony.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20210422-111710_Facebook_r8wjoq.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825729/Products/Customer%20Views/Furniture/Screenshot_20210701-083017_Facebook_1_tn2n3r.jpg", "Bar", true, new Category("Dining", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825728/Products/Customer%20Views/Furniture/Screenshot_20210414-193043_Messenger_trlbjb.jpg", "End Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825728/Products/Customer%20Views/Furniture/Screenshot_20210414-193037_Messenger_dtzpye.jpg", "End Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825727/Products/Customer%20Views/Furniture/Screenshot_20210317-103654_Facebook_d5yi47.jpg", "Bar", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825727/Products/Customer%20Views/Furniture/received_930117911077888_anmgyg.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825726/Products/Customer%20Views/Furniture/Screenshot_20210215-205945_Facebook_rldhus.jpg", "Bar", true, new Category("Dining", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825725/Products/Customer%20Views/Furniture/received_811096049758277_dmny0n.jpg", "Hamper", true, new Category("Kitchen", "Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825724/Products/Customer%20Views/Furniture/received_778245506184408_ojitpz.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825724/Products/Customer%20Views/Furniture/received_808387730034072_xipcqt.jpg", "Coffee Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825724/Products/Customer%20Views/Furniture/received_723326661717722_bxbb6g.jpg", "Wine Bar", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825723/Products/Customer%20Views/Furniture/received_702820840653236_ip3hli.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825723/Products/Customer%20Views/Furniture/received_641470113487360_twojup.jpg", "Barndoor", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825722/Products/Customer%20Views/Furniture/received_467696121746135_farlgx.jpg", "Bar", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825722/Products/Customer%20Views/Furniture/received_483713766799334_l451u6.jpg", "Bar", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825721/Products/Customer%20Views/Furniture/received_466020218433870_he90a7.jpg", "Bar", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825721/Products/Customer%20Views/Furniture/received_3697372226965282_iubnay.jpg", "Barndoor", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825721/Products/Customer%20Views/Furniture/received_357549356249462_dqqmqm.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825721/Products/Customer%20Views/Furniture/received_369805604602631_njyluv.jpg", "Bed", true, new Category("Bed")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825720/Products/Customer%20Views/Furniture/received_395886785333740_kvhplh.jpg", "Desk", true, new Category("Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825720/Products/Customer%20Views/Furniture/received_381348330488508_c1ufbb.jpg", "Dresser", true, new Category("Bed")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825719/Products/Customer%20Views/Furniture/received_3614032512007088_c1boqu.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825718/Products/Customer%20Views/Furniture/received_1660024184385172_knz3tz.jpg", "Desk", true, new Category("Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825718/Products/Customer%20Views/Furniture/received_287558342951935_elbzgj.jpg", "Desk", true, new Category("Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825718/Products/Customer%20Views/Furniture/received_3201721843392491_lem4yn.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825718/Products/Customer%20Views/Furniture/20200905_110654_vzr9nx.jpg", "Bookshelf", true, new Category("Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825717/Products/Customer%20Views/Furniture/received_3070549483231739_h4mdsp.jpg", "Desk", true, new Category("Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825716/Products/Customer%20Views/Furniture/received_301813115130265_fm7wlg.jpg", "Christmas Tree Box", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825715/Products/Customer%20Views/Furniture/received_262373681914865_gzkzon.jpg", "Dresser", true, new Category("Bed")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825713/Products/Customer%20Views/Furniture/received_255605989273819_xrjoxq.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825713/Products/Customer%20Views/Furniture/20200418_132057_pzneeb.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825712/Products/Customer%20Views/Furniture/received_1140934363012491_j3zukn.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825712/Products/Customer%20Views/Furniture/received_191027339093527_azuqxo.jpg", "Bathroom Vanity", true, new Category("Bath")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825712/Products/Customer%20Views/Furniture/received_1823986314449983_jiyjd7.jpg", "Sofa Bench", true, new Category("Outdoors")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825711/Products/Customer%20Views/Furniture/received_234300065504121_kt6tp4.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825710/Products/Customer%20Views/Furniture/received_1447653595415360_fevll0.jpg", "Shelf", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825710/Products/Customer%20Views/Furniture/received_1608615372669032_awkc0v.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825710/Products/Customer%20Views/Furniture/received_1203616616721149_amfpzi.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825710/Products/Customer%20Views/Furniture/received_176493614425585_zbzhhq.jpg", "Console", true, new Category("Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825710/Products/Customer%20Views/Furniture/received_209364694457509_dh1f39.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1650825709/Products/Customer%20Views/Furniture/20200920_092454_ymlxtc.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618118/Products/Customer%20Views/Furniture%202/Resized_20201031_110348_1_knqvgv.jpg", "Barndoor", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618118/Products/Customer%20Views/Furniture%202/20201018_112018_2_dhvfaa.jpg", "Bench", true, new Category("Dining", "Outdoors")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618115/Products/Customer%20Views/Furniture%202/zKgF2K3l-680652317_zuyi3a.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618115/Products/Customer%20Views/Furniture%202/ulDagJdM-630547319_1_puxmea.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618115/Products/Customer%20Views/Furniture%202/ZXMdfpjH-628374978_1_jvzzbt.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618114/Products/Customer%20Views/Furniture%202/u4u8SLqe-629580321_1_czckqf.jpg", "Baby Changing Table", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618114/Products/Customer%20Views/Furniture%202/uTXMWL6t-629633517_1_ovahyj.jpg", "Barndoor Console", true, new Category("Bedroom", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618113/Products/Customer%20Views/Furniture%202/sH7mfeNu-676282705_qsnmc9.jpg", "Bookshelf", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618113/Products/Customer%20Views/Furniture%202/Resized_20220423_165648001_r1xu1m.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618113/Products/Customer%20Views/Furniture%202/RHDFlI8q-677302149_ie4afr.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618113/Products/Customer%20Views/Furniture%202/Resized_20220222_175251_1_k56tcf.jpg", "Bar", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618112/Products/Customer%20Views/Furniture%202/Resized_20220430_163900_pxc8fh.jpg", "Barndoor Console", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618112/Products/Customer%20Views/Furniture%202/Resized_20220413_171355_1_dpc2cc.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618111/Products/Customer%20Views/Furniture%202/Resized_20220322_174925_1_rerohb.jpg", "Consoles", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618111/Products/Customer%20Views/Furniture%202/Resized_20220319_185653_1_pyttry.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618111/Products/Customer%20Views/Furniture%202/20220503_173817_ea5nre.jpg", "Bookshelf", true, new Category("Living", "Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618111/Products/Customer%20Views/Furniture%202/2382RVsH-627339468_1_oaeoou.jpg", "Living Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618111/Products/Customer%20Views/Furniture%202/fRPSXI6W-148276276_iikb8d.jpg", "Coffee Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618110/Products/Customer%20Views/Furniture%202/Resized_20220219_153340_1_ozunlg.jpg", "End Table", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618110/Products/Customer%20Views/Furniture%202/Resized_20220123_165255_1_1_lze9af.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618110/Products/Customer%20Views/Furniture%202/Resized_20220123_165255_1_1_lze9af.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618110/Products/Customer%20Views/Furniture%202/20220503_173724_orxmpo.jpg", "Coffee Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618110/Products/Customer%20Views/Furniture%202/Resized_20220106_172729_1_2_f5nqpm.jpg", "Living Room Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618110/Products/Customer%20Views/Furniture%202/Resized_20220117_173635_1_qldteb.jpg", "Chest", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618110/Products/Customer%20Views/Furniture%202/20220503_173526_ghwuh7.jpg", "Desk", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618109/Products/Customer%20Views/Furniture%202/Resized_20220106_172552_1_rqizy5.jpg", "Coffee Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618109/Products/Customer%20Views/Furniture%202/20220413_164138_qpwewi.jpg", "Dining Table and Bench", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618109/Products/Customer%20Views/Furniture%202/Resized_20211120_153312_2_tsvkyh.jpg", "Barndoor Console", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618109/Products/Customer%20Views/Furniture%202/Resized_20211118_165834_ohsnvp.jpg", "Mini Fridge Console", true, new Category("Dining", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618108/Products/Customer%20Views/Furniture%202/Resized_20211118_164915_1_q8vd3f.jpg", "Christmas Tree Box", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618108/Products/Customer%20Views/Furniture%202/20220226_181145_1_jwivhg.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618108/Products/Customer%20Views/Furniture%202/Resized_20211028_175728_2_ypg7lv.jpg", "Laundry Cabinet", true, new Category("Living", "Bath")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618108/Products/Customer%20Views/Furniture%202/20220503_173409_vvnebt.jpg", "Living Room Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618108/Products/Customer%20Views/Furniture%202/20220402_161433_1_n82fcm.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618107/Products/Customer%20Views/Furniture%202/20220228_164555_1_b44ik4.jpg", "Modern Bench", true, new Category("Living", "Outdoors", "Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618107/Products/Customer%20Views/Furniture%202/Resized_20211026_183908_1_rxxcdo.jpg", "Bookshelf", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618107/Products/Customer%20Views/Furniture%202/Resized_20211007_183132_2_1_w4uhwp.jpg", "Dog Kennel", true, new Category("Bedroom", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618106/Products/Customer%20Views/Furniture%202/Resized_20210828_162127_1_t1k3bh.jpg", "Coffee Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618106/Products/Customer%20Views/Furniture%202/20220127_174539_1_pkddml.jpg", "End Tables", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618106/Products/Customer%20Views/Furniture%202/Resized_20210811_180622_1_2_r4xju0.jpg", "Barndoor Desk", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618106/Products/Customer%20Views/Furniture%202/Resized_20210731_174725_1_o2to1c.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618105/Products/Customer%20Views/Furniture%202/20220207_170811_1_af9zwk.jpg", "Living Room Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618105/Products/Customer%20Views/Furniture%202/Resized_20210808_162611_1_zjisf1.jpg", "End Tables", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618104/Products/Customer%20Views/Furniture%202/Resized_20210726_174307_1_ijmsdu.jpg", "Living Room Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618104/Products/Customer%20Views/Furniture%202/Resized_20210717_165136_1_cva3tx.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618104/Products/Customer%20Views/Furniture%202/20211119_162440_d9tekp.jpg", "Christmas Tree Box", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618104/Products/Customer%20Views/Furniture%202/20220104_162339_2_zk0xnt.jpg", "Metal Bench", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618103/Products/Customer%20Views/Furniture%202/20211021_182931_y4631e.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618103/Products/Customer%20Views/Furniture%202/Resized_20210712_171901_2_snizga.jpg", "Living Room Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618102/Products/Customer%20Views/Furniture%202/Resized_20210606_151905_erqa2h.jpg", "Front Desk", true, new Category("Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618102/Products/Customer%20Views/Furniture%202/Resized_20210529_180646_1_qqvc7g.jpg", "Bench and Coat Hanger", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618102/Products/Customer%20Views/Furniture%202/Resized_20210527_182845_1_1_tlibkv.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618101/Products/Customer%20Views/Furniture%202/20210124_102216_1_fyxqx4.jpg", "Living Room Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618101/Products/Customer%20Views/Furniture%202/Resized_20210417_113508_1_ohlobx.jpg", "L Shaped Desk", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618100/Products/Customer%20Views/Furniture%202/Resized_20210406_181700_2_z6xkeb.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618099/Products/Customer%20Views/Furniture%202/Resized_20210326_130652_1_w8hllz.jpg", "Barndoor Desk", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618099/Products/Customer%20Views/Furniture%202/20201129_095626_hcyrvw.jpg", "Coffee Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618099/Products/Customer%20Views/Furniture%202/Resized_20210403_110512_1_lyh0yi.jpg", "Barnndoor End Table", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618099/Products/Customer%20Views/Furniture%202/Resized_20210403_104713_2_hdf3ej.jpg", "Outdoor Chairs", true, new Category("Outdoors")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618098/Products/Customer%20Views/Furniture%202/Resized_20201212_111503_1_1_tv5mv9.jpg", "bench", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618098/Products/Customer%20Views/Furniture%202/Resized_20210123_113656_gbbnlm.jpg", "Mini Fridge Console", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618098/Products/Customer%20Views/Furniture%202/Resized_20210211_172105_1_yaksqq.jpg", "Dining Table", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618097/Products/Customer%20Views/Furniture%202/Resized_20210130_165831_wndvgg.jpg", "End Tables", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618097/Products/Customer%20Views/Furniture%202/20200913_151835_1_m1bxbz.jpg", "Barndoor Console", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618096/Products/Customer%20Views/Furniture%202/Resized_20201024_130152_1_c0fwnh.jpg", "Barndoor Consoles", true, new Category("Living", "Bed")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618096/Products/Customer%20Views/Furniture%202/Resized_20200929_104632_1_oel3kp.jpg", "Shelf", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618096/Products/Customer%20Views/Furniture%202/20200920_143832_nxhrpd.jpg", "Ladder", true, new Category("Living", "Bed")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618095/Products/Customer%20Views/Furniture%202/Resized_20200613_131410_mjcgha.jpg", "Dining Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618095/Products/Customer%20Views/Furniture%202/Resized_20200613_131410_mjcgha.jpg", "", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618095/Products/Customer%20Views/Furniture%202/Resized_20200516_114550_bmkwta.jpg", "Shelves", true, new Category("Office", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618095/Products/Customer%20Views/Furniture%202/20201018_095111_cbep9m.jpg", "Coffee Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618094/Products/Customer%20Views/Furniture%202/received_1203616616721149_2_wbjl8u.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618094/Products/Customer%20Views/Furniture%202/20200920_143818_k4eyo3.jpg", "Ladder", true, new Category("Living", "Bed")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618094/Products/Customer%20Views/Furniture%202/qVdzt7R4-627679739_1_hvldgz.jpg", "Barndoor End Tables", true, new Category("Living", "Bed")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618094/Products/Customer%20Views/Furniture%202/QKRu2Ue7-675739771_yrcgni.jpg", "Coffee Table", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618093/Products/Customer%20Views/Furniture%202/R8XvdL8J-629291445_1_hmqhi6.jpg", "Living Room Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618093/Products/Customer%20Views/Furniture%202/lONMoNuk-630526636_1_iery0e.jpg", "Distressed Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618093/Products/Customer%20Views/Furniture%202/LSy7q0cK-677625620_loute7.jpg", "Bench", true, new Category("Dining", "Outdoors")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618093/Products/Customer%20Views/Furniture%202/20200920_143804_hu6mwa.jpg", "Ladder", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618092/Products/Customer%20Views/Furniture%202/czt3FQGR-630783069_1_htylrw.jpg", "Coat Hanger and Storage", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618092/Products/Customer%20Views/Furniture%202/1UFZzAYO-676292858_e9n2rq.jpg", "Desk", true, new Category("Office")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618092/Products/Customer%20Views/Furniture%202/LksMczNC-629460144_1_zxlk5n.jpg", "Console", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618092/Products/Customer%20Views/Furniture%202/IqChhpeD-627591887_1_rzfsok.jpg", "Living Room Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618091/Products/Customer%20Views/Furniture%202/hqyvG2YV-628367738_1_lmis8l.jpg", "Living Room Set", true, new Category("Dining")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618091/Products/Customer%20Views/Furniture%202/20200818_091129_1_xwhcdy.jpg", "Living Room Set", true, new Category("Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618091/Products/Customer%20Views/Furniture%202/APIEQxt4-260016450_lv0lv9.jpg", "Barndoor Console", true, new Category("Bed", "Living")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618103/Products/Customer%20Views/Furniture%202/Resized_20210715_180821_1_h3ingw.jpg", "Patio bench w/Chase", true, new Category("Outdoors")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651618103/Products/Customer%20Views/Furniture%202/Resized_20210715_175837_1_u1lhra.jpg", "Patio Bench", true, new Category("Outdoors")),
            new Products(12, "https://res.cloudinary.com/dmremrlru/image/upload/v1651953981/Products/Customer%20Views/Furniture%202/20220507_150541_qhiewl.jpg", "Patio Bench", true, new Category("Shoe Storage"))






        };

        public IActionResult ProductsIndex()
        {
            return View(list);
        }

        public IActionResult LivingRoom()
        {
            
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Living")).ToList();
            return View(list_);
        }

        public IActionResult BedRoom()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Bed")).ToList();
            return View(list_);
        }

        public IActionResult BathRoom()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Bath")).ToList();
            return View(list_);
        }

        public IActionResult DiningRoom()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Dining")).ToList();
            return View(list_);
        }

        public IActionResult Office()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Office")).ToList();
            return View(list_);
        }

        public IActionResult Outdoors()
        {
            var list_ = list.Where(a => a.Categories!.Categories!.Any(x => x == "Outdoors")).ToList();
            return View(list_);
        }




    }
}
