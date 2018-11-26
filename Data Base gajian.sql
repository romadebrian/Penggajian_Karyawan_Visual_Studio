/*
SQLyog Enterprise - MySQL GUI v5.26
Host - 5.0.45-community-nt : Database - gajian
*********************************************************************
Server version : 5.0.45-community-nt
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

create database if not exists `gajian`;

USE `gajian`;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

/*Table structure for table `hrd` */

DROP TABLE IF EXISTS `hrd`;

CREATE TABLE `hrd` (
  `no_hrd` int(100) NOT NULL,
  `namaHrd` varchar(50) default NULL,
  `jenkel_hrd` varchar(15) default NULL,
  `tglLhr` date default NULL,
  `agamaHrd` varchar(20) default NULL,
  `statusHrd` varchar(20) default NULL,
  `tgl_msk` date default NULL,
  PRIMARY KEY  (`no_hrd`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `hrd` */

insert  into `hrd`(`no_hrd`,`namaHrd`,`jenkel_hrd`,`tglLhr`,`agamaHrd`,`statusHrd`,`tgl_msk`) values (1,'Hestia','Perempuan','1900-08-08','Islam','Belum Kawin','2010-08-01'),(2,'Farhan','Laki - laki','1997-08-07','Islam','Belum Kawin','2010-06-06'),(3,'Jia','Laki - laki','2001-10-10','Islam','Belum Kawin','2000-10-08'),(4,'Kana','Perempuan','1991-07-09','Islam','Kawin','2014-06-10'),(5,'dawd','Laki - laki','2017-11-15','Islam','Kawin','2017-11-15'),(6,'dwad','Laki - laki','2017-11-15','Islam','Kawin','2017-11-15'),(7,'wdawdad','Laki - laki','2017-11-15','Islam','Kawin','2017-11-15'),(8,'wdadwawdawd','Laki - laki','2017-11-15','Islam','Kawin','2017-11-15'),(9,'wdawdawdawdawd','Laki - laki','2017-11-15','Islam','Kawin','2017-11-15'),(10,'wdadwdawdawd','Laki - laki','2017-11-15','Islam','Kawin','2017-11-15'),(11,'Rama','Laki - laki','2007-09-13','Islam','Belum Kawin','2014-08-12'),(12,'Ramoz','Laki - laki','2012-09-13','Kristen','Kawin','2016-09-14'),(13,'HRD','Laki - laki','2017-11-15','Islam','Kawin','2017-11-15');

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `NIP` char(20) NOT NULL,
  `namaKar` varchar(50) default NULL,
  `Jenkel` varchar(15) default NULL,
  `alamat` varchar(100) default NULL,
  `no_hp` varchar(20) default NULL,
  `tgl_lahir` date default NULL,
  `agama` varchar(20) default NULL,
  `status` varchar(20) default NULL,
  `tgl_masuk` date default NULL,
  `jabatan` varchar(20) default NULL,
  `gajiPokok` varchar(255) default NULL,
  PRIMARY KEY  (`NIP`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `karyawan` */

insert  into `karyawan`(`NIP`,`namaKar`,`Jenkel`,`alamat`,`no_hp`,`tgl_lahir`,`agama`,`status`,`tgl_masuk`,`jabatan`,`gajiPokok`) values ('1','Jason','Laki - laki','Jl. Jalan Jalan','07564564564','2009-05-31','Budha','Kawin','1982-03-02','Staff Part Time','2,500,000'),('10','Oky','Laki - laki','Jl. Jalan','088323423','1998-11-12','Islam','Belum Kawin','2016-11-12','Staff Full Time','3,500,000'),('11','Faisal','Laki - laki','Jl. Pake Motor','0854654656','1998-11-12','Islam','Kawin','2016-11-12','Staff Full Time','3,500,000'),('12','Fariq','Laki - laki','Jl Pala Merah','088657657657','1998-11-12','Islam','Kawin','2016-11-12','Staff Full Time','3,500,000'),('13','Bahamut','Laki - laki','Jl Salah','09884353434','2004-03-29','Kristen','Kawin','2008-01-31','Staff Full Time','3,500,000'),('14','Suzu','Laki - laki','Jl Lanang','08787687687','2016-08-12','Kristen','Belum Kawin','2016-09-14','Sekretaris','4,000,000'),('2','Hana','Perempuan','Jl. Anihana','0878976897','2014-04-06','Islam','Belum Kawin','2017-11-09','Sekretaris','4,000,000'),('3','Geroge','Laki - laki','Jl. Genius','067567456456','2012-03-03','Hindu','Kawin','2014-07-06','Staff Part Time','2,500,000'),('4','Nana','Perempuan','Jl. Ryugajou','087554534534534','2005-05-31','Kristen','Belum Kawin','2008-01-31','Sekretaris','4,000,000'),('5','Lilounch','Laki - laki','Jl.Haji Jawa','0864654654','2004-09-10','Kristen','Kawin','2013-10-08','Staff Part Time','2,500,000'),('6','Leha','Perempuan','Jl.Babelan','0898685765778','2004-10-10','Islam','Belum Kawin','2017-11-11','Sekretaris','4,000,000'),('7','Roma','Laki - laki','Jl.Haji Nawi Rt 6 / Rw 12','083800587709','2017-11-12','Islam','Kawin','2017-11-12','Staff Full Time','3,500,000'),('8','Jinzo','Laki - laki','Jl Yugioh','090423423','1998-10-11','Katolik','Belum Kawin','2014-08-11','Staff Full Time','3,500,000'),('9','Adnan','Laki - laki','Jl H-1','098873423423','2002-11-12','Kristen','Belum Kawin','2016-11-12','Staff Full Time','3,500,000');

/*Table structure for table `transaksi` */

DROP TABLE IF EXISTS `transaksi`;

CREATE TABLE `transaksi` (
  `no_slip` varchar(30) NOT NULL,
  `tgl_gajian` date default NULL,
  `NIP` char(10) default NULL,
  `namaKar` varchar(50) default NULL,
  `tgl_masuk` date default NULL,
  `jabatan` varchar(20) default NULL,
  `gajiPokok` varchar(255) default NULL,
  `biayaLembur` varchar(255) default NULL,
  `totalLembur` varchar(255) default NULL,
  `bonus` varchar(255) default NULL,
  `Asuransi` varchar(255) default NULL,
  `gajiBersih` varchar(255) default NULL,
  PRIMARY KEY  (`no_slip`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `transaksi` */

insert  into `transaksi`(`no_slip`,`tgl_gajian`,`NIP`,`namaKar`,`tgl_masuk`,`jabatan`,`gajiPokok`,`biayaLembur`,`totalLembur`,`bonus`,`Asuransi`,`gajiBersih`) values ('Slip/000001','2017-11-15','4','Nana','2008-01-31','Sekretaris','4,000,000','150,000','50','7,500,000','50,000','11,450,000'),('Slip/000002','2018-11-15','4','Nana','2008-01-31','Sekretaris','4,000,000','150,000','21','3,150,000','50,000','7,100,000'),('Slip/000003','2017-11-15','6','Leha','2017-11-11','Sekretaris','4,000,000','150,000','6','900,000','50,000','4,850,000'),('Slip/000004','2017-11-15','4','Nana','2008-01-31','Sekretaris','4,000,000','150,000','20','3,000,000','50,000','6,950,000'),('Slip/000005','2017-11-15','5','Lilounch','2013-10-08','Staff Part Time','2,500,000','150,000','5','750,000','50,000','3,200,000'),('Slip/000006','2017-11-15','5','Lilounch','2013-10-08','Staff Part Time','2,500,000','150,000','1','150,000','50,000','2,600,000'),('Slip/000007','2017-11-15','7','Roma','2017-11-12','Staff Full Time','3,500,000','150,000','20','3,000,000','50,000','6,450,000'),('Slip/000008','2017-11-15','4','Nana','2008-01-31','Sekretaris','4,000,000','150,000','2','300,000','50,000','4,250,000'),('Slip/000009','2017-11-15','7','Roma','2017-11-12','Staff Full Time','3,500,000','150,000','50','7,500,000','50,000','10,950,000'),('Slip/000010','2016-07-13','7','Roma','2017-11-12','Staff Full Time','3,500,000','150,000','50','7,500,000','50,000','10,950,000'),('Slip/000011','2017-09-15','9','Adnan','2016-11-12','Staff Full Time','3,500,000','150,000','9','1,350,000','50,000','4,800,000'),('Slip/000012','2017-11-15','4','Nana','2008-01-31','Sekretaris','4,000,000','150,000','2','300,000','50,000','4,250,000');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `no_user` int(100) NOT NULL,
  `username` varchar(30) default NULL,
  `password` varchar(30) default NULL,
  `Level` int(2) default NULL,
  PRIMARY KEY  (`no_user`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `user` */

insert  into `user`(`no_user`,`username`,`password`,`Level`) values (1,'Roma','1',1),(2,'Raisa','1',2),(3,'Adnan','1',1),(4,'Fariq','1',1),(5,'Faisal Racman','1',1),(6,'Oky','1',1),(7,'Tanaka','1',2),(8,'Tatara','1',2),(9,'Kenma','1',2),(10,'Yani','1',2),(11,'sda','dawda',2),(12,'Sukebe','1',2),(13,'ll','0',2),(14,'Hana','1',2),(15,'Hana','1',2),(16,'HRD','1',2),(17,'Bozer','1',2);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
