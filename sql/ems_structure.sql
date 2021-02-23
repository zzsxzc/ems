/*
Navicat MySQL Data Transfer

Source Server         : mysql-local
Source Server Version : 80022
Source Host           : localhost:3306
Source Database       : ems

Target Server Type    : MYSQL
Target Server Version : 80022
File Encoding         : 65001

Date: 2021-02-23 09:24:19
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for ems_btlcategory
-- ----------------------------
DROP TABLE IF EXISTS `ems_btlcategory`;
CREATE TABLE `ems_btlcategory` (
  `id` int NOT NULL AUTO_INCREMENT,
  `bottleCategory` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COMMENT='瓶子类别';

-- ----------------------------
-- Table structure for ems_emp
-- ----------------------------
DROP TABLE IF EXISTS `ems_emp`;
CREATE TABLE `ems_emp` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL COMMENT '姓名',
  `empcategory` varchar(255) DEFAULT NULL,
  `group` varchar(255) DEFAULT NULL,
  `rygz` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=500 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for ems_empcategory
-- ----------------------------
DROP TABLE IF EXISTS `ems_empcategory`;
CREATE TABLE `ems_empcategory` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COMMENT='员工类别(正式、劳务)';

-- ----------------------------
-- Table structure for ems_group
-- ----------------------------
DROP TABLE IF EXISTS `ems_group`;
CREATE TABLE `ems_group` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for ems_gwmx
-- ----------------------------
DROP TABLE IF EXISTS `ems_gwmx`;
CREATE TABLE `ems_gwmx` (
  `id` int NOT NULL AUTO_INCREMENT,
  `des` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=391 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for ems_gxgz
-- ----------------------------
DROP TABLE IF EXISTS `ems_gxgz`;
CREATE TABLE `ems_gxgz` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for ems_jjmain
-- ----------------------------
DROP TABLE IF EXISTS `ems_jjmain`;
CREATE TABLE `ems_jjmain` (
  `id` int NOT NULL AUTO_INCREMENT,
  `empcategory` varchar(255) DEFAULT NULL,
  `group` varchar(255) DEFAULT NULL,
  `empname` varchar(255) NOT NULL,
  `empid` int DEFAULT NULL,
  `gxgz` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `rygz` varchar(255) DEFAULT NULL,
  `gwmx` varchar(255) DEFAULT NULL,
  `btlcategory` varchar(255) DEFAULT NULL,
  `spdj` double(11,0) DEFAULT NULL COMMENT '审批单价',
  `xs` double(11,0) NOT NULL DEFAULT '1',
  `sjjp` double(11,0) DEFAULT NULL,
  `cl` double(11,0) DEFAULT NULL,
  `rgz` double(11,0) DEFAULT NULL COMMENT '日工资',
  `llgs` double(11,0) DEFAULT NULL COMMENT '理论工时',
  `workdate` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5443 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for ems_rygz
-- ----------------------------
DROP TABLE IF EXISTS `ems_rygz`;
CREATE TABLE `ems_rygz` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
