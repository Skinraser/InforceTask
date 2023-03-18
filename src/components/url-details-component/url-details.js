import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import urlService from "../../services/url-service";
import "./url-details.css"
const UrlDetails = () => {

    const {id} = useParams();

    const [url, setUrl] = useState(urlService.getUrlById(id))

    const fetchUrl = async () => {
        const { data, errorMessage } = await urlService.getUrlById(id);
        setUrl(data);
    };

    useEffect(() => {
        fetchUrl();
    }, []);
return (
<div>
    <h4>Url information</h4>
    <hr />
    <dl class="row">
        <dt class = "col-sm-2">
            Long Url:
        </dt>
        <dd class = "col-sm-10">
            {url.longUrl}
        </dd>
        <dt class = "col-sm-2">
            Short Url:
        </dt>
        <dd class = "col-sm-10">
            {url.shortUrl}
        </dd>
        <dt class = "col-sm-2">
            Date Created:
        </dt>
        <dd class = "col-sm-10">
            {url.createdDate}
        </dd>
        <dt class = "col-sm-2">
            User Created:
        </dt>
        <dd class = "col-sm-10">
            {url.createdDate}
        </dd>
    </dl>
</div>
)
}
export default UrlDetails;