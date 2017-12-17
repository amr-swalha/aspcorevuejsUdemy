module.exports = {
    created: function () {
        this.logData();
    },
    methods: {
        logData: function () {
            console.log('it\'s a live');
        },
        mixinMethod: function() {
            console.log('Im a mixin method');
        }
    },
    data() {
        return {
            msg: 'from Mixin',
            datafromMixin: 'test mixin data'
        }
    }
}
