import React, { useState } from 'react';
import urlService from '../../services/url-service';

const LoginForm = ({ }) => {

    const [url, setUrl] = useState()
    function onUrlChange(e) {
        setUrl(e.target.value);
    }


    const handleSubmit = async (event) => {
        event.preventDefault();
        urlService.shortenUrl(url)
        .then(response => {
            window.alert("Url successfully shortened")
                })
    }
    return (
        <>
            <form onSubmit={handleSubmit} className='authorization-form'>
                <div className='center-div'>
                    <h2 className='authorization-form-heading'>Write url to shorten it </h2>

                    <input type='text' className='form-control' placeholder='Url' onChange={onUrlChange} />

                    <button type='submit' className='btn btn-success'>Submit</button>

                </div>
            </form>
        </>
    );
}

export default LoginForm;