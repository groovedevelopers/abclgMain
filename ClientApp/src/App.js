import React from "react";
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";
import { GuardProvider, GuardedRoute } from 'react-router-guards';
import Home from './pages/home';
import Profile from './pages/profile';
import Benefits from './pages/benefits';
import Persons from './pages/persons';
import Invoices from './pages/invoices';
import Login from './secure/login';
import Register from './secure/register';

const requireLogin = (to, from, next) => {
  if (to.meta.auth) {
    // if (getIsLoggedIn()) {
    //   next();
    // }
    next.redirect('/login');
  } else {
    next();
  }
};

export default function app() {
  return (
    <Router>
      

      <GuardProvider guards={[requireLogin]} >
      <GuardedRoute path="/" exact component={Home} meta={{ auth: false }} />
      <GuardedRoute path="/profile" exact component={Profile} meta={{ auth: false }} />
      <GuardedRoute path="/benefits" exact component={Benefits} meta={{ auth: false }} />
      <GuardedRoute path="/persons" exact component={Persons} meta={{ auth: false }} />
      <GuardedRoute path="/invoices" exact component={Invoices} meta={{ auth: false }} />
      
        <Switch>
        <GuardedRoute path="/login" exact component={Login} />
        <GuardedRoute path="/register"  component={Register} />
       
        </Switch>
        </GuardProvider>
      
    </Router>
  );
}



