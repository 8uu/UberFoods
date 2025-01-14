import React, { Component } from 'react';
import Drawer from './Drawer';
import {BrowserRouter as Router, Switch, Route, withRouter} from 'react-router-dom';
import DashboardPage from './Pages/DashboardPage';
import './Dashboard.css'
import Restaurants from './Pages/Restaurants';

export class RestaurantDashboard extends Component {
    render() {
        return (
            <Router>
                <div className="mainSection">
                    <div className="drawer-container">
                        <Drawer/>
                    </div>
                    <div className="left-content-container">
                        <Switch>
                            <Route path="/resDashboard" component={DashboardPage}/>
                            <Route path="/resRestaurants" component={Restaurants}/>
                        </Switch>
                    </div>
                </div>
                        
            </Router>
        )   
    }
}

export default withRouter(RestaurantDashboard);