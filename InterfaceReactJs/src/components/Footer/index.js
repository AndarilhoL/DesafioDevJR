import React from 'react';
import DateComp from '../Date/index'
import { withStyles } from '@material-ui/core/styles';
import { orange } from '@material-ui/core/colors';
import Radio from '@material-ui/core/Radio';
import TvIcon from '@material-ui/icons/Tv';
import UpdateIcon from '@material-ui/icons/Update';
import './styles.css';

const OrangeRadio = withStyles({
  root: {
    color: orange[600]
  },
  checked: {},
})((props) => <Radio color="default" {...props} />);

export default function footer() {

  return (
    <div className="footer">
      <div className="footerLeftSide">
        <div className="footerRadio">
          <OrangeRadio checked={true} />
          <h4>NO AR</h4>
        </div>

        <div className="programation">
          <TvIcon fontSize="small" style={{ color: '#FFF' }}></TvIcon>
          <h3>DU, DUDU e EDU - 15:00</h3>
        </div>

        <div className="lastUpdate">
          <UpdateIcon style={{ color: "#FFF" }}></UpdateIcon>
          <p>Última atualização em 14:42</p>
        </div>
      </div>

      <div className="footerRightSide">
        <DateComp></DateComp>
      </div>
    </div>
  );
}