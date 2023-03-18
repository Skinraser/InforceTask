import './login-page.css';
import React, { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import AuthService from "../../services/auth.service";

const LoginForm = ({ }) => {

    const [email, setEmail] = useState()
    const [password, setPassword] = useState()

    const navigate = useNavigate()

    function onEmailChange(e) {
        setEmail(e.target.value);
    }

    function onPasswordChange(e) {
        setPassword(e.target.value);
    }

    const handleSubmit = async (event) => {
        event.preventDefault();
        AuthService.login(email, password)
            .then(() => {
                    return navigate('/')
                }).then(response => {
                        localStorage.setItem("user", "logged");
                })
                .catch(error=>{
                    window.alert("Wrong email or password")
                })
    }


    return (
        <>
            <form onSubmit={handleSubmit} className='authorization-form'>
                <div className='center-div'>
                    <h2 className='authorization-form-heading'>Welcome</h2>

                    <input type='email' className='form-control' placeholder='Email' onChange={onEmailChange} />
                    <input type='password' className='form-control' placeholder='Password' onChange={onPasswordChange} minLength={5} />

                    <button type='submit' className='btn btn-success'>Log in</button>
                    <span>Don`t have an account yet?&nbsp;
                        <Link to='/signup'>Register</Link>
                    </span>
                </div>
            </form>
        </>
    );
}

export default LoginForm;