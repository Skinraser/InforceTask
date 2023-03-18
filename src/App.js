import './App.css';
import {Route, BrowserRouter as Router, Routes} from 'react-router-dom';
import Navbar from './components/navbar';
import UrlList from './components/url-list-component/url-list';
import UrlDetails from './components/url-details-component/url-details';
import SignupForm from './components/signup-form-component/signup-form';
import LoginPage from './components/login-page-component/login-page';
import MainPage from './components/main-page-component/main-page'
import About from './components/about-component/about'

function App() {
  return (
<Router>
  
            <Navbar />
              <Routes>
                  <Route exact path='/' element={<MainPage/>}></Route>
                  <Route exact path='/url' element={<UrlList/>}></Route>
                  <Route exact path='/url/:id' element={<UrlDetails/>}></Route>
                  <Route exact path='/signup' element={<SignupForm/>}></Route>
                  <Route exact path='/login' element={<LoginPage/>}></Route>
                  <Route exact path='/about' element={<About/>}></Route>
              </Routes>
</Router>
  );
}

export default App;
