import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import HomePage from 'components/home-page'
import Hello from 'components/Hello'
import Directives from 'components/Directives'
import Databinding from 'components/Databinding'
import Models from 'components/Models'
import Routes from 'components/Routes'
import Methods from 'components/Methods'
import Child from 'components/Child/Child'
import Data from 'components/Data'
import ListRendering from 'components/Advanced/ListRendering'
import Computed from 'components/Advanced/Computed'

export const routes = [
    { path: '/', component: HomePage, display: 'Home', style: 'glyphicon glyphicon-home' },
    { path: '/counter', component: CounterExample, display: 'Counter', style: 'glyphicon glyphicon-education' },
    { path: '/fetch-data', component: FetchData, display: 'Fetch data', style: 'glyphicon glyphicon-th-list' },
    { path: '/Hello', component: Hello, display: 'Hello', style: 'glyphicon glyphicon-th-list' },
    { path: '/Data', component: Data, display: 'Data', style: 'glyphicon glyphicon-list-alt' },
    { path: '/Directives', component: Directives, display: 'Directives', style: 'glyphicon glyphicon-th-list' },
    { path: '/Databinding', component: Databinding, display: 'Databinding', style: 'glyphicon glyphicon-resize-small' },
    { path: '/Methods', component: Methods, display: 'Methods', style: 'glyphicon glyphicon-retweet' },
    { path: '/Models', component: Models, display: 'Models', style: 'glyphicon glyphicon-duplicate' },
    {
        path: '/Routes', component: Routes, display: 'Routes', style: 'glyphicon glyphicon-sort',
        children: [
            {path:'Child/:id',component:Child}
        ]
    },
    {
        path: '/Advanced/ListRendering',
        component: ListRendering
    },
    {
        path: '/Advanced/Computed',
        component: Computed
    }
]
