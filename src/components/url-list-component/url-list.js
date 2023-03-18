import { useState, useEffect } from "react"
import { useNavigate } from "react-router-dom"
import urlService from "../../services/url-service"

export default function UrlList(){
const[urlList, setUrlList] = useState()
const[url, setUrl] = useState()
const navigate = useNavigate()

    const deleteUrl = async (id) => {
        await urlService.deleteUrl(id)
        window.location.reload()
    }
    const CreateUrl = () => {
        
        
    }
    const getUrlList = async () => {
        const { data } = await urlService.getUrls();
        setUrlList(data)
    }
    function getUrl(id) {
        navigate(`/url/${id}`)
    }

    useEffect(() => {
        getUrlList();
    }, []);

return(
    urlList ?
    <div>        
        <table className='table table-striped' aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>LongUrl</th>
                    <th>ShortUrl</th>
                    <th>CreatedDate</th>
                </tr>
            </thead>
            <tbody>
                {urlList.map(url =>
                    <tr key={url.id}>
                        <td>{url.id}</td>
                        <td>{url.longUrl}</td>
                        <td>{url.shortUrl}</td>
                        <td>{url.createdDate}</td>
                        <td><button className="btn btn-primary" onClick={()=> {getUrl(url.id);}}>Details</button></td>
                        <td><button className="btn btn-primary" onClick={()=> {deleteUrl(url.id);}}>Delete</button></td>
                    </tr>
                )}
            </tbody>
        </table>
    </div>
            :
            <div>Loading</div>
                )

}