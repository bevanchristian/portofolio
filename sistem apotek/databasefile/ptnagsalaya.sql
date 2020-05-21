-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Bulan Mei 2020 pada 12.29
-- Versi server: 10.1.37-MariaDB
-- Versi PHP: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ptnagsalaya`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_penerimaan`
--

CREATE TABLE `detail_penerimaan` (
  `id_dpenerimaan` varchar(45) NOT NULL,
  `id_penerimaan` varchar(45) NOT NULL,
  `id_barang` varchar(45) NOT NULL,
  `nama_barang` varchar(45) NOT NULL,
  `jumlah` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `history`
--

CREATE TABLE `history` (
  `id_history` varchar(45) NOT NULL,
  `id_barang` varchar(45) NOT NULL,
  `nama_barang` varchar(45) NOT NULL,
  `stok_masuk` varchar(45) NOT NULL,
  `stok_keluar` varchar(45) NOT NULL,
  `tgl_history` date NOT NULL,
  `owner` varchar(45) NOT NULL,
  `keterangan` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `history`
--

INSERT INTO `history` (`id_history`, `id_barang`, `nama_barang`, `stok_masuk`, `stok_keluar`, `tgl_history`, `owner`, `keterangan`) VALUES
('H1', 'A0003', 'DISPOSIBLE SYRINGE 5CC GIDCARE', '2', '0', '2019-05-16', 'pembelian', 'pembelian'),
('H10', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', '2', '0', '2019-05-16', 'UBAHRETURPENJUALAN', 'CUSTOMER KEKURANGAN SAAT RETUR'),
('H11', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', '0', '2', '2019-05-16', 'returbeli', 'barang di kembalikan'),
('H12', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', '0', '2', '2019-05-16', 'UBAHRETUR', 'kekurangan ketika retur ke supplier'),
('H13', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', '0', '2', '2019-05-16', 'UBAHRETUR', 'kekurangan ketika retur ke supplier'),
('H14', 'A0009', 'DISPOSIBLE SYRINGE 10CC O M', '0', '2', '2019-08-08', 'returbeli', 'barang di kembalikan'),
('H15', 'A0002', 'DISPOSIBLE SYRINGE 3CC GIDCARE', '2', '0', '2020-05-21', 'pembelian', 'pembelian'),
('H2', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', '2', '0', '2019-05-16', 'pembelian', 'pembelian'),
('H3', 'A0009', 'DISPOSIBLE SYRINGE 10CC O M', '2', '0', '2019-05-16', 'pembelian', 'pembelian'),
('H4', 'A0009', 'DISPOSIBLE SYRINGE 10CC O M', '2', '0', '2019-05-16', 'pembelian', 'pembelian'),
('H5', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', '2', '0', '2019-05-16', 'pembelian', 'pembelian'),
('H6', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', '0', '2', '2019-05-16', 'penjualan', 'penjualan'),
('H7', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', '0', '2', '2019-05-16', 'penjualan', 'penjualan'),
('H8', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', '0', '2', '2019-05-16', 'penjualan', 'penjualan'),
('H9', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', '2', '0', '2019-05-16', 'retur jual', 'barang di kembalikan');

-- --------------------------------------------------------

--
-- Struktur dari tabel `m_barang`
--

CREATE TABLE `m_barang` (
  `id_barang` varchar(45) NOT NULL,
  `nama_barang` varchar(45) NOT NULL,
  `harga_beli` varchar(45) NOT NULL,
  `diskon` varchar(45) NOT NULL,
  `no_batch` varchar(45) NOT NULL,
  `expire_date` year(4) DEFAULT NULL,
  `delete` int(10) UNSIGNED NOT NULL,
  `harga_jual` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `m_barang`
--

INSERT INTO `m_barang` (`id_barang`, `nama_barang`, `harga_beli`, `diskon`, `no_batch`, `expire_date`, `delete`, `harga_jual`) VALUES
('A0001', 'DISPOSIBLE SYRINGE 1CC GIDCARE', '10000', '0', 'B1', 2021, 1, 13000),
('A0002', 'DISPOSIBLE SYRINGE 3CC GIDCARE', '12000', '0', 'B2', 2020, 0, 15500),
('A0003', 'DISPOSIBLE SYRINGE 5CC GIDCARE', '12500', '0', 'B3', 2020, 0, 20000),
('A0004', 'DISPOSIBLE SYRINGE 10CC GIDCARE', '12599', '0', 'B4', 2020, 0, 22000),
('A0005', 'DISPOSIBLE SYRINGE 20CC GIDCARE', '14000', '0', 'B5', 2020, 0, 25000),
('A0006', 'DISPOSIBLE SYRINGE 1CC O M', '14600', '5', 'B6', 2021, 0, 30000),
('A0007', 'DISPOSIBLE SYRINGE 3CC O M', '13000', '30', 'B7', 2023, 1, 21000),
('A0008', 'DISPOSIBLE SYRINGE 5CC O M', '26400', '30', 'B8', 2023, 0, 45400),
('A0009', 'DISPOSIBLE SYRINGE 10CC O M', '29000', '25', 'B9', 2024, 0, 38000),
('A0010', 'DISPOSIBLE SYRINGE 20CC O M', '29400', '20', 'B10', 2020, 0, 38400),
('A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', '29400', '5', 'B11', 2025, 0, 38400),
('A0012', 'HANDSCOON NON STERIL S', '27400', '0', 'B12', 2020, 0, 38400),
('A0013', 'HANDSCOON NON STERIL M', '20400', '35', 'B13', 2023, 0, 40400),
('A0014', 'HANDSCOON NON STERIL L / 100S', '20400', '35', 'B14', 2021, 0, 40400),
('A0015', 'NEEDLE NO.18 TERUMO', '26400', '78', 'B15', 2023, 0, 45400),
('A0016', 'NEEDLE NO.23 TERUMO', '26400', '50', 'B16', 2024, 0, 45400),
('A0017', 'Paramex', '3000', '10', 'B17', 2021, 0, 5000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `m_customer`
--

CREATE TABLE `m_customer` (
  `id_customer` varchar(45) NOT NULL,
  `nama_customer` varchar(45) NOT NULL,
  `alamat_customer` varchar(45) NOT NULL,
  `kota_customer` varchar(45) NOT NULL,
  `notelp_customer` varchar(45) NOT NULL,
  `delete` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `m_customer`
--

INSERT INTO `m_customer` (`id_customer`, `nama_customer`, `alamat_customer`, `kota_customer`, `notelp_customer`, `delete`) VALUES
('C1', 'PT.JAPFA COMFEED INDONESIA TBK', 'GEDUNG WISMA MILENIA', 'JAKARTA', '081231778747', 0),
('C10', 'APT.FADICA/CV.FADICA', 'JALAN RAYA TAMAN ASRI NO 38', 'SIDOARJO', '098766787688', 0),
('C11', 'deddy', 'deddyid', 'deddydey', '082236273627', 0),
('C2', 'PT GATRA PERSADA', 'JL.SAMBISARI KAV.UTARA BLOK F NOMOR 6', 'SIDOARJO', '0317887149', 0),
('C3', 'APT.SAMBISARI', 'JALAN RAYA JEMUNDO', 'SIDOARJO', '03199783540', 0),
('C4', 'DINAS KESEHATAN KAB SERAM BAGIAN TIMUR', 'JALAN WAILOLA', 'BULA', '081235678756', 0),
('C5', 'PEMEGANG KAS DINAS KESEHATAN KESEJAHTERAAN SO', 'JL.UMAR ANAKODA', 'KEPULAUAN ARU', '081371778767', 0),
('C6', 'BENDAHARA RUTIN DINAS KESEHATAN SAUMLAKI', 'SAUMLAKI', 'MALUKU', '08134567778', 0),
('C7', 'BEND.DIKNES PENGENDALIAN PENDUDUK DAN KB', 'JALAN PELAJAR NO 3', 'KEPULAUAN RIAU', '081231678747', 0),
('C8', 'BEND.PENGELUARAN DINKES KAB.MOJOKERTO', 'JL.R.A.BASUNI NO 4 RT/RW.05/03', 'MOJOKERTO', '081231778647', 0),
('C9', 'BEND.RSUD.CENDRAWASIH', 'JL.DEPNAKER KILO 6 SIWALIMA', 'KEPULAUAN ARU', '081234567822', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `m_golongan`
--

CREATE TABLE `m_golongan` (
  `id_golongan` varchar(45) NOT NULL,
  `nama_golongan` varchar(45) NOT NULL,
  `delete` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `m_golongan`
--

INSERT INTO `m_golongan` (`id_golongan`, `nama_golongan`, `delete`) VALUES
('G1', 'OBAT BEBAS', 0),
('G2', 'OBAT BEBAS TERBATAS', 0),
('G3', 'OBAT KERAS', 0),
('G4', 'NARKOTIKA', 0),
('G5', 'PSIKOTROPIKA', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `m_pegawai`
--

CREATE TABLE `m_pegawai` (
  `id_pegawai` varchar(45) NOT NULL,
  `nama_pegawai` varchar(45) NOT NULL,
  `jabatan_pegawai` varchar(45) NOT NULL,
  `alamat_pegawai` varchar(45) NOT NULL,
  `kota_pegawai` varchar(45) NOT NULL,
  `notelp_pegawai` varchar(45) NOT NULL,
  `delete` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `m_pegawai`
--

INSERT INTO `m_pegawai` (`id_pegawai`, `nama_pegawai`, `jabatan_pegawai`, `alamat_pegawai`, `kota_pegawai`, `notelp_pegawai`, `delete`) VALUES
('PG001', 'RYAN', 'MANAGER', 'JL.SAMBIKEREP NO.35', 'SURABAYA', '0314567838', 0),
('PG002', 'DIKA', 'CLEANING SERVICE', 'JL.MANUKAN NO.56', 'SURABAYA', '0312345867', 0),
('PG003', 'PUTRI', 'SEKRETARIS', 'JL.KEBON KACANG NO.6', 'JAKARTA', '0213421345', 0),
('PG004', 'FERNANDO', 'BENDAHARA', 'JL.MAYJEND SUNGKONO NO.67', 'SURABAYA', '0314223789', 0),
('PG005', 'KEVIN', 'KARYAWAN', 'JL.MH.THAMRIN NO 56', 'JAKARTA', '0213421267', 0),
('PG006', 'ADNAN', 'KARYAWAN', 'JL.BKR NO.01', 'BANDUNG', '0223435377', 0),
('PG007', 'DANI', 'MARKETING', 'JL.MENGANTI NO.55', 'SURABAYA', '0315566434', 0),
('PG008', 'BELLA', 'DIREKTUR', 'JL.CITRALAND NO.53', 'SURABAYA', '031422789', 0),
('PG009', 'NAUFAL', 'KARYAWAN', 'JL.SENAYAN NO.77', 'JAKARTA', '0213447789', 0),
('PG010', 'SALSA', 'KARYAWAN', 'JL.MOJO NO.54', 'SURABAYA', '031447766568', 0),
('PG011', 'Michael', 'Manager', 'Citraraya', 'Surabaya', '0873636262445', 0),
('PG012', 'daral', 'karyawan', 'citraraya', 'surabaya', '081592862105', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `m_supplier`
--

CREATE TABLE `m_supplier` (
  `id_supplier` varchar(45) NOT NULL,
  `nama_supplier` varchar(45) NOT NULL,
  `alamat_supplier` varchar(45) NOT NULL,
  `kota_supplier` varchar(45) NOT NULL,
  `notelp_supplier` varchar(45) NOT NULL,
  `delete` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `m_supplier`
--

INSERT INTO `m_supplier` (`id_supplier`, `nama_supplier`, `alamat_supplier`, `kota_supplier`, `notelp_supplier`, `delete`) VALUES
('SP1', 'PT.GATRA PERSADA', 'JL.SAMBISARI KAV.UTARA F.6', 'TAMAN-SIDOARJO', '0317887149', 0),
('SP10', 'PT.DAYA MUDA AGUNG', 'JL.NANGKA 265 GEDANGAN', 'SIDOARJO', '0314567897', 0),
('SP11', 'PT.KIMIA FARMA', 'KOMP.PERGUDANGAN TANRISE SOUTH GATE', 'SIDOARJO', '0318910501', 0),
('SP12', 'MILLENIUM PHARMACON I', 'JL.KARTINI NO.70', 'SIDOARJO', '03145678532', 0),
('SP13', 'PT.BINA MITRA JB', 'RUKO GATEWAY BLOK A 33-37', 'WARU-SIDOARJO', '0318548445', 0),
('SP14', 'PT.DOSNI ROHA', 'JL.HR.MUHAMMAD NO.3', 'SURABAYA', '03145632343', 0),
('SP15', 'ddsd', 'sdsds', 'dsds', '093232', 0),
('SP16', 'ddsd', 'sdsds', 'dsds', '093232', 0),
('SP17', 'PT.ANGIN RIBUT', 'JL.CITRALAND NO.55', 'SURABAYA', '031465654', 0),
('SP2', 'PT.GIDION JAYA', 'JL.SULTAN HASANUDDIN RT 005/05 SIRIMAU', 'AMBON', '0911351135', 0),
('SP3', 'PT.COBRA DENTAL', 'JL.DARMAWANGSA NO.50A', 'SURABAYA', '0315034831', 0),
('SP4', 'PT.BLESINDO IND', 'RUKO DUREN SAWIT CENTRE NO.9B', 'JAKARTA TIMUR', '02186611271', 0),
('SP5', 'PD.GRACE', 'JL.PRAPANCA 14', 'SURABAYA', '0315677226', 0),
('SP6', 'PT.DISTRIVERSA B.M', 'JL.MARGOREJO INDAH 28', 'SURABAYA', '0318436251', 0),
('SP7', 'PT.DOHO NAULI', 'JL.DANDANGAN II/14', 'KEDIRI', '0354680239', 0),
('SP8', 'PT.MBS', 'JL.MOJOKLANGGRU LOR', 'SURABAYA', '0314563223', 0),
('SP9', 'PT.INTISUMBER HS', 'JL.KENCANASARI BARAT 1/A-4', 'SURABAYA', '0315672236', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `penerimaan`
--

CREATE TABLE `penerimaan` (
  `id_penerimaan` varchar(45) NOT NULL,
  `tgl_penerimaan` date NOT NULL,
  `no_faktur` varchar(45) NOT NULL,
  `delete` varchar(45) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `retur_dpembelian`
--

CREATE TABLE `retur_dpembelian` (
  `id_dpembelian` varchar(45) NOT NULL,
  `id_retur_pembelian` varchar(45) NOT NULL,
  `id_supplier` varchar(45) NOT NULL,
  `id_barang` varchar(45) NOT NULL,
  `nama_barang` varchar(45) NOT NULL,
  `jumlah` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `retur_dpembelian`
--

INSERT INTO `retur_dpembelian` (`id_dpembelian`, `id_retur_pembelian`, `id_supplier`, `id_barang`, `nama_barang`, `jumlah`) VALUES
('PB002', 'RP1', 'SP13', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', 2),
('PB002', 'RPU2', 'SP13', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', 2),
('PB002', 'RPU3', 'SP13', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', 2),
('PB004', 'RP4', 'SP13', 'A0009', 'DISPOSIBLE SYRINGE 10CC O M', 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `retur_dpenjualan`
--

CREATE TABLE `retur_dpenjualan` (
  `id_dpenjualan` varchar(45) NOT NULL,
  `id_retur_penjualan` varchar(45) NOT NULL,
  `id_customer` varchar(45) NOT NULL,
  `id_barang` varchar(45) NOT NULL,
  `nama_barang` varchar(45) NOT NULL,
  `jumlah` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `retur_dpenjualan`
--

INSERT INTO `retur_dpenjualan` (`id_dpenjualan`, `id_retur_penjualan`, `id_customer`, `id_barang`, `nama_barang`, `jumlah`) VALUES
('PJ002', 'RJ1', 'C5', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', 2),
('PJ002', 'RJU2', 'C5', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `retur_pembelian`
--

CREATE TABLE `retur_pembelian` (
  `id_retur_pembelian` varchar(45) NOT NULL,
  `no_faktur` varchar(45) NOT NULL,
  `tgl_retur` date NOT NULL,
  `delete` varchar(45) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `retur_pembelian`
--

INSERT INTO `retur_pembelian` (`id_retur_pembelian`, `no_faktur`, `tgl_retur`, `delete`) VALUES
('RP1', 'F1', '2019-05-16', '0'),
('RPU2', 'F1', '2019-05-16', '0'),
('RPU3', 'F1', '2019-05-16', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `retur_penjualan`
--

CREATE TABLE `retur_penjualan` (
  `id_retur_penjualan` varchar(45) NOT NULL,
  `no_pajak` varchar(45) NOT NULL,
  `tgl_retur_penjualan` date NOT NULL,
  `delete` varchar(45) NOT NULL DEFAULT '0',
  `selesai` varchar(45) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `retur_penjualan`
--

INSERT INTO `retur_penjualan` (`id_retur_penjualan`, `no_pajak`, `tgl_retur_penjualan`, `delete`, `selesai`) VALUES
('RJ1', 'NP2', '2019-05-16', '0', '0'),
('RJU2', 'NP2', '2019-05-16', '0', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `stok_barang`
--

CREATE TABLE `stok_barang` (
  `id_stok` varchar(45) NOT NULL,
  `id_barang` varchar(45) NOT NULL,
  `nama_barang` varchar(45) NOT NULL,
  `stok_masuk` varchar(45) NOT NULL,
  `stok_keluar` varchar(45) NOT NULL,
  `stok_akhir` varchar(45) NOT NULL,
  `delete` varchar(45) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `stok_barang`
--

INSERT INTO `stok_barang` (`id_stok`, `id_barang`, `nama_barang`, `stok_masuk`, `stok_keluar`, `stok_akhir`, `delete`) VALUES
('S01', 'A0001', 'DISPOSIBLE SYRINGE 1CC GIDCARE', '0', '0', '0', '0'),
('S02', 'A0002', 'DISPOSIBLE SYRINGE 3CC GIDCARE', '0', '0', '0', '0'),
('S03', 'A0003', 'DISPOSIBLE SYRINGE 5CC GIDCARE', '0', '0', '0', '0'),
('S04', 'A0004', 'DISPOSIBLE SYRINGE 10CC GIDCARE', '0', '0', '0', '0'),
('S05', 'A0005', 'DISPOSIBLE SYRINGE 20CC GIDCARE', '3', '0', '3', '0'),
('S06', 'A0006', 'DISPOSIBLE SYRINGE 1CC O M', '0', '0', '0', '0'),
('S07', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', '0', '6', '-6', '1'),
('S08', 'A0008', 'DISPOSIBLE SYRINGE 5CC O M', '0', '0', '0', '0'),
('S09', 'A0009', 'DISPOSIBLE SYRINGE 10CC O M', '0', '2', '-2', '0'),
('S10', 'A0010', 'DISPOSIBLE SYRINGE 20CC O M', '0', '0', '0', '0'),
('S11', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', '0', '6', '-6', '0'),
('S12', 'A0012', 'HANDSCOON NON STERIL S', '0', '0', '0', '0'),
('S13', 'A0013', 'HANDSCOON NON STERIL M', '0', '0', '0', '0'),
('S14', 'A0014', 'HANDSCOON NON STERIL L / 100S', '0', '0', '0', '0'),
('S15', 'A0015', 'NEEDLE NO.18 TERUMO', '0', '0', '0', '0'),
('S16', 'A0016', 'NEEDLE NO.23 TERUMO', '0', '0', '0', '0'),
('S17', 'A0017', 'Paramex', '0', '0', '0', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `stok_opname`
--

CREATE TABLE `stok_opname` (
  `id_stok_opname` varchar(45) NOT NULL,
  `tgl_stok_opname` datetime NOT NULL,
  `id_barang` varchar(45) NOT NULL,
  `nama_barang` varchar(45) NOT NULL,
  `stoke_awal` varchar(45) NOT NULL,
  `stok_akhir` varchar(45) NOT NULL,
  `keterangan` varchar(455) NOT NULL,
  `delete` varchar(45) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `stok_opname`
--

INSERT INTO `stok_opname` (`id_stok_opname`, `tgl_stok_opname`, `id_barang`, `nama_barang`, `stoke_awal`, `stok_akhir`, `keterangan`, `delete`) VALUES
('O1', '2019-05-16 00:00:00', 'A0009', 'A0009', '0', '1', 'kelebihan1', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tdetail_pembelian`
--

CREATE TABLE `tdetail_pembelian` (
  `id_dpembelian` varchar(45) NOT NULL,
  `no_faktur` varchar(45) NOT NULL,
  `id_barang` varchar(45) NOT NULL,
  `nama_barang` varchar(45) NOT NULL,
  `harga_beli` int(10) UNSIGNED NOT NULL,
  `diskon` varchar(45) NOT NULL,
  `no_batch` varchar(45) NOT NULL,
  `expire_date` year(4) DEFAULT NULL,
  `total_beli` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tdetail_pembelian`
--

INSERT INTO `tdetail_pembelian` (`id_dpembelian`, `no_faktur`, `id_barang`, `nama_barang`, `harga_beli`, `diskon`, `no_batch`, `expire_date`, `total_beli`) VALUES
('PB001', 'F1', 'A0003', 'DISPOSIBLE SYRINGE 5CC GIDCARE', 12500, '0', 'B3', 2020, '2'),
('PB002', 'F1', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', 29400, '10', 'B11', 2025, '2'),
('PB003', 'F1', 'A0009', 'DISPOSIBLE SYRINGE 10CC O M', 29000, '10', 'B9', 2024, '2'),
('PB004', 'F2', 'A0009', 'DISPOSIBLE SYRINGE 10CC O M', 29000, '10', 'B9', 2024, '2'),
('PB005', 'F2', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', 29400, '0', 'B11', 2025, '2'),
('PB006', 'F3', 'A0008', 'DISPOSIBLE SYRINGE 5CC O M', 26400, '30', 'B8', 2023, '10'),
('PB007', 'F3', 'A0011', 'SAMPLE CUP/PCR TUBE 1.5ML', 29400, '5', 'B11', 2025, '1'),
('PB008', 'F3', 'A0002', 'DISPOSIBLE SYRINGE 3CC GIDCARE', 12000, '0', 'B2', 2020, '2');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tdetail_penjualan`
--

CREATE TABLE `tdetail_penjualan` (
  `id_dpenjualan` varchar(45) NOT NULL,
  `no_pajak` varchar(45) NOT NULL,
  `id_barang` varchar(45) NOT NULL,
  `nama_barang` varchar(45) NOT NULL,
  `harga_jual` int(10) UNSIGNED NOT NULL,
  `diskon` varchar(45) NOT NULL,
  `no_batch` varchar(45) NOT NULL,
  `expire_date` year(4) DEFAULT NULL,
  `total_jual` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tdetail_penjualan`
--

INSERT INTO `tdetail_penjualan` (`id_dpenjualan`, `no_pajak`, `id_barang`, `nama_barang`, `harga_jual`, `diskon`, `no_batch`, `expire_date`, `total_jual`) VALUES
('PJ001', 'NP1', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', 21000, '30', 'B7', 2023, '2'),
('PJ002', 'NP2', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', 21000, '30', 'B7', 2023, '2'),
('PJ003', 'NP3', 'A0007', 'DISPOSIBLE SYRINGE 3CC O M', 21000, '30', 'B7', 2023, '2');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_pembelian`
--

CREATE TABLE `t_pembelian` (
  `no_faktur` varchar(45) NOT NULL,
  `tgl_pembelian` date DEFAULT NULL,
  `id_supplier` varchar(45) NOT NULL,
  `total_pembelian` int(10) UNSIGNED NOT NULL,
  `delete` int(11) NOT NULL DEFAULT '0',
  `selesai` varchar(45) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_pembelian`
--

INSERT INTO `t_pembelian` (`no_faktur`, `tgl_pembelian`, `id_supplier`, `total_pembelian`, `delete`, `selesai`) VALUES
('F1', '2019-05-16', 'SP13', 130120, 0, '0'),
('F2', '2019-05-16', 'SP13', 111000, 0, '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_penjualan`
--

CREATE TABLE `t_penjualan` (
  `no_pajak` varchar(45) NOT NULL,
  `tgl_penjualan` date NOT NULL,
  `id_customer` varchar(45) NOT NULL,
  `total_penjual` int(10) UNSIGNED NOT NULL,
  `delete` int(10) UNSIGNED NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_penjualan`
--

INSERT INTO `t_penjualan` (`no_pajak`, `tgl_penjualan`, `id_customer`, `total_penjual`, `delete`) VALUES
('NP1', '2019-05-16', 'C5', 40600, 0),
('NP2', '2019-05-16', 'C5', 40600, 0),
('NP3', '2019-05-16', 'C5', 40600, 0);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `detail_penerimaan`
--
ALTER TABLE `detail_penerimaan`
  ADD PRIMARY KEY (`id_dpenerimaan`);

--
-- Indeks untuk tabel `history`
--
ALTER TABLE `history`
  ADD PRIMARY KEY (`id_history`);

--
-- Indeks untuk tabel `m_barang`
--
ALTER TABLE `m_barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indeks untuk tabel `m_customer`
--
ALTER TABLE `m_customer`
  ADD PRIMARY KEY (`id_customer`);

--
-- Indeks untuk tabel `m_golongan`
--
ALTER TABLE `m_golongan`
  ADD PRIMARY KEY (`id_golongan`);

--
-- Indeks untuk tabel `m_pegawai`
--
ALTER TABLE `m_pegawai`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indeks untuk tabel `m_supplier`
--
ALTER TABLE `m_supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indeks untuk tabel `penerimaan`
--
ALTER TABLE `penerimaan`
  ADD PRIMARY KEY (`id_penerimaan`);

--
-- Indeks untuk tabel `retur_pembelian`
--
ALTER TABLE `retur_pembelian`
  ADD PRIMARY KEY (`id_retur_pembelian`);

--
-- Indeks untuk tabel `retur_penjualan`
--
ALTER TABLE `retur_penjualan`
  ADD PRIMARY KEY (`id_retur_penjualan`);

--
-- Indeks untuk tabel `stok_barang`
--
ALTER TABLE `stok_barang`
  ADD PRIMARY KEY (`id_stok`);

--
-- Indeks untuk tabel `stok_opname`
--
ALTER TABLE `stok_opname`
  ADD PRIMARY KEY (`id_stok_opname`);

--
-- Indeks untuk tabel `tdetail_pembelian`
--
ALTER TABLE `tdetail_pembelian`
  ADD PRIMARY KEY (`id_dpembelian`);

--
-- Indeks untuk tabel `tdetail_penjualan`
--
ALTER TABLE `tdetail_penjualan`
  ADD PRIMARY KEY (`id_dpenjualan`);

--
-- Indeks untuk tabel `t_pembelian`
--
ALTER TABLE `t_pembelian`
  ADD PRIMARY KEY (`no_faktur`);

--
-- Indeks untuk tabel `t_penjualan`
--
ALTER TABLE `t_penjualan`
  ADD PRIMARY KEY (`no_pajak`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
