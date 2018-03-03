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
import Mixins from 'components/Advanced/Mixins'
import Custom from 'components/Deep/Custom'
import Transition from 'components/Deep/Transition'
import Filters from 'components/Deep/Filters'
import Vuex from 'components/Deep/Vuex'
import StoreHome from 'components/Store/Home'
import StoreAdd from 'components/Store/Add'
import Auth from 'components/Auth/Auth'

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
    { path: '/Store/Home', component: StoreHome, display: 'Store Home', style: 'glyphicon glyphicon-duplicate' },
    { path: '/Store/Add', component: StoreAdd, display: 'Store Add Item', style: 'glyphicon glyphicon-duplicate' },
    { path: '/Auth/Auth', component: Auth, display: 'Authentication', style: 'glyphicon glyphicon-duplicate' },
    {
        path: '/Routes',
        component: Routes,
        display: 'Routes',
        style: 'glyphicon glyphicon-sort',
        children: [
            { path: 'Child/:id', component: Child }
        ]
    },
    {
        path: '/Advanced/ListRendering',
        component: ListRendering
    },
    {
        path: '/Advanced/Computed',
        component: Computed
    },
    {
        path: '/Advanced/Mixins',
        component: Mixins
    }
    ,
    {
        path: '/Deep/Custom',
        component: Custom
    } ,
    {
        path: '/Deep/Transition',
        component: Transition
    },
    {
        path: '/Deep/Filters',
        component: Filters
    },
    {
        path: '/Deep/Vuex',
        component: Vuex
    }
];
