import './navbar.css';
import { Link } from 'react-router-dom';
import React from 'react';
import 'bootstrap/dist/css/bootstrap.css';

export default function Navbar(){


    return (
        <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
            <div className="container-fluid">
                <div className='col-2'>
                    <Link className="navbar-brand" to="/">
                        <span className='projectTitle'>UrlShortener</span>
                    </Link>
                </div>

                <button className="navbar-toggler ms-auto" type="button" data-bs-toggle="collapse" data-bs-target="#collapseNavbar">
                    <span className="navbar-toggler-icon"></span>
                </button>
                <div className="navbar-collapse collapse" id="collapseNavbar">
                    <ul className="navbar-nav left-navbar-part">
                        <li className="nav-item">
                            <Link className="nav-link" to="/">Main</Link>
                        </li>
                        <li className="nav-item">
                            <Link className="nav-link" to="/url">Url List</Link>
                        </li>
                        <li className="nav-item">
                          <Link className="nav-link" to="about">About us</Link>
                      </li>
                    </ul>
                    <ul className="navbar-nav ms-auto">
                      <li className="nav-item">
                          <Link className="nav-link" to="/login">Log in</Link>
                      </li>
                      <li className="nav-item">
                          <Link className="nav-link" to="/signup">Sign Up</Link>
                      </li>
                    </ul>
                </div>
            </div>
        </nav>
    );
}