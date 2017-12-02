import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import HomePage from 'components/home-page'
import Hello from 'components/Hello'
import Directives from 'components/Directives'
import Databinding from 'components/Databinding'
import Models from 'components/Models'
import Routes from 'components/Routes'
import Child from 'components/Child/Child'

export const routes = [
    { path: '/', component: HomePage, display: 'Home', style: 'glyphicon glyphicon-home' },
    { path: '/counter', component: CounterExample, display: 'Counter', style: 'glyphicon glyphicon-education' },
    { path: '/fetch-data', component: FetchData, display: 'Fetch data', style: 'glyphicon glyphicon-th-list' },
    { path: '/Hello', component: Hello, display: 'Hello', style: 'glyphicon glyphicon-th-list' },
    { path: '/Directives', component: Directives, display: 'Directives', style: 'glyphicon glyphicon-th-list' },
    { path: '/Databinding', component: Databinding, display: 'Databinding', style: 'glyphicon glyphicon-resize-small' },
    { path: '/Models', component: Models, display: 'Models', style: 'glyphicon glyphicon-duplicate' },
    {
        path: '/Routes', component: Routes, display: 'Routes', style: 'glyphicon glyphicon-sort',
        children: [
            {path:'Child/:id',component:Child}
        ]
    }
]
