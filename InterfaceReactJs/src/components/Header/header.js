import React, { useState } from 'react';
import './styles.css';
import { BsPersonFill } from 'react-icons/bs';
import { GoSearch } from 'react-icons/go';
import { BiShieldQuarter } from 'react-icons/bi'
import IconButton from '@material-ui/core/IconButton';
import TuneIcon from '@material-ui/icons/Tune';
import HomeIcon from '@material-ui/icons/Home';
import PowerSettingsNewIcon from '@material-ui/icons/PowerSettingsNew';
import SettingsIcon from '@material-ui/icons/Settings';
import ImagemTeste from '../../assets/symbol.svg'
import Modal from '../Modal/index';


export default function Header() {
  const [isModalVisible, setIsModalVisible] = useState(false);

  return (
    <div>
      <div className="header">

        <div className="first">
          <img src={ImagemTeste} alt="" />

          <div className="divider"></div>

          <button className="shieldButtton"><BiShieldQuarter color="#656565" size={22} /></button>
          <button className="buttonUser"><BsPersonFill color="#FFF" size={22} /></button>
          <div className="inputView">
            <input className="input" type="text" placeholder="Pesquisar..." />
            <GoSearch onClick={() => alert("Hi")} className="lupa" size={22} />
          </div>
        </div>

        <div className="second">
          <span className="tuneIconSpan">
            <TuneIcon onClick={() => setIsModalVisible(true)}></TuneIcon>
            {isModalVisible ? <Modal onClose={() => setIsModalVisible(false)}></Modal> : null}
          </span>

          <span className="buttonAddUser">
            <BsPersonFill color="#FFF" size={32} />
            <h4 style={{ color: "#FFF", fontSize: '10px' }}>INCLUIR USUÁRIO</h4>
          </span>

          <div className="divider"></div>

          <IconButton>
            <HomeIcon className=""></HomeIcon>
          </IconButton>

          <IconButton>
            <SettingsIcon className=""></SettingsIcon>
          </IconButton>

          <IconButton>
            <PowerSettingsNewIcon className=""></PowerSettingsNewIcon>
          </IconButton>
        </div>
      </div>
    </div>
  );
}
