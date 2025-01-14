import React, { Component } from 'react';
import { Route } from 'react-router';
//import requireAuth from './components/ProtectedRoute';

import './App.css'
/*
import SignIn from './components/SignIn/SignIn';
import Food from './components/Foods/Food';*/
import FrontPage from './components/FrontPage';
import Order from './components/Order/Order';
import LoginForm from './components/Auth/Login'
import Register from './components/Auth/Register';
import Dashboard from './components/Dashboard/Dashboard';
import AddRestaurant from './components/Dashboard/Pages/AddRestaurant';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <>
        <Route exact path='/' component={Order} />
        <Route exact path='/login' component={LoginForm} />
        <Route exact path='/signup' component={Register} />
        <Route exact path='/dashboard' component={Dashboard} />
        <Route exact path='/add/restaurant' component={AddRestaurant} />
        <Route exact path='/home' component={FrontPage} />
      {/* 
        <Route exact path='/home' component={FrontPage} />
        <Route exact path='/sign-in' component={SignIn} />
        <Route exact path='/foods' component={Food} />
      */}
      </>
    );
  }
}
